﻿Imports Microsoft.VisualBasic
Imports System
Imports System.Diagnostics
Imports System.Globalization
Imports System.Runtime.InteropServices
Imports System.ComponentModel.Design
Imports Microsoft.Win32
Imports Microsoft.VisualStudio
Imports Microsoft.VisualStudio.Shell.Interop
Imports Microsoft.VisualStudio.OLE.Interop
Imports Microsoft.VisualStudio.Shell

'<Snippet1>
Imports EnvDTE
'</Snippet1>

''' <summary>
''' This is the class that implements the package exposed by this assembly.
'''
''' The minimum requirement for a class to be considered a valid package for Visual Studio
''' is to implement the IVsPackage interface and register itself with the shell.
''' This package uses the helper classes defined inside the Managed Package Framework (MPF)
''' to do it: it derives from the Package class that provides the implementation of the 
''' IVsPackage interface and uses the registration attributes defined in the framework to 
''' register itself and its components with the shell.
''' </summary>
' The PackageRegistration attribute tells the PkgDef creation utility (CreatePkgDef.exe) that this class
' is a package.
'
' The InstalledProductRegistration attribute is used to register the information needed to show this package
' in the Help/About dialog of Visual Studio.
    '
' The ProvideMenuResource attribute is needed to let the shell know that this package exposes some menus.

    <PackageRegistration(UseManagedResourcesOnly := true), _ 
    InstalledProductRegistration("#110", "#112", "1.0", IconResourceID := 400), _
    ProvideMenuResource("Menus.ctmenu", 1), _    
    Guid(GuidList.guidVSSDKAutoPkgString)> _
    Public NotInheritable Class VSSDKAutoPackage
Inherits Package

''' <summary>
''' Default constructor of the package.
''' Inside this method you can place any initialization code that does not require 
''' any Visual Studio service because at this point the package object is created but 
''' not sited yet inside Visual Studio environment. The place to do all the other 
''' initialization is the Initialize method.
''' </summary>
Public Sub New()
    Trace.WriteLine(String.Format(CultureInfo.CurrentCulture, "Entering constructor for: {0}", Me.GetType().Name))
End Sub



''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
' Overriden Package Implementation
#Region "Package Members"

''' <summary>
''' Initialization of the package; this method is called right after the package is sited, so this is the place
''' where you can put all the initilaization code that rely on services provided by VisualStudio.
''' </summary>
Protected Overrides Sub Initialize()
    Trace.WriteLine(String.Format(CultureInfo.CurrentCulture, "Entering Initialize() of: {0}", Me.GetType().Name))
    MyBase.Initialize()

            ' Add our command handlers for menu (commands must exist in the .vsct file)
    Dim mcs As OleMenuCommandService = TryCast(GetService(GetType(IMenuCommandService)), OleMenuCommandService)
    If Not mcs Is Nothing Then
                ' Create the command for the menu item.
                Dim menuCommandID As New CommandID(GuidList.guidVSSDKAutoCmdSet, CInt(PkgCmdIDList.cmdidMyCommand))
        Dim menuItem As New MenuCommand(New EventHandler(AddressOf MenuItemCallback), menuCommandID)
        mcs.AddCommand(menuItem)
            End If
        End Sub
#End Region

''' <summary>
''' This function is the callback used to execute a command when the a menu item is clicked.
''' See the Initialize method to see how the menu item is associated to this function using
''' the OleMenuCommandService service and the MenuCommand class.
    ''' </summary>
    '<Snippet2>
    Private Sub MenuItemCallback(ByVal sender As Object, ByVal e As EventArgs)
        Dim dte As DTE
        dte = CType(GetService(GetType(DTE)), DTE)
        Dim myString As String = "Name is " & dte.Name + vbCrLf & "Version is " & dte.Version

        Dim windows As Windows = dte.Windows
        Dim window As Window = CType(windows.Item(EnvDTE.Constants.vsWindowKindOutput), Window)
        window.Visible = True

        Dim outputWindow As OutputWindow = CType(window.Object, OutputWindow)
        Dim outputWindowPane As OutputWindowPane = outputWindow.OutputWindowPanes.Add("Test")
        outputWindowPane.Activate()
        outputWindowPane.OutputString(myString)
    End Sub
    '</Snippet2>
End Class
