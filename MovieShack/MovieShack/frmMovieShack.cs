using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Diagnostics;

namespace MovieShack
{
    public partial class frmMovieShack : Form
    {
        private const string FILE_DIRECTORY_CUSTOMER_RECORDS = "custRecords.dat";
        private const string FILE_DIRECTORY_MOVIE_RECORDS = "movieRecords.dat";
        private const string FILE_DIRECTORY_RENTAL_RECODRS = "rentalRecords.dat";
        private const string FILE_DIRECTORY_REPORT_CUSTOMER = "custReport.txt";
        private const string FILE_DIRECTORY_REPORT_CATEGORY = "movieCatReport.txt";
        private const string FILE_DIRECTORY_REPORT_REVENUE = "revenueReport.txt";
        private const string FILE_DIRECTORY_REPORT_LATEST = "latestMovieReport.txt";

        public frmMovieShack()
        {
            InitializeComponent();
        }

        private void frmMovieShack_Load(object sender, EventArgs e)
        {
            ControlStyles.OptimizedDoubleBuffer.Equals(true);
            this.DoubleBuffered = true;
            cmbMovieCategory.SelectedIndex = 1;
        }


        //Toggles visibility between 2 panels depending on a radio button selection
        private void rabSearchMovie_CheckedChanged(object sender, EventArgs e)
        {
            if (rabSearchMovie.Checked)
            {
                pnlSearchMovie.Visible = true;
                pnlSearchCustomer.Visible = false;
            }
            else if (rabSearchCustomer.Checked)
            {
                pnlSearchCustomer.Visible = true;
                pnlSearchMovie.Visible = false;
            }
        }

        //Toggles visibility between 2 panels depending on a radio button selection
        private void rabAddMovie_CheckedChanged(object sender, EventArgs e)
        {
            if (rabAddMovie.Checked)
            {
                pnlAddMovie.Visible = true;
                pnlAddCustomer.Visible = false;
            }
            else if (rabAddCustomer.Checked)
            {
                pnlAddCustomer.Visible = true;
                pnlAddMovie.Visible = false;
            }
        }

