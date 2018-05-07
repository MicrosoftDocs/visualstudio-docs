Imports Microsoft.Office.Tools.Ribbon

Public Class Ribbon1

    Private Sub Ribbon1_Load(ByVal sender As System.Object, ByVal e As RibbonUIEventArgs) Handles MyBase.Load

    End Sub
    '<Snippet3>
    Private Sub PopulateDynamicMenu()
        Menu1.Items.Add(Me.Factory.CreateRibbonButton())
        CType(menu1.Items.Last(), RibbonButton).Label = "Button 1"
        Menu1.Items.Add(Me.Factory.CreateRibbonButton())
        CType(Menu1.Items.Last(), RibbonButton).Label = "Button 2"
    End Sub
    '</Snippet3>
    '<Snippet4>
    Private Sub SetButtonProperties()
        Button1.ControlSize = _
            Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        button1.Description = "My Ribbon Button"
    End Sub
    '</Snippet4>
    '<Snippet5>
    Private Sub LoadImages()
        button1.ShowImage = True
        Button2.ShowImage = True
        Button1.Image = My.Resources.Image1
        Button2.Image = My.Resources.Image2
    End Sub
    '</Snippet5>
    '<Snippet6>
    Private Sub Ribbon1_LoadImage(ByVal sender As Object, _
        ByVal e As RibbonLoadImageEventArgs)
        Select Case e.ImageName
            Case "Button1Image"
                e.Image = My.Resources.Image1
            Case "Button2Image"
                e.Image = My.Resources.Image2
        End Select
    End Sub
    '</Snippet6>
    '<Snippet7>
    Private Sub AssignKeyTips()
        tab1.KeyTip = "Z"
        button1.KeyTip = "A1"
        checkBox1.KeyTip = "A2"
    End Sub
    '</Snippet7>
    '<Snippet8>
    Private Sub AssignTagToButton()
        Dim customerArrayList As _
            New System.Collections.ArrayList()
        customerArrayList.Add("Jay Hamlin")
        customerArrayList.Add("Yael Peled")
        customerArrayList.Add("Lori Penor")
        Button2.Tag = customerArrayList
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, _
        ByVal e As RibbonControlEventArgs)
        AssignTagToButton()
        Dim tempArrayList As System.Collections.ArrayList = _
            CType(Button2.Tag, System.Collections.ArrayList)
        Dim customer As String
        For Each customer In tempArrayList
            System.Windows.Forms.MessageBox.Show(customer)
        Next customer
    End Sub

    '</Snippet8>
    '<Snippet9>
    Private Sub AddButtonsToMenu()
        Dim tempButton = Me.Factory.CreateRibbonButton()
        tempButton.Label = "Button 1"
        tempButton.ControlSize = _
            Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        tempButton.Description = "My Ribbon Button"
        tempButton.ShowImage = True
        tempButton.ShowImage = True
        tempButton.Image = My.Resources.Image1
        tempButton.Image = My.Resources.Image2
        tempButton.KeyTip = "A1"
        menu1.Items.Add(tempButton)
    End Sub
    '</Snippet9>
End Class
