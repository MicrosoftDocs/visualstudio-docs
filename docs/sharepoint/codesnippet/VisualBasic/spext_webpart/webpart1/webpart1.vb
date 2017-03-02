Imports System
Imports System.Runtime.InteropServices
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports Microsoft.SharePoint
Imports Microsoft.SharePoint.WebControls
'<Snippet1>
Imports System.Data
'</Snippet1>

<Guid("8c8f9e6d-307b-4bfc-86c3-6c72c3d27f0b")> _
Public Class WebPart1
    Inherits WebPart

    Public Sub New()
    End Sub

    '<Snippet2>
    Private grid As DataGrid
    Private Shared verbText As String = "Show Managers Only"
    Private errorMessage As New Label()
    Protected xmlFilePath As String
    '</Snippet2>

    '<Snippet3>
    <Personalizable(PersonalizationScope.[Shared]), _
        WebBrowsable(True), WebDisplayName("Path to Employee Data File"), _
        WebDescription("Location of the XML file that contains employee data")> _
    Public Property DataFilePath() As String
        Get
            Return xmlFilePath
        End Get
        Set(ByVal value As String)
            xmlFilePath = value
        End Set
    End Property
    '</Snippet3>

    '<Snippet4>
    Protected Overloads Overrides Sub CreateChildControls()

        'Define the grid control that displays employee data in the Web Part.
        grid = New DataGrid()
        With grid
            .Width = Unit.Percentage(100)
            .GridLines = GridLines.Horizontal
            .HeaderStyle.CssClass = "ms-vh2"
            .CellPadding = 2
            .BorderWidth = Unit.Pixel(5)
            .HeaderStyle.Font.Bold = True
            .HeaderStyle.HorizontalAlign = HorizontalAlign.Center
        End With



        'Populate the grid control with data in the employee data file.
        Try
            Dim dataset As New DataSet()
            dataset.ReadXml(xmlFilePath, XmlReadMode.InferSchema)
            grid.DataSource = dataset
            grid.DataBind()
        Catch x As Exception
            errorMessage.Text += x.Message
        End Try

        'Add control to the controls collection of the Web Part.
        Controls.Add(grid)
        Controls.Add(errorMessage)
        MyBase.CreateChildControls()

    End Sub
    '</Snippet4>

    Protected Overrides Sub Render(ByVal writer As HtmlTextWriter)
        MyBase.Render(writer)
    End Sub

    '<Snippet5>
    Public Overrides ReadOnly Property Verbs() As WebPartVerbCollection
        Get
            Dim customVerb As New WebPartVerb("Manager_Filter_Verb", _
                New WebPartEventHandler(AddressOf CustomVerbEventHandler))

            customVerb.Text = verbText
            customVerb.Description = "Shows only employees that are managers"

            Dim newVerbs() As WebPartVerb = {customVerb}

            Return New WebPartVerbCollection(MyBase.Verbs, newVerbs)
        End Get
    End Property

    Protected Sub CustomVerbEventHandler(ByVal sender As Object, ByVal args As WebPartEventArgs)
        Dim titleColumn As Integer = 2

        Dim item As DataGridItem
        For Each item In grid.Items
            If item.Cells(titleColumn).Text <> "Manager" Then
                If item.Visible = True Then
                    item.Visible = False
                Else
                    item.Visible = True
                End If
            End If
        Next item
        If verbText = "Show Managers Only" Then
            verbText = "Show All Employees"
        Else
            verbText = "Show Managers Only"
        End If
    End Sub
    '</Snippet5>
End Class
