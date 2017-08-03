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
    /// Interaction logic for QB.xaml
    /// </summary>
    public partial class QB : Window
    {
        List<Team> teams = League.teamlist;
        public QB()
        {
            InitializeComponent();

            foreach(Team t in teams)
            {
                cmb_team.Items.Add(t.teamName);
            }
        }

        private void btn_makeplayer_Click(object sender, RoutedEventArgs e)
        {

            Csvreader c = new Csvreader();
            Csvreader d = new Csvreader();
            Csvreader f = new Csvreader();


            RBCalculations RBC = new RBCalculations();
            int rattemts = int.Parse(txt_rushattempts.Text);
            float ravg = float.Parse(txt_rushaverage.Text);
            int ryards = int.Parse(txt_rushyards.Text);
            int rlong = int.Parse(txt_rushlongest.Text);
            string[] rval = RBC.Rushing_Calculations(rattemts, ravg, rlong, ryards);
            double cmp = float.Parse(txt_cmp.Text);
            double ict = float.Parse(txt_int.Text);
            double qcmp = float.Parse(txt_qcmp.Text);
            double qint = float.Parse(txt_qint.Text);
            double lcmp = float.Parse(txt_lcmp.Text);
            double lint = float.Parse(txt_lint.Text);
            double sack = float.Parse(txt_sck.Text);

            int long_intercept = (int)System.Math.Floor((48 - ((lint / 100) * 48)));
            int normal_completion = (int)System.Math.Floor(((cmp / 100) * 48));
            int normal_intercept = (int)System.Math.Ceiling((48 - ((((lint-ict)) / 100) * 48)));
            lbl_scom.Content = ("1 - " + normal_completion.ToString());
            if (normal_intercept == 48)
            {
                lbl_sint.Content = "48";


            }
            else lbl_sint.Content = normal_intercept.ToString() + "- 48";
            lbl_sinc.Content = (normal_completion + 1).ToString() + " - " + (normal_intercept - 1).ToString();

            int short_completion = (int)System.Math.Floor(((qcmp / 100) * 48));
            int short_intercept = (int)System.Math.Floor((48 - ((qint / 100) * 48)));
            lbl_qcom.Content = ("1 - " + short_completion.ToString());
            if (qint < 2)
            {
                lbl_qint.Content = "-";
                lbl_qinc.Content = (short_completion + 1).ToString() + " - 48";

            }
            else if (short_intercept == 48)
            {
                lbl_qint.Content = "48";
                lbl_qinc.Content = (short_completion + 1).ToString() + " - 47";
            }
            else {
                lbl_qint.Content = short_intercept.ToString() + "- 48";
                lbl_qinc.Content = (short_completion + 1).ToString() + " - " + (short_intercept - 1).ToString();
            }
            int long_completion = (int)System.Math.Floor(((lcmp / 100) * 48));

            lbl_lcom.Content = ("1 - " + long_completion.ToString());
            if (long_intercept == 48)
            {
                lbl_lint.Content = "48";


            }
            else
            {
                lbl_lint.Content = long_intercept.ToString() + "- 48";
            }

            int prsack = (int)Math.Round(sack) + 4;
            int rpcomp = (int)System.Math.Floor(((cmp / 100) * 18)) + 30;

            lbl_sck.Content = "1 - " + prsack.ToString();
            lbl_prrun.Content = (prsack + 1).ToString() + " - 30";
            lbl_prcom.Content = "31 - " + rpcomp.ToString();
            lbl_princ.Content = (rpcomp + 1).ToString() + "- 48"; 
            

        
            lbl_linc.Content = (long_completion + 1).ToString() + " - " + (long_intercept - 1).ToString();
            lbl_rushing1.Content = rval[0];
            lbl_rushing2.Content = rval[1];
            lbl_rushing3.Content = rval[2];
            lbl_rushing4.Content = rval[3];
            lbl_rushing5.Content = rval[4];
            lbl_rushing6.Content = rval[5];
            lbl_rushing7.Content = rval[6];
            lbl_rushing8.Content = rval[7];
            lbl_rushing9.Content = rval[8];
            lbl_rushing10.Content = rval[9];
            lbl_rushing11.Content = rval[10];
            lbl_rushing12.Content = rval[11];

            Team t = teams.ElementAt(cmb_team.SelectedIndex);
            rct_bck.Fill = new SolidColorBrush(t.clr);

            lbl_name.Content = txt_firstname.Text + " "+ txt_surname.Text;
            lbl_position.Content = "Quarterback " + txt_endurance.Text;
            lbl_team.Content = t.teamName;
            SolidColorBrush txt = new SolidColorBrush(t.text);
            lbl_name.Foreground = txt;
            lbl_position.Foreground = txt;
            lbl_team.Foreground = txt;

        }

        private void btn_makeimage_Click(object sender, RoutedEventArgs e)
        {
            Team t = teams.ElementAt(cmb_team.SelectedIndex);
            MakeImage m = new MakeImage();
            m.Export(QBGrid, "QB_" + t.abbv + "_" + txt_surname.Text + "_" + txt_firstname.Text);
        }
        private void backclick(object sender, MouseButtonEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            this.Close();
        }
    }
        }
    


