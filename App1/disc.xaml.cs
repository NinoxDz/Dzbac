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
using Windows.ApplicationModel.DataTransfer;
using SQLite;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class disc : Page
    {
        public disc()
        {
            this.InitializeComponent();

        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            textBlock.DataContext = e.Parameter;
            textBlock1.DataContext = e.Parameter;
        }

        public void sharedt()
        {

            DataTransferManager data = DataTransferManager.GetForCurrentView();
            data.DataRequested += Data_DataRequested;

        }

        private void Data_DataRequested(DataTransferManager sender, DataRequestedEventArgs args)
        {
            DataRequest request = args.Request;
            request.Data.Properties.Title = textBlock.Text;
            request.Data.SetText(textBlock1.Text);


        }

        private void textBox1_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void share_Click(object sender, RoutedEventArgs e)
        {
            sharedt();
            DataTransferManager.ShowShareUI();
        }
       

       
        }


    }

