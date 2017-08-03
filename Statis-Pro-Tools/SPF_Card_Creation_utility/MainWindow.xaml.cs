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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SPF_Card_Creation_utility
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            League.InitialiseList();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            SkillCreator s = new SkillCreator();
            s.Show();
            this.Close();
        }

        private void buttonQB_Click(object sender, RoutedEventArgs e)
        {
            QB q = new QB();
            q.Show();
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_ol_Click(object sender, RoutedEventArgs e)
        {
            OLine o = new OLine();
            o.Show();
            this.Close();
        }

        private void btn_DL_Click(object sender, RoutedEventArgs e)
        {
            Dline d = new Dline();
            d.Show();
            this.Close();
        }

        private void btn_LB_Click(object sender, RoutedEventArgs e)
        {
            LB l = new LB();
            l.Show();
            this.Close();
        }

        private void btn_P_Click(object sender, RoutedEventArgs e)
        {
            Punter p = new Punter();
            p.Show();
            this.Close();
        }

        private void btn_pr_Click(object sender, RoutedEventArgs e)
        {
            PuntReturner p = new PuntReturner();
            p.Show();
            this.Close();
        }

        private void kr_Click(object sender, RoutedEventArgs e)
        {
            KickReturner k = new KickReturner();
            k.Show();
            this.Close();
        }

        private void btn_K_Click(object sender, RoutedEventArgs e)
        {
            Kicker k = new Kicker();
            k.Show();
            this.Close();
        }

        private void btn_db_Click(object sender, RoutedEventArgs e)
        {
            DB d = new DB();
            d.Show();
            this.Close();
        }
    }
}
