using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace SPF_Card_Creation_utility
{
    class League
    {
        public static List<Team> teamlist = new List<Team>();


        static Team Cardinals = new Team { teamName = "Arizona Cardinals", abbv = "Ari", clr = (Color)ColorConverter.ConvertFromString("#9B2743"), text = (Color)ColorConverter.ConvertFromString("#000000") };
        static Team Falcons = new Team { teamName = "Atlanta Falcons", abbv = "Atl", clr=(Color)ColorConverter.ConvertFromString("#000000"), text = (Color)ColorConverter.ConvertFromString("#A6192D")};
        static Team Ravens = new Team { teamName = "Baltimore Ravens", abbv = "Blt", clr = (Color)ColorConverter.ConvertFromString("#280353"), text = (Color)ColorConverter.ConvertFromString("#D0B240") };
        static Team Bills = new Team { teamName = "Buffalo Bills", abbv = "Buf", clr = (Color)ColorConverter.ConvertFromString("#00338D"), text = (Color)ColorConverter.ConvertFromString("#C60230") };
        static Team Panthers = new Team { teamName = "Carolina Panthers", abbv = "Car", clr = (Color)ColorConverter.ConvertFromString("#000000"), text = (Color)ColorConverter.ConvertFromString("#0088CE") };
        static Team Bears = new Team { teamName = "Chicago Bears", abbv = "Chi", clr = (Color)ColorConverter.ConvertFromString("#03202F"), text = (Color)ColorConverter.ConvertFromString("#DD4814") };
        static Team Bengals = new Team { teamName = "Cincinatti Bengals", abbv = "Cin", clr = (Color)ColorConverter.ConvertFromString("#FB4F14"), text = (Color)ColorConverter.ConvertFromString("#000000") };
        static Team Browns = new Team { teamName = "Atlanta Falcons", abbv = "Atl", clr = (Color)ColorConverter.ConvertFromString("#000000"), text = (Color)ColorConverter.ConvertFromString("#A6192D") };

        static Team Patriots = new Team { teamName = "New England Patriots", abbv = "NE", clr = (Color)(ColorConverter.ConvertFromString("#D6D6D6")), text = (Color)(ColorConverter.ConvertFromString("#C80815")) };
        static Team Seahawks = new Team { teamName = "Seattle Seahawks", abbv = "Sea", clr = (Color)ColorConverter.ConvertFromString("#002244"), text = (Color)ColorConverter.ConvertFromString("#69BE28") };

        public static void InitialiseList()
        {
            teamlist.Add(Cardinals);
            teamlist.Add(Falcons);
            teamlist.Add(Ravens);
            teamlist.Add(Bills);
            teamlist.Add(Panthers);
            teamlist.Add(Bengals);

            teamlist.Add(Patriots);
            teamlist.Add(Seahawks);
        }
     
    }
}
