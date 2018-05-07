Imports System
Imports Microsoft.SharePoint
Imports Microsoft.SharePoint.WebControls

'<Snippet1>
Imports System.Web.UI.WebControls
Imports Microsoft.SharePoint.Administration
Imports System.Collections
'</Snippet1>

Namespace Layouts.SP_ApplicationPage

    Partial Public Class SearchItems
        Inherits LayoutsPageBase
        '<Snippet4>
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            'use to be a snippet here that is no longer needed.
        End Sub
        '</Snippet4>
        '<Snippet5>
        Protected Sub DropDownList1_SelectedIndexChanged _
       (ByVal sender As Object, ByVal e As EventArgs) _
       Handles DropDownList1.SelectedIndexChanged
            SPSecurity.RunWithElevatedPrivileges(AddressOf GetItems)
        End Sub
        '</Snippet5>
        '<Snippet2>
        Private Sub GetItems()
            Dim CurrentUser As New SPFieldUserValue _
                (Me.Web, Me.Web.CurrentUser.ID, Me.Web.CurrentUser.Name)

            Dim ResultsList As New ArrayList()

            Dim ThisFarm As SPFarm = SPFarm.Local
            Dim Service As SPWebService = _
                ThisFarm.Services.GetValue(Of SPWebService)("")

            Dim WebApp As SPWebApplication
            For Each WebApp In Service.WebApplications
                Dim SiteCollection As SPSite
                For Each SiteCollection In WebApp.Sites
                    Dim Web As SPWeb
                    For Each Web In SiteCollection.AllWebs
                        Dim Lists As SPListCollection = Web.Lists
                        Dim List As SPList
                        For Each List In Lists
                            Dim Item As SPListItem
                            Try
                                For Each Item In List.Items
                                    If Item(DropDownList1.SelectedValue).ToString() = _
                                        CurrentUser.ToString() Then
                                        ResultsList.Add(Item)
                                    End If
                                Next Item
                            Catch exception As Exception
                                'Error in list. Move on to the next list.
                            End Try
                        Next List
                    Next Web
                Next SiteCollection
            Next WebApp
            CreateResultsTable(ResultsList)
        End Sub
        '</Snippet2>
        '<Snippet3>
        Private Sub CreateResultsTable(ByVal ResultsList As ArrayList)
            Dim CurrentList As String = ""
            Dim CurrentSite As String = ""
            Table1.Rows.Clear()

            Dim Item As SPListItem
            For Each Item In ResultsList
                If Item.ParentList.ParentWeb.Title <> CurrentSite Then
                    CurrentSite = Item.ParentList.ParentWeb.Title

                    Dim NewSiteCell As New TableCell()
                    NewSiteCell.Text = CurrentSite

                    Dim NewSiteRow As New TableRow()
                    With NewSiteRow
                        .Cells.Add(NewSiteCell)
                        .Font.Bold = True
                        .Font.Size = FontUnit.Larger
                        .Font.Underline = True
                    End With
                    Table1.Rows.Add(NewSiteRow)

                End If

                If Item.ParentList.Title <> CurrentList Then
                    CurrentList = Item.ParentList.Title
                    Dim NewListCell As New TableCell()
                    NewListCell.Text = CurrentList

                    Dim NewListRow As New TableRow()
                    With NewListRow
                        .Cells.Add(NewListCell)
                        .Font.Bold = True
                    End With
                    Table1.Rows.Add(NewListRow)

                    Dim ItemHeading As New TableCell()
                    With ItemHeading
                        .Text = "Item"
                        .Font.Italic = True
                    End With

                    Dim CreatedHeading As New TableCell()
                    With CreatedHeading
                        .Text = "Created"
                        .Font.Italic = True
                    End With


                    Dim ModifiedHeading As New TableCell()
                    With ModifiedHeading
                        .Text = "Last Modified"
                        .Font.Italic = True
                    End With

                    Dim HeadingRow As New TableRow()
                    HeadingRow.Cells.Add(ItemHeading)
                    HeadingRow.Cells.Add(CreatedHeading)
                    HeadingRow.Cells.Add(ModifiedHeading)

                    Table1.Rows.Add(HeadingRow)
                End If

                Dim ItemName As New TableCell()
                Dim ItemLink As New HyperLink()
                Try
                    ItemLink.NavigateUrl = Item.ParentList.ParentWeb.Url & _
                        "/" & Item.ParentList.Forms(PAGETYPE.PAGE_DISPLAYFORM).Url & _
                        "?ID=" & Item.ID
                Catch exception As Exception
                    ' Some items might not have a form page. Ignore the exception.
                End Try
                ItemLink.Text = Item.DisplayName
                ItemName.Controls.Add(ItemLink)

                Dim Created As New TableCell()
                Created.Text = Item("Created").ToString()

                Dim Modified As New TableCell()
                Modified.Text = Item("Modified").ToString()

                Dim DataRow As New TableRow()
                DataRow.Cells.Add(ItemName)
                DataRow.Cells.Add(Created)
                DataRow.Cells.Add(Modified)

                Table1.Rows.Add(DataRow)
            Next Item
        End Sub
        '</Snippet3>
    End Class

End Namespace
