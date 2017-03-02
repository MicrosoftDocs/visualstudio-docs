Public Class FormRegion1

#Region "Form Region Factory"
    '<Snippet1>
    <Microsoft.Office.Tools.Outlook.FormRegionMessageClass(Microsoft.Office.Tools.Outlook.FormRegionMessageClassAttribute.Note)> _
    <Microsoft.Office.Tools.Outlook.FormRegionMessageClass("IPM.Task.Contoso")> _
    <Microsoft.Office.Tools.Outlook.FormRegionName("Trin_Outlook_FR_Attributes.FormRegion1")> _
    Partial Public Class FormRegion1Factory

    ' Occurs before the form region is initialized.
    ' To prevent the form region from appearing, set e.Cancel to true.
    ' Use e.OutlookItem to get a reference to the current Outlook item.
        Private Sub FormRegion1Factory_FormRegionInitializing(ByVal sender As Object, ByVal e As Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs) Handles Me.FormRegionInitializing

    End Sub
        '</Snippet1>
    End Class

#End Region

    'Occurs before the form region is displayed. 
    'Use this.OutlookItem to get a reference to the current Outlook item.
    'Use this.OutlookFormRegion to get a reference to the form region.
    '<Snippet2>
    Private Sub FormRegion1_FormRegionShowing(ByVal sender As Object, _
        ByVal e As System.EventArgs) Handles MyBase.FormRegionShowing
        If TypeOf (Me.OutlookItem) Is Outlook.MailItem Then
            If Me.OutlookFormRegion.FormRegionMode = _
                Outlook.OlFormRegionMode.olFormRegionRead Then
                Dim mailItem As Outlook.MailItem = CType(Me.OutlookItem,  _
                    Outlook.MailItem)
                Label1.Text = "This form region contains information " & _
                    "about " & mailItem.Subject
            End If
        End If

    End Sub
    '</Snippet2>
    'Occurs when the form region is closed.   
    'Use this.OutlookItem to get a reference to the current Outlook item.
    'Use this.OutlookFormRegion to get a reference to the form region.
    Private Sub FormRegion1_FormRegionClosed(ByVal sender As Object, _
        ByVal e As System.EventArgs) Handles MyBase.FormRegionClosed

    End Sub

End Class
