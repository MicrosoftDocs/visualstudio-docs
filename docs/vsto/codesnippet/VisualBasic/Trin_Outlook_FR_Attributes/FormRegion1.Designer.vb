<System.ComponentModel.ToolboxItemAttribute(False)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegion1
    Inherits Microsoft.Office.Tools.Outlook.FormRegionBase

    Public Sub New(ByVal formRegion As Microsoft.Office.Interop.Outlook.FormRegion)
        MyBase.New(Globals.Factory, formRegion)
        Me.InitializeComponent()
    End Sub

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'FormRegion1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormRegion1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    'NOTE: The following procedure is required by the Form Regions Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Shared Sub InitializeManifest(ByVal manifest As Microsoft.Office.Tools.Outlook.FormRegionManifest, ByVal factory As Microsoft.Office.Tools.Outlook.Factory)
        manifest.FormRegionName = "FormRegion1"
        manifest.ShowReadingPane = False

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label

    Partial Public Class FormRegion1Factory
        Implements Microsoft.Office.Tools.Outlook.IFormRegionFactory

        Public Event FormRegionInitializing As Microsoft.Office.Tools.Outlook.FormRegionInitializingEventHandler

        Private _Manifest As Microsoft.Office.Tools.Outlook.FormRegionManifest


        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Sub New()
            Me._Manifest = Globals.Factory.CreateFormRegionManifest()
            FormRegion1.InitializeManifest(Me._Manifest, Globals.Factory)
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        ReadOnly Property Manifest() As Microsoft.Office.Tools.Outlook.FormRegionManifest Implements Microsoft.Office.Tools.Outlook.IFormRegionFactory.Manifest
            Get
                Return Me._Manifest
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Function CreateFormRegion(ByVal formRegion As Microsoft.Office.Interop.Outlook.FormRegion) As Microsoft.Office.Tools.Outlook.IFormRegion Implements Microsoft.Office.Tools.Outlook.IFormRegionFactory.CreateFormRegion
            Dim form As FormRegion1 = New FormRegion1(formRegion)
            form.Factory = Me
            Return form
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Function GetFormRegionStorage(ByVal outlookItem As Object, ByVal formRegionMode As Microsoft.Office.Interop.Outlook.OlFormRegionMode, ByVal formRegionSize As Microsoft.Office.Interop.Outlook.OlFormRegionSize) As Byte() Implements Microsoft.Office.Tools.Outlook.IFormRegionFactory.GetFormRegionStorage
            Throw New System.NotSupportedException()
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
                Return Microsoft.Office.Tools.Outlook.FormRegionKindConstants.WindowsForms
            End Get
        End Property
    End Class
    
End Class


Partial Class WindowFormRegionCollection

    Friend ReadOnly Property FormRegion1() As FormRegion1
        Get
            For Each Item As Object In Me
                If (TypeOf (Item) Is FormRegion1) Then
                    Return Item
                End If
            Next
            Return Nothing
        End Get
    End Property
End Class