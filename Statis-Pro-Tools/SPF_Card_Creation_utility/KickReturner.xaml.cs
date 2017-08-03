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
    /// Interaction logic for KickReturner.xaml
    /// </summary>
    public partial class KickReturner : Window
    {
        public KickReturner()
        {
            InitializeComponent();
            foreach (Team t in League.teamlist)
            {
                cmb_team.Items.Add(t.teamName);
            }
        }

        private void btn_generatecard_Click(object sender, RoutedEventArgs e)
        {
            bool haskr2, haskr3, haskr4;

            lbl_kr1name.Content = txt_fname1.Text + " " + txt_sname1.Text;

            if (rb_use1_2.IsChecked == true)
            {
                haskr2 = false;
                lbl_kr2name.Content = "Use PR-1";
            }
            else
            {
                haskr2 = true;
                lbl_kr2name.Content = txt_fname2.Text + " " + txt_sname2.Text;
            }

            if (rb_use1_3.IsChecked == true)
            {
                haskr3 = false;
                lbl_kr3name.Content = "Use PR-1";
            }
            else if (rb_use2_3.IsChecked == true)
            {
                haskr3 = false;
                lbl_kr3name.Content = "Use PR-2";
            }
            else
            {
                haskr3 = true;
                lbl_kr3name.Content = txt_fname3.Text + " " + txt_sname3.Text;
            }

            if (rb_use1_4.IsChecked == true)
            {
                haskr4 = false;
                lbl_kr4name.Content = "Use PR-1";
            }
            else if (rb_use2_4.IsChecked == true)
            {
                haskr4 = false;
                lbl_kr4name.Content = "Use PR-2";
            }
            else if (rb_use3_4.IsChecked == true)
            {
                haskr4 = false;
                lbl_kr4name.Content = "Use PR-3";
            }
            else
            {
                haskr4 = true;
                lbl_kr4name.Content = txt_fname4.Text + " " + txt_sname4.Text;
            }
            KRCalc k = new KRCalc();
            string[] kr1val = k.getKRNumbers(double.Parse(txt_avg1.Text), int.Parse(txt_long1.Text));

            lbl_kr1_1.Content = kr1val[0];
            lbl_kr1_2.Content = kr1val[1];
            lbl_kr1_3.Content = kr1val[2];
            lbl_kr1_4.Content = kr1val[3];
            lbl_kr1_5.Content = kr1val[4];
            lbl_kr1_6.Content = kr1val[5];
            lbl_kr1_7.Content = kr1val[6];
            lbl_kr1_8.Content = kr1val[7];
            lbl_kr1_9.Content = kr1val[8];
            lbl_kr1_10.Content = kr1val[9];
            lbl_kr1_11.Content = kr1val[10];
            lbl_kr1_12.Content = kr1val[11];
            lbl_kr1_ast.Content = kr1val[12];



            if (haskr2 == true)
            {
                string[] kr2val = k.getKRNumbers(double.Parse(txt_avg2.Text), int.Parse(txt_long2.Text));

                lbl_kr2_1.Content = kr2val[0];
                lbl_kr2_2.Content = kr2val[1];
                lbl_kr2_3.Content = kr2val[2];
                lbl_kr2_4.Content = kr2val[3];
                lbl_kr2_5.Content = kr2val[4];
                lbl_kr2_6.Content = kr2val[5];
                lbl_kr2_7.Content = kr2val[6];
                lbl_kr2_8.Content = kr2val[7];
                lbl_kr2_9.Content = kr2val[8];
                lbl_kr2_10.Content = kr2val[9];
                lbl_kr2_11.Content = kr2val[10];
                lbl_kr2_12.Content = kr2val[11];
                lbl_kr2_ast.Content = kr2val[12];
            }


            if (haskr3 == true)
            {
                string[] kr3val = k.getKRNumbers(double.Parse(txt_avg3.Text), int.Parse(txt_long3.Text));

                lbl_kr3_1.Content = kr3val[0];
                lbl_kr3_2.Content = kr3val[1];
                lbl_kr3_3.Content = kr3val[2];
                lbl_kr3_4.Content = kr3val[3];
                lbl_kr3_5.Content = kr3val[4];
                lbl_kr3_6.Content = kr3val[5];
                lbl_kr3_7.Content = kr3val[6];
                lbl_kr3_8.Content = kr3val[7];
                lbl_kr3_9.Content = kr3val[8];
                lbl_kr3_10.Content = kr3val[9];
                lbl_kr3_11.Content = kr3val[10];
                lbl_kr3_12.Content = kr3val[11];
                lbl_kr3_ast.Content = kr3val[12];
            }

            if (haskr4 == true)
            {
                string[] kr4val = k.getKRNumbers(double.Parse(txt_avg4.Text), int.Parse(txt_long4.Text));

                lbl_kr4_1.Content = kr4val[0];
                lbl_kr4_2.Content = kr4val[1];
                lbl_kr4_3.Content = kr4val[2];
                lbl_kr4_4.Content = kr4val[3];
                lbl_kr4_5.Content = kr4val[4];
                lbl_kr4_6.Content = kr4val[5];
                lbl_kr4_7.Content = kr4val[6];
                lbl_kr4_8.Content = kr4val[7];
                lbl_kr4_9.Content = kr4val[8];
                lbl_kr4_10.Content = kr4val[9];
                lbl_kr4_11.Content = kr4val[10];
                lbl_kr4_12.Content = kr4val[11];
                lbl_kr4_ast.Content = kr4val[12];



            }

            Team t = League.teamlist.ElementAt(cmb_team.SelectedIndex);
            rct_bck.Fill = new SolidColorBrush(t.clr);
            SolidColorBrush txt = new SolidColorBrush(t.text);
            lbl_kr1name.Foreground = txt;
            lbl_kr2name.Foreground = txt;
            lbl_kr3name.Foreground = txt;
            lbl_kr4name.Foreground = txt;
            lbl_position1.Foreground = txt;
            lbl_position1_Copy.Foreground = txt;
            lbl_position1_Copy1.Foreground = txt;
            lbl_position1_Copy2.Foreground = txt;

            lbl_team1.Foreground = txt;
            lbl_team1.Content = t.teamName + " KR";

        }

        private void btn_makeimage_Click(object sender, RoutedEventArgs e)
        {
            Team t = League.teamlist.ElementAt(cmb_team.SelectedIndex);
            MakeImage m = new MakeImage();
            m.Export(OL1Grid, t.teamName + "KR");
        }

        private void backclick(object sender, MouseButtonEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            this.Close();
        }
    }
}
