using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Animation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using FelicesApp.Resources;
using System.Windows.Threading;

namespace FelicesApp
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void Delivery_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DeliveryPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Recipes_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/RecipesPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Timers_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Timer.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Inventory_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Inventory2Page.xaml", UriKind.RelativeOrAbsolute));
        }
        
      
        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}


