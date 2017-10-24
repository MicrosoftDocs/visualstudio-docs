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