﻿using System;
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
    /// Interaction logic for SettingsScreen.xaml
    /// </summary>
    public partial class SettingsScreen : Window
    {
        public SettingsScreen()
        {
            InitializeComponent();
            new_user_canvas.Visibility = Visibility.Visible;
        }

        private void BackSS_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void GeneralSetting_Button_Click(object sender, RoutedEventArgs e)
        {
            general_setting_canvas.Visibility = Visibility.Visible;
            new_user_canvas.Visibility = Visibility.Hidden;

        }

        private void NewUser_Button_Click_1(object sender, RoutedEventArgs e)
        {
            new_user_canvas.Visibility = Visibility.Visible;
            general_setting_canvas.Visibility = Visibility.Hidden;
        }
    }
}
