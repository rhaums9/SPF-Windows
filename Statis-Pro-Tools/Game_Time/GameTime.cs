using SPFCoreLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Time
{
    public static class GameTime
    {
        public static Player BlankPlayer = new Player { canPass = false, canRecieve = false, canRush = false, canTE = false, tackle = -2 };
        public static Team myTeam = Seahawks.Team_Seahawks;

        
        public static OffenseLineup olineup = new OffenseLineup(); 
    }
}
