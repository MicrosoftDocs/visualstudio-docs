---
title: "IDE Constants | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "IDE, errors"
  - "logical views"
  - "errors [Visual Studio], IDE"
  - "UI context constants"
  - "constants, Visual Studio IDE"
  - "IDE, constants"
  - "physical views"
ms.assetid: 5030e70a-241d-474a-ba8c-e3b1cf947ff0
caps.latest.revision: 23
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# IDE Constants
The <xref:Microsoft.VisualStudio.VSConstants> class provides constants that are specific to the integrated development environment (IDE) and that were previously defined only in header files.  
  
## Logical and Physical Views  
  
|Value|Description|  
|-----------|-----------------|  
|<xref:Microsoft.VisualStudio.VSConstants.LOGVIEWID_Code>|<xref:Microsoft.VisualStudio.VSConstants.GUID_VSStandardCommandSet97> `cmdidOpenWith` handlers should pass this value to the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShellOpenDocument.OpenStandardEditor%2A> method to get the **Open With** dialog box, in this case on possible Code views.|  
|<xref:Microsoft.VisualStudio.VSConstants.LOGVIEWID_Debugging>|<xref:Microsoft.VisualStudio.VSConstants.GUID_VSStandardCommandSet97> `cmdidOpenWith` handlers pass this value to the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShellOpenDocument.OpenStandardEditor%2A> method to get the **Open With** dialog box, in this case populated with possible <xref:Microsoft.VisualStudio.VSConstants.LOGVIEWID_Debugging> debugging views which map to the same view as <xref:Microsoft.VisualStudio.VSConstants.LOGVIEWID_Code>.|  
|<xref:Microsoft.VisualStudio.VSConstants.LOGVIEWID_Designer>|<xref:Microsoft.VisualStudio.VSConstants.GUID_VSStandardCommandSet97> `cmdidOpenWith` handlers pass this value to the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShellOpenDocument.OpenStandardEditor%2A> method to get the **Open With** dialog box, in this case to **View Form** designer views.|  
|<xref:Microsoft.VisualStudio.VSConstants.LOGVIEWID_Primary>|<xref:Microsoft.VisualStudio.VSConstants.GUID_VSStandardCommandSet97> `cmdidOpenWith` handlers pass this value to the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShellOpenDocument.OpenStandardEditor%2A> method to get the **Open With** dialog box, in this case the default/primary view of the editor factory.|  
|<xref:Microsoft.VisualStudio.VSConstants.LOGVIEWID_TextView>|<xref:Microsoft.VisualStudio.VSConstants.GUID_VSStandardCommandSet97> `cmdidOpenWith` handlers pass this value to the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShellOpenDocument.OpenStandardEditor%2A> method to get the **Open With** dialog box, in this for a document or data text editor view.|  
|<xref:Microsoft.VisualStudio.VSConstants.LOGVIEWID_UserChooseView>|<xref:Microsoft.VisualStudio.VSConstants.GUID_VSStandardCommandSet97> `cmdidOpenWith` handlers pass this value to the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShellOpenDocument.OpenStandardEditor%2A> method which prompts the user to choose which user-defined view to use.|  
  
## Editor Factory Flags  
  
|Value|Description|  
|-----------|-----------------|  
|<xref:Microsoft.VisualStudio.VSConstants.CEF_CLONEFILE>|An obsolete flag combined bitwise as the first parameter of the <xref:Microsoft.VisualStudio.Package.EditorFactory.CreateEditorInstance%2A> method.|  
|<xref:Microsoft.VisualStudio.VSConstants.CEF_OPENASNEW>|Combined bitwise as the first parameter of the <xref:Microsoft.VisualStudio.Package.EditorFactory.CreateEditorInstance%2A>, method, this indicates the editor factory should perform necessary fixes.|  
|<xref:Microsoft.VisualStudio.VSConstants.CEF_OPENFILE>|Combined bitwise as the first parameter of the <xref:Microsoft.VisualStudio.Package.EditorFactory.CreateEditorInstance%2A> method, this flag is mutually exclusive of <xref:Microsoft.VisualStudio.VSConstants.CEF_CLONEFILE>.|  
|<xref:Microsoft.VisualStudio.VSConstants.CEF_SILENT>|Combined bitwise as the first parameter of the <xref:Microsoft.VisualStudio.Package.EditorFactory.CreateEditorInstance%2A> method, this indicates the editor factory should create the editor without displaying a user interface (UI).|  
  
## Visual Studio Errors  
  
