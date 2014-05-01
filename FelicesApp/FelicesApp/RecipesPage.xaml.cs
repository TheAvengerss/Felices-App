using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace FelicesApp
{
    public partial class RecipePage : PhoneApplicationPage
    {
        public RecipePage()
        {
            InitializeComponent();
        }

        private void Soups_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Recipes/Soups.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Meats_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Recipes/Meats.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Salads_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Recipes/Salads.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Other_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Recipes/Other.xaml", UriKind.RelativeOrAbsolute));
        }
    }

}