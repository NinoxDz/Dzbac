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
    public sealed partial class islamic : Page
    {
        public islamic()
        {
            this.InitializeComponent();
        }

        public static List<listview.islam> islam()
        {
            List<listview.islam> d = new List<listview.islam>();
            using (var statment = new SQLite.SQLiteConnection("dzbac.db"))
            {
                d = statment.Query<listview.islam>
                    ("SELECT * FROM[islam]; ").ToList<listview.islam>();

            }
            return d;
        }
        public static List<listview.islamhadith> islamhadith()
        {
            List<listview.islamhadith> d = new List<listview.islamhadith>();
            using (var statment = new SQLite.SQLiteConnection("dzbac.db"))
            {
                d = statment.Query<listview.islamhadith>
                    ("SELECT * FROM[islamhadith]; ").ToList<listview.islamhadith>();

            }
            return d;
        }
        public static List<listview.islamayat> islamayat()
        {
            List<listview.islamayat> d = new List<listview.islamayat>();
            using (var statment = new SQLite.SQLiteConnection("dzbac.db"))
            {
                d = statment.Query<listview.islamayat>
                    ("SELECT * FROM[islamayat]; ").ToList<listview.islamayat>();

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
            Frame.Navigate(typeof(listview), islam());
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(listview), islamhadith());
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(listview), islamayat());
        }
    }
}
