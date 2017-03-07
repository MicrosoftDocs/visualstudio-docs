'<Snippet3>
Public Class Page2
    Private mainWindow As WizardWindow
    Private innerTextBoxForGroupComboBox As TextBox

    Friend Sub New(ByVal mainWindow As WizardWindow)
        Me.mainWindow = mainWindow
        InitializeComponent()
    End Sub

    Friend Sub ClearControls()
        fieldTypeComboBox.Items.Clear()
        groupComboBox.Items.Clear()
        nameTextBox.Clear()
    End Sub

    Friend Sub PopulateSiteColumnOptions()
        ' Add the available field type names to the combo box.
        Dim fieldTypes As System.Collections.ArrayList = mainWindow.PresentationModel.GetFieldTypes()
        If fieldTypes IsNot Nothing Then
            fieldTypes.Sort()
            For Each fieldValue As String In fieldTypes
                fieldTypeComboBox.Items.Add(fieldValue)
            Next
            fieldTypeComboBox.SelectedIndex = 0
        End If

        ' Add the default group names to the combo box.
        Dim fieldGroups As List(Of String) = mainWindow.PresentationModel.GetFieldGroups()
        For Each fieldGroupValue As String In fieldGroups
            groupComboBox.Items.Add(fieldGroupValue)
        Next
        groupComboBox.SelectedIndex = 0
    End Sub

    Private Sub UserControl_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
        ' Handle the TextChanged event of the underlying TextBox for the ComboBox. This enables us to determine 
        ' 1) when the user selects an item in the list and 2) when they type their own custom group name. 
        ' The ComboBox.SelectionChanged event is not raised when you type in an editable ComboboBox.
        innerTextBoxForGroupComboBox = CType(groupComboBox.Template.FindName(
            "PART_EditableTextBox", groupComboBox), TextBox)
        AddHandler innerTextBoxForGroupComboBox.TextChanged, AddressOf innerTextBoxForGroupComboBox_TextChanged
    End Sub

    Private Sub fieldTypeComboBox_SelectionChanged(ByVal sender As Object, ByVal e As SelectionChangedEventArgs)
        mainWindow.PresentationModel.FieldType = CStr(fieldTypeComboBox.SelectedItem)
    End Sub

    Private Sub innerTextBoxForGroupComboBox_TextChanged(ByVal sender As Object, ByVal e As TextChangedEventArgs)
        mainWindow.PresentationModel.FieldGroup = groupComboBox.Text
    End Sub

    Private Sub nameTextBox_TextChanged(ByVal sender As Object, ByVal e As TextChangedEventArgs)
        mainWindow.PresentationModel.FieldName = nameTextBox.Text
    End Sub
End Class
'</Snippet3>
