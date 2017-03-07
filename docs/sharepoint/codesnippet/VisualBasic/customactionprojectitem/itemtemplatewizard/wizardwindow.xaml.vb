'<Snippet7>
Public Class WizardWindow
    Private standardMenuGroups As List(Of String)
    Private listEditGroups As List(Of String)
    Private standardMenuGroupIdBinding As Binding
    Private listEditGroupIdBinding As Binding
    Private standardMenuGroupIdBindingView As ListCollectionView
    Private listEditGroupIdBindingView As ListCollectionView

    Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
        standardMenuGroups = New List(Of String) From {
            StandardMenuGroupIds.Actions,
            StandardMenuGroupIds.ActionsSurvey,
            StandardMenuGroupIds.NewMenu,
            StandardMenuGroupIds.Settings,
            StandardMenuGroupIds.SettingsSurvey,
            StandardMenuGroupIds.SiteActions,
            StandardMenuGroupIds.Upload,
            StandardMenuGroupIds.ViewSelector}
        listEditGroups = New List(Of String) From {
            ListEditGroupIds.Communications,
            ListEditGroupIds.GeneralSettings,
            ListEditGroupIds.Permissions}

        standardMenuGroupIdBinding = New Binding()
        standardMenuGroupIdBinding.Source = standardMenuGroups
        listEditGroupIdBinding = New Binding()
        listEditGroupIdBinding.Source = listEditGroups

        standardMenuGroupIdBindingView = CType(CollectionViewSource.GetDefaultView(standardMenuGroups), ListCollectionView)
        listEditGroupIdBindingView = CType(CollectionViewSource.GetDefaultView(listEditGroups), ListCollectionView)

        standardMenuRadioButton.IsChecked = True
    End Sub

    Private Sub standardMenuRadioButton_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
        BindingOperations.ClearBinding(idComboBox, ComboBox.ItemsSourceProperty)
        idComboBox.SetBinding(ComboBox.ItemsSourceProperty, standardMenuGroupIdBinding)
        standardMenuGroupIdBindingView.MoveCurrentToFirst()
    End Sub

    Private Sub listEditRadioButton_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
        BindingOperations.ClearBinding(idComboBox, ComboBox.ItemsSourceProperty)
        idComboBox.SetBinding(ComboBox.ItemsSourceProperty, listEditGroupIdBinding)
        listEditGroupIdBindingView.MoveCurrentToFirst()
    End Sub

    Private Sub finishButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Me.DialogResult = True
        Me.Close()
    End Sub
End Class
'</Snippet7>