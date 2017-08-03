using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPF_Card_Creation_utility
{
    class PRCalc
    {
        public string[] getPRNumbers(double average, int longest)
        {
            string[] s = new string[13];
            int[] i = new int[13];
            bool hasAsterix;
            int avg = (int)Math.Round(average);

            i[1] = avg + 5;
            i[2] = avg + 4;
            i[3] = avg + 3;
            i[4] = avg + 1; 
            i[5] = avg;
            i[6] = avg - 1;
            i[7] = avg - 2;
            i[8] = avg - 3;
            i[9] = avg - 4;
            i[10] = avg - 5;
            i[11] = avg - 6;

            int sum = i[1] + i[2] + i[3] + i[4] + i[5] + i[6] + i[7] + i[8] + i[9] + i[10] + i[11];
            double avg1 = (longest + sum) / 12;
            double avg2 = (sum / 11);

            if(avg1 - avg2 > 2)
            {
                hasAsterix = true;
                i[0] = (12 * avg) - sum;
                i[12] = longest;

            }
            else
            {
                hasAsterix = false;
                i[0] = longest;
            }


            if(hasAsterix == false)
            {
                s[0] = i[0].ToString();
            }
            else
            {
                s[0] = i[0].ToString() + "*";
                s[12] = i[12].ToString();
            }

            s[1] = i[1].ToString();
            s[2] = i[2].ToString();
            s[3] = i[3].ToString();
            s[4] = i[4].ToString();
            s[5] = i[5].ToString();
            s[6] = i[6].ToString();
            s[7] = i[7].ToString();
            s[8] = i[8].ToString();
            s[9] = i[9].ToString();
            s[10] = i[10].ToString();
            s[11] = i[11].ToString();


            return s;
        }
    }
}
