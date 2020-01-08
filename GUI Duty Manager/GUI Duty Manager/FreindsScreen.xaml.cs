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
    /// Interaction logic for FreindsScreen.xaml
    /// </summary>
    public partial class FreindsScreen : Window
    {
        public FreindsScreen()
        {
            InitializeComponent();
            update_user_canvas.Visibility = Visibility.Hidden;
            new_superuser_canvas.Visibility = Visibility.Visible;
        }

        private void BackSS_Button_Click(object sender, RoutedEventArgs e)
        {
            LobbyScreen ls = new LobbyScreen();
            ls.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GeneralSetting_Button_Click(object sender, RoutedEventArgs e)
        {
            update_user_canvas.Visibility = Visibility.Visible;
            new_superuser_canvas.Visibility = Visibility.Hidden;
        }

        private void NewUser_Button_Click_1(object sender, RoutedEventArgs e)
        {
            update_user_canvas.Visibility = Visibility.Hidden;
            new_superuser_canvas.Visibility = Visibility.Visible;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void BackSS_Buttone_Click(object sender, RoutedEventArgs e)
        {
            LobbyScreen ls = new LobbyScreen();
            ls.Show();
            this.Close();
        }
    }
}
