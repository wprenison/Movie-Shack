using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MovieShack
{
    class Customer
    {
        private const string FILE_DIRECTORY = "custRecords.dat";
        private string name;
        private string surname;
        private string address;
        private string telNumber;
        private string idNo;

        public Customer(string name, string surname, string address, string telNumber, string idNo)
        {
            this.name = name;
            this.surname = surname;
            this.address = address;
            this.telNumber = telNumber;
            this.idNo = idNo;
        }

        public void writeToFile()
        {
            try
            {
                using(FileStream filStream = new FileStream(FILE_DIRECTORY, FileMode.Append))
                {
                    using (BinaryWriter writer = new BinaryWriter(filStream))
                    {
                        writer.Write(name);
                        writer.Write(surname);
                        writer.Write(address);
                        writer.Write(telNumber);
                        writer.Write(idNo);

                        MessageBox.Show("A new Customer has successfully been created", "Status");
                    }
                }
            }
            catch (DirectoryNotFoundException dnfe)
            {
                MessageBox.Show("Could not find the specified directory to write the customer too :" + FILE_DIRECTORY + "(" + dnfe.Message + ")", "Error");
            }
            catch (IOException ioe)
            {
                MessageBox.Show("An Unknown IO Exception Error occured while try to write the customers details to this file: " + FILE_DIRECTORY + "(" + ioe.Message + ")", "Error");
            }
            
        }

        public string reportToString()
        {
            string reportString = "";

            //Building customer report formated record
            reportString = string.Format("|{0,-10}|{1,-10}|{2,-50}|{3,-15}|{4,-14}|\n", name, surname, telNumber, address, idNo);

            return reportString;
        }

    }
}
