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
    /// Interaction logic for SkillCreator.xaml
    /// </summary>
    public partial class SkillCreator : Window
    {
        List<Team> teams = League.teamlist;
        public SkillCreator()
        {
            InitializeComponent();
            foreach (Team t in League.teamlist)
            {
                comboBox_team.Items.Add(t.teamName);
            }
        }
        private void backclick(object sender, MouseButtonEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            this.Close();
        }

        private void btn_makeplayer_Click(object sender, RoutedEventArgs e)
        {
            string rushendurance = "N/A";
            string recendurance = "N/A";
            bool isReciever = true;
            int rattemts = int.Parse(txt_rushattempts.Text);
            if (rattemts < 11)
            {
                rushendurance = "N/A";
            }
            else if (rattemts < 31)
            {
                rushendurance = "4";
            }
            else if(rattemts < 54)
            {
                rushendurance = "3";
            }
            else if(rattemts < 124)
            {
                rushendurance = "2";
            }
            else if(rattemts < 289)
            {
                rushendurance = "1";
            }
            else if(rattemts > 289)
            {
                rushendurance = "0";
            }

            int recattempts = int.Parse(txt_recattempts.Text);
            if(recattempts < 11)
            {
                recendurance = "N/A";
            }
            else if(recattempts < 19)
            {
                recendurance = "4";
            }
            else if(recattempts < 29)
            {
                recendurance = "3";
            }
            else if(recattempts < 54)
            {
                recendurance = "2";
            }
            else if(recattempts < 79)
            {
                recendurance = "1";
            }
            else if(recattempts > 79)
            {
                recendurance = "0";
            }
            if (comboBox.SelectedItem.ToString() == "Running Back")
            {
                isReciever = false;
                lbl_position.Content = "Running Back " + rushendurance;
                lbl_end2.Content = "Recieving: " + recendurance;
            }
            else
            {
                lbl_position.Content = comboBox.SelectedItem + " " + recendurance;
                lbl_end2.Content = "Rushing: " + rushendurance;
            }

            RBCalculations RBC = new RBCalculations();
            if (int.Parse(txt_rushattempts.Text) > 5)
            {
                
                float ravg = float.Parse(txt_rushaverage.Text);
                int ryards = int.Parse(txt_rushyards.Text);
                int rlong = int.Parse(txt_rushlongest.Text);
                string[] rval = RBC.Rushing_Calculations(rattemts, ravg, rlong, ryards);
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
            }

            RecieverCalculations rcc = new RecieverCalculations();
            if (int.Parse(txt_recattempts.Text) > 5)
            {
                
                float ravg = float.Parse(txt_recaverage.Text);
                
                int rlong = int.Parse(txt_reclongest.Text);
                string[] rval = rcc.getClmValues(ravg, rlong);
                lbl_passing1.Content = rval[0];
                lbl_passing2.Content = rval[1];
                lbl_passing3.Content = rval[2];
                lbl_passing4.Content = rval[3];
                lbl_passing5.Content = rval[4];
                lbl_passing6.Content = rval[5];
                lbl_passing7.Content = rval[6];
                lbl_passing8.Content = rval[7];
                lbl_passing9.Content = rval[8];
                lbl_passing10.Content = rval[9];
                lbl_passing11.Content = rval[10];
                lbl_passing12.Content = rval[11];
            }

            lbl_name.Content = txt_fname.Text + " " + txt_sname.Text;
            
            Team team = League.teamlist.ElementAt(comboBox_team.SelectedIndex);
            lbl_team.Content = team.teamName;
            rct_bck.Fill = (new SolidColorBrush(team.clr));
            SolidColorBrush txt = new SolidColorBrush(team.text);

            lbl_name.Foreground = txt;
            lbl_team.Foreground = txt;
            lbl_position.Foreground = txt;
        }

        private void back(object sender, MouseButtonEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            this.Close();
        }
    }
}
