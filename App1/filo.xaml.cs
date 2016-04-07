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
    public sealed partial class filo : Page
    {
        public filo()
        {
            this.InitializeComponent();
        }
        public static List<listview.filojadel> seljadel()
        {
            List<listview.filojadel> d = new List<listview.filojadel>();
            using (var statment = new SQLite.SQLiteConnection("dzbac.db"))
            {
                d = statment.Query<listview.filojadel>
                    ("SELECT * FROM[filojadel]; ").ToList<listview.filojadel>();

            }
            return d;
        }
        public static List<listview.filowade> selwade()
        {
            List<listview.filowade> d = new List<listview.filowade>();
            using (var statment = new SQLite.SQLiteConnection("dzbac.db"))
            {
                d = statment.Query<listview.filowade>
                    ("SELECT * FROM[filowade]; ").ToList<listview.filowade>();

            }
            return d;
        }
        public static List<listview.filorafe> selrafe()
        {
            List<listview.filorafe> d = new List<listview.filorafe>();
            using (var statment = new SQLite.SQLiteConnection("dzbac.db"))
            {
                d = statment.Query<listview.filorafe>
                    ("SELECT * FROM[filorafe]; ").ToList<listview.filorafe>();

            }
            return d;
        }
        public static List<listview.filomokarana> selmokarana()
        {
            List<listview.filomokarana> d = new List<listview.filomokarana>();
            using (var statment = new SQLite.SQLiteConnection("dzbac.db"))
            {
                d = statment.Query<listview.filomokarana>
                    ("SELECT * FROM[filomokarana]; ").ToList<listview.filomokarana>();

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

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(listview), seljadel());
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(listview), selwade());
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(listview), selrafe());
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(listview), selmokarana()); 
        }
    }
}
