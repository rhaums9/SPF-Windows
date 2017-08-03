using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPFCoreLibrary;

namespace SPFRules
{
    public class FAC
    {
        Random rand = new Random();
        public bool isZCard()
        {
            int r = rand.Next(1, 110);
            if (r <= 13)
            {
                return true;
            }
            else return false;
        }

        public int getRunNumber()
        {
            int r = rand.Next(1, 13);
            return r;
        }

        public int getPassNumber()
        {
            int r = rand.Next(1, 49);
            return r;
        }

        public string sweepLeft(OffenseLineup o, DefenseLineup d)
        {
            int r = rand.Next(1, 9) + (rand.Next(1, 7) * 10);
            if (r <= 12)
            {
                return "Break";
            }
            else if (r <= 14)
            {
                return o.LG.runBlock.ToString();
            }
            else if (r <= 18)
            {
                return (o.LG.runBlock + o.RG.runBlock).ToString();
            }
            else if (r <= 23)
            {
                return o.LT.runBlock.ToString();
            }
            else if (r <= 25)
            {
                return (o.LG.runBlock + o.LE.runBlock).ToString();
            }
            else if (r <= 27)
            {
                return o.LE.runBlock.ToString();
            }
            else if (r == 28)
            {
                return o.bestBKBlock().ToString();
            }
            else if (r == 31)
            {
                return (o.bestBKBlock() + 2).ToString();
            }
            else if(r == 32)
            {
                return (o.bestBKBlock() + -1).ToString();
            }
            else if(r<=34)
            {
                return (o.LG.runBlock + -1).ToString();
            }
            else if(r<=36)
            {
                return (o.LT.runBlock + 2).ToString();
            }
            else if (r <= 42)
            {
                return (o.LT.runBlock - 1).ToString();
            }
            else if (r <= 43)
            {
                return (o.LT.runBlock).ToString();
            }
            else if (r <= 47)
            {
                return (o.LE.runBlock - 1).ToString();
            }
            else if (r <= 48)
            {
                return (o.LE.runBlock ).ToString();
            }
            else if (r <= 54)
            {
                return (-1).ToString();
            }
            else
            {
                return 0.ToString();
            }


        }
    }
}
