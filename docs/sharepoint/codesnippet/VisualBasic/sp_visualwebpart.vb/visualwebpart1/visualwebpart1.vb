Imports System
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports Microsoft.SharePoint
Imports Microsoft.SharePoint.WebControls
'<Snippet5>
<ToolboxItemAttribute(false)> _
Public Class VisualWebPart1
    Inherits WebPart

    Private Const _ascxPath As String = "~/_CONTROLTEMPLATES/VB/VisualWebPart1/VisualWebPart1UserControl.ascx"

    Public Sub New()
    End Sub

    Protected Overrides Sub CreateChildControls()
        Dim control As Control = Page.LoadControl(_ascxPath)
        Controls.Add(control)
        MyBase.CreateChildControls()
    End Sub

    Protected Overrides Sub RenderContents(ByVal writer As HtmlTextWriter)
        MyBase.RenderContents(writer)
    End Sub

End Class
'</Snippet5>