---
title: "Managing Undo and Redo by Using the Legacy API | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "editors [Visual Studio SDK], legacy - undo management"
ms.assetid: 838c0ddf-fdf3-4df1-8d21-79610b8ba0b1
caps.latest.revision: 15
ms.author: gregvanl
manager: jillfra
---
# Managing Undo and Redo by Using the Legacy API
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Editors must support undo operations that let users reverse their recent changes when they modify code. Most editors implemented under [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] and the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] can have undo support automatically provided by the integrated development environment (IDE).  
  
## In This Section  
 [How to: Implement Undo Management](../extensibility/how-to-implement-undo-management.md)  
 Provides undo capability for editors with single or multiple views.  
  
 [How to: Clear the Undo Stack](../extensibility/how-to-clear-the-undo-stack.md)  
 Describes how to clear an undo stack.  
  
 [How to: Use Linked Undo Management](../extensibility/how-to-use-linked-undo-management.md)  
 Incorporates linked undo management into your editor.  
  
## Reference  
 <xref:Microsoft.VisualStudio.TextManager.Interop.IVsChangeTrackingUndoManager>  
 Provides undo management for an editor that supports multiple views.  
  
## Related Sections
