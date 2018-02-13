
Public Class ThisWorkbook

    '<Snippet1>
    ' Declare the menu variable at the class level.
    Private WithEvents menuCommand As Office.CommandBarButton
    Private menuTag As String = "A unique tag"


    ' Call AddMenu from the Startup event of ThisWorkbook.
    Private Sub ThisWorkbook_Startup(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles Me.Startup

        CheckIfMenuBarExists()
        AddMenuBar()
    End Sub


    ' If the menu already exists, remove it.
    Private Sub CheckIfMenuBarExists()
        Try
            Dim foundMenu As Office.CommandBarPopup = _
                Me.Application.CommandBars.ActiveMenuBar.FindControl( _
                    Office.MsoControlType.msoControlPopup, System.Type.Missing, menuTag, True, True)

            If foundMenu IsNot Nothing Then
                foundMenu.Delete(True)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    ' Create the menu, if it does not exist.
    Private Sub AddMenuBar()

        Try
            Dim menuBar As Office.CommandBar = Application.comm.CommandBars.ActiveMenuBar
            Dim menuCaption As String = "Ne&w Menu"

            If menuBar IsNot Nothing Then
                Dim cmdBarControl As Office.CommandBarPopup = Nothing
                Dim controlCount As Integer = menuBar.Controls.Count

                ' Add the new menu.
                cmdBarControl = CType(menuBar.Controls.Add( _
                    Type:=Office.MsoControlType.msoControlPopup, Before:=controlCount, Temporary:=True),  _
                    Office.CommandBarPopup)

                cmdBarControl.Caption = menuCaption
                cmdBarControl.Tag = menuTag

                ' Add the menu command.
                menuCommand = CType(cmdBarControl.Controls.Add( _
                    Type:=Office.MsoControlType.msoControlButton, Temporary:=True),  _
                    Office.CommandBarButton)

                With menuCommand
                    .Caption = "&New Menu Command"
                    .Tag = "NewMenuCommand"
                    .FaceId = 65
                End With
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    ' Add text to cell A1 when the menu is clicked.
    Private Sub menuCommand_Click(ByVal Ctrl As Microsoft.Office.Core.CommandBarButton, _
        ByRef CancelDefault As Boolean) Handles menuCommand.Click

        Globals.Sheet1.Range("A1").Value2 = "The menu command was clicked."
    End Sub
    '</Snippet1>

End Class
