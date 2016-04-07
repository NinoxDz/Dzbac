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
    public sealed partial class histoire : Page
    {
        
        public histoire()
        {

            this.InitializeComponent();

        }
       
        public static List<listview.histdates> selectdate()
        {
            List<listview.histdates> d = new List<listview.histdates>();
            using (var statment = new SQLite.SQLiteConnection("dzbac.db"))
            {
            
                d = statment.Query<listview.histdates>
                    ("SELECT * FROM[histdates]; ").ToList<listview.histdates>();
               
            }
            return d;
        }
        public static List<listview.histmakala> selmakala()
        {
            List<listview.histmakala> d = new List<listview.histmakala>();
            using (var statment = new SQLite.SQLiteConnection("dzbac.db"))
            {
                d = statment.Query<listview.histmakala>
                    ("SELECT * FROM[histmakala]; ").ToList<listview.histmakala>();

            }
            return d;
        }
        public static List<listview.histpers> selectpers()
        {
            List<listview.histpers> d = new List<listview.histpers>();
            using (var statment = new SQLite.SQLiteConnection("dzbac.db"))
            {
                d = statment.Query<listview.histpers>
                    ("SELECT * FROM[histpers]; ").ToList<listview.histpers>();

            }
            return d;
        }
        public static List<listview.histthings> selectdatethings()
        {
            List<listview.histthings> d = new List<listview.histthings>();
            using (var statment = new SQLite.SQLiteConnection("dzbac.db"))
            {
                d = statment.Query<listview.histthings>
                    ("SELECT * FROM[histthings]; ").ToList<listview.histthings>();

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
            Frame.Navigate(typeof(listview), selectpers());
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(listview), selectdate());
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(listview), selectdatethings());
        
    }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
          Frame.Navigate(typeof(listview), selmakala());
        }
    }
}
