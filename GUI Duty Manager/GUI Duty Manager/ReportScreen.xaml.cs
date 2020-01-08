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

namespace GUI_Duty_Manager
{
    /// <summary>
    /// Interaction logic for ReportScreen.xaml
    /// </summary>
    public partial class ReportScreen : Window
    {
        public ReportScreen()
        {
            InitializeComponent();
        }

        private void Btn_back_to_main_Click(object sender, RoutedEventArgs e)
        {
            LobbyScreen lb = new LobbyScreen();
            lb.Show();
            this.Close();
        }

        private void Check_box_report_shibutzim_Checked(object sender, RoutedEventArgs e)
        {
            check_box_toranuito.IsEnabled = true;

        }

        private void Check_box_report_shibutzim_Unchecked(object sender, RoutedEventArgs e)
        {
            check_box_toranuito.IsEnabled = false;
        }

        private void BackSS_Button_report_Click(object sender, RoutedEventArgs e)
        {
            LobbyScreen ls = new LobbyScreen();
            ls.Show();
            this.Close();
        }

        private void Check_box_chaverim_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Btn_tor_lachaver_Click(object sender, RoutedEventArgs e)
        {
            check_box_chaverim.IsEnabled = true;
            check_box_report_shibutzim.IsEnabled = true;
            calendar_date_ini.IsEnabled = true;
            calendar_date_end.IsEnabled = true;
        }

        private void Btn_miss_Click(object sender, RoutedEventArgs e)
        {
            check_box_chaverim.IsEnabled = false;
            check_box_toranuito.IsEnabled = false;
            check_box_report_shibutzim.IsEnabled = false;
            calendar_date_ini.IsEnabled = true;
            calendar_date_end.IsEnabled = true;
        }

        private void Btn_shibutzim_Click(object sender, RoutedEventArgs e)
        {
            check_box_report_shibutzim.IsEnabled = true;
            calendar_date_ini.IsEnabled = true;
            calendar_date_end.IsEnabled = true;
        }

        private void Btn_tor_clali_Click(object sender, RoutedEventArgs e)
        {
            check_box_chaverim.IsEnabled = false;
            check_box_toranuito.IsEnabled = false;
            check_box_report_shibutzim.IsEnabled = false;
            calendar_date_ini.IsEnabled = false;
            calendar_date_end.IsEnabled = false;
        }
    }
}
