using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MovieShack
{
    class Movie
    {
        private const string FILE_DIRECTORY = "movieRecords.dat";
        private string movieId;
        private string title;
        private string category;
        private string runtime;
        //private int popularity = 0;

        public Movie(string movieId, string title, string category, string runtime)
        {
            this.movieId = movieId;
            this.title = title;
            this.category = category;
            this.runtime = runtime;
        }

        public void writeToFile()
        {
            try
            {
                using (FileStream filStream = new FileStream(FILE_DIRECTORY, FileMode.Append))
                {
                    using (BinaryWriter writer = new BinaryWriter(filStream))
                    {
                        writer.Write(movieId);
                        writer.Write(title);
                        writer.Write(category);
                        writer.Write(runtime);
                        
                        MessageBox.Show("A new Movie has successfully been created", "Status");
                    }
                }
            }
            catch (DirectoryNotFoundException dnfe)
            {
                MessageBox.Show("Could not find the specified directory to write the movie too :" + FILE_DIRECTORY + "(" + dnfe.Message + ")", "Error");
            }
            catch (IOException ioe)
            {
                MessageBox.Show("An Unknown IO Exception Error occured while try to write the movie details to this file: " + FILE_DIRECTORY + "(" + ioe.Message + ")", "Error");
            }
        }

        public string reportToString()
        {
            string reportString = "";

            //Building customer report formated record
            reportString = string.Format("|{0,-10}|{1,-30}|{2,-15}|{3,-16}|\n", movieId, title, category, runtime);
            
            return reportString;
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

    }
}
