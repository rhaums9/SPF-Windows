using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPF_Card_Creation_utility
{
    class OLineBlocking
    { 
        public int[] GetBlockingValues(int ypg)
        {
            int[] v = new int[8];

            if (ypg < 80)
            {
                v[0] = 2;
                v[1] = 2;
                v[2] = 1;
                v[3] = 1;
                v[4] = 0;
                v[5] = 0;
                v[6] = -1;
                v[7] = -1;
                   
            }
            else if(79<ypg && ypg<90)
            {
                v[0] = 2;
                v[1] = 2;
                v[2] = 2;
                v[3] = 1;
                v[4] = 1;
                v[5] = 1;
                v[6] = 0;
                v[7] = -1;
            }
            else if (89< ypg && ypg < 95)
            {
                v[0] = 3;
                v[1] = 2;
                v[2] = 2;
                v[3] = 1;
                v[4] = 1;
                v[5] = 1;
                v[6] = 0;
                v[7] = -1;
            }
            else if (93 < ypg && ypg < 100)
            {
                v[0] = 3;
                v[1] = 2;
                v[2] = 2;
                v[3] = 2;
                v[4] = 1;
                v[5] = 1;
                v[6] = 0;
                v[7] = -1;
            }
            else if (99 < ypg && ypg < 105)
            {
                v[0] = 3;
                v[1] = 3;
                v[2] = 2;
                v[3] = 2;
                v[4] = 1;
                v[5] = 1;
                v[6] = 1;
                v[7] = 0;
            }
            else if (104 < ypg && ypg < 110)
            {
                v[0] = 3;
                v[1] = 3;
                v[2] = 3;
                v[3] = 2;
                v[4] = 1;
                v[5] = 1;
                v[6] = 1;
                v[7] = 0;
            }
            else if (109 < ypg && ypg < 120)
            {
                v[0] = 4;
                v[1] = 3;
                v[2] = 3;
                v[3] = 2;
                v[4] = 1;
                v[5] = 1;
                v[6] = 1;
                v[7] = 0;
            }
            else if (119 < ypg && ypg < 130)
            {
                v[0] = 4;
                v[1] = 3;
                v[2] = 3;
                v[3] = 2;
                v[4] = 2;
                v[5] = 1;
                v[6] = 1;
                v[7] = 0;
            }
            else if (129 < ypg && ypg < 140)
            {
                v[0] = 4;
                v[1] = 3;
                v[2] = 3;
                v[3] = 3;
                v[4] = 2;
                v[5] = 1;
                v[6] = 1;
                v[7] = 1;
            }
            else if (139 < ypg && ypg < 150)
            {
                v[0] = 4;
                v[1] = 4;
                v[2] = 3;
                v[3] = 3;
                v[4] = 2;
                v[5] = 2;
                v[6] = 1;
                v[7] = 1;
            }
            else if (ypg > 150)
            {
                v[0] = 4;
                v[1] = 4;
                v[2] = 3;
                v[3] = 3;
                v[4] = 3;
                v[5] = 2;
                v[6] = 1;
                v[7] = 1;
            }

            return v;
        }

        public int[] passBlocking(int sacks)
        {
            int[] pb = new int[8];

            if(sacks < 16)
            {
                pb[0] = 3;
                pb[1] = 3;
                pb[2] = 2;
                pb[3] = 2;
                pb[4] = 1;
                pb[5] = 1;
                pb[6] = 0;
                pb[7] = 0;
                
            }
            else if (sacks < 23)
            {
                pb[0] = 3;
                pb[1] = 3;
                pb[2] = 2;
                pb[3] = 2;
                pb[4] = 1;
                pb[5] = 0;
                pb[6] = 0;
                pb[7] = 0;
            }
            else if (sacks < 30)
            {
                pb[0] = 3;
                pb[1] = 3;
                pb[2] = 1;
                pb[3] = 1;
                pb[4] = 1;
                pb[5] = 0;
                pb[6] = 0;
                pb[7] = 0;
            }
            else if (sacks < 36)
            {
                pb[0] = 3;
                pb[1] = 2;
                pb[2] = 1;
                pb[3] = 1;
                pb[4] = 1;
                pb[5] = 0;
                pb[6] = 0;
                pb[7] = 0;
            }
            else if (sacks < 43)
            {
                pb[0] = 3;
                pb[1] = 2;
                pb[2] = 1;
                pb[3] = 1;
                pb[4] = 1;
                pb[5] = 0;
                pb[6] = 0;
                pb[7] = 0;
            }
            else if (sacks < 50)
            {
                pb[0] = 3;
                pb[1] = 2;
                pb[2] = 1;
                pb[3] = 1;
                pb[4] = 0;
                pb[5] = 0;
                pb[6] = 0;
                pb[7] = 0;
            }
            else if (sacks < 56)
            {
                pb[0] = 2;
                pb[1] = 2;
                pb[2] = 1;
                pb[3] = 1;
                pb[4] = 0;
                pb[5] = 0;
                pb[6] = 0;
                pb[7] = 0;
            }
            else if (sacks < 63)
            {
                pb[0] = 2;
                pb[1] = 2;
                pb[2] = 1;
                pb[3] = 0;
                pb[4] = 0;
                pb[5] = 0;
                pb[6] = 0;
                pb[7] = 0;

            }
            else if (sacks < 70)
            {
                pb[0] = 2;
                pb[1] = 1;
                pb[2] = 1;
                pb[3] = 0;
                pb[4] = 0;
                pb[5] = 0;
                pb[6] = 0;
                pb[7] = 0;
            }
            else if (sacks < 76)
            {
                pb[0] = 2;
                pb[1] = 1;
                pb[2] = 0;
                pb[3] = 0;
                pb[4] = 0;
                pb[5] = 0;
                pb[6] = 0;
                pb[7] = 0;
            }
            else if (sacks > 75)
            {
                pb[0] = 1;
                pb[1] = 1;
                pb[2] = 0;
                pb[3] = 0;
                pb[4] = 0;
                pb[5] = 0;
                pb[6] = 0;
                pb[7] = 0;
            }

            return pb;
        }
    }
}
