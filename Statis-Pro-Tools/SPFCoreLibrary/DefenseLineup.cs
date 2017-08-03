using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPFCoreLibrary
{
    public class DefenseLineup
    {
        //Sets the Players in Each Box
        public int playersInA { get; set; }
        public Player a1 { get; set; }
        public Player a2 { get; set; }


        public int playersInB { get; set; }
        public int bRunBlock { get; set; }
        public Player b1 { get; set; }
        public Player b2 { get; set; }

        public int playersInC { get; set; }
        public Player c1 { get; set; }
        public Player c2 { get; set; }

        public int playersInD { get; set; }
        public Player d1 { get; set; }
        public Player d2 { get; set; }

        public int playersInE { get; set; }
        public Player e1 { get; set; }
        public Player e2 { get; set; }

        public bool hasF { get; set; }
        public Player f { get; set; }

        public bool hasG { get; set; }
        public Player g { get; set; }

        public bool hasH { get; set; }
        public Player h { get; set; }

        public bool hasI { get; set; }
        public Player i { get; set; }

        public bool hasJ { get; set; }
        public Player j { get; set; }

        public bool hasK {get;set;}
        public Player k { get; set; }

        public int playersInL { get; set; }
        public Player l1 { get; set; }
        public Player l2 { get; set; }

        public bool hasM { get; set; }
        public Player m { get; set; }

        public bool hasN { get; set; }
        public Player n { get; set; }

        public bool hasO { get; set; }
        public Player o { get; set; }
    }
}
