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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppMarathon.Pages.AdminPages.UserPages
{
    /// <summary>
    /// Логика взаимодействия для UserPageMenu.xaml
    /// </summary>
    public partial class UserPageMenu : Page
    {
        public UserPageMenu()
        {
            InitializeComponent();
        }

        private void RunnerButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AdminPages.UserPages.RunnerControl.ControlRunnerPage());
        }

        private void UserButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AdminPages.UserPages.UserControl.ControlUserPage());
        }
    }
}
