using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AdventureWorksSalesEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //<Snippet2>
        private AdventureWorksService.AdventureWorksLTEntities dataServiceClient;
        private System.Data.Services.Client.DataServiceQuery<AdventureWorksService.SalesOrderHeader> salesQuery;
        private CollectionViewSource ordersViewSource;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // TODO: Modify the port number in the following URI as required.
            dataServiceClient = new AdventureWorksService.AdventureWorksLTEntities(
                new Uri("http://localhost:45899/AdventureWorksService.svc"));
            salesQuery = dataServiceClient.SalesOrderHeaders;

            ordersViewSource = ((CollectionViewSource)(this.FindResource("salesOrderHeadersViewSource")));
            ordersViewSource.Source = salesQuery.Execute();
            ordersViewSource.View.MoveCurrentToFirst();
        }
        //</Snippet2>


        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            //<Snippet3>
            if (ordersViewSource.View.CurrentPosition > 0)
                ordersViewSource.View.MoveCurrentToPrevious();
            //</Snippet3>
        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            //<Snippet4>
            if (ordersViewSource.View.CurrentPosition < ((CollectionView)ordersViewSource.View).Count - 1)
            {
                ordersViewSource.View.MoveCurrentToNext();
            }
            //</Snippet4>
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            //<Snippet5>
            AdventureWorksService.SalesOrderHeader currentOrder = (AdventureWorksService.SalesOrderHeader)ordersViewSource.View.CurrentItem;
            dataServiceClient.UpdateObject(currentOrder);
            dataServiceClient.SaveChanges();
            //</Snippet5>
        }
   
    }
}
