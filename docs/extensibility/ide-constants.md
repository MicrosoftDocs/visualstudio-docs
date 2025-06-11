---
title: IDE Constants
description: The VSConstants class provides constants specific to the IDE and that were previously defined only in header files.
ms.date: 03/22/2018
ms.topic: reference
helpviewer_keywords:
- IDE, errors
- logical views
- errors [Visual Studio], IDE
- UI context constants
- constants, Visual Studio IDE
- IDE, constants
- physical views
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# IDE constants

The <xref:Microsoft.VisualStudio.VSConstants> class provides constants that are specific to the integrated development environment (IDE) and that were previously defined only in header files.

## Logical and physical views

|Value|Description|
|-----------|-----------------|
|<xref:Microsoft.VisualStudio.VSConstants.LOGVIEWID.Code_guid>|<xref:Microsoft.VisualStudio.VSConstants.GUID_VSStandardCommandSet97> `cmdidOpenWith` handlers should pass this value to the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShellOpenDocument.OpenStandardEditor%2A> method to get the **Open With** dialog box, in this case on possible code views.|
|<xref:Microsoft.VisualStudio.VSConstants.LOGVIEWID.Debugging_guid>|<xref:Microsoft.VisualStudio.VSConstants.GUID_VSStandardCommandSet97> `cmdidOpenWith` handlers pass this value to the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShellOpenDocument.OpenStandardEditor%2A> method to get the **Open With** dialog box, in this case populated with possible <xref:Microsoft.VisualStudio.VSConstants.LOGVIEWID.Debugging_guid> debugging views which map to the same view as <xref:Microsoft.VisualStudio.VSConstants.LOGVIEWID.Code_guid>.|
|<xref:Microsoft.VisualStudio.VSConstants.LOGVIEWID.Designer_guid>|<xref:Microsoft.VisualStudio.VSConstants.GUID_VSStandardCommandSet97> `cmdidOpenWith` handlers pass this value to the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShellOpenDocument.OpenStandardEditor%2A> method to get the **Open With** dialog box, in this case to **View Form** designer views.|
|<xref:Microsoft.VisualStudio.VSConstants.LOGVIEWID.Primary_guid>|<xref:Microsoft.VisualStudio.VSConstants.GUID_VSStandardCommandSet97> `cmdidOpenWith` handlers pass this value to the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShellOpenDocument.OpenStandardEditor%2A> method to get the **Open With** dialog box, in this case the default/primary view of the editor factory.|
|<xref:Microsoft.VisualStudio.VSConstants.LOGVIEWID.TextView_guid>|<xref:Microsoft.VisualStudio.VSConstants.GUID_VSStandardCommandSet97> `cmdidOpenWith` handlers pass this value to the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShellOpenDocument.OpenStandardEditor%2A> method to get the **Open With** dialog box, in this for a document or data text editor view.|
|<xref:Microsoft.VisualStudio.VSConstants.LOGVIEWID.UserChooseView_guid>|<xref:Microsoft.VisualStudio.VSConstants.GUID_VSStandardCommandSet97> `cmdidOpenWith` handlers pass this value to the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShellOpenDocument.OpenStandardEditor%2A> method which prompts the user to choose which user-defined view to use.|

## Editor Factory Flags

