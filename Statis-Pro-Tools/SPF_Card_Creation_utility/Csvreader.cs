using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace SPF_Card_Creation_utility
{
    class Csvreader
    {

        public string[,] ReadCSV(string filename )
        {
            string wholefile = System.IO.File.ReadAllText(@"C:\Users\David Ross\Desktop\2016_Stats/" + filename + ".csv");
            wholefile = wholefile.Replace("\n", "\r");
            string[] lines = wholefile.Split(new Char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int numrows = lines.Length;
            int numcols = lines[0].Split('r').Length;

            string[,] csv = new string[numrows, numcols];

            for( int r = 0; r < numrows; r++ )
            {
                string[] line_r = lines[r].Split(',');
                for (int c = 0; c < numcols; c++)
                {
                    csv[r, c] = line_r[c];
                }
            }

            return csv;
        }
    }
}
