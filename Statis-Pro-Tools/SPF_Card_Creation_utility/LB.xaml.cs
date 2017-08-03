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
    /// Interaction logic for LB.xaml
    /// </summary>
    public partial class LB : Window
    {
        public LB()
        {
            InitializeComponent();
            foreach (Team t in League.teamlist)
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
        string[,] Lb = new string[8, 7];
        private void btn_g_linemen_Click(object sender, RoutedEventArgs e)
        {
            Defensive_Calculations d = new Defensive_Calculations();
            string[] tackle = d.lb_tackle((int)Math.Round(double.Parse(txb_rushyards.Text)));
            Lb[0, 3] = tackle[int.Parse(txb_tck1.Text) - 1].ToString();
            Lb[1, 3] = tackle[int.Parse(txb_tck2.Text) - 1].ToString();
            Lb[2, 3] = tackle[int.Parse(txb_tck3.Text) - 1].ToString();
            Lb[3, 3] = tackle[int.Parse(txb_tck4.Text) - 1].ToString();
            Lb[4, 3] = tackle[int.Parse(txb_tck5.Text) - 1].ToString();
            Lb[5, 3] = tackle[int.Parse(txb_tck6.Text) - 1].ToString();
            Lb[6, 3] = tackle[int.Parse(txb_tck7.Text) - 1].ToString();
            Lb[7, 3] = tackle[int.Parse(txb_tck8.Text) - 1].ToString();

            string[] pd = d.lbpassdef(double.Parse(txb_ypa.Text));
            Lb[0, 4] = pd[int.Parse(txb_pd1.Text) - 1].ToString();
            Lb[1, 4] = pd[int.Parse(txb_pd2.Text) - 1].ToString();
            Lb[2, 4] = pd[int.Parse(txb_pd3.Text) - 1].ToString();
            Lb[3, 4] = pd[int.Parse(txb_pd4.Text) - 1].ToString();
            Lb[4, 4] = pd[int.Parse(txb_pd5.Text) - 1].ToString();
            Lb[5, 4] = pd[int.Parse(txb_pd6.Text) - 1].ToString();
            Lb[6, 4] = pd[int.Parse(txb_pd7.Text) - 1].ToString();
            Lb[7, 4] = pd[int.Parse(txb_pd8.Text) - 1].ToString();

            Lb[0, 5] = d.intercept(int.Parse(txb_int.Text));
            Lb[1, 5] = d.intercept(int.Parse(txb_int1.Text));
            Lb[2, 5] = d.intercept(int.Parse(txb_int2.Text));
            Lb[3, 5] = d.intercept(int.Parse(txb_int3.Text));
            Lb[4, 5] = d.intercept(int.Parse(txb_int4.Text));
            Lb[5, 5] = d.intercept(int.Parse(txb_int5.Text));
            Lb[6, 5] = d.intercept(int.Parse(txb_int6.Text));
            Lb[7, 5] = d.intercept(int.Parse(txb_int7.Text));

            Lb[0, 6] = d.passrush(int.Parse(txb_sk1.Text)).ToString();
            Lb[1, 6] = d.passrush(int.Parse(txb_sk2.Text)).ToString();
            Lb[2, 6] = d.passrush(int.Parse(txb_sk3.Text)).ToString();
            Lb[3, 6] = d.passrush(int.Parse(txb_sk4.Text)).ToString();
            Lb[4, 6] = d.passrush(int.Parse(txb_sk5.Text)).ToString();
            Lb[5, 6] = d.passrush(int.Parse(txb_sk6.Text)).ToString();
            Lb[6, 6] = d.passrush(int.Parse(txb_sk7.Text)).ToString();
            Lb[7, 6] = d.passrush(int.Parse(txb_sk8.Text)).ToString();

            Lb[0, 0] = txb_fname1.Text;
            Lb[1, 0] = txb_fname2.Text;
            Lb[2, 0] = txb_fname3.Text;
            Lb[3, 0] = txb_fname4.Text;
            Lb[4, 0] = txb_fname5.Text;
            Lb[5, 0] = txb_fname6.Text;
            Lb[6, 0] = txb_fname7.Text;
            Lb[7, 0] = txb_fname8.Text;

            Lb[0, 1] = txb_sname1.Text;
            Lb[1, 1] = txb_sname2.Text;
            Lb[2, 1] = txb_sname3.Text;
            Lb[3, 1] = txb_sname4.Text;
            Lb[4, 1] = txb_sname5.Text;
            Lb[5, 1] = txb_sname6.Text;
            Lb[6, 1] = txb_sname7.Text;
            Lb[7, 1] = txb_sname8.Text;

            Lb[0, 2] = txb_pos1.Text;
            Lb[1, 2] = txb_pos2.Text;
            Lb[2, 2] = txb_pos3.Text;
            Lb[3, 2] = txb_pos4.Text;
            Lb[4, 2] = txb_pos5.Text;
            Lb[5, 2] = txb_pos6.Text;
            Lb[6, 2] = txb_pos7.Text;
            Lb[7, 2] = txb_pos8.Text;

            int p = 0;
            while(p < 8)
            {
                comboBox.Items.Add(Lb[p, 0] + " "  + Lb[p, 1]);
                p++;
            }
        }

        private void btn_gen_card_Click(object sender, RoutedEventArgs e)
        {
            int l = comboBox.SelectedIndex;
            lbl_pr.Content = Lb[l, 6];
            lbl_tck.Content = Lb[l, 3];
            lbl_pd.Content = Lb[l, 4];
            lbl_int.Content = Lb[l, 5];
            lbl_name1.Content = Lb[l, 0] + " " + Lb[l, 1];
            lbl_position1.Content = Lb[l, 2];
            Team t = League.teamlist.ElementAt(l);
            rct_bck.Fill = new SolidColorBrush(t.clr);
            SolidColorBrush txt = new SolidColorBrush(t.text);
            lbl_name1.Foreground = txt;
            lbl_position1.Foreground = txt;
            lbl_team1.Foreground = txt;
            lbl_team1.Content = t.teamName;
        }

        private void btn_print_card_Click(object sender, RoutedEventArgs e)
        {
            int i = comboBox.SelectedIndex;
            int j = cmb_team.SelectedIndex;
            Team t = League.teamlist.ElementAt(j);
            MakeImage m = new MakeImage();

            m.Export(OL1Grid, "LB_" + t.abbv + "_" + Lb[i, 1] + "_" + Lb[i, 0]);
        }
    }
}
