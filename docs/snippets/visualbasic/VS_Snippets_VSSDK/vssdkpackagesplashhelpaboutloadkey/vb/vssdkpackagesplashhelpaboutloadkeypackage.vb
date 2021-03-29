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
'<Snippet1>
<InstalledProductRegistration(True, Nothing, Nothing, Nothing)> _
<DefaultRegistryRoot("Software\Microsoft\VisualStudio\8.0")> _
<PackageRegistration(UseManagedResourcesOnly:=True)> _
<Guid("EEE474A0-083B-4e9c-B453-F6FCCEDA2577")> _
Public NotInheritable Class PackageSplashHelpAboutLoadKey
    Inherits Package
    Implements IVsInstalledProduct
    '</Snippet1>

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
#End Region

    '<Snippet2>
    Public Function IdBmpSplash(ByRef pIdBmp As UInteger) As Integer _
        Implements IVsInstalledProduct.IdBmpSplash
        pIdBmp = 300
        Return VSConstants.S_OK
    End Function
    Public Function IdIcoLogoForAboutbox(ByRef pIdIco As UInteger) As Integer _
        Implements IVsInstalledProduct.IdIcoLogoForAboutbox
        pIdIco = 400
        Return VSConstants.S_OK
    End Function
    Public Function OfficialName(ByRef pbstrName As String) As Integer _
        Implements IVsInstalledProduct.OfficialName
        pbstrName = GetResourceString("@101")
        Return VSConstants.S_OK
    End Function
    Public Function ProductDetails(ByRef pbstrProductDetails As String) As Integer _
        Implements IVsInstalledProduct.ProductDetails
        pbstrProductDetails = GetResourceString("@102")
        Return VSConstants.S_OK
    End Function
    Public Function ProductID(ByRef pbstrPID As String) As Integer _
        Implements IVsInstalledProduct.ProductID
        pbstrPID = GetResourceString("@104")
        Return VSConstants.S_OK
    End Function
    Public Function GetResourceString(ByVal resourceName As String) As String
        Dim resourceValue As String
        Dim resourceManager As IVsResourceManager = DirectCast(GetService(GetType(SVsResourceManager)), IVsResourceManager)
        If resourceManager Is Nothing Then
            Throw New InvalidOperationException("Could not get SVsResourceManager service. Make sure that the package is sited before calling this method")
        End If
        Dim packageGuid As Guid = Me.[GetType]().GUID
        Dim hr As Integer = resourceManager.LoadResourceString(packageGuid, -1, resourceName, resourceValue)
        Microsoft.VisualStudio.ErrorHandler.ThrowOnFailure(hr)
        Return resourceValue
    End Function
    '</Snippet2>
End Class
