---
title: "Walkthrough: Creating a Core Editor and Registering an Editor File Type | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "editors [Visual Studio SDK], legacy - walkthrough"
ms.assetid: 24d2bffd-a35c-46db-8515-fd60b884b7fb
caps.latest.revision: 30
ms.author: gregvanl
manager: jillfra
---
# Walkthrough: Creating a Core Editor and Registering an Editor File Type
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This walkthrough demonstrates how to create a VSPackage that starts the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] core editor when a file that has the .myext file name extension is loaded.  
  
## Prerequisites  
 To follow this walkthrough, you must install the Visual Studio SDK. For more information, see [Visual Studio SDK](../extensibility/visual-studio-sdk.md).  
  
## Locations for the Visual Studio Package Project template  
 The Visual Studio Package project template can be found in three different locations in the **New Project** dialog:  
  
1. Under Visual Basic Extensibility. The default language of the project is Visual Basic.  
  
2. Under C# Extensibility. The default language of the project is C#.  
  
3. Under Other Project Types Extensibility. The default language of the project is C++.  
  
### To create the VSPackage  
  
- Start [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] and create a [!INCLUDE[csprcs](../includes/csprcs-md.md)] VSPackage named `MyPackage`, as outlined in [Walkthrough: Creating a Menu Command VSPackage](https://msdn.microsoft.com/d699c149-5d1e-47ff-94c7-e1222af02c32).  
  
### To add the editor factory  
  
1. Right-click the **MyPackage** project, point to **Add** and then click **Class**.  
  
2. In the **Add New Item** dialog box, make sure the **Class** template is selected, type `EditorFactory.cs` for the name, and then click **Add** to add the class to your project.  
  
     The EditorFactory.cs file should be automatically opened.  
  
3. Reference the following assemblies from your code.  
  
    ```vb  
    Imports System.Runtime.InteropServices  
    Imports Microsoft.VisualStudio  
    Imports Microsoft.VisualStudio.Shell  
    Imports Microsoft.VisualStudio.Shell.Interop  
    Imports Microsoft.VisualStudio.OLE.Interop  
    Imports Microsoft.VisualStudio.TextManager.Interop  
    Imports IOleServiceProvider = Microsoft.VisualStudio.OLE.Interop.IServiceProvider  
    ```  
  
    ```csharp  
    using System.Runtime.InteropServices;  
    using Microsoft.VisualStudio;  
    using Microsoft.VisualStudio.Shell;  
    using Microsoft.VisualStudio.Shell.Interop;  
    using Microsoft.VisualStudio.OLE.Interop;  
    using Microsoft.VisualStudio.TextManager.Interop;  
    using IOleServiceProvider = Microsoft.VisualStudio.OLE.Interop.IServiceProvider;  
  
    ```  
  
4. Add a GUID to the `EditorFactory` class by adding the `Guid` attribute immediately before the class declaration.  
  
     You can generate a new GUID by using the guidgen.exe program at the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] command prompt, or by clicking **Create GUID** on the **Tools** menu. The GUID used here is only an example; do not use it in your project.  
  
    ```vb  
    <Guid("0eea3187-c5fa-48d4-aa72-b5eecd3b17b1")> _  
    ```  
  
    ```csharp  
    [Guid("0eea3187-c5fa-48d4-aa72-b5eecd3b17b1")]   
    ```  
  
5. In the class definition, add two private variables to contain the parent package and a service provider.  
  
    ```vb  
    Class EditorFactory  
        Private parentPackage As Package  
        Private serviceProvider As IOleServiceProvider  
    ```  
  
    ```csharp  
    class EditorFactory  
    {  
        private Package parentPackage;  
        private IOleServiceProvider serviceProvider;  
    }  
  
    ```  
  
6. Add a public class constructor that takes one parameter of type <xref:Microsoft.VisualStudio.Shell.Package>:  
  
    ```vb  
    Public Sub New(ByVal parentPackage As Package)  
        Me.parentPackage = parentPackage  
    End Sub  
    ```  
  
    ```csharp  
    public EditorFactory(Package parentPackage)  
    {  
        this.parentPackage = parentPackage;  
    }  
    ```  
  
