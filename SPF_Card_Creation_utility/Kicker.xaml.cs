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
    /// Interaction logic for Kicker.xaml
    /// </summary>
    public partial class Kicker : Window
    {
        public Kicker()
        {
            List<Team> teams = League.teamlist;
            InitializeComponent();
            foreach (Team t in teams)
            {
                cmb_team.Items.Add(t.teamName);
            }
        }

        private void backclick(object sender, MouseButtonEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            this.Close();
        }

        public void btn_gen_card_Click(object sender, RoutedEventArgs e)
        {
            int acc20 = (int)(Math.Round(double.Parse(txb_20yard.Text))/100 * 48);
            int acc30 = (int)(Math.Round(double.Parse(txb_30yard.Text)) / 100 * 48);
            int acc40 = (int)(Math.Round(double.Parse(txb_40yard.Text)) / 100 * 48);
            int acc50 = (int)(Math.Round(double.Parse(txb_50yard.Text)) / 100 * 48);
            int longest = int.Parse(txb_longest.Text);
            int pat = (int)Math.Round(double.Parse(txb_pat.Text)/100*48);

            if (acc20 == 48)
            {
                lbl_20yards.Content = "1 - 48?";
            }
            else
            {
                lbl_20yards.Content = "1 - " + acc20.ToString();
            }

            if (acc30 == 48)
            {
                lbl_30yards.Content = "1 - 48?";
            }
            else
            {
                lbl_30yards.Content = "1 - " + acc30.ToString();
            }

            if (acc40 == 48)
            {
                lbl_40yards.Content = "1 - 48?";
            }
            else
            {
                lbl_40yards.Content = "1 - " + acc40.ToString();
            }

            if (longest > 50)
            {
                acc50 = (longest - 54);
                lbl_50yards.Content = "1 - " + acc50.ToString();
            }
            else
            {
                lbl_50yards.Content = "-";
            }
            lbl_longest.Content = longest.ToString();

            if (pat == 48)
            {
                lbl_pat.Content = "1 - 48?";
            }
            else
            {
                lbl_pat.Content = "1 - " + pat.ToString();
            }

            lbl_name1.Content = txb_fname.Text + " " + txb_sname.Text;
            lbl_position1.Content = "Kicker";

            int l = cmb_team.SelectedIndex;
            Team t = League.teamlist.ElementAt(l);
            rct_bck.Fill = new SolidColorBrush(t.clr);
            SolidColorBrush txt = new SolidColorBrush(t.text);
            lbl_name1.Foreground = txt;
            lbl_position1.Foreground = txt;
            lbl_team1.Foreground = txt;
            lbl_team1.Content = t.teamName;
        }

        private void btn_makeimage_Click(object sender, RoutedEventArgs e)
        {
            Team t = League.teamlist.ElementAt(cmb_team.SelectedIndex);
            MakeImage m = new MakeImage();
            m.Export(OL1Grid, "K_" + t.abbv + "_" + txb_sname.Text + "_" + txb_fname.Text);
        }
    }
}
