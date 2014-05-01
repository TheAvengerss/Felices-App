using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Threading;

namespace FelicesApp.Timers
{
    public partial class Chicken : PhoneApplicationPage
    {
        public Chicken()
        {
            InitializeComponent();
        }
        private static DateTime EndTime { get; set; }
        private DispatcherTimer dispatcherTimer;

        private void btnStartClick(object sender, RoutedEventArgs e)
        {
            if (this.dispatcherTimer == null)
            {
                this.dispatcherTimer = new DispatcherTimer();
                this.dispatcherTimer.Interval = TimeSpan.FromMilliseconds(100);
                this.dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            }

            if (EndTime == DateTime.MinValue)
            {
                EndTime = DateTime.Now + (TimeSpan)this.timeSpan.Value;
            }

            this.dispatcherTimer.Start();
        }

        void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            var remaining = EndTime - DateTime.Now;
            int remainingSeconds = (int)remaining.TotalSeconds;
            this.timeSpan.Value = TimeSpan.FromSeconds(remainingSeconds);

            if (remaining.TotalSeconds <= 0)
            {
                this.dispatcherTimer.Stop();
            }
        }

        private void btnStopClick(object sender, RoutedEventArgs e)
        {
            this.dispatcherTimer.Stop();
            EndTime = DateTime.MinValue;
            this.timeSpan.Value = TimeSpan.FromMinutes(40);
           

        }

        private void btnPauseClick(object sender, RoutedEventArgs e)
        {
            this.dispatcherTimer.Stop();
        }

        protected override void OnNavigatedFrom(System.Windows.Navigation.NavigationEventArgs e)
        {
            EndTime = DateTime.MinValue;
            base.OnNavigatedFrom(e);
        }




    }
}