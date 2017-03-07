Public Class FormRegion1

#Region "Form Region Factory"

    <Microsoft.Office.Tools.Outlook.FormRegionMessageClass(Microsoft.Office.Tools.Outlook.FormRegionMessageClassAttribute.Note)> _
    <Microsoft.Office.Tools.Outlook.FormRegionName("Trin_Outlook_FR_Access_O12.FormRegion1")> _
    Partial Public Class FormRegion1Factory

    ' Occurs before the form region is initialized.
    ' To prevent the form region from appearing, set e.Cancel to true.
    ' Use e.OutlookItem to get a reference to the current Outlook item.
        Private Sub FormRegion1Factory_FormRegionInitializing(ByVal sender As Object, ByVal e As Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs) Handles Me.FormRegionInitializing

    End Sub

    End Class

#End Region

    'Occurs before the form region is displayed. 
    'Use Me.OutlookItem to get a reference to the current Outlook item.
    'Use Me.OutlookFormRegion to get a reference to the form region.
    Private Sub FormRegion1_FormRegionShowing(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FormRegionShowing

    End Sub

    'Occurs when the form region is closed.   
    'Use Me.OutlookItem to get a reference to the current Outlook item.
    'Use Me.OutlookFormRegion to get a reference to the form region.
    Private Sub FormRegion1_FormRegionClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FormRegionClosed

    End Sub

End Class
