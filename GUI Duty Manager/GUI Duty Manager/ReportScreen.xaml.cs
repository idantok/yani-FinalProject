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
            check_box_chaverim.IsEnabled = true;
            check_box_toranuito.IsEnabled = true;

        }

        private void Check_box_report_shibutzim_Unchecked(object sender, RoutedEventArgs e)
        {
            check_box_chaverim.IsEnabled = false;
            check_box_toranuito.IsEnabled = false;
        }
    }
}
