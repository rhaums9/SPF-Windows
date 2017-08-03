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
    /// Interaction logic for PuntReturner.xaml
    /// </summary>
    public partial class PuntReturner : Window
    {
        public PuntReturner()
        {
            InitializeComponent();
            foreach (Team t in League.teamlist)
            {
                cmb_team.Items.Add(t.teamName);
            }
        }

        private void btn_generatecard_Click(object sender, RoutedEventArgs e)
        {
            bool haspr2, haspr3, haspr4;

            lbl_pr1name.Content = txt_fname1.Text + " " + txt_sname1.Text;

            if(rb_use1_2.IsChecked == true)
            {
                haspr2 = false;
                lbl_pr2name.Content = "Use PR-1";
            }
            else
            {
                haspr2 = true;
                lbl_pr2name.Content = txt_fname2.Text + " " + txt_sname2.Text;
            }

            if(rb_use1_3.IsChecked == true)
            {
                haspr3 = false;
                lbl_pr3name.Content = "Use PR-1";
            }
            else if (rb_use2_3.IsChecked == true)
            {
                haspr3 = false;
                lbl_pr3name.Content = "Use PR-2";
            }
            else
            {
                haspr3 = true;
                lbl_pr3name.Content = txt_fname3.Text + " " + txt_sname3.Text;
            }

            if (rb_use1_4.IsChecked == true)
            {
                haspr4 = false;
                lbl_pr4name.Content = "Use PR-1";
            }
            else if (rb_use2_4.IsChecked == true)
            {
                haspr4 = false;
                lbl_pr4name.Content = "Use PR-2";
            }
            else if (rb_use3_4.IsChecked == true)
            {
                haspr4 = false;
                lbl_pr4name.Content = "Use PR-3";
            }
            else
            {
                haspr4 = true;
                lbl_pr4name.Content = txt_fname4.Text + " " + txt_sname4.Text;
            }
            PRCalc p = new PRCalc();
            string[] pr1val = p.getPRNumbers(double.Parse(txt_avg1.Text), int.Parse(txt_long1.Text));

            lbl_pr1_1.Content = pr1val[0];
            lbl_pr1_2.Content = pr1val[1];
            lbl_pr1_3.Content = pr1val[2];
            lbl_pr1_4.Content = pr1val[3];
            lbl_pr1_5.Content = pr1val[4];
            lbl_pr1_6.Content = pr1val[5];
            lbl_pr1_7.Content = pr1val[6];
            lbl_pr1_8.Content = pr1val[7];
            lbl_pr1_9.Content = pr1val[8];
            lbl_pr1_10.Content = pr1val[9];
            lbl_pr1_11.Content = pr1val[10];
            lbl_pr1_12.Content = pr1val[11];
            lbl_pr1_ast.Content = pr1val[12];



            if(haspr2 == true)
            {
                string[] pr2val = p.getPRNumbers(double.Parse(txt_avg2.Text), int.Parse(txt_long2.Text));

                lbl_pr2_1.Content = pr2val[0];
                lbl_pr2_2.Content = pr2val[1];
                lbl_pr2_3.Content = pr2val[2];
                lbl_pr2_4.Content = pr2val[3];
                lbl_pr2_5.Content = pr2val[4];
                lbl_pr2_6.Content = pr2val[5];
                lbl_pr2_7.Content = pr2val[6];
                lbl_pr2_8.Content = pr2val[7];
                lbl_pr2_9.Content = pr2val[8];
                lbl_pr2_10.Content = pr2val[9];
                lbl_pr2_11.Content = pr2val[10];
                lbl_pr2_12.Content = pr2val[11];
                lbl_pr2_ast.Content = pr2val[12];
            }


            if (haspr3 == true)
            {
                string[] pr3val = p.getPRNumbers(double.Parse(txt_avg3.Text), int.Parse(txt_long3.Text));

                lbl_pr3_1.Content = pr3val[0];
                lbl_pr3_2.Content = pr3val[1];
                lbl_pr3_3.Content = pr3val[2];
                lbl_pr3_4.Content = pr3val[3];
                lbl_pr3_5.Content = pr3val[4];
                lbl_pr3_6.Content = pr3val[5];
                lbl_pr3_7.Content = pr3val[6];
                lbl_pr3_8.Content = pr3val[7];
                lbl_pr3_9.Content = pr3val[8];
                lbl_pr3_10.Content = pr3val[9];
                lbl_pr3_11.Content = pr3val[10];
                lbl_pr3_12.Content = pr3val[11];
                lbl_pr3_ast.Content = pr3val[12];
            }

            if (haspr4 == true)
            {
                string[] pr4val = p.getPRNumbers(double.Parse(txt_avg4.Text), int.Parse(txt_long4.Text));

                lbl_pr4_1.Content = pr4val[0];
                lbl_pr4_2.Content = pr4val[1];
                lbl_pr4_3.Content = pr4val[2];
                lbl_pr4_4.Content = pr4val[3];
                lbl_pr4_5.Content = pr4val[4];
                lbl_pr4_6.Content = pr4val[5];
                lbl_pr4_7.Content = pr4val[6];
                lbl_pr4_8.Content = pr4val[7];
                lbl_pr4_9.Content = pr4val[8];
                lbl_pr4_10.Content = pr4val[9];
                lbl_pr4_11.Content = pr4val[10];
                lbl_pr4_12.Content = pr4val[11];
                lbl_pr4_ast.Content = pr4val[12];

                

            }

            Team t = League.teamlist.ElementAt(cmb_team.SelectedIndex);
            rct_bck.Fill = new SolidColorBrush(t.clr);
            SolidColorBrush txt = new SolidColorBrush(t.text);
            lbl_pr1name.Foreground = txt;
            lbl_pr2name.Foreground = txt;
            lbl_pr3name.Foreground = txt;
            lbl_pr4name.Foreground = txt;
            lbl_position1.Foreground = txt;
            lbl_position1_Copy.Foreground = txt;
            lbl_position1_Copy1.Foreground = txt;
            lbl_position1_Copy2.Foreground = txt;

            lbl_team1.Foreground = txt;
            lbl_team1.Content = t.teamName + " PR";

        }

        private void btn_makeimage_Click(object sender, RoutedEventArgs e)
        {
            Team t = League.teamlist.ElementAt(cmb_team.SelectedIndex);
            MakeImage m = new MakeImage();
            m.Export(OL1Grid, t.teamName + " PR");
        }

        private void backclick(object sender, MouseButtonEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            this.Close();
        }
    }
}
