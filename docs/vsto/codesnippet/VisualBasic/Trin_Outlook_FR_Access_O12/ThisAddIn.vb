Public Class ThisAddIn

    Private Sub ThisAddIn_Startup(ByVal sender As Object, ByVal e _
        As System.EventArgs) Handles Me.Startup

    End Sub

    Private Sub ThisAddIn_Shutdown(ByVal sender As Object, ByVal e _
        As System.EventArgs) Handles Me.Shutdown

    End Sub
    '<Snippet1>
    Friend Sub Access_All_Form_Regions()
        Dim formRegion As Microsoft.Office.Tools.Outlook.IFormRegion
        For Each formRegion In Globals.FormRegions
            If TypeOf formRegion Is FormRegion1 Then
                Dim formRegion1 As FormRegion1 = _
                    CType(formRegion, FormRegion1)
                formRegion1.textBox1.Text = "Hello World"
            End If
        Next formRegion
    End Sub
    '</Snippet1>
    '<Snippet2>
    Private Sub Access_Form_Regions_ByInspector()
        Dim formRegions As WindowFormRegionCollection = Globals.FormRegions _
            (Globals.ThisAddIn.Application.ActiveInspector())
        formRegions.FormRegion1.textBox1.Text = "Hello World"
    End Sub

    '</Snippet2>
    '<Snippet3>
    Private Sub Access_Form_Regions_ByExplorer()
        Dim formRegions As WindowFormRegionCollection = Globals.FormRegions _
            (Globals.ThisAddIn.Application.ActiveExplorer())
        formRegions.FormRegion1.textBox1.Text = "Hello World"
    End Sub
    '</Snippet3>
    '<Snippet4>
    Private Sub Access_All_Ribbons_Globals()
        Globals.Ribbons.Ribbon1.comboBox1.Text = "Hello World"
    End Sub
    '</Snippet4>
    '<Snippet5>
    Private Sub Access_Ribbons_By_Inspector()
        Dim ribbonCollection As ThisRibbonCollection = Globals.Ribbons _
            (Globals.ThisAddIn.Application.ActiveInspector())
        ribbonCollection.Ribbon1.ComboBox1.Text = "Hello World"
    End Sub
    '</Snippet5>
    '<Snippet6>
    Private Sub Access_Ribbons_By_Explorer()
        Dim ribbonCollection As ThisRibbonCollection = Globals.Ribbons _
            (Globals.ThisAddIn.Application.ActiveExplorer())
        ribbonCollection.Ribbon1.ComboBox1.Text = "Hello World"
    End Sub
    '</Snippet6>
End Class
