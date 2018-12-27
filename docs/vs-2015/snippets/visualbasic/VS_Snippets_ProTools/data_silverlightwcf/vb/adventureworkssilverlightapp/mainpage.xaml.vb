'<Snippet2>
Imports System.Windows.Data
Imports AdventureWorksSilverlightApp.AdventureWorksService
'</Snippet2>

Partial Public Class MainPage
    Inherits UserControl

    Public Sub New()
        InitializeComponent()
    End Sub



    Private Sub LayoutRoot_Loaded(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles LayoutRoot.Loaded

    End Sub


    '<Snippet4>
    Private Sub backButton_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles backButton.Click
        customersViewSource.View.MoveCurrentToPrevious()
        If customersViewSource.View.IsCurrentBeforeFirst Then
            customersViewSource.View.MoveCurrentToFirst()
        End If
    End Sub
    '</Snippet4>

    '<Snippet5>
    Private Sub nextButton_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles nextButton.Click
        customersViewSource.View.MoveCurrentToNext()
        If customersViewSource.View.IsCurrentAfterLast Then
            customersViewSource.View.MoveCurrentToLast()
        End If
    End Sub
    '</Snippet5>


    '<Snippet3>
    Private advWorksService As AdventureWorksLTEntities
    Private customersViewSource As CollectionViewSource

    Private Sub UserControl_Loaded(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded
        advWorksService = New AdventureWorksLTEntities(New Uri("http://localhost:6188/AdventureWorksDataService.svc"))
        customersViewSource = Me.Resources("CustomersViewSource")
        advWorksService.Customers.BeginExecute(Sub(result As IAsyncResult)
                                                   customersViewSource.Source = advWorksService.Customers.EndExecute(result)
                                               End Sub, Nothing)
    End Sub
    '</Snippet3>
End Class