#Region "Using directives"

Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.IO
Imports System.Text
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Office = Microsoft.Office.Core


#End Region

' TODO:
' This is an override of the RequestService method in ThisAddin class.
' To hook up your custom ribbon uncomment this code.
Partial Public Class ThisAddIn

    Private ribbon As Ribbon1

    Protected Overrides Function RequestService(ByVal serviceGuid As System.Guid) As Object

        If (serviceGuid = GetType(Office.IRibbonExtensibility).GUID) Then
            If ribbon Is Nothing Then
                ribbon = New Ribbon1()
            End If

            Return ribbon
        End If

        Return MyBase.RequestService(serviceGuid)
    End Function

End Class


<ComVisible(True)> _
    Public Class Ribbon1
    Implements Office.IRibbonExtensibility

#Region "Fields"
    Private ribbon As Office.IRibbonUI
#End Region

#Region "Initialization"

    Public Sub New()
    End Sub

    '<Snippet1>
    Public Function GetCustomUI(ByVal ribbonID As String) As String _
        Implements Office.IRibbonExtensibility.GetCustomUI

        Dim ribbonXML As String = String.Empty

        If ribbonID = "Microsoft.Outlook.Mail.Compose" Then
            ribbonXML = GetResourceText("Trin_RibbonOutlookBasic.Ribbon1.xml")
        End If

        Return ribbonXML
    End Function
    '</Snippet1>

    Public Sub OnLoad(ByVal ribbonUI As Office.IRibbonUI)
        Me.ribbon = ribbonUI
    End Sub

#End Region

    Public Sub OnToggleButton1(ByVal control As Office.IRibbonControl, _
        ByVal isPressed As Boolean)

        If (isPressed) Then
            MessageBox.Show("Pressed!")
        Else
            MessageBox.Show("Released!")
        End If

    End Sub

    '<Snippet2>
    Public Sub OnActionCallback(ByVal control As Office.IRibbonControl, _
        ByVal isPressed As Boolean)

        If (control.Id = "checkBox1") Then
            MessageBox.Show("You clicked " + control.Id)
        Else
            MessageBox.Show("You clicked a different control.")
        End If

    End Sub
    '</Snippet2>

#Region "Helpers"
    Private Shared Function GetResourceText(ByVal resourceName As String) As String
        Dim asm As Assembly = Assembly.GetExecutingAssembly()
        Dim resourceNames() As String = asm.GetManifestResourceNames()
        For i As Integer = 0 To resourceNames.Length - 1
            If String.Compare(resourceName, resourceNames(i), StringComparison.OrdinalIgnoreCase) = 0 Then
                Using resourceReader As StreamReader = New StreamReader(asm.GetManifestResourceStream(resourceNames(i)))
                    If resourceReader IsNot Nothing Then
                        Return resourceReader.ReadToEnd()
                    End If
                End Using
            End If
        Next
        Return Nothing
    End Function
#End Region
End Class
