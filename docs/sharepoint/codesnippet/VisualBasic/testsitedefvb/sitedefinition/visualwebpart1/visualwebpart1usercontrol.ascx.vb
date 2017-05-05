Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts

Partial Public Class VisualWebPart1UserControl
    Inherits UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub

    '<Snippet1>
    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs)
        lblName.Text = tbName.Text
    End Sub
    '</Snippet1>

End Class
