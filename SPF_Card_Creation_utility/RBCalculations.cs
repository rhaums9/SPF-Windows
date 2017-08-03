using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPF_Card_Creation_utility
{
    class RBCalculations
    {
        public string[] Rushing_Calculations(int attempts, float avg, int longest, int yards)
        {
            string[] columns = new string[12];
            string[] clm1 = new string[12];
            string[] clm2 = new string[12];
            string[] clm3 = new string[12];
            bool hasclm1;
            int sm = 0;
            int i = 0;
          
            if (longest > 12)
            {
                hasclm1 = true;
                clm1[0] = longest.ToString();
                clm1[11] = "12";
                double lngavg = ((double)(longest - 12) / 11);

                int q = 1;
                
                while ( q < 11)
                {
                    clm1[q] = Math.Round((longest - (lngavg * q))).ToString();
                    sm += int.Parse(clm1[q]);
                    q++;
                }
            }
            else
            {
                hasclm1 = false;
                attempts = attempts + 12;
            }

                int evravg = (yards*5 - sm) / (attempts*5 - 12);
                clm2[0] = (evravg + 9).ToString();
                clm2[1] = (evravg + 9).ToString();
                clm2[2] = (evravg + 8).ToString();
                clm2[3] = (evravg + 8).ToString();
                clm2[4] = (evravg + 7).ToString();
                clm2[5] = (evravg + 7).ToString();
                clm2[6] = (evravg + 5).ToString();
                clm2[7] = (evravg + 5).ToString();
                clm2[8] = (evravg + 4).ToString();
                clm2[9] = (evravg + 4).ToString();
                clm2[10] = (evravg + 3).ToString();
                clm2[11] = (evravg + 3).ToString();


                clm3[0] = "SG";
                clm3[1] = (evravg + 3).ToString();
                clm3[2] = (evravg + 2).ToString();
                clm3[3] = (evravg + 1).ToString();
                clm3[4] = (evravg).ToString();
                clm3[5] = (evravg).ToString();
                clm3[6] = (evravg - 1).ToString();
                clm3[7] = (evravg - 1).ToString();
                clm3[8] = (evravg - 2).ToString();
                clm3[9] = (evravg - 3).ToString();
                clm3[10] = (evravg - 4).ToString();
                clm3[11] = (evravg - 5).ToString();


                while (i < 12)
                {
                    if(hasclm1 == true)
                    {
                        columns[i] = clm3[i] + "/" + clm2[i] + "/" + clm1[i];
                        
                    }
                    else
                    {
                    columns[i] = clm3[i] + "/" + clm2[i];
                    }
                i++;
                }
            

            return columns;
        }
    }
}
