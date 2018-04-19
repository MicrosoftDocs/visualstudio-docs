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
//<Snippet2>
using System.Windows.Data;
using AdventureWorksSilverlightApp.AdventureWorksService;
//</Snippet2>

namespace AdventureWorksSilverlightApp
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }


        //<Snippet3>
        private AdventureWorksLTEntities advWorksService;
        private System.Windows.Data.CollectionViewSource customersViewSource;

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            advWorksService = new AdventureWorksLTEntities(new Uri("http://localhost:54961/AdventureWorksDataService.svc"));

            customersViewSource = this.Resources["customersViewSource"]
            as System.Windows.Data.CollectionViewSource;
            advWorksService.Customers.BeginExecute(result => customersViewSource.Source = advWorksService.Customers.EndExecute(result), null);
        }
        //</Snippet3>

         private void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {
            //advWorksService = new AdventureWorksLTEntities(new Uri("http://localhost:54961/AdventureWorksDataService.svc"));

            //customersViewSource = this.Resources["customersViewSource"]
            //as System.Windows.Data.CollectionViewSource;
            //advWorksService.Customers.BeginExecute(result => customersViewSource.Source = advWorksService.Customers.EndExecute(result), null);
        }

        //<Snippet5>
        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            customersViewSource.View.MoveCurrentToNext();
            if (customersViewSource.View.IsCurrentAfterLast)
                customersViewSource.View.MoveCurrentToLast();
        }
        //</Snippet5>

        //<Snippet4>
        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            customersViewSource.View.MoveCurrentToPrevious();
            if (customersViewSource.View.IsCurrentBeforeFirst)
                customersViewSource.View.MoveCurrentToFirst();
        }
        //</Snippet4>
    }
}
