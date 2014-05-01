using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Threading;

namespace FelicesApp
{
    public partial class Timer : PhoneApplicationPage
    {
        public Timer()
        {
            InitializeComponent();
        }

        private void Chicken_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Timers/Chicken.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Bread_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Timers/Bread.xaml", UriKind.RelativeOrAbsolute));
        }
        private void Cookies_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Timers/Cookies.xaml", UriKind.RelativeOrAbsolute));
        }



    }
}