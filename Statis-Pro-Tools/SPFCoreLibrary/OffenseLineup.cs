using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPFCoreLibrary
{
    public class OffenseLineup
    {

        //Sets the Offensive Linemen
        public Player LG { get; set; }
        public Player LT { get; set; }
        public Player C { get; set; }
        public Player RT { get; set; }
        public Player RG { get; set; }


        //Sets the Left End, and determines if the End is a Tight End or Split End
        public Player LE { get; set; }
        public bool isLESplit { get; set; }

        //Sets the Right End, and determines if the End is a Tight End or Split End
        public Player RE { get; set; }
        public bool isRESplit { get; set; }

        //Sets the Quarterback
        public Player QB { get; set; }


        public Player BK1 { get; set; }


        public Player Bk2 { get; set; }


        public Player BK3 { get; set; }

        public int bestBKBlock()
        {
            int i = BK1.runBlock;


            return i;
        }

        public Player FL1 { get; set; }
        public Player FL2 { get; set; }
    }
}
