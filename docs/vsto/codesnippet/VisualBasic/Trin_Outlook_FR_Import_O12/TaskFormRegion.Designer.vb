Option Strict Off
Option Explicit On

Partial Class TaskFormRegion
    Inherits Microsoft.Office.Tools.Outlook.ImportedFormRegionBase

    Private WithEvents olkTextBox1 As Microsoft.Office.Interop.Outlook.OlkTextBox
    Private WithEvents olkLabel1 As Microsoft.Office.Interop.Outlook.OlkLabel
    Private WithEvents olkTextBox2 As Microsoft.Office.Interop.Outlook.OlkTextBox
    Private WithEvents olkLabel2 As Microsoft.Office.Interop.Outlook.OlkLabel
    Private WithEvents label1 As Microsoft.Office.Interop.Outlook.OlkLabel
    Private WithEvents listBox1 As Microsoft.Office.Interop.Outlook.OlkListBox
    Private WithEvents label2 As Microsoft.Office.Interop.Outlook.OlkLabel
    Private WithEvents comboBox1 As Microsoft.Office.Interop.Outlook.OlkComboBox
    Private WithEvents addDependentTask As Microsoft.Office.Interop.Outlook.OlkCommandButton
    Private WithEvents olkTextBox3 As Microsoft.Office.Interop.Outlook.OlkTextBox
    Private WithEvents olkLabel3 As Microsoft.Office.Interop.Outlook.OlkLabel

    Public Sub New(ByVal formRegion As Microsoft.Office.Interop.Outlook.FormRegion)
        MyBase.New(Globals.Factory, formRegion)
    End Sub

    <System.Diagnostics.DebuggerStepThrough()> _
    Protected Overrides Sub InitializeControls()
        Me.olkTextBox1 = CType(GetFormRegionControl("OlkTextBox1"), Microsoft.Office.Interop.Outlook.OlkTextBox)
        Me.olkLabel1 = CType(GetFormRegionControl("OlkLabel1"), Microsoft.Office.Interop.Outlook.OlkLabel)
        Me.olkTextBox2 = CType(GetFormRegionControl("OlkTextBox2"), Microsoft.Office.Interop.Outlook.OlkTextBox)
        Me.olkLabel2 = CType(GetFormRegionControl("OlkLabel2"), Microsoft.Office.Interop.Outlook.OlkLabel)
        Me.label1 = CType(GetFormRegionControl("Label1"), Microsoft.Office.Interop.Outlook.OlkLabel)
        Me.listBox1 = CType(GetFormRegionControl("ListBox1"), Microsoft.Office.Interop.Outlook.OlkListBox)
        Me.label2 = CType(GetFormRegionControl("Label2"), Microsoft.Office.Interop.Outlook.OlkLabel)
        Me.comboBox1 = CType(GetFormRegionControl("ComboBox1"), Microsoft.Office.Interop.Outlook.OlkComboBox)
        Me.addDependentTask = CType(GetFormRegionControl("AddDependentTask"), Microsoft.Office.Interop.Outlook.OlkCommandButton)
        Me.olkTextBox3 = CType(GetFormRegionControl("OlkTextBox3"), Microsoft.Office.Interop.Outlook.OlkTextBox)
        Me.olkLabel3 = CType(GetFormRegionControl("OlkLabel3"), Microsoft.Office.Interop.Outlook.OlkLabel)
    End Sub

    Partial Public Class TaskFormRegionFactory
        Implements Microsoft.Office.Tools.Outlook.IFormRegionFactory

        Public Event FormRegionInitializing As Microsoft.Office.Tools.Outlook.FormRegionInitializingEventHandler

        Private _Manifest As Microsoft.Office.Tools.Outlook.FormRegionManifest

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Sub New()
            Me._Manifest = Globals.Factory.CreateFormRegionManifest()
            Me.InitializeManifest()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        ReadOnly Property Manifest() As Microsoft.Office.Tools.Outlook.FormRegionManifest Implements Microsoft.Office.Tools.Outlook.IFormRegionFactory.Manifest
            Get
                Return Me._Manifest
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Function CreateFormRegion(ByVal formRegion As Microsoft.Office.Interop.Outlook.FormRegion) As Microsoft.Office.Tools.Outlook.IFormRegion Implements Microsoft.Office.Tools.Outlook.IFormRegionFactory.CreateFormRegion
            Dim form As TaskFormRegion = New TaskFormRegion(formRegion)
            form.Factory = Me
            Return form
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Function GetFormRegionStorage(ByVal outlookItem As Object, ByVal formRegionMode As Microsoft.Office.Interop.Outlook.OlFormRegionMode, ByVal formRegionSize As Microsoft.Office.Interop.Outlook.OlFormRegionSize) As Byte() Implements Microsoft.Office.Tools.Outlook.IFormRegionFactory.GetFormRegionStorage
            Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(TaskFormRegion))
            Return CType(resources.GetObject("TaskFormRegionImport"), Byte())
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Function IsDisplayedForItem(ByVal outlookItem As Object, ByVal formRegionMode As Microsoft.Office.Interop.Outlook.OlFormRegionMode, ByVal formRegionSize As Microsoft.Office.Interop.Outlook.OlFormRegionSize) As Boolean Implements Microsoft.Office.Tools.Outlook.IFormRegionFactory.IsDisplayedForItem
            Dim cancelArgs As Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs = Globals.Factory.CreateFormRegionInitializingEventArgs(outlookItem, formRegionMode, formRegionSize, False)
            cancelArgs.Cancel = False
            RaiseEvent FormRegionInitializing(Me, cancelArgs)
            Return Not cancelArgs.Cancel
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        ReadOnly Property Kind() As Microsoft.Office.Tools.Outlook.FormRegionKindConstants Implements Microsoft.Office.Tools.Outlook.IFormRegionFactory.Kind
            Get
                Return Microsoft.Office.Tools.Outlook.FormRegionKindConstants.Ofs
            End Get
        End Property
    End Class


End Class


Partial Class WindowFormRegionCollection

    Friend ReadOnly Property TaskFormRegion() As TaskFormRegion
        Get
            For Each Item As Object In Me
                If (TypeOf (Item) Is TaskFormRegion) Then
                    Return Item
                End If
            Next
            Return Nothing
        End Get
    End Property
End Class