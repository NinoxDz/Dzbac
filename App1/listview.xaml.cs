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
    public sealed partial class listview : Page
    {

        public static int x;

        public listview()
        {
            
            this.InitializeComponent();
            

                        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
           
            if(e.Parameter == null)
            {
                return;
            }
            var type = e.Parameter.GetType();
            if(type == typeof(List<histdates>))
            {
                listView.ItemsSource = (List<histdates>)e.Parameter;
                PageTitle.Text = "تــاريــــــــخ";
                PageSubTitle.Text = "تـــــواريــــــخ";
            }
            else if (type == typeof(List<histpers>))
            {
                listView.ItemsSource = (List<histpers>)e.Parameter;
                PageTitle.Text = "تـــاريــــــــخ";
                PageSubTitle.Text = "شــخصـيـات";
            }
            else if (type == typeof(List<histthings>))
            {
                listView.ItemsSource = (List<histthings>)e.Parameter;
                PageTitle.Text = "تـــــاريــــــــخ";
                PageSubTitle.Text = "مـصـطـلحـات";
            }
            else if (type == typeof(List<histmakala>))
            {
                listView.ItemsSource = (List<histmakala>)e.Parameter;
                PageTitle.Text = "تــاريــــــــخ";
                PageSubTitle.Text = "مـــــقــــالات";
            }
            else if (type == typeof(List<geothings>))
            {
                listView.ItemsSource = (List<geothings>)e.Parameter;
                PageTitle.Text ="جـــغرافـــيا";
                PageSubTitle.Text = "مــصطــلحــات";
            }
            else if (type == typeof(List<islam>))
            {
                listView.ItemsSource = (List<islam>)e.Parameter;
                PageTitle.Text = "علــوم أســلاميــة";
                PageSubTitle.Text = "مــصطــلحــات";
            }
            else if (type == typeof(List<islamayat>))
            {
                listView.ItemsSource = (List<islamayat>)e.Parameter;
                PageTitle.Text = "علــوم أســلاميــة";
                PageSubTitle.Text = "أيــــــات";
            }
            else if (type == typeof(List<islamhadith>))
            {
                listView.ItemsSource = (List<islamhadith>)e.Parameter;
                PageTitle.Text = "علــوم أســلاميــة";
                PageSubTitle.Text = "أحــاديث";
            }
           
            else if (type == typeof(List<geomakala>))
            {
                listView.ItemsSource = (List<geomakala>)e.Parameter;
                PageTitle.Text = "جـــغرافـــيا";
                PageSubTitle.Text = "مقالات";
            }
            else if (type == typeof(List<filojadel>))
            {
                listView.ItemsSource = (List<filojadel>)e.Parameter;
                PageTitle.Text = "فــلسفــى";
                PageSubTitle.Text = "جــدل";
            }
            else if (type == typeof(List<filorafe>))
            {
                listView.ItemsSource = (List<filorafe>)e.Parameter;
                PageTitle.Text = "فــلسفــى";
                PageSubTitle.Text = "بالــرفــع";
            }
            else if (type == typeof(List<filowade>))
            {
                listView.ItemsSource = (List<filowade>)e.Parameter;
                PageTitle.Text = "فــلسفــى";
                PageSubTitle.Text = "بالـــوضــع";
            }
            else if (type == typeof(List<filomokarana>))
            {
                listView.ItemsSource = (List<filomokarana>)e.Parameter;
                PageTitle.Text = "فــلسفــى";
                PageSubTitle.Text = "مـــقارنـــة";
            }
        }


        


        //start-histoire
        public partial class histdates
        {
            
            public Int64 ID { get; set; }

            
            public String date { get; set; }

            public String name { get { return date; } }
           
            public String disc { get; set; }

            public histdates()
            {
            }

        }
        public partial class histmakala
        {
            public Int64 ID { get; set; }

            public String name { get; set; }

           
            public String disc { get; set; }
                     
            public histmakala()
            {

            }
        }
        public partial class histpers
        {

            public Int64 ID { get; set; }

            public String name { get; set; }

            public String disc { get; set; }

            public histpers()
            {
            }
        }
        public partial class favorite
        {

            public Int64 ID { get; set; }

            public String name { get; set; }

            public String disc { get; set; }

            public favorite()
            {
            }
            public favorite(String Name, String Disc)
            {
                name = Name;
                disc = Disc;
            }
        }

        public partial class histthings
        {

            public Int64 ID { get; set; }


            public String name { get; set; }


            public String disc { get; set; }
            public histthings()
            {
            }
        }
        //end-histoire
        //start-geo
        public partial class geothings
        {

            public Int64 ID { get; set; }


            public String name { get; set; }


            public String disc { get; set; }


            public geothings()
            {
            }
       }

        public partial class geomakala
        {
            public Int64 ID { get; set; }

            public String name { get; set; }


            public String disc { get; set; }

            public geomakala()
            {

            }
        }

        //eng-geo
        //start islam
        public partial class islam
        {

            public Int64 ID { get; set; }

            public String name { get; set; }

            public String disc { get; set; }

            public islam()
            {
            }
        }
        public partial class islamhadith
        {

            public Int64 ID { get; set; }

            public String name { get; set; }

            public String disc { get; set; }

            public islamhadith()
            {
            }
        }
        public partial class islamayat
        {

            public Int64 ID { get; set; }

            public String name { get; set; }

            public String disc { get; set; }

            public islamayat()
            {
            }
        }
        //ennd islam

        //start filo
        public partial class filojadel
        {

            public Int64 ID { get; set; }

            public String name { get; set; }

            public String disc { get; set; }

            public filojadel()
            {
            }
        }
        public partial class filowade
        {

            public Int64 ID { get; set; }

            public String name { get; set; }

            public String disc { get; set; }

            public filowade()
            {
            }
        }
        public partial class filorafe
        {

            public Int64 ID { get; set; }

            public String name { get; set; }

            public String disc { get; set; }

            public filorafe()
            {
            }
        }
        public partial class filomokarana
        {

            public Int64 ID { get; set; }

            public String name { get; set; }

            public String disc { get; set; }

            public filomokarana()
            {
            }
        }
        
        //end filo

        private void OnPostItemClick(object sender, ItemClickEventArgs e)
        {
            // Navigate to cocktail page with item you click/tap on
            Frame.Navigate(typeof(disc), e.ClickedItem);
        }
    }
}
