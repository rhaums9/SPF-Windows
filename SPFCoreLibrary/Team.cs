using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;
using System.Text;
using System.Threading.Tasks;

namespace SPFCoreLibrary
{
    public class Team
    {
        //Name of the Team
        public string TeamName { get; set; }

        //This section is for a full season - not implemented yet
        public string HeadCoach { get; set; }
        public int TeamWins { get; set; }
        public int TeamLoss { get; set; }
        public int TeamTie { get; set; }

        //Basic Team Details
        public string abbv { get; set; }
        public Color main { get; set; }
        public Color txt { get; set; }


        //List of Players
        public List<Player> playerList = new List<Player>();

        string GetTeamRecord()
        {
            return TeamWins.ToString() + "-" + TeamLoss.ToString() + "-" + TeamTie.ToString();
        }

        
    }
}
