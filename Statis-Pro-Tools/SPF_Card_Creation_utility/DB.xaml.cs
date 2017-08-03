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
    /// Interaction logic for DB.xaml
    /// </summary>
    public partial class DB : Window
    {
        List<Team> teams = League.teamlist;
        public DB()
        {
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
        string[,] Db = new string[7, 6];
        private void btn_g_linemen_Click(object sender, RoutedEventArgs e)
        {
            Defensive_Calculations d = new Defensive_Calculations();



            string[] pd = d.lbpassdef(double.Parse(txb_ypa.Text));
            Db[0, 4] = pd[int.Parse(txb_pd1.Text) - 1].ToString();
            Db[1, 4] = pd[int.Parse(txb_pd2.Text) - 1].ToString();
            Db[2, 4] = pd[int.Parse(txb_pd3.Text) - 1].ToString();
            Db[3, 4] = pd[int.Parse(txb_pd4.Text) - 1].ToString();
            Db[4, 4] = pd[int.Parse(txb_pd5.Text) - 1].ToString();
            Db[5, 4] = pd[int.Parse(txb_pd6.Text) - 1].ToString();
            Db[6, 4] = pd[int.Parse(txb_pd7.Text) - 1].ToString();

            Db[0, 5] = d.intercept(int.Parse(txb_int.Text));
            Db[1, 5] = d.intercept(int.Parse(txb_int1.Text));
            Db[2, 5] = d.intercept(int.Parse(txb_int2.Text));
            Db[3, 5] = d.intercept(int.Parse(txb_int3.Text));
            Db[4, 5] = d.intercept(int.Parse(txb_int4.Text));
            Db[5, 5] = d.intercept(int.Parse(txb_int5.Text));
            Db[6, 5] = d.intercept(int.Parse(txb_int6.Text));


            Db[0, 3] = d.passrush(int.Parse(txb_sk1.Text)).ToString();
            Db[1, 3] = d.passrush(int.Parse(txb_sk2.Text)).ToString();
            Db[2, 3] = d.passrush(int.Parse(txb_sk3.Text)).ToString();
            Db[3, 3] = d.passrush(int.Parse(txb_sk4.Text)).ToString();
            Db[4, 3] = d.passrush(int.Parse(txb_sk5.Text)).ToString();
            Db[5, 3] = d.passrush(int.Parse(txb_sk6.Text)).ToString();
            Db[6, 3] = d.passrush(int.Parse(txb_sk7.Text)).ToString();
        

            Db[0, 0] = txb_fname1.Text;
            Db[1, 0] = txb_fname2.Text;
            Db[2, 0] = txb_fname3.Text;
            Db[3, 0] = txb_fname4.Text;
            Db[4, 0] = txb_fname5.Text;
            Db[5, 0] = txb_fname6.Text;
            Db[6, 0] = txb_fname7.Text;


            Db[0, 1] = txb_sname1.Text;
            Db[1, 1] = txb_sname2.Text;
            Db[2, 1] = txb_sname3.Text;
            Db[3, 1] = txb_sname4.Text;
            Db[4, 1] = txb_sname5.Text;
            Db[5, 1] = txb_sname6.Text;
            Db[6, 1] = txb_sname7.Text;


            Db[0, 2] = txb_pos1.Text;
            Db[1, 2] = txb_pos2.Text;
            Db[2, 2] = txb_pos3.Text;
            Db[3, 2] = txb_pos4.Text;
            Db[4, 2] = txb_pos5.Text;
            Db[5, 2] = txb_pos6.Text;
            Db[6, 2] = txb_pos7.Text;


            int p = 0;
            while (p < 7)
            {
                comboBox.Items.Add(Db[p, 0] + " " + Db[p, 1]);
                p++;
            }
        }

        private void btn_gen_card_Click(object sender, RoutedEventArgs e)
        {
            int l = comboBox.SelectedIndex;
            lbl_pr.Content = Db[l, 6];

            lbl_pd.Content = Db[l, 4];
            lbl_int.Content = Db[l, 5];
            lbl_name1.Content = Db[l, 0] + " " + Db[l, 1];
            lbl_position1.Content = Db[l, 2];
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

            m.Export(OL1Grid, "DB_" + t.abbv + "_" + Db[i, 1] + "_" + Db[i, 0]);
        }
    }
}
