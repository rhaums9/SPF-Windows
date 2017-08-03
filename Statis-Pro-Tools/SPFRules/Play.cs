
using SPFCoreLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPFRules
{
    class Play
    {
        //Information regarding each play

        public string DownType { get; set; }

        public TimeSpan time { get; set; }

        public Team Offense { get; set; }
        public Team Defense { get; set; }
        public string quarter { get; set; }
        public int downint { get; set; }
        public Player passer { get; set; }
        public Player intercepter { get; set; }
        public Player rusher { get; set; }
        public Player receiver { get; set; }
        public Player returner { get; set; }
        public string endlocation { get; set; }
        public Player tackler { get; set; }
        public int kicklength { get; set; }
        public Player kicker { get; set; }
        public int kicklocation { get; set; }
        public string kicklocations { get; set; }
        public bool istouchback { get; set; }
        public string getDown()
        {
            if (downint == 1)
            {
                return "1st";
            }
            else if (downint == 2)
            {
                return "2nd";
            }
            else if (downint == 3)
            {
                return "3rd";
            }
            else if (downint == 4)
            {
                return "4th";
            }
            else return "Not Scrimmage";
        }
        public int YardsToFirst { get; set; }

        public int Yardage { get; set; }

        public enum playtype { Pass, Run, Knee, Spike}
        public enum SpecialEvents { Fumble, Intercept, Injury, Foul}

    }
}