        private void btnMovieShackSubmit_Click(object sender, EventArgs e)
        {
            //checks which tab has been selected, then handles the proccessing required for that page
            string selectedTabName = tctrlMovieShack.SelectedTab.Name;
            if (selectedTabName == "tpgRent")
            {
                //read all the item in the list boxes incl the non visible ones, then crreates a rental obj which is writen to the file
                for (int i = 0; i < lbRentPrice.Items.Count; i++)
                {
                    Rental rentalObj = new Rental((string)lbRentMovieID.Items[i], (string)lbRentMovieMoviesToRent.Items[i], (string)lbRentCustId.Items[i], (string)lbRentPrice.Items[i]);
                    rentalObj.writeToFile();
                }

                //clear all controls after rental has been writen to file
                txtbRentMovieId.Clear();
                txtbRentMovieTitle.Clear();
                txtbRentMovieCustId.Clear();
                txtbRentPrice.Clear();
                txtbRentTotalPrice.Clear();
                lbRentMovieID.Items.Clear();
                lbRentMovieMoviesToRent.Items.Clear();
                lbRentCustId.Items.Clear();
                lbRentPrice.Items.Clear();
            }
            else if (selectedTabName == "tpgSearch")
            {
                if (rabSearchMovie.Checked)
                {
                    if (txtbSearchMovieID.Text != "")
                    {
                        searchMovie(txtbSearchMovieID.Text);
                    }
                    else if (txtbSearchMovieTitle.Text != "")
                    {
                        searchMovie(txtbSearchMovieTitle.Text);
                    }
                    else
                    {
                        MessageBox.Show("A search term was not entered in either Movie ID or Movie Title fields.", "Error");
                    }
                }
                else if (rabSearchCustomer.Checked)
                {
                    ValidationCalculator validator = new ValidationCalculator();
                    bool allValid = true;

                    //Validate that a search term has been entered to at least 1 of the searchable fields
                    if (txtbSearchCustomerNumber.Text == "" && txtbSearchCustomerID.Text == "")
                    {
                        allValid = false;
                        MessageBox.Show("A search term was not entered in either Customer Number, Customer Surname or Customer ID fields.", "Error");
                    }

                    //searches for the customer in the file by order of preffered search field &
                    //validates the customer id search term if it was entered
                    if (txtbSearchCustomerID.Text != "")
                    {
                        string[] arrayDigitsOnlyId = { txtbSearchCustomerID.Text };

                        if (!(validator.valDigitsOnly(arrayDigitsOnlyId)))
                        {
                            allValid = false;
                            MessageBox.Show("An invalid character that is not a digit was entered into the id search field.", "Error");
                        }
                        else if (!(validator.valIdNo(txtbSearchCustomerID.Text)))
                        {
                            allValid = false;
                            MessageBox.Show("The ID number search term was not a valid id number", "Error");
                        }

                        //actually searches for the customer with customer id field
                        if (allValid)
                        {
                            searchCustomer(txtbSearchCustomerID.Text);
                        }
                    }

                    //validates the customer number search term if it was entered
                    if (txtbSearchCustomerNumber.Text != "")
                    {
                        string[] arrayDigitsOnlyNumber = { txtbSearchCustomerNumber.Text };

                        if (!(validator.valDigitsOnly(arrayDigitsOnlyNumber)))
                        {
                            allValid = false;
                            MessageBox.Show("An invalid character that is not a digit was entered into the customer number search field.", "Error");
                        }

                        //actually searches for the customer with customer Number field
                        if (allValid)
                        {
                            searchCustomer(txtbSearchCustomerNumber.Text);
                        }
                    }
                }
            }
            else if (selectedTabName == "tpgReports")
            {

            }
            else if (selectedTabName == "tpgAddNew")
            {
                //Decides wheather to create a new movie obj or new cust obj to write to a file
                if (rabAddMovie.Checked)
                {
                    //validates all fields, then adds a new record to the movie file
                    addMovieRecord();
                }
                else if (rabAddCustomer.Checked)
                {
                    //validates all fields, then adds a new record to the customer file
                    addCustomerRecord();
                }
            }
            else
            {
                MessageBox.Show("A selected menu tab was not detected.", "Error");
            }

        }

        //Searches the movie file for specefied search term
        private void searchMovie(string searchTerm)
        {
            //clears the list box if a previous search was made
            lbSearchResults.Items.Clear();
            string[] readRecord = new string[4];

            try
            {
                using (FileStream filStream = new FileStream(FILE_DIRECTORY_MOVIE_RECORDS, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader reader = new BinaryReader(filStream))
                    {
                        bool found = false;

                        //Reads binary file till end of file or the item was found
                        while (reader.PeekChar() > 0)
                        {
                            //reads 4 items at a time to form an array with all the details a movie obj would normally have
                            for (int i = 0; i < readRecord.Length; i++)
                            {
                                readRecord[i] = reader.ReadString();
                            }

                            //If the search term is found it stop searching the file
                            if (readRecord[0] == searchTerm || readRecord[1] == searchTerm)
                            {
                                found = true;
                                break;
                            }
                        }

                        if (found)
                        {
                            for (int i = 0; i < readRecord.Length; i++)
                            {
                                lbSearchResults.Items.Add(readRecord[i]);
                            }

                            MessageBox.Show("Movie was found. \nYou can now select the Titel and Movie ID right click and copy the details to the rent window if you wish to do so", "MOVIE FOUND");
                        }
                        else
                        {
                            txtbSearchMovieID.Clear();
                            txtbSearchMovieTitle.Clear();
                            MessageBox.Show("The Movie was not found", "MOVIE NOT FOUND");
                        }

                    }
                }


            }
            catch (FileNotFoundException fnfe)
            {
                MessageBox.Show("Could not find the specified file when searching for a Movie: " + FILE_DIRECTORY_MOVIE_RECORDS + "(" + fnfe.Message + ")");
            }
            catch (InvalidDataException ide)
            {
                MessageBox.Show("Invalid file format. (" + ide.Message + ")");
            }
            catch (EndOfStreamException eose)
            {
                MessageBox.Show("Unexpected end of file. (" + eose.Message + ")");
            }
            catch (IOException ioe)
            {
                MessageBox.Show("An Unknown IO Exception Error occured while try to search a movie from this file: " + FILE_DIRECTORY_MOVIE_RECORDS + "(" + ioe.Message + ")", "Error");
            }
        }

