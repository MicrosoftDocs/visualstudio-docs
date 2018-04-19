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

namespace AdventureWorksProductsEditor
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

        //<Snippet1>
        private AdventureWorksProductsEditor.AdventureWorksLTDataSet AdventureWorksLTDataSet;
        private AdventureWorksProductsEditor.AdventureWorksLTDataSetTableAdapters.ProductTableAdapter adventureWorksLTDataSetProductTableAdapter;
        private System.Windows.Data.CollectionViewSource productViewSource;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            AdventureWorksLTDataSet = ((AdventureWorksProductsEditor.AdventureWorksLTDataSet)(this.FindResource("adventureWorksLTDataSet")));
            // Load data into the table Product. You can modify this code as needed.
            adventureWorksLTDataSetProductTableAdapter = new AdventureWorksProductsEditor.AdventureWorksLTDataSetTableAdapters.ProductTableAdapter();
            adventureWorksLTDataSetProductTableAdapter.Fill(AdventureWorksLTDataSet.Product);
            productViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("productViewSource")));
            productViewSource.View.MoveCurrentToFirst();
        }
        //</Snippet1>

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            //<Snippet2>
            if (productViewSource.View.CurrentPosition > 0)
            {
                productViewSource.View.MoveCurrentToPrevious();
            }
            //</Snippet2>
        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            //<Snippet3>
            if (productViewSource.View.CurrentPosition < ((CollectionView)productViewSource.View).Count - 1)
            {
                productViewSource.View.MoveCurrentToNext();
            }
            //</Snippet3>
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            //<Snippet4>
            adventureWorksLTDataSetProductTableAdapter.Update(AdventureWorksLTDataSet.Product);
            //</Snippet4>
        }
    }
}
