using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace MovieShack
{
    class Rental
    {
        private const string FILE_DIRECTORY_RENTAL_RECODRS = "rentalRecords.dat";
        private string movieId;
        private string movieTitle;
        private string custId;
        private string price;

        public Rental(string movieId, string movieTitle, string custId, string price)
        {
            this.movieId = movieId;
            this.movieTitle = movieTitle;
            this.custId = custId;
            this.price = price;
        }

        public void writeToFile()
        {
            try
            {
                using (FileStream filStream = new FileStream(FILE_DIRECTORY_RENTAL_RECODRS, FileMode.Append))
                {
                    using (BinaryWriter writer = new BinaryWriter(filStream))
                    {
                        writer.Write(movieId);
                        writer.Write(movieTitle);
                        writer.Write(custId);
                        writer.Write(price);

                        MessageBox.Show("A new Rental has successfully been created", "Status");
                    }
                }
            }
            catch (DirectoryNotFoundException dnfe)
            {
                MessageBox.Show("Could not find the specified directory to write the rental too :" + FILE_DIRECTORY_RENTAL_RECODRS + "(" + dnfe.Message + ")", "Error");
            }
            catch (IOException ioe)
            {
                MessageBox.Show("An Unknown IO Exception Error occured while try to write the rental details to this file: " + FILE_DIRECTORY_RENTAL_RECODRS + "(" + ioe.Message + ")", "Error");
            }
        }

        public string reportToString()
        {
            string reportString = "";

            //Building customer report formated record
            reportString = string.Format("|{0,-10}|{1,-30}|{2,-14}|{3,-6}|\n", movieId, movieTitle, custId, price);

            return reportString;
        }

        public string Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