        //Searches the customer file for specified search term
        private void searchCustomer(string searchTerm)
        {
            //clears the list box if a previous search was made
            lbSearchResults.Items.Clear();
            string[] readRecord = new string[5];

            try
            {
                using (FileStream filStream = new FileStream(FILE_DIRECTORY_CUSTOMER_RECORDS, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader reader = new BinaryReader(filStream))
                    {
                        bool found = false;

                        //Reads binary file till end of file or the item was found
                        while (reader.PeekChar() > 0)
                        {
                            //reads 5 items at a time to form an array with all the details a customer obj would normally have
                            for (int i = 0; i < readRecord.Length; i++)
                            {
                                readRecord[i] = reader.ReadString();
                            }

                            //If the search term is found it stop searching the file
                            if (readRecord[2] == searchTerm || readRecord[4] == searchTerm)
                            {
                                found = true;
                                break;
                            }
                        }

                        if (found)
                        {
                            for (int i = 0; i < readRecord.Length; i++)
                            {
                                lbSearchResults.Items.Add(readRecord[i]);
                            }

                            MessageBox.Show("Customer was found.\nYou can now select the Customer ID Number right click and copy the details to the rent window if you wish to do so", "CUSTOMER FOUND");
                        }
                        else
                        {
                            txtbSearchCustomerID.Clear();
                            txtbSearchCustomerNumber.Clear();
                            MessageBox.Show("The Customer was not found", "CUSTOMER NOT FOUND");
                        }

                    }
                }


            }
            catch (FileNotFoundException fnfe)
            {
                MessageBox.Show("Could not find the specified file when searching for a customer: " + FILE_DIRECTORY_CUSTOMER_RECORDS + "(" + fnfe.Message + ")");
            }
            catch (InvalidDataException ide)
            {
                MessageBox.Show("Invalid file format. (" + ide.Message + ")");
            }
            catch (EndOfStreamException eose)
            {
                MessageBox.Show("Unexpected end of file. (" + eose.Message + ")");
            }
            catch (IOException ioe)
            {
                MessageBox.Show("An Unknown IO Exception Error occured while try to search a customer from this file: " + FILE_DIRECTORY_CUSTOMER_RECORDS + "(" + ioe.Message + ")", "Error");
            }
        }

        private void addMovieRecord()
        {
            //a bool value to indicate if all validation has been succesfull
            bool allValid = true;

            //validation that all the required fields are completed
            ValidationCalculator validator = new ValidationCalculator();

            //create string array of required fields
            string[] arrayAddMovieRequiredFields = { txtbAddMovieId.Text, txtbAddMovieTitle.Text, cmbMovieCategory.SelectedItem.ToString(), txtbAddMovieRuntime.Text };

            if (!(validator.valCompleted(arrayAddMovieRequiredFields)))
            {
                allValid = false;
                MessageBox.Show("One of the fields was incomplete", "Error");
            }



            //validates the runtime field only contains numbers
            string[] arrayAddMovieDigitsOnlyFields = { txtbAddMovieRuntime.Text };

            if (!(validator.valDigitsOnly(arrayAddMovieDigitsOnlyFields)))
            {
                allValid = false;
                MessageBox.Show("The runtime(in minutes) field contains a character that is not a digit.", "Error");
            }




            if (allValid)
            {
                //creates a movie obj and uses the methode inside the class to write the details of the new customer to the correct file
                Movie movieToWrite = new Movie(txtbAddMovieId.Text, txtbAddMovieTitle.Text, cmbMovieCategory.SelectedItem.ToString(), txtbAddMovieRuntime.Text);
                movieToWrite.writeToFile();

                //Clears all the fields after the movie was written to the file
                txtbAddMovieTitle.Clear();
                txtbAddMovieId.Clear();
                cmbMovieCategory.SelectedItem = 1;
                txtbAddMovieRuntime.Clear();
            }

        }

