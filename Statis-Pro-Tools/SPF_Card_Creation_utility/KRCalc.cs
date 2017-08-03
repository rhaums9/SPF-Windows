using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPF_Card_Creation_utility
{
    class KRCalc
    {
        public string[] getKRNumbers(double average, int longest)
        {
            string[] s = new string[13];
            int[] i = new int[13];
            bool has_asterix = false;

            i[6] = (int)Math.Round(average);

            if (longest - average > 5)
            {
                i[5] = i[6] + 1;
                i[4] = i[6] + 2;
                if (longest - average > 6)
                {
                    i[3] = i[6] + 5;
                    if (longest - average > 8)
                    {
                        i[2] = i[6] + 7;
                        if (longest - average > 15)
                        {
                            i[1] = i[6] + 15;
                        }
                        else
                        {
                            i[1] = longest - 1;
                        }
                    }
                    else
                    {
                        i[2] = longest - 2;
                        i[1] = longest - 1;
                    }
                }
                else
                {
                    i[3] = longest - 3;
                    i[2] = longest - 2;
                    i[1] = longest - 1;
                }
            }

                
            
            else
            {
                i[5] = longest - 5;
                i[4] = longest - 4;
                i[3] = longest - 3;
                i[2] = longest - 2;
                i[1] = longest - 1;
            }

            i[7] = i[6] - 2;
            i[8] = i[6] - 8;
            i[9] = i[6] - 10;
            i[10] = i[6] - 13;
            i[11] = i[6] - 15;

            int sum = 0;
            int i1 = 1;
            while(i1<12)
            {
                sum = sum + i[i1];
                i1++;
            }

            if(((sum+longest)/12)-(sum/11)>3 )
            {
                i[0] = (int)average * 12 - sum;
                has_asterix = true;
                i[12] = longest;
            }
            else
            {
                i[0] = longest;
            }


            if (has_asterix == false)
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

