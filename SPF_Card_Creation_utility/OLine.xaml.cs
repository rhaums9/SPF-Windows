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
    /// Interaction logic for OLine.xaml
    /// </summary>
    public partial class OLine : Window
    {
        public OLine()
        {
            InitializeComponent();
            comboBox.Items.Add(1);
            comboBox.Items.Add(2);
            comboBox.Items.Add(3);
            comboBox.Items.Add(4);
            comboBox.Items.Add(5);
            comboBox.Items.Add(6);
            comboBox.Items.Add(7);
            comboBox.Items.Add(8);

            foreach (Team t in League.teamlist)
            {
                cmb_team.Items.Add(t.teamName);
            }
        }
        string[,] Oline = new string[8, 5];
        int[] rbranks = new int[8];
        int[] pbranks = new int[8];
        
        int sacks;
        double rushyards;
        private void btn_g_linemen_Click(object sender, RoutedEventArgs e)
        {
            sacks = int.Parse(txb_passyards.Text);
            rushyards = double.Parse(txb_rushyards.Text);
            OLineBlocking o = new OLineBlocking();
            int[] rbv = o.GetBlockingValues((int)Math.Round(double.Parse(txb_rushyards.Text)));
            int[] pbv = o.passBlocking(int.Parse(txb_passyards.Text));
            Oline[0, 3] = rbv[int.Parse(txb_rbv1.Text) - 1].ToString();
            Oline[1, 3] = rbv[int.Parse(txb_rbv2.Text) - 1].ToString();
            Oline[2, 3] = rbv[int.Parse(txb_rbv3.Text) - 1].ToString();
            Oline[3, 3] = rbv[int.Parse(txb_rbv4.Text) - 1].ToString();
            Oline[4, 3] = rbv[int.Parse(txb_rbv5.Text) - 1].ToString();
            Oline[5, 3] = rbv[int.Parse(txb_rbv6.Text) - 1].ToString();
            Oline[6, 3] = rbv[int.Parse(txb_rbv7.Text) - 1].ToString();
            Oline[7, 3] = rbv[int.Parse(txb_rbv8.Text) - 1].ToString();

            Oline[0, 4] = pbv[int.Parse(txb_pbv1.Text) - 1].ToString();
            Oline[1, 4] = pbv[int.Parse(txb_pbv2.Text) - 1].ToString();
            Oline[2, 4] = pbv[int.Parse(txb_pbv3.Text) - 1].ToString();
            Oline[3, 4] = pbv[int.Parse(txb_pbv4.Text) - 1].ToString();
            Oline[4, 4] = pbv[int.Parse(txb_pbv5.Text) - 1].ToString();
            Oline[5, 4] = pbv[int.Parse(txb_pbv6.Text) - 1].ToString();
            Oline[6, 4] = pbv[int.Parse(txb_pbv7.Text) - 1].ToString();
            Oline[7, 4] = pbv[int.Parse(txb_pbv8.Text) - 1].ToString();

            Oline[0, 0] = txb_fname1.Text;
            Oline[1, 0] = txb_fname2.Text;
            Oline[2, 0] = txb_fname3.Text;
            Oline[3, 0] = txb_fname4.Text;
            Oline[4, 0] = txb_fname5.Text;
            Oline[5, 0] = txb_fname6.Text;
            Oline[6, 0] = txb_fname7.Text;
            Oline[7, 0] = txb_fname8.Text;

            Oline[0, 1] = txb_sname1.Text;
            Oline[1, 1] = txb_sname2.Text;
            Oline[2, 1] = txb_sname3.Text;
            Oline[3, 1] = txb_sname4.Text;
            Oline[4, 1] = txb_sname5.Text;
            Oline[5, 1] = txb_sname6.Text;
            Oline[6, 1] = txb_sname7.Text;
            Oline[7, 1] = txb_sname8.Text;

            Oline[0, 2] = txb_pos1.Text;
            Oline[1, 2] = txb_pos2.Text;
            Oline[2, 2] = txb_pos3.Text;
            Oline[3, 2] = txb_pos4.Text;
            Oline[4, 2] = txb_pos5.Text;
            Oline[5, 2] = txb_pos6.Text;
            Oline[6, 2] = txb_pos7.Text;
            Oline[7, 2] = txb_pos8.Text;
        }

        private void btn_gen_card_Click(object sender, RoutedEventArgs e)
        {
            int l = comboBox.SelectedIndex;
            lbl_bv1.Content = Oline[l, 3];
            lbl_pbv1.Content = Oline[l, 4];
            lbl_name1.Content = Oline[l, 0] + " " + Oline[l, 1];
            lbl_position1.Content = Oline[l, 2];
            Team t = League.teamlist.ElementAt(l);
            rct_bck.Fill = new SolidColorBrush(t.clr);
            SolidColorBrush txt = new SolidColorBrush(t.text);
            lbl_name1.Foreground = txt;
            lbl_position1.Foreground = txt;
            lbl_team1.Foreground = txt;
            lbl_team1.Content = t.teamName;

        }
        private void backclick(object sender, MouseButtonEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            this.Close();
        }
        private void btn_print_card_Click(object sender, RoutedEventArgs e)
        {
            int i = comboBox.SelectedIndex;
            int j = cmb_team.SelectedIndex;
            Team t = League.teamlist.ElementAt(j);
            MakeImage m = new MakeImage();

            m.Export(OL1Grid, "OL_" + t.abbv +"_" + Oline[i, 1] + "_" + Oline[i, 0]);
        }
    }
}