        private void addCustomerRecord()
        {
            //a bool value to indicate if all validation has been succesfull
            bool allValid = true;

            //validation that all the required fields are completed
            ValidationCalculator validator = new ValidationCalculator();

            //create string array of required fields
            string[] arrayAddCustomerRequiredFields = { txtbAddCustomerName.Text, txtbAddCustomerSurname.Text, txtbAddCustomerTelNo.Text, txtbAddCustomerAddress.Text, txtbAddCustomerIdNo.Text };

            if (!(validator.valCompleted(arrayAddCustomerRequiredFields)))
            {
                allValid = false;
                MessageBox.Show("One of the fields was incomplete", "Error");
            }

            //validates that name and surname only contain letters and spaces
            //create string array for fields that may only contain letters and spaces
            string[] arrayAddCustomerLettersAndSpacesOnly = { txtbAddCustomerName.Text, txtbAddCustomerSurname.Text };

            if (!(validator.valLettersAndSpace(arrayAddCustomerLettersAndSpacesOnly)))
            {
                allValid = false;
                MessageBox.Show("An  Illegal character was detected within name or surname field", "Error");
            }

            //validates the telephone field only contains numbers
            string[] arrayAddCustomerDigitsOnlyFields = { txtbAddCustomerTelNo.Text, txtbAddCustomerIdNo.Text };

            if (!(validator.valDigitsOnly(arrayAddCustomerDigitsOnlyFields)))
            {
                allValid = false;
                MessageBox.Show("The Telephone or ID number field contains an character that is not a digit.", "Error");
            }
            else if (!(validator.valIdNo(txtbAddCustomerIdNo.Text))) //validates the new customers id no
            {
                allValid = false;
                MessageBox.Show("The ID number entered is not valid", "Error");
            }



            if (allValid)
            {
                //creates a customer obj and uses the methode inside the class to write the details of the new customer to the correct file
                Customer newCustToWrite = new Customer(txtbAddCustomerName.Text, txtbAddCustomerSurname.Text, txtbAddCustomerTelNo.Text, txtbAddCustomerAddress.Text, txtbAddCustomerIdNo.Text);
                newCustToWrite.writeToFile();

                //Clears all the fields after the customer was written to the file
                txtbAddCustomerName.Clear();
                txtbAddCustomerSurname.Clear();
                txtbAddCustomerTelNo.Clear();
                txtbAddCustomerIdNo.Clear();
                txtbAddCustomerAddress.Clear();
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //makes sure color scheme help text for menu item is visible even during highlight
            if (mnuItemHelp.ForeColor == Color.WhiteSmoke)
            {
                mnuItemHelp.ForeColor = Color.Black;
            }
            else
                mnuItemHelp.ForeColor = Color.WhiteSmoke;
        }

        private void mnuItemHelpFiles_Click(object sender, EventArgs e)
        {
            //makes sure color scheme help text for menu item is visible even during highlight
            if (mnuItemHelp.ForeColor == Color.WhiteSmoke)
            {
                mnuItemHelp.ForeColor = Color.Black;
            }
            else
                mnuItemHelp.ForeColor = Color.WhiteSmoke;

            //Opens the readme file for version
            Process.Start("READ ME.txt");

        }

        private void mnuItemAbout_Click(object sender, EventArgs e)
        {
            //makes sure color scheme help text for menu item is visible even during highlight
            if (mnuItemHelp.ForeColor == Color.WhiteSmoke)
            {
                mnuItemHelp.ForeColor = Color.Black;
            }
            else
                mnuItemHelp.ForeColor = Color.WhiteSmoke;

            //Opens about dialogue
            frmAbout about = new frmAbout();
            about.ShowDialog();

        }

        private void btnRentMovieAdd_Click(object sender, EventArgs e)
        {
            ValidationCalculator validator = new ValidationCalculator();
            bool allValid = true;

            //validate that all fields are complete
            string[] arrayRequiredFields = { txtbRentMovieId.Text, txtbRentMovieTitle.Text, txtbRentMovieCustId.Text, txtbRentPrice.Text };

            if (!(validator.valCompleted(arrayRequiredFields)))
            {
                allValid = false;
                MessageBox.Show("One of the fields was incomplete.", "Error");
            }

            //validate digits only is used in specific fields and that the customer id number is correct
            string[] arrayDigitOnlyFields = { txtbRentMovieCustId.Text, txtbRentPrice.Text };

            if (!(validator.valDigitsOnly(arrayDigitOnlyFields)))
            {
                allValid = false;
                MessageBox.Show("Non digit characters where used in the price or customer id fields.", "Error");
            }
            else if (!(validator.valIdNo(txtbRentMovieCustId.Text)))
            {
                allValid = false;
                MessageBox.Show("The Customer ID provided is not valid", "Error");
            }
            else if (searchCustomerId(txtbRentMovieCustId.Text))
            {
                //code to add item to list box after all fields have been validated
                if (allValid)
                {
                    lbRentMovieMoviesToRent.Items.Add(txtbRentMovieTitle.Text);
                    lbRentPrice.Items.Add(txtbRentPrice.Text);

                    //stores extra details of rental in non visible list boxes to be writen to file later, together with the visible list box items
                    lbRentMovieID.Items.Add(txtbRentMovieId.Text);
                    lbRentCustId.Items.Add(txtbRentMovieCustId.Text);

                    calcTotalRentalPrice();

                }
            }
            else
                MessageBox.Show("The Customer ID was not found, Try search them first.", "Error");
        }

        private void calcTotalRentalPrice()
        {
            ArrayList prices = new ArrayList();

            //read all the prices in the price list box then total them
            for (int i = 0; i < lbRentPrice.Items.Count; i++)
            {
                prices.Add(lbRentPrice.Items[i]);
            }
            double totalPrice = 0;

            for (int j = 0; j < prices.Count; j++)
            {
                totalPrice = totalPrice + Double.Parse((string)prices[j]);
            }

            txtbRentTotalPrice.Text = totalPrice + "";
        }

        private bool searchCustomerId(string searchTerm)
        {
            bool found = false;
            //clears the list box if a previous search was made
            lbSearchResults.Items.Clear();
            string[] readRecord = new string[5];

            try
            {
                using (FileStream filStream = new FileStream(FILE_DIRECTORY_CUSTOMER_RECORDS, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader reader = new BinaryReader(filStream))
                    {


                        //Reads binary file till end of file or the item was found
                        while (reader.PeekChar() > 0)
                        {
                            //reads 5 items at a time to form an array with all the details a customer obj would normally have
                            for (int i = 0; i < readRecord.Length; i++)
                            {
                                readRecord[i] = reader.ReadString();
                            }

                            //If the search term is found it stop searching the file
                            if (readRecord[2] == searchTerm || readRecord[4] == searchTerm)
                            {
                                found = true;
                                break;
                            }
                        }

                    }
                }


            }
            catch (FileNotFoundException fnfe)
            {
                MessageBox.Show("Could not find the specified file when searching for a customer: " + FILE_DIRECTORY_CUSTOMER_RECORDS + "(" + fnfe.Message + ")");
            }
            catch (InvalidDataException ide)
            {
                MessageBox.Show("Invalid file format. (" + ide.Message + ")");
            }
            catch (EndOfStreamException eose)
            {
                MessageBox.Show("Unexpected end of file. (" + eose.Message + ")");
            }
            catch (IOException ioe)
            {
                MessageBox.Show("An Unknown IO Exception Error occured while try to search a customer from this file: " + FILE_DIRECTORY_CUSTOMER_RECORDS + "(" + ioe.Message + ")", "Error");
            }

            return found;
        }

        private void btnRentRemove_Click(object sender, EventArgs e)
        {
            //Removes selected item from rent list boxs(title box and price box)
            //validates that a item was selected
            if ((lbRentMovieMoviesToRent.SelectedIndex != -1))
            {
                int selectedItem = lbRentMovieMoviesToRent.SelectedIndex;

                lbRentMovieMoviesToRent.Items.RemoveAt(selectedItem);
                lbRentPrice.Items.RemoveAt(selectedItem);

                //removes items in non visible list boxes that was stored for writing later
                lbRentMovieID.Items.RemoveAt(selectedItem);
                lbRentCustId.Items.RemoveAt(selectedItem);

                //Recalculates the new total price
                calcTotalRentalPrice();
            }
            else
            {
                MessageBox.Show("A selection on the movie to rent list was not made.", "Error");
            }
        }

        private void btnReportCategory_Click(object sender, EventArgs e)
        {
            //Prompts and gets the category from the user for the report
            frmCatgoryReportDialog promptCategory = new frmCatgoryReportDialog();
            promptCategory.ShowDialog();

            string reportCategory = promptCategory.category;

            //Read customer record from file
            string[] readRecord = new string[4];
            ArrayList arrayListMovieObjects = new ArrayList();

            try
            {
                using (FileStream filStream = new FileStream(FILE_DIRECTORY_MOVIE_RECORDS, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader reader = new BinaryReader(filStream))
                    {
                        //Reads binary file till end of file or the item was found
                        while (reader.PeekChar() > 0)
                        {
                            //reads 4 items at a time to form an array with all the details a movie obj would normally have
                            for (int i = 0; i < readRecord.Length; i++)
                            {
                                readRecord[i] = reader.ReadString();
                            }

                            Movie movieObj = new Movie(readRecord[0], readRecord[1], readRecord[2], readRecord[3]);
                            arrayListMovieObjects.Add(movieObj);
                        }

                    }
                }

                //write the report to the text file
                using (StreamWriter writer = new StreamWriter(FILE_DIRECTORY_REPORT_CATEGORY))
                {
                    Movie movieObjToWrite;

                    //Building customer report formated headings
                    string reportHeadings = string.Format("|{0,-10}|{1,-30}|{2,-15}|{3,-16}|\n", "Movie ID", "Title", "Category", "Runtime(in min)");
                    writer.WriteLine("\t\tCATEGORY REPORT : " + reportCategory.ToUpper());
                    writer.WriteLine(reportHeadings);

                    for (int i = 0; i < arrayListMovieObjects.Count; i++)
                    {
                        movieObjToWrite = (Movie)arrayListMovieObjects[i];

                        //Only writes to report if appropriate cattegory
                        if (((Movie)movieObjToWrite).Category == reportCategory)
                        {
                            writer.WriteLine(movieObjToWrite.reportToString());
                        }
                    }

                }

            }
            catch (FileNotFoundException fnfe)
            {
                MessageBox.Show("Could not find the specified file when reading a movie record for a report: " + FILE_DIRECTORY_CUSTOMER_RECORDS + "(" + fnfe.Message + ")");
            }
            catch (InvalidDataException ide)
            {
                MessageBox.Show("Invalid file format. (" + ide.Message + ")");
            }
            catch (EndOfStreamException eose)
            {
                MessageBox.Show("Unexpected end of file. (" + eose.Message + ")");
            }
            catch (IOException ioe)
            {
                MessageBox.Show("An Unknown IO Exception Error occured while trying to reading a movie record for a report: " + FILE_DIRECTORY_CUSTOMER_RECORDS + "(" + ioe.Message + ")", "Error");
            }

            //Opens the file in text editor for viewing and additional saving
            Process.Start(FILE_DIRECTORY_REPORT_CATEGORY);

        }

        private void btnReportCustomers_Click(object sender, EventArgs e)
        {
            //Read customer record from file
            string[] readRecord = new string[5];
            ArrayList arrayListCustObjects = new ArrayList();

            try
            {
                using (FileStream filStream = new FileStream(FILE_DIRECTORY_CUSTOMER_RECORDS, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader reader = new BinaryReader(filStream))
                    {
                        //Reads binary file till end of file or the item was found
                        while (reader.PeekChar() > 0)
                        {
                            //reads 5 items at a time to form an array with all the details a customer obj would normally have
                            for (int i = 0; i < readRecord.Length; i++)
                            {
                                readRecord[i] = reader.ReadString();
                            }

                            Customer custObj = new Customer(readRecord[0], readRecord[1], readRecord[2], readRecord[3], readRecord[4]);
                            arrayListCustObjects.Add(custObj);
                        }

                    }
                }

                //write the report to the text file
                using (StreamWriter writer = new StreamWriter(FILE_DIRECTORY_REPORT_CUSTOMER))
                {
                    Customer custObjToWrite;

                    //Building customer report formated headings
                    string reportHeadings = string.Format("|{0,-10}|{1,-10}|{2,-50}|{3,-15}|{4,-14}|", "Name", "Surname", "Address", "Tel Number", "ID Number");
                    writer.WriteLine("\t\tCUSTOMER REPORT");
                    writer.WriteLine(reportHeadings);

                    for (int i = 0; i < arrayListCustObjects.Count; i++)
                    {
                        custObjToWrite = (Customer)arrayListCustObjects[i];
                        writer.WriteLine(custObjToWrite.reportToString());
                    }

                }

            }
            catch (FileNotFoundException fnfe)
            {
                MessageBox.Show("Could not find the specified file when reading a customer record for a report: " + FILE_DIRECTORY_CUSTOMER_RECORDS + "(" + fnfe.Message + ")");
            }
            catch (InvalidDataException ide)
            {
                MessageBox.Show("Invalid file format. (" + ide.Message + ")");
            }
            catch (EndOfStreamException eose)
            {
                MessageBox.Show("Unexpected end of file. (" + eose.Message + ")");
            }
            catch (IOException ioe)
            {
                MessageBox.Show("An Unknown IO Exception Error occured while trying to reading a customer record for a report: " + FILE_DIRECTORY_CUSTOMER_RECORDS + "(" + ioe.Message + ")", "Error");
            }

            //Opens the file in text editor for viewing and additional saving
            Process.Start(FILE_DIRECTORY_REPORT_CUSTOMER);
        }

        private void btnReportTotalRevenue_Click(object sender, EventArgs e)
        {
            //Read rental record from file
            double totalRevenue = 0;
            string[] readRecord = new string[4];
            ArrayList arrayListRentalObjects = new ArrayList();

            try
            {
                using (FileStream filStream = new FileStream(FILE_DIRECTORY_RENTAL_RECODRS, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader reader = new BinaryReader(filStream))
                    {
                        //Reads binary file till end of file or the item was found
                        while (reader.PeekChar() > 0)
                        {
                            //reads 4 items at a time to form an array with all the details a rental obj would normally have
                            for (int i = 0; i < readRecord.Length; i++)
                            {
                                readRecord[i] = reader.ReadString();
                            }

                            Rental rentalObj = new Rental(readRecord[0], readRecord[1], readRecord[2], readRecord[3]);
                            arrayListRentalObjects.Add(rentalObj);
                        }

                    }
                }

                //write the report to the text file
                using (StreamWriter writer = new StreamWriter(FILE_DIRECTORY_REPORT_REVENUE))
                {
                    Rental rentalObjToWrite;

                    //Building revenue report formated headings
                    string reportHeadings = string.Format("|{0,-10}|{1,-30}|{2,-14}|{3,-6}|\n", "Movie ID", "Title", "Cust ID Number", "Price");
                    writer.WriteLine("\t\tREVENUE REPORT");
                    writer.WriteLine(reportHeadings);

                    for (int i = 0; i < arrayListRentalObjects.Count; i++)
                    {
                        rentalObjToWrite = (Rental)arrayListRentalObjects[i];
                        writer.WriteLine(rentalObjToWrite.reportToString());
                        totalRevenue = totalRevenue + Double.Parse(rentalObjToWrite.Price);
                    }

                    writer.WriteLine("-----------------------------------------------------------------");
                    writer.WriteLine("{0,63}", "Total");
                    writer.WriteLine("{0,63}", totalRevenue + "");

                }

            }
            catch (FileNotFoundException fnfe)
            {
                MessageBox.Show("Could not find the specified file when reading a rental record for a report: " + FILE_DIRECTORY_CUSTOMER_RECORDS + "(" + fnfe.Message + ")");
            }
            catch (InvalidDataException ide)
            {
                MessageBox.Show("Invalid file format. (" + ide.Message + ")");
            }
            catch (EndOfStreamException eose)
            {
                MessageBox.Show("Unexpected end of file. (" + eose.Message + ")");
            }
            catch (IOException ioe)
            {
                MessageBox.Show("An Unknown IO Exception Error occured while trying to reading a rental record for a report: " + FILE_DIRECTORY_CUSTOMER_RECORDS + "(" + ioe.Message + ")", "Error");
            }

            //Opens the file in text editor for viewing and additional saving
            Process.Start(FILE_DIRECTORY_REPORT_REVENUE);
        }

        private void btnReportLatest_Click(object sender, EventArgs e)
        {

            //Read customer record from file
            string[] readRecord = new string[4];
            ArrayList arrayListMovieObjects = new ArrayList();

            try
            {
                using (FileStream filStream = new FileStream(FILE_DIRECTORY_MOVIE_RECORDS, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader reader = new BinaryReader(filStream))
                    {
                        //Reads binary file till end of file or the item was found
                        while (reader.PeekChar() > 0)
                        {
                            //seek to last position - 5 


                            //reads 4 items at a time to form an array with all the details a movie obj would normally have
                            for (int i = 0; i < readRecord.Length; i++)
                            {
                                readRecord[i] = reader.ReadString();
                            }

                            Movie movieObj = new Movie(readRecord[0], readRecord[1], readRecord[2], readRecord[3]);
                            arrayListMovieObjects.Add(movieObj);
                        }

                    }
                }

                //write the report to the text file
                using (StreamWriter writer = new StreamWriter(FILE_DIRECTORY_REPORT_LATEST))
                {
                    Movie movieObjToWrite;

                    //Building latest report formated headings
                    string reportHeadings = string.Format("|{0,-10}|{1,-30}|{2,-15}|{3,-16}|\n", "Movie ID", "Title", "Category", "Runtime(in min)");
                    writer.WriteLine("\t\tLATEST REPORT");
                    writer.WriteLine(reportHeadings);

                    int startIndex = arrayListMovieObjects.Count - 5;
                    int endIndex = arrayListMovieObjects.Count;

                    for (int i = startIndex; i < endIndex; i++)
                    {
                        movieObjToWrite = (Movie)arrayListMovieObjects[i];
                        writer.WriteLine(movieObjToWrite.reportToString());

                    }

                }

            }
            catch (FileNotFoundException fnfe)
            {
                MessageBox.Show("Could not find the specified file when reading a movie record for a report: " + FILE_DIRECTORY_CUSTOMER_RECORDS + "(" + fnfe.Message + ")");
            }
            catch (InvalidDataException ide)
            {
                MessageBox.Show("Invalid file format. (" + ide.Message + ")");
            }
            catch (EndOfStreamException eose)
            {
                MessageBox.Show("Unexpected end of file. (" + eose.Message + ")");
            }
            catch (IOException ioe)
            {
                MessageBox.Show("An Unknown IO Exception Error occured while trying to reading a movie record for a report: " + FILE_DIRECTORY_CUSTOMER_RECORDS + "(" + ioe.Message + ")", "Error");
            }

            //Opens the file in text editor for viewing and additional saving
            Process.Start(FILE_DIRECTORY_REPORT_LATEST);
        }

        private void mnuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuItemFile_Click(object sender, EventArgs e)
        {
            //makes sure color scheme File text for menu item is visible even during highlight
            if (mnuItemFile.ForeColor == Color.WhiteSmoke)
            {
                mnuItemFile.ForeColor = Color.Black;
            }
            else
                mnuItemFile.ForeColor = Color.WhiteSmoke;
        }

        private void copyToRentFieldsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedIndex = lbSearchResults.SelectedIndex;

            //This context menu copies the value selected from the list box to the appropriate field in the rent form
            if (rabSearchMovie.Checked)
            {
                if (selectedIndex == 0)
                {
                    txtbRentMovieId.Text = lbSearchResults.SelectedItem.ToString();
                }
                else if (selectedIndex == 1)
                {
                    txtbRentMovieTitle.Text = lbSearchResults.SelectedItem.ToString();
                }
                else
                {
                    MessageBox.Show("The Copy function is not supported for your selection because a simillar field does not exist in the rent window.", "Error");
                }
            }
            else if (rabSearchCustomer.Checked)
            {
                if (selectedIndex == 4)
                {
                    txtbRentMovieCustId.Text = lbSearchResults.SelectedItem.ToString();
                }
                else
                {
                    MessageBox.Show("The Copy function is not supported for your selection because a simillar field does not exist in the rent window.", "Error");
                }
            }
        }

        //Used to eliminate flickering, keeps form\Control invisible till it has been fully painted
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }

        }
    }
}
