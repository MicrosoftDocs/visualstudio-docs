Public Class MapIt

#Region "Form Region Factory"

    <Microsoft.Office.Tools.Outlook.FormRegionMessageClass(Microsoft.Office.Tools.Outlook.FormRegionMessageClassAttribute.Contact)> _
    <Microsoft.Office.Tools.Outlook.FormRegionName("Trin_Outlook_FR_Separate_O12.MapIt")> _
    Partial Public Class MapItFactory

    ' Occurs before the form region is initialized.
    ' To prevent the form region from appearing, set e.Cancel to true.
    ' Use e.OutlookItem to get a reference to the current Outlook item.
        '<Snippet1>
        Private Sub MapItFactory_FormRegionInitializing(ByVal sender As Object, ByVal e As Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs) Handles Me.FormRegionInitializing

            Dim myItem As Outlook.ContactItem = CType(e.OutlookItem, Outlook.ContactItem)

            If Not (myItem Is Nothing) Then
                If Not (myItem.BusinessAddress Is Nothing) AndAlso myItem.BusinessAddress.Trim().Length > 0 Or (Not (myItem.HomeAddress Is Nothing) AndAlso myItem.HomeAddress.Trim().Length > 0) Or (Not (myItem.OtherAddress Is Nothing) AndAlso myItem.OtherAddress.Trim().Length > 0) Then
                    Return
                End If
            End If

            e.Cancel = True

        End Sub
        '</Snippet1>

    End Class

#End Region

    'Occurs before the form region is displayed. 
    'Use Me.OutlookItem to get a reference to the current Outlook item.
    'Use Me.OutlookFormRegion to get a reference to the form region.
    '<Snippet2>
    Private Sub MapIt_FormRegionShowing(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles MyBase.FormRegionShowing
        Dim tempLoc As String = ""
        Dim defaultAddress As String = ""
        Dim scratchPadAddress As String = ""

        Dim myItem As Outlook.ContactItem = _
            CType(Me.OutlookItem, Outlook.ContactItem)

        If Not (myItem Is Nothing) Then
            If Not (myItem.HomeAddress Is Nothing) And _
                myItem.HomeAddress.Trim().Length > 0 Then
                tempLoc = myItem.HomeAddressStreet.Trim() + " " _
                    + myItem.HomeAddressCity + " " + myItem.HomeAddressState + _
                        " " + myItem.HomeAddressPostalCode
                If myItem.HomeAddress = myItem.MailingAddress Then
                    defaultAddress = tempLoc + "_Home"
                Else
                    scratchPadAddress += "adr." + tempLoc + "_Home~"
                End If
            End If
            If Not (myItem.BusinessAddress Is Nothing) And _
                myItem.BusinessAddress.Trim().Length > 0 Then
                tempLoc = myItem.BusinessAddressStreet.Trim() + " " _
                    + myItem.BusinessAddressCity + " " + _
                        myItem.BusinessAddressState + " " + _
                            myItem.BusinessAddressPostalCode
                If myItem.BusinessAddress = myItem.MailingAddress Then
                    defaultAddress = tempLoc + "_Business"
                Else
                    scratchPadAddress += "adr." + tempLoc + "_Business~"
                End If
            End If
            If Not (myItem.OtherAddress Is Nothing) And _
                myItem.OtherAddress.Trim().Length > 0 Then
                tempLoc = myItem.OtherAddressStreet.Trim() + " " + _
                    myItem.OtherAddressCity + " " + myItem.OtherAddressState + _
                        " " + myItem.OtherAddressPostalCode
                If myItem.OtherAddress = myItem.MailingAddress Then
                    defaultAddress = tempLoc + "_Other"
                Else
                    scratchPadAddress += "adr." + tempLoc + "_Other~"
                End If
            End If
        End If

        WebBrowser1.Navigate(("http://local.live.com/default.aspx?style=r&where1=" _
            + defaultAddress + "&sp=" + scratchPadAddress))

    End Sub
    '</Snippet2>

    'Occurs when the form region is closed.   
    'Use Me.OutlookItem to get a reference to the current Outlook item.
    'Use Me.OutlookFormRegion to get a reference to the form region.
    Private Sub MapIt_FormRegionClosed(ByVal sender As Object, _
        ByVal e As System.EventArgs) Handles MyBase.FormRegionClosed

    End Sub

End Class
