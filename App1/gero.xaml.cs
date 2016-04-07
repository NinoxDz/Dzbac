using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class gero : Page
    {
        public gero()
        {
            this.InitializeComponent();
        }
        public static List<listview.geothings> selgeothings()
        {
            List<listview.geothings> d = new List<listview.geothings>();
            using (var statment = new SQLite.SQLiteConnection("dzbac.db"))
            {
                d = statment.Query<listview.geothings>
                    ("SELECT * FROM[geothings]; ").ToList<listview.geothings>();

            }
            return d;
        }
        public static List<listview.geomakala> selgeomakala()
        {
            List<listview.geomakala> d = new List<listview.geomakala>();
            using (var statment = new SQLite.SQLiteConnection("dzbac.db"))
            {
                d = statment.Query<listview.geomakala>
                    ("SELECT * FROM[geomakala]; ").ToList<listview.geomakala>();

            }
            return d;
        }
        

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(listview), selgeothings());
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(listview), selgeomakala());
        }
    }
}
