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
    /// Interaction logic for LobbyScreen.xaml
    /// </summary>
    public partial class LobbyScreen : Window
    {
        public LobbyScreen()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }


        private void Setting_Button_Click(object sender, RoutedEventArgs e)
        {
            SettingsScreen ss = new SettingsScreen();
            ss.Show();
        }
    }
}
