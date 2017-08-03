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
    /// Interaction logic for Dline.xaml
    /// </summary>
    public partial class Dline : Window
    {
        public Dline()
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

        Defensive_Calculations dc = new Defensive_Calculations();

        string[,] DLine = new string[6, 5];

        private void btn_g_linemen_Click(object sender, RoutedEventArgs e)
        {
            string[] tackle = dc.linemantackle((int)Math.Round(double.Parse(txb_rushyards.Text)));
            DLine[0, 3] = tackle[int.Parse(txb_tck1.Text) - 1].ToString();
            DLine[1, 3] = tackle[int.Parse(txb_tck2.Text) - 1].ToString();
            DLine[2, 3] = tackle[int.Parse(txb_tck3.Text) - 1].ToString();
            DLine[3, 3] = tackle[int.Parse(txb_tck4.Text) - 1].ToString();
            DLine[4, 3] = tackle[int.Parse(txb_tck5.Text) - 1].ToString();
            DLine[5, 3] = tackle[int.Parse(txb_tck6.Text) - 1].ToString();

            DLine[0, 4] = dc.passrush(int.Parse(txb_sk1.Text)).ToString();
            DLine[1, 4] = dc.passrush(int.Parse(txb_sk2.Text)).ToString();
            DLine[2, 4] = dc.passrush(int.Parse(txb_sk3.Text)).ToString();
            DLine[3, 4] = dc.passrush(int.Parse(txb_sk4.Text)).ToString();
            DLine[4, 4] = dc.passrush(int.Parse(txb_sk5.Text)).ToString();
            DLine[5, 4] = dc.passrush(int.Parse(txb_sk6.Text)).ToString();

            DLine[0, 0] = txb_fname1.Text;
            DLine[1, 0] = txb_fname2.Text;
            DLine[2, 0] = txb_fname3.Text;
            DLine[3, 0] = txb_fname4.Text;
            DLine[4, 0] = txb_fname5.Text;
            DLine[5, 0] = txb_fname6.Text;

            DLine[0, 1] = txb_sname1.Text;
            DLine[1, 1] = txb_sname2.Text;
            DLine[2, 1] = txb_sname3.Text;
            DLine[3, 1] = txb_sname4.Text;
            DLine[4, 1] = txb_sname5.Text;
            DLine[5, 1] = txb_sname6.Text;

            DLine[0, 2] = txb_pos1.Text;
            DLine[1, 2] = txb_pos2.Text;
            DLine[2, 2] = txb_pos3.Text;
            DLine[3, 2] = txb_pos4.Text;
            DLine[4, 2] = txb_pos5.Text;
            DLine[5, 2] = txb_pos6.Text;


            comboBox.Items.Add(DLine[0, 0] + " " + DLine[0, 1]);
            comboBox.Items.Add(DLine[1, 0] + " " + DLine[1, 1]);
            comboBox.Items.Add(DLine[2, 0] + " " + DLine[2, 1]);
            comboBox.Items.Add(DLine[3, 0] + " " + DLine[3, 1]);
            comboBox.Items.Add(DLine[4, 0] + " " + DLine[4, 1]);
            comboBox.Items.Add(DLine[5, 0] + " " + DLine[5, 1]);
        }

        private void btn_gen_card_Click(object sender, RoutedEventArgs e)
        {
            int l = comboBox.SelectedIndex;
            lbl_pr.Content = DLine[l, 4];
            lbl_tck.Content = DLine[l, 3];
            lbl_name1.Content = DLine[l, 0] + " " + DLine[l, 1];
            lbl_position1.Content = DLine[l, 2];
            int j = cmb_team.SelectedIndex;
            Team t = League.teamlist.ElementAt(j);
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

            m.Export(OL1Grid, "DL_" + t.abbv + "_" + DLine[i, 1] + "_" + DLine[i, 0]);
        }
    }
}
