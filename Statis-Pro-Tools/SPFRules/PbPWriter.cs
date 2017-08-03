using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPFRules
{
    class PbPWriter
    {
        public string PlaybyPlay(Play p)
        {
            string time = p.time.TotalMinutes.ToString() + ":" + p.time.TotalSeconds.ToString();
            string down = p.getDown();
            string pbp;

            if (p.DownType == "KO")
            {
                string kickposition;
                if (p.istouchback == true)
                {
                    kickposition = ". Touchback.";
                }
                else
                {
                    kickposition = p.kicklocations + ". " + p.returner + " to " + p.endlocation + " for " + p.Yardage.ToString() + " yards.";
                }

                pbp = "(" + time + "-" + p.quarter + ") " + p.kicker.name + " kicks " + p.kicklength.ToString() + " yards from " + p.Defense.abbv.ToString() + " 35" + kickposition;


            }

            return down;
        }
    }
}
