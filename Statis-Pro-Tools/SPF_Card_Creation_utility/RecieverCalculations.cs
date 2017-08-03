using System;

namespace SPF_Card_Creation_utility
{
    class RecieverCalculations
    {

        public string[] getClmValues(double avg, int longest)
        {
            bool hasClm1 = false;
            bool hasClm2 = false;
            string[] values = new string[12];

            int avgint = (int)Math.Round(avg);

            float lngavg = new float();
            lngavg = ((float)(longest - 20) / 11);
            int i = 0;


            string[] clm1 = new string[12];
            string[] clm2 = new string[12];
            string[] clm3 = new string[12];

            if(avgint <= 3)
            {
                hasClm1 = false;
                hasClm2 = false;
                if(longest > 8)
                {
                    clm3[0] = longest.ToString();
                }
                else { clm3[0] = "8"; }

                clm3[1] = "7";
                clm3[2] = "6";
                clm3[3] = "5";
                clm3[4] = "4";
                clm3[5] = "3";
                clm3[6] = "2";
                clm3[7] = "1";
                clm3[8] = "0";
                clm3[9] = "-1";
                clm3[10] = "-2";
                clm3[11] = "-3";
            }
            else if(avgint<28)
            {
                switch (avgint)
                {
                    case 4:
                        hasClm1 = false;
                        hasClm2 = false;
                        if (longest > 9)
                        {
                            clm3[0] = longest.ToString();
                        }
                        else { clm3[0] = "9"; }

                        clm3[1] = "8";
                        clm3[2] = "7";
                        clm3[3] = "6";
                        clm3[4] = "5";
                        clm3[5] = "4";
                        clm3[6] = "3";
                        clm3[7] = "2";
                        clm3[8] = "1";
                        clm3[9] = "0";
                        clm3[10] = "-1";
                        clm3[11] = "-2";
                        break;
                    case 5:
                        hasClm1 = false;
                        hasClm2 = false;
                        if (longest > 10)
                        {
                            clm3[0] = longest.ToString();
                        }
                        else { clm3[0] = "10"; }

                        clm3[1] = "9";
                        clm3[2] = "8";
                        clm3[3] = "7";
                        clm3[4] = "6";
                        clm3[5] = "5";
                        clm3[6] = "4";
                        clm3[7] = "3";
                        clm3[8] = "2";
                        clm3[9] = "1";
                        clm3[10] = "0";
                        clm3[11] = "-1";
                        break;
                    case 6:
                        hasClm1 = false;
                        hasClm2 = false;
                        if (longest > 11)
                        {
                            clm3[0] = longest.ToString();
                        }
                        else { clm3[0] = "11"; }

                        clm3[1] = "10";
                        clm3[2] = "9";
                        clm3[3] = "8";
                        clm3[4] = "7";
                        clm3[5] = "6";
                        clm3[6] = "5";
                        clm3[7] = "4";
                        clm3[8] = "3";
                        clm3[9] = "2";
                        clm3[10] = "1";
                        clm3[11] = "0";
                        break;
                    case 7:
                        if (longest > 20)
                        {
                            hasClm1 = true;
                            hasClm2 = true;


                            
                            clm1[0] = longest.ToString();
                            clm1[11] = "20";
                            
                            while (i < 11)
                            {
                                clm1[i] = (Math.Round(longest - (lngavg * i))).ToString();
                                i++;
                            }

                            clm2[0] = "12";
                            clm2[1] = "11";
                            clm2[2] = "10";
                            clm2[3] = "9";
                            clm2[4] = "8";
                            clm2[5] = "7";
                            clm2[6] = "6";
                            clm2[7] = "5";
                            clm2[8] = "5";
                            clm2[9] = "5";
                            clm2[10] = "5";
                            clm2[11] = "5";
                            clm3[0] = "6";

                        }
                        else if ( longest > 6)
                        {
                            hasClm1 = false;
                            hasClm2 = true;
                            lngavg = ((float)(longest - 5) / 11);
                            clm2[0] = longest.ToString();
                            clm2[11] = "5";
                            i = 1;
                            while (i < 11)
                            {
                                clm2[i] = (Math.Round(longest - (lngavg * i))).ToString();
                                i++;
                            }
                            clm3[0] = "6";
                        }
                        else
                        {
                            hasClm1 = false;
                            hasClm2 = false;
                            if (longest > 6)
                            {
                                clm3[0] = longest.ToString();
                            }
                            else clm3[0] = "6";
                        }
                        clm3[1] = "5";
                        clm3[2] = "5";
                        clm3[3] = "4";
                        clm3[4] = "4";
                        clm3[5] = "3";
                        clm3[6] = "3";
                        clm3[7] = "2";
                        clm3[8] = "2";
                        clm3[9] = "1";
                        clm3[10] = "0";
                        clm3[11] = "0";
                        break;
                    case 8:
                        if (longest > 20)
                        {
                            hasClm1 = true;
                            hasClm2 = true;


                            lngavg = ((float)(longest - 20) / 11);
                            clm1[0] = longest.ToString();
                            clm1[11] = "20";
                             i = 1;
                            while (i < 11)
                            {
                                clm1[i] = (Math.Round(longest - (lngavg * i))).ToString();
                                i++;
                            }

                            clm2[0] = "L";
                            clm2[1] = "12";
                            clm2[2] = "11";
                            clm2[3] = "9";
                            clm2[4] = "8";
                            clm2[5] = "7";
                            clm2[6] = "6";
                            clm2[7] = "5";
                            clm2[8] = "5";
                            clm2[9] = "5";
                            clm2[10] = "5";
                            clm2[11] = "5";
                            clm3[0] = "L";

                        }
                        else if (longest > 10)
                        {
                            hasClm1 = false;
                            hasClm2 = true;
                            lngavg = ((float)(longest - 5) / 11);
                            clm2[0] = longest.ToString();
                            clm2[11] = "5";
                            i = 1;
                            while (i < 11)
                            {
                                clm2[i] = (Math.Round(longest - (lngavg * i))).ToString();
                                i++;
                            }
                            clm3[0] = "L";
                        }
                        else
                        {
                            hasClm1 = false;
                            hasClm2 = false;
                            clm3[0] = "11";
                        }
                        clm3[1] = "10";
                        clm3[2] = "5";
                        clm3[3] = "4";
                        clm3[4] = "4";
                        clm3[5] = "3";
                        clm3[6] = "3";
                        clm3[7] = "2";
                        clm3[8] = "2";
                        clm3[9] = "1";
                        clm3[10] = "0";
                        clm3[11] = "0";
                        break;
                    case 9:
                        if (longest > 20)
                        {
                            hasClm1 = true;
                            hasClm2 = true;


                            lngavg = ((float)(longest - 20) / 11);
                            clm1[0] = longest.ToString();
                            clm1[11] = "20";
                            i = 1;
                            while (i < 11)
                            {
                                clm1[i] = (Math.Round(longest - (lngavg * i))).ToString();
                                i++;
                            }

                            clm2[0] = "L";
                            clm2[1] = "13";
                            clm2[2] = "12";
                            clm2[3] = "11";
                            clm2[4] = "10";
                            clm2[5] = "9";
                            clm2[6] = "8";
                            clm2[7] = "7";
                            clm2[8] = "6";
                            clm2[9] = "5";
                            clm2[10] = "5";
                            clm2[11] = "5";
                            clm3[0] = "L";

                        }
                        else if (longest > 10)
                        {
                            hasClm1 = false;
                            hasClm2 = true;
                            lngavg = ((float)(longest - 5) / 11);
                            clm2[0] = longest.ToString();
                            clm2[11] = "5";
                            i = 1;
                            while (i < 11)
                            {
                                clm2[i] = (Math.Round(longest - (lngavg * i))).ToString();
                                i++;
                            }
                            clm3[0] = "L";
                        }
                        else
                        {
                            hasClm1 = false;
                            hasClm2 = false;
                            clm3[0] = "12";
                        }
                        clm3[1] = "10";
                        clm3[2] = "6";
                        clm3[3] = "5";
                        clm3[4] = "5";
                        clm3[5] = "4";
                        clm3[6] = "4";
                        clm3[7] = "3";
                        clm3[8] = "3";
                        clm3[9] = "2";
                        clm3[10] = "2";
                        clm3[11] = "1";
                        break;
                    case 10:
                        if (longest > 20)
                        {
                            hasClm1 = true;
                            hasClm2 = true;


                            lngavg = ((float)(longest - 20) / 11);
                            clm1[0] = longest.ToString();
                            clm1[11] = "20";
                            i = 1;
                            while (i < 11)
                            {
                                clm1[i] = (Math.Round(longest - (lngavg * i))).ToString();
                                i++;
                            }

                            clm2[0] = "L";
                            clm2[1] = "14";
                            clm2[2] = "13";
                            clm2[3] = "12";
                            clm2[4] = "11";
                            clm2[5] = "10";
                            clm2[6] = "9";
                            clm2[7] = "8";
                            clm2[8] = "7";
                            clm2[9] = "6";
                            clm2[10] = "5";
                            clm2[11] = "5";
                            clm3[0] = "L";

                        }
                        else if (longest > 10)
                        {
                            hasClm1 = false;
                            hasClm2 = true;
                            lngavg = ((float)(longest - 5) / 11);
                            clm2[0] = longest.ToString();
                            clm2[11] = "5";
                            i = 1;
                            while (i < 11)
                            {
                                clm2[i] = (Math.Round(longest - (lngavg * i))).ToString();
                                i++;
                            }
                            clm3[0] = "L";
                        }
                        else
                        {
                            hasClm1 = false;
                            hasClm2 = false;
                            clm3[0] = "12";
                        }
                        clm3[1] = "10";
                        clm3[2] = "6";
                        clm3[3] = "6";
                        clm3[4] = "5";
                        clm3[5] = "5";
                        clm3[6] = "4";
                        clm3[7] = "3";
                        clm3[8] = "3";
                        clm3[9] = "3";
                        clm3[10] = "2";
                        clm3[11] = "2";
                        break;
                    case 11:
                        if (longest > 20)
                        {
                            hasClm1 = true;
                            hasClm2 = true;


                            lngavg = ((float)(longest - 20) / 11);
                            clm1[0] = longest.ToString();
                            clm1[11] = "20";
                            i = 1;
                            while (i < 11)
                            {
                                clm1[i] = (Math.Round(longest - (lngavg * i))).ToString();
                                i++;
                            }

                            clm2[0] = "L";
                            clm2[1] = "15";
                            clm2[2] = "14";
                            clm2[3] = "13";
                            clm2[4] = "12";
                            clm2[5] = "11";
                            clm2[6] = "10";
                            clm2[7] = "9";
                            clm2[8] = "8";
                            clm2[9] = "7";
                            clm2[10] = "6";
                            clm2[11] = "5";
                            clm3[0] = "L";

                        }
                        else if (longest > 10)
                        {
                            hasClm1 = false;
                            hasClm2 = true;
                            lngavg = ((float)(longest - 5) / 11);
                            clm2[0] = longest.ToString();
                            clm2[11] = "5";
                            i = 1;
                            while (i < 11)
                            {
                                clm2[i] = (Math.Round(longest - (lngavg * i))).ToString();
                                i++;
                            }
                            clm3[0] = "L";
                        }
                        else
                        {
                            hasClm1 = false;
                            hasClm2 = false;
                            clm3[0] = "12";
                        }
                        clm3[1] = "10";
                        clm3[2] = "7";
                        clm3[3] = "6";
                        clm3[4] = "6";
                        clm3[5] = "5";
                        clm3[6] = "5";
                        clm3[7] = "4";
                        clm3[8] = "4";
                        clm3[9] = "3";
                        clm3[10] = "3";
                        clm3[11] = "2";
                        break;
                        
                    case 12:
                        if (longest > 20)
                        {
                            hasClm1 = true;
                            hasClm2 = true;


                            lngavg = ((float)(longest - 20) / 11);
                            clm1[0] = longest.ToString();
                            clm1[11] = "20";
                             i = 1;
                            while (i < 11)
                            {
                                clm1[i] = (Math.Round(longest - (lngavg * i))).ToString();
                                i++;
                            }

                            clm2[0] = "L";
                            clm2[1] = "16";
                            clm2[2] = "15";
                            clm2[3] = "14";
                            clm2[4] = "13";
                            clm2[5] = "12";
                            clm2[6] = "11";
                            clm2[7] = "10";
                            clm2[8] = "9";
                            clm2[9] = "8";
                            clm2[10] = "7";
                            clm2[11] = "6";
                            clm3[0] = "L";

                        }
                        else if (longest > 12)
                        {
                            hasClm1 = false;
                            hasClm2 = true;
                            lngavg = ((float)(longest - 6) / 11);
                            clm2[0] = longest.ToString();
                            clm2[11] = "6";
                            i = 1;
                            while (i < 11)
                            {
                                clm2[i] = (Math.Round(longest - (lngavg * i))).ToString();
                                i++;
                            }
                            clm3[0] = "L";
                        }
                        else
                        {
                            hasClm1 = false;
                            hasClm2 = false;
                            clm3[0] = "13";
                        }
                        clm3[1] = "12";
                        clm3[2] = "7";
                        clm3[3] = "7";
                        clm3[4] = "6";
                        clm3[5] = "6";
                        clm3[6] = "5";
                        clm3[7] = "5";
                        clm3[8] = "4";
                        clm3[9] = "4";
                        clm3[10] = "3";
                        clm3[11] = "3";
                        
                        break;
                    case 13:
                        if (longest > 20)
                        {
                            hasClm1 = true;
                            hasClm2 = true;


                             lngavg = ((float)(longest - 20) / 11);
                            clm1[0] = longest.ToString();
                            clm1[11] = "20";
                             i = 1;
                            while (i < 11)
                            {
                                clm1[i] = (Math.Round(longest - (lngavg * i))).ToString();
                                i++;
                            }

                            clm2[0] = "L";
                            clm2[1] = "17";
                            clm2[2] = "16";
                            clm2[3] = "15";
                            clm2[4] = "14";
                            clm2[5] = "13";
                            clm2[6] = "12";
                            clm2[7] = "11";
                            clm2[8] = "10";
                            clm2[9] = "9";
                            clm2[10] = "8";
                            clm2[11] = "7";
                            clm3[0] = "L";

                        }
                        else if (longest > 13)
                        {
                            hasClm1 = false;
                            hasClm2 = true;
                            lngavg = ((float)(longest - 6) / 11);
                            clm2[0] = longest.ToString();
                            clm2[11] = "7";
                            i = 1;
                            while (i < 11)
                            {
                                clm2[i] = (Math.Round(longest - (lngavg * i))).ToString();
                                i++;
                            }
                            clm3[0] = "L";
                        }
                        else
                        {
                            hasClm1 = false;
                            hasClm2 = false;
                            clm3[0] = "14";
                        }
                        clm3[1] = "13";
                        clm3[2] = "8";
                        clm3[3] = "7";
                        clm3[4] = "7";
                        clm3[5] = "6";
                        clm3[6] = "6";
                        clm3[7] = "5";
                        clm3[8] = "5";
                        clm3[9] = "4";
                        clm3[10] = "4";
                        clm3[11] = "3";

                        break;
                    case 14:
                        if (longest > 20)
                        {
                            hasClm1 = true;
                            hasClm2 = true;


                            lngavg = ((float)(longest - 20) / 11);
                            clm1[0] = longest.ToString();
                            clm1[11] = "20";
                            i = 1;
                            while (i < 11)
                            {
                                clm1[i] = (Math.Round(longest - (lngavg * i))).ToString();
                                i++;
                            }

                            clm2[0] = "L";
                            clm2[1] = "18";
                            clm2[2] = "17";
                            clm2[3] = "16";
                            clm2[4] = "15";
                            clm2[5] = "14";
                            clm2[6] = "13";
                            clm2[7] = "12";
                            clm2[8] = "11";
                            clm2[9] = "10";
                            clm2[10] = "9";
                            clm2[11] = "8";
                            clm3[0] = "L";

                        }
                        else if (longest > 15)
                        {
                            hasClm1 = false;
                            hasClm2 = true;
                            lngavg = ((float)(longest - 6) / 11);
                            clm2[0] = longest.ToString();
                            clm2[11] = "8";
                             i = 1;
                            while (i < 11)
                            {
                                clm2[i] = (Math.Round(longest - (lngavg * i))).ToString();
                                i++;
                            }
                            clm3[0] = "L";
                        }
                        else
                        {
                            hasClm1 = false;
                            hasClm2 = false;
                            clm3[0] = "15";
                        }
                        clm3[1] = "14";
                        clm3[2] = "8";
                        clm3[3] = "8";
                        clm3[4] = "7";
                        clm3[5] = "7";
                        clm3[6] = "6";
                        clm3[7] = "6";
                        clm3[8] = "5";
                        clm3[9] = "5";
                        clm3[10] = "4";
                        clm3[11] = "4";

                        break;

                    case 15:
                        if (longest > 20)
                        {
                            hasClm1 = true;
                            hasClm2 = true;


                            lngavg = ((float)(longest - 20) / 11);
                            clm1[0] = longest.ToString();
                            clm1[11] = "20";
                            i = 1;
                            while (i < 11)
                            {
                                clm1[i] = (Math.Round(longest - (lngavg * i))).ToString();
                                i++;
                            }

                            clm2[0] = "L";
                            clm2[1] = "19";
                            clm2[2] = "18";
                            clm2[3] = "17";
                            clm2[4] = "16";
                            clm2[5] = "15";
                            clm2[6] = "14";
                            clm2[7] = "13";
                            clm2[8] = "12";
                            clm2[9] = "11";
                            clm2[10] = "10";
                            clm2[11] = "9";
                            clm3[0] = "L";

                        }
                        else if (longest > 16)
                        {
                            hasClm1 = false;
                            hasClm2 = true;
                             lngavg = ((float)(longest - 6) / 11);
                            clm2[0] = longest.ToString();
                            clm2[11] = "8";
                            i = 1;
                            while (i < 11)
                            {
                                clm2[i] = (Math.Round(longest - (lngavg * i))).ToString();
                                i++;
                            }
                            clm3[0] = "L";
                        }
                        else
                        {
                            hasClm1 = false;
                            hasClm2 = false;
                            clm3[0] = "15";
                        }
                        clm3[1] = "15";
                        clm3[2] = "9";
                        clm3[3] = "9";
                        clm3[4] = "8";
                        clm3[5] = "8";
                        clm3[6] = "7";
                        clm3[7] = "7";
                        clm3[8] = "6";
                        clm3[9] = "6";
                        clm3[10] = "5";
                        clm3[11] = "5";

                        break;

                    case 16:
                        if (longest > 20)
                        {
                            hasClm1 = true;
                            hasClm2 = true;


                            lngavg = ((float)(longest - 20) / 11);
                            clm1[0] = longest.ToString();
                            clm1[11] = "20";
                            i = 1;
                            while (i < 11)
                            {
                                clm1[i] = (Math.Round(longest - (lngavg * i))).ToString();
                                i++;
                            }

                            clm2[0] = "L";
                            clm2[1] = "20";
                            clm2[2] = "19";
                            clm2[3] = "18";
                            clm2[4] = "17";
                            clm2[5] = "16";
                            clm2[6] = "15";
                            clm2[7] = "14";
                            clm2[8] = "13";
                            clm2[9] = "12";
                            clm2[10] = "11";
                            clm2[11] = "10";
                            clm3[0] = "L";

                        }
                        else if (longest > 17)
                        {
                            hasClm1 = false;
                            hasClm2 = true;
                             lngavg = ((float)(longest - 6) / 11);
                            clm2[0] = longest.ToString();
                            clm2[11] = "10";
                            i = 1;
                            while (i < 11)
                            {
                                clm2[i] = (Math.Round(longest - (lngavg * i))).ToString();
                                i++;
                            }
                            clm3[0] = "L";
                        }
                        else
                        {
                            hasClm1 = false;
                            hasClm2 = false;
                            clm3[0] = "17";
                        }
                        clm3[1] = "16";
                        clm3[2] = "9";
                        clm3[3] = "9";
                        clm3[4] = "8";
                        clm3[5] = "8";
                        clm3[6] = "7";
                        clm3[7] = "7";
                        clm3[8] = "6";
                        clm3[9] = "6";
                        clm3[10] = "5";
                        clm3[11] = "5";

                        break;

                    case 17:
                        if (longest > 20)
                        {
                            hasClm1 = true;
                            hasClm2 = true;


                             lngavg = ((float)(longest - 20) / 11);
                            clm1[0] = longest.ToString();
                            clm1[11] = "20";
                            i = 1;
                            while (i < 11)
                            {
                                clm1[i] = (Math.Round(longest - (lngavg * i))).ToString();
                                i++;
                            }

                            clm2[0] = "L";
                            clm2[1] = "21";
                            clm2[2] = "20";
                            clm2[3] = "19";
                            clm2[4] = "18";
                            clm2[5] = "17";
                            clm2[6] = "16";
                            clm2[7] = "15";
                            clm2[8] = "14";
                            clm2[9] = "13";
                            clm2[10] = "12";
                            clm2[11] = "11";
                            clm3[0] = "L";

                        }
                        else if (longest > 18)
                        {
                            hasClm1 = false;
                            hasClm2 = true;
                            lngavg = ((float)(longest - 6) / 11);
                            clm2[0] = longest.ToString();
                            clm2[11] = "11";
                            i = 1;
                            while (i < 11)
                            {
                                clm2[i] = (Math.Round(longest - (lngavg * i))).ToString();
                                i++;
                            }
                            clm3[0] = "L";
                        }
                        else
                        {
                            hasClm1 = false;
                            hasClm2 = false;
                            clm3[0] = "18";
                        }
                        clm3[1] = "17";
                        clm3[2] = "12";
                        clm3[3] = "9";
                        clm3[4] = "9";
                        clm3[5] = "8";
                        clm3[6] = "8";
                        clm3[7] = "7";
                        clm3[8] = "7";
                        clm3[9] = "6";
                        clm3[10] = "6";
                        clm3[11] = "5";

                        break;

                    case 18:
                        if (longest > 20)
                        {
                            hasClm1 = true;
                            hasClm2 = true;


                            lngavg = ((float)(longest - 20) / 11);
                            clm1[0] = longest.ToString();
                            clm1[11] = "20";
                            i = 1;
                            while (i < 11)
                            {
                                clm1[i] = (Math.Round(longest - (lngavg * i))).ToString();
                                i++;
                            }

                            clm2[0] = "L";
                            clm2[1] = "21";
                            clm2[2] = "20";
                            clm2[3] = "19";
                            clm2[4] = "18";
                            clm2[5] = "17";
                            clm2[6] = "16";
                            clm2[7] = "15";
                            clm2[8] = "14";
                            clm2[9] = "13";
                            clm2[10] = "12";
                            clm2[11] = "11";
                            clm3[0] = "L";

                        }
                        else if (longest > 19)
                        {
                            hasClm1 = false;
                            hasClm2 = true;
                            lngavg = ((float)(longest - 6) / 11);
                            clm2[0] = longest.ToString();
                            clm2[11] = "11";
                            i = 1;
                            while (i < 11)
                            {
                                clm2[i] = (Math.Round(longest - (lngavg * i))).ToString();
                                i++;
                            }
                            clm3[0] = "L";
                        }
                        else
                        {
                            hasClm1 = false;
                            hasClm2 = false;
                            clm3[0] = "19";
                        }
                        clm3[1] = "18";
                        clm3[2] = "12";
                        clm3[3] = "10";
                        clm3[4] = "9";
                        clm3[5] = "9";
                        clm3[6] = "8";
                        clm3[7] = "8";
                        clm3[8] = "7";
                        clm3[9] = "7";
                        clm3[10] = "6";
                        clm3[11] = "6";

                        break;

                    case 19:
                        if (longest > 20)
                        {
                            hasClm1 = true;
                            hasClm2 = true;


                            lngavg = ((float)(longest - 20) / 11);
                            clm1[0] = longest.ToString();
                            clm1[11] = "20";
                             i = 1;
                            while (i < 11)
                            {
                                clm1[i] = (Math.Round(longest - (lngavg * i))).ToString();
                                i++;
                            }

                            clm2[0] = "L";
                            clm2[1] = "23";
                            clm2[2] = "22";
                            clm2[3] = "21";
                            clm2[4] = "20";
                            clm2[5] = "19";
                            clm2[6] = "18";
                            clm2[7] = "17";
                            clm2[8] = "16";
                            clm2[9] = "15";
                            clm2[10] = "14";
                            clm2[11] = "13";
                            clm3[0] = "L";

                        }

                        clm3[1] = "19";
                        clm3[2] = "12";
                        clm3[3] = "10";
                        clm3[4] = "10";
                        clm3[5] = "9";
                        clm3[6] = "9";
                        clm3[7] = "8";
                        clm3[8] = "8";
                        clm3[9] = "7";
                        clm3[10] = "7";
                        clm3[11] = "6";

                        break;

                    case 20:
                       
                            hasClm1 = true;
                            hasClm2 = true;


                             lngavg = ((float)(longest - 20) / 11);
                            clm1[0] = longest.ToString();
                            clm1[11] = "20";
                             i = 1;
                            while (i < 11)
                            {
                                clm1[i] = (Math.Round(longest - (lngavg * i))).ToString();
                                i++;
                            }

                            clm2[0] = "L";
                            clm2[1] = "24";
                            clm2[2] = "23";
                            clm2[3] = "22";
                            clm2[4] = "21";
                            clm2[5] = "20";
                            clm2[6] = "19";
                            clm2[7] = "18";
                            clm2[8] = "17";
                            clm2[9] = "16";
                            clm2[10] = "15";
                            clm2[11] = "14";
                            clm3[0] = "L";

                        
                        
                        clm3[1] = "19";
                        clm3[2] = "12";
                        clm3[3] = "11";
                        clm3[4] = "10";
                        clm3[5] = "10";
                        clm3[6] = "9";
                        clm3[7] = "9";
                        clm3[8] = "8";
                        clm3[9] = "8";
                        clm3[10] = "7";
                        clm3[11] = "7";

                        break;
                    case 21:

                        hasClm1 = true;
                        hasClm2 = true;


                        lngavg = ((float)(longest - 20) / 11);
                        clm1[0] = longest.ToString();
                        clm1[11] = "20";
                        i = 1;
                        while (i < 11)
                        {
                            clm1[i] = (Math.Round(longest - (lngavg * i))).ToString();
                            i++;
                        }

                        clm2[0] = "L";
                        clm2[1] = "24";
                        clm2[2] = "23";
                        clm2[3] = "22";
                        clm2[4] = "21";
                        clm2[5] = "20";
                        clm2[6] = "19";
                        clm2[7] = "18";
                        clm2[8] = "17";
                        clm2[9] = "16";
                        clm2[10] = "15";
                        clm2[11] = "14";
                        clm3[0] = "L";



                        clm3[1] = "19";
                        clm3[2] = "12";
                        clm3[3] = "11";
                        clm3[4] = "11";
                        clm3[5] = "10";
                        clm3[6] = "10";
                        clm3[7] = "9";
                        clm3[8] = "9";
                        clm3[9] = "8";
                        clm3[10] = "8";
                        clm3[11] = "7";
                        break;
                    case 22:
                        break;
                    case 23:
                        break;
                    case 24:
                        break;
                    case 25:
                        break;
                    case 26:
                        break;
                    case 27:
                        break;
                    default:
                        break;
                }
            }



           if(hasClm2 == true)
            {
                if(hasClm1 == true)
                {
                    int j = 0;
                   while(j<12)
                    {
                        values[j] = clm3[j] + "/" + clm2[j] + "/" + clm1[j];
                        j++;
                    }
                }
                else
                {
                    int j = 0;
                    while (j < 12)
                    {
                        values[j] = clm3[j] + "/" + clm2[j];
                        j++;
                    }
                }
                
            }
           else
            {
                int j = 0;
                while (j < 12)
                {
                    values[j] = clm3[j];
                    j++;
                }
            }

            return values;
        }
    }
}
