---
title: "VisibilityItem Element | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "VisibilityItem element (VSCT XML schema)"
  - "VSCT XML schema elements, VisibilityItem"
ms.assetid: 0932f551-972d-4194-84bb-426e3e4375e4
caps.latest.revision: 14
ms.author: gregvanl
manager: jillfra
---
# VisibilityItem Element
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The `VisibilityItem` element determines the static visibility of commands and toolbars. Every entry identifies a command or menu, and also an associated command UI context. Visual Studio detects commands, menus, and toolbars, and their visibility, without loading the VSPackages that define them. The IDE uses the <xref:Microsoft.VisualStudio.Shell.Interop.IVsMonitorSelection.IsCmdUIContextActive%2A> method to determine whether a command UI context is active.  
  
 After the VSPackage is loaded, Visual Studio expects command visibility to be determined by the VSPackage rather than the `VisibilityItem`. To determine your command's visibility, you can implement either the <xref:Microsoft.VisualStudio.Shell.OleMenuCommand.BeforeQueryStatus> event handler or the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget.QueryStatus%2A> method, depending on how you have implemented your command.  
  
 A command or menu that has a `VisibilityItem` element appears only when the associated context is active. You can associate a single command, menu, or toolbar with one or more command UI contexts by including an entry for each command-context combination. If a command or menu is associated with multiple command UI contexts, then the command or menu is visible when any one of the associated command UI contexts is active.  
  
 The `VisibilityItem` element applies only to commands, menus, and toolbars, not to groups. An element that does not have a related `VisibilityItem` element is visible whenever its parent menu is active.  
  
## Syntax  
  
```  
<VisibilityItem  
  guid ="="cmdGuidMyProductCommands"  
  id=="cmdidAddWidget"  
  context="guidNotViewSourceMode"/>  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|guid|Required. The GUID of the GUID/ID command identifier.|  
|id|Required. The ID of the GUID/ID command identifier.|  
|context|Required. The UI context in which the command is visible.|  
|Condition|Optional. See [Conditional Attributes](../extensibility/vsct-xml-schema-conditional-attributes.md).|  
  
### Child Elements  
 None  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[VisibilityConstraints Element](../extensibility/visibilityconstraints-element.md)|The `VisibilityConstraints` element determines the static visibility of groups of commands and toolbars.|  
  
## Remarks  
 The standard Visual Studio UI contexts are defined in the *Visual Studio SDK installation path*\VisualStudioIntegration\Common\Inc\vsshlids.h file as well as in the <xref:Microsoft.VisualStudio.Shell.Interop.UIContextGuids> and <xref:Microsoft.VisualStudio.Shell.Interop.UIContextGuids80> classes. A more complete set of UI contexts is defined in the <xref:Microsoft.VisualStudio.VSConstants> class.  
  
## Example  
  
```  
<VisibilityConstraints>  
  <VisibilityItem guid="cmdSetGuidMyProductCommands"     id="cmdidAddWidget"  
    context="guidNotViewSourceMode"/>  
</VisibilityConstraints>  
```  
  
## See also  
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsMonitorSelection.IsCmdUIContextActive%2A>   
 <xref:Microsoft.VisualStudio.Shell.OleMenuCommand.BeforeQueryStatus>   
 <xref:Microsoft.VisualStudio.VSConstants>   
 <xref:Microsoft.VisualStudio.Shell.Interop.UIContextGuids>   
 <xref:Microsoft.VisualStudio.Shell.Interop.UIContextGuids80>   
 [VisibilityConstraints Element](../extensibility/visibilityconstraints-element.md)   
 [Visual Studio Command Table (.Vsct) Files](../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)