7. Modify the `EditorFactory` class declaration to derive from the <xref:Microsoft.VisualStudio.Shell.Interop.IVsEditorFactory> interface.  
  
    ```vb  
    Class EditorFactory Implements IVsEditorFacto  
    ```  
  
    ```csharp  
    class EditorFactory : IVsEditorFactory  
  
    ```  
  
8. Right-click <xref:Microsoft.VisualStudio.Shell.Interop.IVsEditorFactory>, click **Implement Interface**, and then click **Implement Interface Explicitly**.  
  
     This adds the four methods that must be implemented in the <xref:Microsoft.VisualStudio.Shell.Interop.IVsEditorFactory> interface.  
  
9. Replace the contents of the `IVsEditorFactory.Close` method with the following code.  
  
    ```vb  
    Return VSConstants.S_OK  
    ```  
  
    ```csharp  
    return VSConstants.S_OK;  
    ```  
  
10. Replace the contents of the `IVsEditorFactory.SetSite` with the following code.  
  
    ```vb  
    Me.serviceProvider = psp  
    Return VSConstants.S_OK  
    ```  
  
    ```csharp  
    this.serviceProvider = psp;  
    return VSConstants.S_OK;  
    ```  
  
11. Replace the contents of the `IVsEditorFactory.MapLogicalView` method with the following code.  
  
    ```vb  
    Dim retval As Integer = VSConstants.E_NOTIMPL  
    pbstrPhysicalView = Nothing ' We support only one view.  
    If rguidLogicalView.Equals(VSConstants.LOGVIEWID_Designer)OrElse _  
    rguidLogicalView.Equals(VSConstants.LOGVIEWID_Primary) Then  
        retval = VSConstants.S_OK  
    End If  
    Return retval  
    ```  
  
    ```csharp  
    int retval = VSConstants.E_NOTIMPL;  
    pbstrPhysicalView = null;   // We support only one view.  
    if (rguidLogicalView.Equals(VSConstants.LOGVIEWID_Designer) ||  
    rguidLogicalView.Equals(VSConstants.LOGVIEWID_Primary))  
    {  
        retval = VSConstants.S_OK;  
    }  
    return retval;  
    ```  
  