|Value|Description|
|-----------|-----------------|
|[CEF.CloneFile](<xref:Microsoft.VisualStudio.VSConstants.CEF#Microsoft_VisualStudio_VSConstants_CEF_CloneFile>)|An obsolete flag combined bitwise as the first parameter of the <xref:Microsoft.VisualStudio.Package.EditorFactory.CreateEditorInstance%2A> method.|
|[CEF.OpenAsNew](<xref:Microsoft.VisualStudio.VSConstants.CEF#Microsoft_VisualStudio_VSConstants_CEF_OpenAsNew>)|Combined bitwise as the first parameter of the <xref:Microsoft.VisualStudio.Package.EditorFactory.CreateEditorInstance%2A>, method, this indicates the editor factory should perform necessary fixes.|
|[CEF.OpenFile](<xref:Microsoft.VisualStudio.VSConstants.CEF#Microsoft_VisualStudio_VSConstants_CEF_OpenFile>)|Combined bitwise as the first parameter of the <xref:Microsoft.VisualStudio.Package.EditorFactory.CreateEditorInstance%2A> method, this flag is mutually exclusive of [CEF.CloneFile](<xref:Microsoft.VisualStudio.VSConstants.CEF#Microsoft_VisualStudio_VSConstants_CEF_CloneFile>).|
|[CEF.Silent](<xref:Microsoft.VisualStudio.VSConstants.CEF#Microsoft_VisualStudio_VSConstants_CEF_Silent>)|Combined bitwise as the first parameter of the <xref:Microsoft.VisualStudio.Package.EditorFactory.CreateEditorInstance%2A> method, this indicates the editor factory should create the editor without displaying a user interface (UI).|

## Visual Studio errors

|Value|Description|
|-----------|-----------------|
|<xref:Microsoft.VisualStudio.VSConstants.VS_E_BUSY>|A constant returned by interfaces to asynchronous behavior when the object in question in already busy|
|<xref:Microsoft.VisualStudio.VSConstants.VS_E_INCOMPATIBLEDOCDATA>|An error HRESULT that is specific to Visual Studio for "Incompatible document data".|
|<xref:Microsoft.VisualStudio.VSConstants.VS_E_PACKAGENOTLOADED>|An error HRESULT that is specific to Visual Studio and that indicates "Package not loaded."|
|<xref:Microsoft.VisualStudio.VSConstants.VS_E_PROJECTALREADYEXISTS>|An error HRESULT that is specific to Visual Studio and that indicates that the "Project already exists."|
|<xref:Microsoft.VisualStudio.VSConstants.VS_E_PROJECTMIGRATIONFAILED>|An error HRESULT that is specific to Visual Studio and that indicates "Project configuration failed."|
|<xref:Microsoft.VisualStudio.VSConstants.VS_E_PROJECTNOTLOADED>|An error HRESULT that is specific to Visual Studio and that indicates "Project not loaded."|
|<xref:Microsoft.VisualStudio.VSConstants.VS_E_SOLUTIONALREADYOPEN>|An error HRESULT that is specific to Visual Studio and that indicates "Solution already open."|
|<xref:Microsoft.VisualStudio.VSConstants.VS_E_SOLUTIONNOTOPEN>|An error HRESULT that is specific to Visual Studio and that indicates "Solution not open."|
|<xref:Microsoft.VisualStudio.VSConstants.VS_E_SPECIFYING_OUTPUT_UNSUPPORTED>|Returned by build interfaces that have parameters for specifying an array from the <xref:Microsoft.VisualStudio.Shell.Interop.IVsOutput> interface, but the implementation can only apply the method to all outputs.|
|<xref:Microsoft.VisualStudio.VSConstants.VS_E_UNSUPPORTEDFORMAT>|The <xref:Microsoft.VisualStudio.Package.EditorFactory.CreateEditorInstance%2A> method returns this value if the document has a format that cannot be opened in the editor.|
|<xref:Microsoft.VisualStudio.VSConstants.VS_E_WIZARDBACKBUTTONPRESS>|An HRESULT value that indicates that the user hit the back button in a Visual Studio wizard.|

## Visual Studio constants

|Value|Description|
|-----------|-----------------|
|<xref:Microsoft.VisualStudio.VSConstants.VS_S_PROJECTFORWARDED>|An error HRESULT that is specific to Visual Studio and that indicates "Project forwarded."|
|<xref:Microsoft.VisualStudio.VSConstants.VS_S_TBXMARKER>|A constant that is specific to Visual Studio for a "Toolbox marker."|
|<xref:Microsoft.VisualStudio.VSConstants.VSM_ENTERMODAL>|A constant that is specific to Visual Studio for broadcasting a notification message via the <xref:Microsoft.VisualStudio.Shell.Interop.IVsBroadcastMessageEvents.OnBroadcastMessage%2A> method which indicates the beginning of modality.|
|<xref:Microsoft.VisualStudio.VSConstants.VSM_EXITMODAL>|A constant that is specific to Visual Studio for broadcasting a notification message via the <xref:Microsoft.VisualStudio.Shell.Interop.IVsBroadcastMessageEvents.OnBroadcastMessage%2A> method that indicates the end of modality.|
|<xref:Microsoft.VisualStudio.VSConstants.VSM_TOOLBARMETRICSCHANGE>|A constant that is specific to Visual Studio for broadcasting a notification message via the <xref:Microsoft.VisualStudio.Shell.Interop.IVsBroadcastMessageEvents.OnBroadcastMessage%2A> method indicating that the command bar metrics have changed.|
|<xref:Microsoft.VisualStudio.VSConstants.VSCOOKIE_NIL>|A constant that is specific to Visual Studio that indicates that a cookie has not been set.|
|[VSITEMID.Nil](<xref:Microsoft.VisualStudio.VSConstants.VSITEMID#Microsoft_VisualStudio_VSConstants_VSITEMID_Nil>)|A Visual Studio item identifier that represents the absence of a project item. This value is used when there is no current selection.|
|[VSITEMID.Root](<xref:Microsoft.VisualStudio.VSConstants.VSITEMID#Microsoft_VisualStudio_VSConstants_VSITEMID_Root>)|A Visual Studio item identifier that represents the root of a project hierarchy and is used to identify the entire hierarchy, as opposed to a single item.|
|[VSITEMID.Selection](<xref:Microsoft.VisualStudio.VSConstants.VSITEMID#Microsoft_VisualStudio_VSConstants_VSITEMID_Selection>)|A Visual Studio item identifier that represents the currently selected item or items, which can include the root of the hierarchy.|

## IVsSelectionEvents
 Describes what component of the IDE has just been selected, in an <xref:Microsoft.VisualStudio.Shell.Interop.IVsSelectionEvents.OnElementValueChanged%2A> call, for example.

|Constant|Value|
|--------------|-----------|
|[SelectionElement.DocumentFrame](<xref:Microsoft.VisualStudio.VSConstants.SelectionElement#Microsoft_VisualStudio_VSConstants_SelectionElement_DocumentFrame>)|0x2|
|[SelectionElement.PropertyBrowserSID](<xref:Microsoft.VisualStudio.VSConstants.SelectionElement#Microsoft_VisualStudio_VSConstants_SelectionElement_PropertyBrowserSID>)|0x4|
|[SelectionElement.StartupProject](<xref:Microsoft.VisualStudio.VSConstants.SelectionElement#Microsoft_VisualStudio_VSConstants_SelectionElement_StartupProject>)|0x3|
|[SelectionElement.UndoManager](<xref:Microsoft.VisualStudio.VSConstants.SelectionElement#Microsoft_VisualStudio_VSConstants_SelectionElement_UndoManager>)|0x0|
|[SelectionElement.UserContext](<xref:Microsoft.VisualStudio.VSConstants.SelectionElement#Microsoft_VisualStudio_VSConstants_SelectionElement_UserContext>)|0x5|
|[SelectionElement.WindowFrame](<xref:Microsoft.VisualStudio.VSConstants.SelectionElement#Microsoft_VisualStudio_VSConstants_SelectionElement_WindowFrame>)|0x1|

## VSSELELEMID
 Constants used to indicate a new selection state.

|Constant|Value|
|--------------|-----------|
|<xref:Microsoft.VisualStudio.VSConstants.VSSELELEMID>|2|
|<xref:Microsoft.VisualStudio.VSConstants.VSSELELEMID>|7|
|<xref:Microsoft.VisualStudio.VSConstants.VSSELELEMID>|4|
|<xref:Microsoft.VisualStudio.VSConstants.VSSELELEMID>|6|
|<xref:Microsoft.VisualStudio.VSConstants.VSSELELEMID>|3|
|<xref:Microsoft.VisualStudio.VSConstants.VSSELELEMID>|0|
|<xref:Microsoft.VisualStudio.VSConstants.VSSELELEMID>|5|
|<xref:Microsoft.VisualStudio.VSConstants.VSSELELEMID>|1|

## Component selector dialog constants

|Constant|Value|
|--------------|-----------|
|<xref:Microsoft.VisualStudio.VSConstants.CPDN_SELCHANGED>|WM_USER + 1280|
|<xref:Microsoft.VisualStudio.VSConstants.CPDN_SELDBLCLICK>|WM_USER + 1281|
|<xref:Microsoft.VisualStudio.VSConstants.CPPM_CLEARSELECTION>|WM_USER + 1290|
|<xref:Microsoft.VisualStudio.VSConstants.CPPM_GETSELECTION>|WM_USER + 1287|
|<xref:Microsoft.VisualStudio.VSConstants.CPPM_INITIALIZELIST>|WM_USER + 1285|
|<xref:Microsoft.VisualStudio.VSConstants.CPPM_INITIALIZETAB>|WM_USER + 1288|
|<xref:Microsoft.VisualStudio.VSConstants.CPPM_QUERYCANSELECT>|WM_USER + 1286|
|<xref:Microsoft.VisualStudio.VSConstants.CPPM_SETMULTISELECT>|WM_USER + 1289|

## See also

- [IDE-defined commands for extending project systems](../extensibility/internals/ide-defined-commands-for-extending-project-systems.md)
