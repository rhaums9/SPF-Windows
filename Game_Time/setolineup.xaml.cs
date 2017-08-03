using SPFCoreLibrary;
using SPFRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Game_Time
{
    /// <summary>
    /// Interaction logic for SetOLineup.xaml
    /// </summary>
    public partial class SetOLineup : Window
    {
        public static List<Player> playerlist()
        {
            List<Player> plist = new List<Player>();
            plist.Add(SeahawksPlayers.Andy_Heck);
            plist.Add(SeahawksPlayers.Bill_Hitchcock);
            plist.Add(SeahawksPlayers.Bryan_Millard);
            plist.Add(SeahawksPlayers.Brian_Blades);
            plist.Add(SeahawksPlayers.Jeff_Kemp);
            plist.Add(SeahawksPlayers.Curt_Stinger);
            plist.Add(SeahawksPlayers.Darrick_Brillz);
            plist.Add(SeahawksPlayers.Ronnie_Lee);
            plist.Add(SeahawksPlayers.Grant_Feasel);
            plist.Add(SeahawksPlayers.David_Daniels);
            plist.Add(SeahawksPlayers.Tommy_Kane);
            plist.Add(SeahawksPlayers.Louis_Clark);
            return plist;
        }
        public SetOLineup()
        {
            InitializeComponent();

            int i;
            for(i = 0;  i < 11; i++)
            {
                

                List<Player> pl = playerlist();
                Player p = pl.ElementAt(i);
                    cmb_c.Items.Add(p.name);
                    cmb_lg.Items.Add(p.name);
                    cmb_lt.Items.Add(p.name);
                    cmb_rg.Items.Add(p.name);
                cmb_re.Items.Add(p.name);
                cmb_rt.Items.Add(p.name);
                


                    cmb_fl1.Items.Add(p.name);
                    cmb_fl2.Items.Add(p.name);
                    cmb_b1.Items.Add(p.name);
                    cmb_b2.Items.Add(p.name);
                    cmb_b3.Items.Add(p.name);
                    cmb_le.Items.Add(p.name);



               
                
                    cmb_qb.Items.Add(p.name);
                

            }
            
        }


        private void btn_setLineup_Click(object sender, RoutedEventArgs e)
        {
            GameTime.olineup.LG = playerlist().ElementAt(cmb_lg.SelectedIndex);
            GameTime.olineup.RG = playerlist().ElementAt(cmb_rg.SelectedIndex);
            GameTime.olineup.RT = playerlist().ElementAt(cmb_rt.SelectedIndex);
            GameTime.olineup.LT = playerlist().ElementAt(cmb_lt.SelectedIndex);

            GameTime.olineup.RE = playerlist().ElementAt(cmb_le.SelectedIndex);
            GameTime.olineup.LE = playerlist().ElementAt(cmb_re.SelectedIndex);

            int checks = 0;
            if(ck_B1.IsChecked == true)
            {
                checks++;
            }
            if (ck_B2.IsChecked == true)
            {
                checks++;
            }
            if (ck_B3.IsChecked == true)
            {
                checks++;
            }
            if (ck_FL1.IsChecked == true)
            {
                checks++;
            }
            if (ck_FL2.IsChecked == true)
            {
                checks++;
            }

            if(checks >3)
            {
                throw new System.ArgumentException("Too many players on the field");
            }
            else if(checks< 3)
            {
                throw new System.ArgumentException("Too few players on the field");
            }
            else
            {
                if (ck_B1.IsChecked == true)
                {
                    GameTime.olineup.BK1 = playerlist().ElementAt(cmb_b1.SelectedIndex);
                }
                

                if (ck_B2.IsChecked == true)
                {
                    GameTime.olineup.Bk2 = playerlist().ElementAt(cmb_b2.SelectedIndex);
                }
                if (ck_B3.IsChecked == true)
                {
                    GameTime.olineup.BK3 = playerlist().ElementAt(cmb_b3.SelectedIndex);
                }
                if (ck_FL1.IsChecked == true)
                {
                    GameTime.olineup.FL1 = playerlist().ElementAt(cmb_fl1.SelectedIndex);
                }
                if (ck_FL2.IsChecked == true)
                {
                    GameTime.olineup.FL2 = playerlist().ElementAt(cmb_fl2.SelectedIndex);
                }
            }
        }

        private void cmb_le_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }



        private void btn_runplayclick(object sender, RoutedEventArgs e)
        {
            int y = Play();
            MessageBox.Show(y.ToString() + " Yards");
        }

        public int Play()
        {
            FAC card = new FAC();
            string fcard = card.sweepLeft(GameTime.olineup, null);
            int yards;

            if(fcard == "Break")
            {
                yards = int.Parse(GameTime.olineup.BK1.rushVal[2, card.getRunNumber()]);
            }
            
            else
            {
                int i = card.getRunNumber();
                if (GameTime.olineup.BK1.rushVal[0, i] == "SG")
                {
                    int i2 = card.getRunNumber();
                    yards = int.Parse(GameTime.olineup.BK1.rushVal[1, i2]);
                }
                else
                {
                    int i2 = card.getRunNumber();
                    yards = int.Parse(GameTime.olineup.BK1.rushVal[0, i2]) + int.Parse(fcard);
                }

            }

            return yards;


        }
    }
}
