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

    <PackageRegistration(UseManagedResourcesOnly := true), _ 
    InstalledProductRegistration("#110", "#112", "1.0", IconResourceID := 400), _    
    Guid(GuidList.guidVSSDKProgressStatusBarPkgString)> _
    Public NotInheritable Class VSSDKProgressStatusBarPackage
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
    End Sub

    '<Snippet1>
    Private Sub ProgressBarExample()
        Dim statusBar As IVsStatusbar = DirectCast(GetService(GetType(SVsStatusbar)), IVsStatusbar)
        Dim cookie As UInteger = 0
        Dim label As String = "Progress bar label..."

        ' Initialize the progress bar. 
        statusBar.Progress(cookie, 1, "", 0, 0)

        Dim i As UInteger = 0, total As UInteger = 100
        While i <= total
            ' Display incremental progress. 
            statusBar.Progress(cookie, 1, label, i, total)
            System.Threading.Thread.Sleep(1)
            i += 1
        End While

        ' Clear the progress bar. 
        statusBar.Progress(cookie, 0, "", 0, 0)
    End Sub
    '</Snippet1>
#End Region

End Class
