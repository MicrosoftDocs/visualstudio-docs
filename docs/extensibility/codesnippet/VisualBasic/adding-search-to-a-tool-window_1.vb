Partial Public Class MyControl
    Inherits System.Windows.Controls.UserControl

    Public Property SearchResultsTextBox As System.Windows.Controls.TextBox
    Public Property SearchContent As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.SearchResultsTextBox = resultsTextBox
        Me.SearchContent = buildContent

        Me.SearchResultsTextBox.Text = Me.SearchContent
    End Sub

    Private Function BuildContent() As String
        Dim sb As New System.Text.StringBuilder()

        sb.AppendLine("1 go")
        sb.AppendLine("2 good")
        sb.AppendLine("3 Go")
        sb.AppendLine("4 Good")
        sb.AppendLine("5 goodbye")
        sb.AppendLine("6 Goodbye")

        Return sb.ToString()
    End Function
End Class