12. Replace the contents of the `IVsEditorFactory.CreateEditorInstance` method with the following code.  
  
    ```vb  
    Dim retval As Integer = VSConstants.E_FAIL          
  
    ' Initialize these to empty to start with   
    ppunkDocView = IntPtr.Zero  
    ppunkDocData = IntPtr.Zero  
    pbstrEditorCaption = ""  
    pguidCmdUI = Guid.Empty  
    pgrfCDW = 0  
  
    If (grfCreateDoc And (VSConstants.CEF_OPENFILE Or _  
    VSConstants.CEF_SILENT)) = 0 Then  
        Throw New ArgumentException("Only Open or Silent is valid")  
    End If  
    If punkDocDataExisting <> IntPtr.Zero Then  
        Return VSConstants.VS_E_INCOMPATIBLEDOCDATA  
    End If  
  
    ' Instantiate a text buffer of type VsTextBuffer.   
    ' Note: we only need an IUnknown (object) interface for   
    ' this invocation.   
    Dim clsidTextBuffer As Guid = GetType(VsTextBufferClass).GUID  
    Dim iidTextBuffer As Guid = VSConstants.IID_IUnknown  
    Dim pTextBuffer As Object = pTextBuffer = _  
    parentPackage.CreateInstance(clsidTextBuffer, iidTextBuffer, _  
    GetType(Object))  
  
    If Not pTextBuffer Is Nothing Then  
        ' "Site" the text buffer with the service provider we were   
        ' provided.   
        Dim textBufferSite As IObjectWithSite = TryCast(pTextBuffer, _  
        IObjectWithSite)  
        If Not textBufferSite Is Nothing Then  
            textBufferSite.SetSite(Me.serviceProvider)  
        End If  
  
        ' Instantiate a code window of type IVsCodeWindow.   
        Dim clsidCodeWindow As Guid = GetType(VsCodeWindowClass).GUID  
        Dim iidCodeWindow As Guid = GetType(IVsCodeWindow).GUID  
        Dim pCodeWindow As IVsCodeWindow = _  
        CType(Me.parentPackage.CreateInstance(clsidCodeWindow, _  
        iidCodeWindow, GetType(IVsCodeWindow)), IVsCodeWindow)  
        If Not pCodeWindow Is Nothing Then  
            ' Give the text buffer to the code window.   
            ' We are giving up ownership of the text buffer!   
            pCodeWindow.SetBuffer(CType(pTextBuffer, IVsTextLines))  
  
            ' Now tell the caller about all this new stuff   
            ' that has been created.   
            ppunkDocView = Marshal.GetIUnknownForObject(pCodeWindow)  
            ppunkDocData = Marshal.GetIUnknownForObject(pTextBuffer)  
  
            ' Specify the command UI to use so keypresses are   
            ' automatically dealt with.   
            pguidCmdUI = VSConstants.GUID_TextEditorFactory  
  
            ' This caption is appended to the filename and   
            ' lets us know our invocation of the core editor   
            ' is up and running.   
            pbstrEditorCaption = " [MyPackage]"  
  
            retval = VSConstants.S_OK  
        End If  
    End If  
    Return retval  
    ```  
  
    ```csharp  
    int retval = VSConstants.E_FAIL;  
  
    // Initialize these to empty to start with  
    ppunkDocView       = IntPtr.Zero;  
    ppunkDocData       = IntPtr.Zero;  
    pbstrEditorCaption = "";  
    pguidCmdUI         = Guid.Empty;   
    pgrfCDW            = 0;  
  
    if ((grfCreateDoc & (VSConstants.CEF_OPENFILE |   
          VSConstants.CEF_SILENT)) == 0)  
    {   
        throw new ArgumentException("Only Open or Silent is valid");  
    }  
    if (punkDocDataExisting != IntPtr.Zero)  
    {  
        return VSConstants.VS_E_INCOMPATIBLEDOCDATA;  
    }  
  
    // Instantiate a text buffer of type VsTextBuffer.  
    // Note: we only need an IUnknown (object) interface for   
    // this invocation.  
    Guid clsidTextBuffer = typeof(VsTextBufferClass).GUID;  
    Guid iidTextBuffer   = VSConstants.IID_IUnknown;  
    object pTextBuffer   = pTextBuffer = parentPackage.CreateInstance(  
          ref clsidTextBuffer,  
          ref iidTextBuffer,  
          typeof(object));  
  
    if (pTextBuffer != null)  
    {  
        // "Site" the text buffer with the service provider we were  
        // provided.  
        IObjectWithSite textBufferSite = pTextBuffer as IObjectWithSite;  
        if (textBufferSite != null)  
        {  
            textBufferSite.SetSite(this.serviceProvider);  
        }  
  
        // Instantiate a code window of type IVsCodeWindow.  
        Guid clsidCodeWindow = typeof(VsCodeWindowClass).GUID;  
        Guid iidCodeWindow   = typeof(IVsCodeWindow).GUID;  
        IVsCodeWindow pCodeWindow =  
        (IVsCodeWindow)this.parentPackage.CreateInstance(   
              ref clsidCodeWindow,  
              ref iidCodeWindow,  
              typeof(IVsCodeWindow));  
        if (pCodeWindow != null)  
        {  
            // Give the text buffer to the code window.  
            // We are giving up ownership of the text buffer!  
            pCodeWindow.SetBuffer((IVsTextLines)pTextBuffer);  
  
            // Now tell the caller about all this new stuff   
            // that has been created.  
            ppunkDocView = Marshal.GetIUnknownForObject(pCodeWindow);  
            ppunkDocData = Marshal.GetIUnknownForObject(pTextBuffer);  
  
            // Specify the command UI to use so keypresses are   
            // automatically dealt with.  
            pguidCmdUI = VSConstants.GUID_TextEditorFactory;  
  
            // This caption is appended to the filename and  
            // lets us know our invocation of the core editor   
            // is up and running.  
            pbstrEditorCaption = " [MyPackage]";  
  
            retval = VSConstants.S_OK;  
        }   
    }   
    return retval;   
    ```  
  
