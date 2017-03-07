//<Snippet3>
using System.Windows;
using System.Windows.Controls;

namespace ProjectTemplateWizard
{
    public partial class Page2 : UserControl
    {
        private WizardWindow mainWindow;
        private TextBox innerTextBoxForGroupComboBox;

        internal Page2(WizardWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            InitializeComponent();
        }

        internal void ClearControls()
        {
            fieldTypeComboBox.Items.Clear();
            groupComboBox.Items.Clear();
            nameTextBox.Clear();
        }

        internal void PopulateSiteColumnOptions()
        {
            // Add the available field type names to the combo box.
            System.Collections.ArrayList fieldTypes = mainWindow.PresentationModel.GetFieldTypes();
            if (fieldTypes != null)
            {
                fieldTypes.Sort();
                foreach (string fieldValue in fieldTypes)
                {
                    fieldTypeComboBox.Items.Add(fieldValue);
                }

                fieldTypeComboBox.SelectedIndex = 0;
            }

            // Add the default group names to the combo box.
            System.Collections.Generic.List<string> fieldGroups = mainWindow.PresentationModel.GetFieldGroups();
            foreach (string fieldGroupValue in fieldGroups)
            {
                groupComboBox.Items.Add(fieldGroupValue);
            }

            groupComboBox.SelectedIndex = 0;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            // Handle the TextChanged event of the underlying TextBox for the ComboBox. This enables us to determine 
            // 1) when the user selects an item in the list and 2) when they type their own custom group name. 
            // The ComboBox.SelectionChanged event is not raised when you type in an editable ComboboBox.
            innerTextBoxForGroupComboBox = groupComboBox.Template.FindName(
                "PART_EditableTextBox", groupComboBox) as TextBox;
            innerTextBoxForGroupComboBox.TextChanged += innerTextBoxForGroupComboBox_TextChanged;
        }

        private void fieldTypeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            mainWindow.PresentationModel.FieldType = (string)fieldTypeComboBox.SelectedItem;
        }

        void innerTextBoxForGroupComboBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            mainWindow.PresentationModel.FieldGroup = groupComboBox.Text;
        }

        private void nameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            mainWindow.PresentationModel.FieldName = nameTextBox.Text;
        }
    }
}
//</Snippet3>
