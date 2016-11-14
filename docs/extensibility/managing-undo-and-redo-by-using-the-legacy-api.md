---
title: "Managing Undo and Redo by Using the Legacy API | Microsoft Docs"
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
  - "editors [Visual Studio SDK], legacy - undo management"
ms.assetid: 838c0ddf-fdf3-4df1-8d21-79610b8ba0b1
caps.latest.revision: 14
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
# Managing Undo and Redo by Using the Legacy API
Editors must support undo operations that let users reverse their recent changes when they modify code. Most editors implemented under [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] and the [!INCLUDE[dnprdnshort](../code-quality/includes/dnprdnshort_md.md)] can have undo support automatically provided by the integrated development environment (IDE).  
  
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