13. Compile the project and make sure there are no errors.  
  
### To register the editor factory  
  
1. In **Solution Explorer**, double-click the Resources.resx file to open it to the string table, in which the entry **String1 is** selected.  
  
2. Change the name of the identifier to `IDS_EDITORNAME` and the text to **MyPackage Editor.** This string will appear as the name of your editor.  
  
3. Open the VSPackage.resx file and add a new string, set the name to **101** and the value to `IDS_EDITORNAME`. This provides the package with a resource ID to access the string you just created.  
  
    > [!NOTE]
    > If the VSPackage.resx file contains another string that the `name` attribute set to **101**, substitute another unique, numeric value, here and in the following steps.  
  
4. In **Solution Explorer**, open the MyPackagePackage.cs file.  
  
     This is the main package file.  
  
5. Add the following user attributes just before the `Guid` attribute.  
  
    ```vb  
    <ProvideEditorFactoryAttribute(GetType(EditorFactory), 101)> _  
    <ProvideEditorExtensionAttribute(GetType(EditorFactory), _  
          ".myext", 32, NameResourceID:=101 )> _  
    ```  
  
    ```csharp  
    [ProvideEditorFactory(typeof(EditorFactory), 101)]  
    [ProvideEditorExtension(typeof(EditorFactory),   
          ".myext", 32, NameResourceID = 101)]   
    ```  
  
     The <xref:Microsoft.VisualStudio.Shell.ProvideEditorExtensionAttribute> attribute associates the .myext file extension with your editor factory so that any time a file that has that extension is loaded, your editor factory is invoked.  
  
6. Add a private variable to the `MyPackage` class, just before the constructor, and give it the type `EditorFactory`.  
  
    ```vb  
    Private editorFactory As EditorFactory  
    ```  
  
    ```csharp  
    private EditorFactory editorFactory;  
    ```  
  
7. Find the `Initialize` method (you may have to open the `Package Members` hidden region) and add the following code after the call to `base.Initialize()`.  
  
    ```vb  
    'Create our editor factory and register it.   
    Me.editorFactory = New EditorFactory(Me)  
    MyBase.RegisterEditorFactory(Me.editorFactory)  
    ```  
  
    ```csharp  
    // Create our editor factory and register it.  
    this.editorFactory = new EditorFactory(this);  
    base.RegisterEditorFactory(this.editorFactory);  
  
    ```  
  
8. Compile the program and make sure there are no errors.  
  
     This step registers the editor factory in the experimental registry hive for [!INCLUDE[vsprvs](../includes/vsprvs-md.md)]. If you are prompted to override the resource.h file, click **OK**.  
  
9. Create a sample file named TextFile1.myext.  
  
10. Press **F5** to open an instance of the experimental [!INCLUDE[vsprvs](../includes/vsprvs-md.md)].  
  
11. In the experimental [!INCLUDE[vsprvs](../includes/vsprvs-md.md)], on the **File** menu, point to **Open** and then click **File**.  
  
12. Find TextFile1.myext and then click **Open**.  
  
     The file should now be loaded.  
  
## Robust Programming  
 The [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] core editor handles a wide range of text-based file types and works closely with language services to provide a rich set of features such as syntax highlighting, brace matching, and IntelliSense word-completion and member-completion lists. If you are working with text-based files, then you can use the core editor together with a custom language service that supports your specific file types.  
  
 A VSPackage can invoke the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] core editor by supplying an editor factory. This editor factory is used any time a file that is associated with it is loaded. If the file is part of a project, then the core editor is automatically invoked unless overridden by your VSPackage. However, if the file is loaded outside of a project, then the core editor must be explicitly invoked by your VSPackage.  
  
 For more information about the core editor, see [Inside the Core Editor](../extensibility/inside-the-core-editor.md).  
  
## See Also  
 [Inside the Core Editor](../extensibility/inside-the-core-editor.md)   
 [Instantiating the Core Editor By Using the Legacy API](../extensibility/instantiating-the-core-editor-by-using-the-legacy-api.md)
