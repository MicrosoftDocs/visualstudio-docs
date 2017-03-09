//<Snippet7>
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Microsoft.VisualStudio.PlatformUI;

namespace ItemTemplateWizard
{
    public partial class WizardWindow : DialogWindow
    {
        private List<string> standardMenuGroups;
        private List<string> listEditGroups;
        private Binding standardMenuGroupIdBinding;
        private Binding listEditGroupIdBinding;
        private ListCollectionView standardMenuGroupIdBindingView;
        private ListCollectionView listEditGroupIdBindingView;

        public WizardWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            standardMenuGroups = new List<string>() { 
                StandardMenuGroupIds.Actions,
                StandardMenuGroupIds.ActionsSurvey,
                StandardMenuGroupIds.NewMenu, 
                StandardMenuGroupIds.Settings, 
                StandardMenuGroupIds.SettingsSurvey,
                StandardMenuGroupIds.SiteActions, 
                StandardMenuGroupIds.Upload, 
                StandardMenuGroupIds.ViewSelector };
            listEditGroups = new List<string>() { 
                ListEditGroupIds.Communications, 
                ListEditGroupIds.GeneralSettings,
                ListEditGroupIds.Permissions };

            standardMenuGroupIdBinding = new Binding();
            standardMenuGroupIdBinding.Source = standardMenuGroups;
            listEditGroupIdBinding = new Binding();
            listEditGroupIdBinding.Source = listEditGroups;

            standardMenuGroupIdBindingView = (ListCollectionView)CollectionViewSource.GetDefaultView(standardMenuGroups);
            listEditGroupIdBindingView = (ListCollectionView)CollectionViewSource.GetDefaultView(listEditGroups);

            standardMenuRadioButton.IsChecked = true;
        }

        private void standardMenuRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            BindingOperations.ClearBinding(idComboBox, ComboBox.ItemsSourceProperty);
            idComboBox.SetBinding(ComboBox.ItemsSourceProperty, standardMenuGroupIdBinding);
            standardMenuGroupIdBindingView.MoveCurrentToFirst();
        }

        private void listEditRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            BindingOperations.ClearBinding(idComboBox, ComboBox.ItemsSourceProperty);
            idComboBox.SetBinding(ComboBox.ItemsSourceProperty, listEditGroupIdBinding);
            listEditGroupIdBindingView.MoveCurrentToFirst();
        }

        private void finishButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }
    }
}
//</Snippet7>
