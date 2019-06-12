---
title: "Document Windows | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "Visual Studio SDK, document windows"
ms.assetid: 50081d48-987f-43db-8bf9-51b7cf76e9c0
caps.latest.revision: 18
ms.author: gregvanl
manager: jillfra
---
# Document Windows
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

In Visual Studio, a *document window* is a framed child window that is associated with a multiple-document interface (MDI) window. Document windows are typically used for the display and modification of source code or text, but they can also host other functional types. Document windows:  
  
- Can be organized in separate horizontal or vertical tab groups in the parent MDI so that multiple files can be viewed at the same time.  
  
- Can be docked in any order in the parent MDI.  
  
- Can be floated freely.  
  
- Are linked in tab order to other MDI windows.  
  
  The commands for grouping, docking, and floating can be found on the shortcut menu for a document window tab.  
  
  For more information about window behavior in Visual Studio, see [Customizing window layouts](../../ide/customizing-window-layouts-in-visual-studio.md).  
  
## Document Window Implementation  
 Document windows are created by implementing an editor. The <xref:Microsoft.VisualStudio.Shell.Interop.IVsEditorFactory> interface creates document windows as part of instantiating an editor. For more information, see [Legacy Interfaces in the Editor](../../extensibility/legacy-interfaces-in-the-editor.md).  
  
> [!NOTE]
> To provide backward and forward navigation points in a window, implement the <xref:Microsoft.VisualStudio.Shell.Interop.IVsBackForwardNavigation> interface. The text editor uses text markers to identify navigation points in the document.  
  
## The Running Document Table  
 The IDE uses the running document table (RDT) to track the status of every document window. The RDT is the mechanism through which document windows are notified of events, such as when a solution is closed or when a file has been edited. For more information, see [Running Document Table](../../extensibility/internals/running-document-table.md).  
  
## See Also  
 [Delayed Document Loading](../../extensibility/internals/delayed-document-loading.md)
