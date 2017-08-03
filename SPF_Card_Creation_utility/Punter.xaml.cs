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

namespace SPF_Card_Creation_utility
{
    /// <summary>
    /// Interaction logic for Punter.xaml
    /// </summary>
    public partial class Punter : Window
    {
        List<Team> teams = League.teamlist;

        public Punter()
        {
            
            InitializeComponent();
            foreach (Team t in teams)
            {
                cmb_team.Items.Add(t.teamName);
            }
        }
        int[] ipunts = new int[12];
        private void btn_generatepunter_Click(object sender, RoutedEventArgs e)
        {
            double avg = double.Parse(txb_pavg.Text);
            int row6 = ((int)Math.Round(avg) - 1);
            int longest = int.Parse(txb_long.Text);
            int number = int.Parse(txb_p.Text);
            double returns = (double.Parse(txb_return.Text)) / number;
            bool is_blocked = false;
            bool asterix = false;
            int blocked = 0;
            if(txb_bp.Text != "0")
            {
                is_blocked = true;
                blocked = int.Parse(txb_bp.Text);
            }

            ipunts[0] = longest;
            ipunts[1] = (row6 + 11);
            ipunts[2] = (row6 + 5);
            ipunts[3] = (row6 + 6);
            ipunts[4] = (row6 + 4);
            ipunts[5] = row6;
            ipunts[6] = (row6 - 2);
            ipunts[7] = (row6 - 3);
            ipunts[8] = (row6 - 4);
            ipunts[9] = (row6 - 9);
            ipunts[10] = (row6 - 19);

            lbl_p1.Content = ipunts[0].ToString() + " yards to PR-1";
            if (returns >= 0.2)
            {
                lbl_p2.Content = ipunts[1].ToString() + " yards to PR-2";
                if(returns >= 0.3)
                {
                    lbl_p3.Content = ipunts[2].ToString() + " yards to PR-3";
                    if(returns >= 0.4)
                    {
                        lbl_p4.Content = ipunts[3].ToString() + " yards to PR-4";
                        if(returns >= 0.5)
                        {
                            lbl_p5.Content = ipunts[4].ToString() + " yards to PR-1";
                            if(returns >= 0.55)
                            {
                                lbl_p6.Content = ipunts[5].ToString() + " yards to PR-2";
                                if(returns >= 0.6)
                                {
                                    lbl_p7.Content = ipunts[6].ToString() + " yards to PR-3";
                                    if(returns >= 0.65)
                                    {
                                        lbl_p8.Content = ipunts[7].ToString() + " yards to PR-4";
                                        if(returns >= 0.7)
                                        {
                                            lbl_p9.Content = ipunts[8].ToString() + " yards to PR-1";
                                            if(returns >= 0.75)
                                            {
                                                lbl_p10.Content = ipunts[9].ToString() + " yards to PR-2";
                                                if(returns >= 0.8)
                                                {
                                                    lbl_p11.Content = ipunts[10].ToString() + " yards to PR-3";
                                                }
                                                else
                                                {
                                                    lbl_p11.Content = ipunts[10].ToString() + " yards to FC";
                                                }
                                            }
                                            else
                                            {
                                                lbl_p10.Content = ipunts[9].ToString() + " yards to FC";
                                                lbl_p11.Content = ipunts[10].ToString() + " yards to FC";
                                            }

                                        }
                                        else
                                        {
                                            lbl_p9.Content = ipunts[8].ToString() + " yards to FC";
                                            lbl_p10.Content = ipunts[9].ToString() + " yards to FC";
                                            lbl_p11.Content = ipunts[10].ToString() + " yards to FC";
                                        }
                                    }
                                    else
                                    {
                                        lbl_p8.Content = ipunts[7].ToString() + " yards to FC";
                                        lbl_p9.Content = ipunts[8].ToString() + " yards to FC";
                                        lbl_p10.Content = ipunts[9].ToString() + " yards to FC";
                                        lbl_p11.Content = ipunts[10].ToString() + " yards to FC";
                                    }
                                }
                                else
                                {
                                    lbl_p7.Content = ipunts[6].ToString() + " yards to FC";
                                    lbl_p8.Content = ipunts[7].ToString() + " yards to FC";
                                    lbl_p9.Content = ipunts[8].ToString() + " yards to FC";
                                    lbl_p10.Content = ipunts[9].ToString() + " yards to FC";
                                    lbl_p11.Content = ipunts[10].ToString() + " yards to FC";
                                }
                            }
                            else
                            {
                                lbl_p6.Content = ipunts[5].ToString() + " yards to FC";
                                lbl_p7.Content = ipunts[6].ToString() + " yards to FC";
                                lbl_p8.Content = ipunts[7].ToString() + " yards to FC";
                                lbl_p9.Content = ipunts[8].ToString() + " yards to FC";
                                lbl_p10.Content = ipunts[9].ToString() + " yards to FC";
                                lbl_p11.Content = ipunts[10].ToString() + " yards to FC";
                            }
                        }
                        else
                        {
                            lbl_p5.Content = ipunts[4].ToString() + " yards to FC";
                            lbl_p6.Content = ipunts[5].ToString() + " yards to FC";
                            lbl_p7.Content = ipunts[6].ToString() + " yards to FC";
                            lbl_p8.Content = ipunts[7].ToString() + " yards to FC";
                            lbl_p9.Content = ipunts[8].ToString() + " yards to FC";
                            lbl_p10.Content = ipunts[9].ToString() + " yards to FC";
                            lbl_p11.Content = ipunts[10].ToString() + " yards to FC";
                        }
                    }
                    else
                    {
                        lbl_p4.Content = ipunts[3].ToString() + " yards to FC";
                        lbl_p5.Content = ipunts[4].ToString() + " yards to FC";
                        lbl_p6.Content = ipunts[5].ToString() + " yards to FC";
                        lbl_p7.Content = ipunts[6].ToString() + " yards to FC";
                        lbl_p8.Content = ipunts[7].ToString() + " yards to FC";
                        lbl_p9.Content = ipunts[8].ToString() + " yards to FC";
                        lbl_p10.Content = ipunts[9].ToString() + " yards to FC";
                        lbl_p11.Content = ipunts[10].ToString() + " yards to FC";
                    }
                }
                else
                {
                    lbl_p3.Content = ipunts[2].ToString() + " yards to FC";
                    lbl_p4.Content = ipunts[3].ToString() + " yards to FC";
                    lbl_p5.Content = ipunts[4].ToString() + " yards to FC";
                    lbl_p6.Content = ipunts[5].ToString() + " yards to FC";
                    lbl_p7.Content = ipunts[6].ToString() + " yards to FC";
                    lbl_p8.Content = ipunts[7].ToString() + " yards to FC";
                    lbl_p9.Content = ipunts[8].ToString() + " yards to FC";
                    lbl_p10.Content = ipunts[9].ToString() + " yards to FC";
                    lbl_p11.Content = ipunts[10].ToString() + " yards to FC";
                }
            }
            else
            {
                lbl_p2.Content = ipunts[1].ToString() + " yards to FC";
                lbl_p3.Content = ipunts[2].ToString() + " yards to FC";
                lbl_p4.Content = ipunts[3].ToString() + " yards to FC";
                lbl_p5.Content = ipunts[4].ToString() + " yards to FC";
                lbl_p6.Content = ipunts[5].ToString() + " yards to FC";
                lbl_p7.Content = ipunts[6].ToString() + " yards to FC";
                lbl_p8.Content = ipunts[7].ToString() + " yards to FC";
                lbl_p9.Content = ipunts[8].ToString() + " yards to FC";
                lbl_p10.Content = ipunts[9].ToString() + " yards to FC";
                lbl_p11.Content = ipunts[10].ToString() + " yards to FC";
            }
            
           

            if(is_blocked == false)
            {
                lbl_p12.Content = "Penalty";
                lbl_spec.Visibility = System.Windows.Visibility.Hidden;
                lbl_bnum.Visibility = System.Windows.Visibility.Hidden;
                lbl_pennum.Visibility = System.Windows.Visibility.Hidden;
                lbl_p_blocked.Visibility = System.Windows.Visibility.Hidden;
                lbl_p_pen.Visibility = System.Windows.Visibility.Hidden;


            }
            else if (is_blocked == true)
            {
                lbl_p_blocked.Content = "Blocked";
                lbl_p_pen.Content = "Penalty";
                lbl_p12.Content = "See Below";
                if(blocked == 1)
                {
                    lbl_bnum.Content = "1";
                    lbl_pennum.Content = "2-12";
                }
                else if(blocked == 2)
                {
                    lbl_pennum.Content = "3-12";
                    lbl_bnum.Content = "1-2";
                }
                else if(blocked == 3)
                {
                    lbl_pennum.Content = "4-12";
                    lbl_bnum.Content = "1-3";
                }
                else if (blocked >= 4)
                {
                    lbl_pennum.Content = "5-12";
                    lbl_bnum.Content = "1-4";
                }
            }


            Team t = teams.ElementAt(cmb_team.SelectedIndex);
            rct_bck.Fill = new SolidColorBrush(t.clr);
            lbl_name1.Content = txt_firstname.Text + " " + txt_surname.Text;
            lbl_team1.Content = t.teamName;
            SolidColorBrush txt = new SolidColorBrush(t.text);
            lbl_name1.Foreground = txt;
            lbl_position1.Foreground = txt;
            lbl_team1.Foreground = txt;
        }

        private void btn_makeimage_Click(object sender, RoutedEventArgs e)
        {
            Team t = teams.ElementAt(cmb_team.SelectedIndex);
            MakeImage m = new MakeImage();
            m.Export(OL1Grid, "P_" + t.abbv + "_" + txt_surname.Text + "_" + txt_firstname.Text);
        }

        private void backclick(object sender, MouseButtonEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            this.Close();
        }

        private void iconfade(object sender, MouseEventArgs e)
        {
            backicon.Foreground.Opacity = 26;
        }

        private void icondark(object sender, MouseEventArgs e)
        {
            backicon.Foreground.Opacity = 54;
        }
    }
}