|Value|Description|  
|-----------|-----------------|  
|<xref:Microsoft.VisualStudio.VSConstants.VS_E_BUSY>|A constant returned by interfaces to asynchronous behavior when the object in question in already busy|  
|<xref:Microsoft.VisualStudio.VSConstants.VS_E_INCOMPATIBLEDOCDATA>|An error HRESULT that is specific to [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] for "Incompatible document data".|  
|<xref:Microsoft.VisualStudio.VSConstants.VS_E_PACKAGENOTLOADED>|An error HRESULT that is specific to [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] and that indicates "Package not loaded."|  
|<xref:Microsoft.VisualStudio.VSConstants.VS_E_PROJECTALREADYEXISTS>|An error HRESULT that is specific to [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] and that indicates that the "Project already exists."|  
|<xref:Microsoft.VisualStudio.VSConstants.VS_E_PROJECTMIGRATIONFAILED>|An error HRESULT that is specific to [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] and that indicates "Project configuration failed."|  
|<xref:Microsoft.VisualStudio.VSConstants.VS_E_PROJECTNOTLOADED>|An error HRESULT that is specific to [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] and that indicates "Project not loaded."|  
|<xref:Microsoft.VisualStudio.VSConstants.VS_E_SOLUTIONALREADYOPEN>|An error HRESULT that is specific to [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] and that indicates "Solution already open."|  
|<xref:Microsoft.VisualStudio.VSConstants.VS_E_SOLUTIONNOTOPEN>|An error HRESULT that is specific to [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] and that indicates "Solution not open."|  
|<xref:Microsoft.VisualStudio.VSConstants.VS_E_SPECIFYING_OUTPUT_UNSUPPORTED>|Returned by build interfaces that have parameters for specifying an array from the <xref:Microsoft.VisualStudio.Shell.Interop.IVsOutput> interface, but the implementation can only apply the method to all outputs.|  
|<xref:Microsoft.VisualStudio.VSConstants.VS_E_UNSUPPORTEDFORMAT>|The <xref:Microsoft.VisualStudio.Package.EditorFactory.CreateEditorInstance%2A> method returns this value if the document has a format that cannot be opened in the editor.|  
|<xref:Microsoft.VisualStudio.VSConstants.VS_E_WIZARDBACKBUTTONPRESS>|An HRESULT value that indicates that the user hit the back button in a [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] wizard.|  
  
## Visual Studio Constants  
  
|Value|Description|  
|-----------|-----------------|  
|<xref:Microsoft.VisualStudio.VSConstants.VS_S_PROJECTFORWARDED>|An error HRESULT that is specific to [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] and that indicates "Project forwarded."|  
|<xref:Microsoft.VisualStudio.VSConstants.VS_S_TBXMARKER>|A constant that is specific to [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] for a "Toolbox marker."|  
|<xref:Microsoft.VisualStudio.VSConstants.VSM_ENTERMODAL>|A constant that is specific to [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] for broadcasting a notification message via the <xref:Microsoft.VisualStudio.Shell.Interop.IVsBroadcastMessageEvents.OnBroadcastMessage%2A> method which indicates the beginning of modality.|  
|<xref:Microsoft.VisualStudio.VSConstants.VSM_EXITMODAL>|A constant that is specific to [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] for broadcasting a notification message via the <xref:Microsoft.VisualStudio.Shell.Interop.IVsBroadcastMessageEvents.OnBroadcastMessage%2A> method that indicates the end of modality.|  
|<xref:Microsoft.VisualStudio.VSConstants.VSM_TOOLBARMETRICSCHANGE>|A constant that is specific to [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] for broadcasting a notification message via the <xref:Microsoft.VisualStudio.Shell.Interop.IVsBroadcastMessageEvents.OnBroadcastMessage%2A> method indicating that the command bar metrics have changed.|  
|<xref:Microsoft.VisualStudio.VSConstants.VSCOOKIE_NIL>|A constant that is specific to [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] that indicates that a cookie has not been set.|  
|<xref:Microsoft.VisualStudio.VSConstants.VSITEMID_NIL>|A [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] item identifier that represents the absence of a project item. This value is used when there is no current selection.|  
|<xref:Microsoft.VisualStudio.VSConstants.VSITEMID_ROOT>|A [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] item identifier that represents the root of a project hierarchy and is used to identify the entire hierarchy, as opposed to a single item.|  
|<xref:Microsoft.VisualStudio.VSConstants.VSITEMID_SELECTION>|A [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] item identifier that represents the currently selected item or items, which can include the root of the hierarchy.|  
  
## IVsSelectionEvents  
 Describes what component of the IDE has just been selected, in an <xref:Microsoft.VisualStudio.Shell.Interop.IVsSelectionEvents.OnElementValueChanged%2A> call, for example.  
  
|Constant|Value|  
|--------------|-----------|  
|<xref:Microsoft.VisualStudio.VSConstants.DocumentFrame>|0x2|  
|<xref:Microsoft.VisualStudio.VSConstants.PropertyBrowserSID>|0x4|  
|<xref:Microsoft.VisualStudio.VSConstants.StartupProject>|0x3|  
|<xref:Microsoft.VisualStudio.VSConstants.UndoManager>|0x0|  
|<xref:Microsoft.VisualStudio.VSConstants.UserContext>|0x5|  
|<xref:Microsoft.VisualStudio.VSConstants.WindowFrame>|0x1|  
  
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
  
## Component Selector Dialog Constants  
  
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
  
## See Also  
 [IDE-Defined Commands for Extending Project Systems](../extensibility/internals/ide-defined-commands-for-extending-project-systems.md)