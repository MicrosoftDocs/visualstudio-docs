---
title: "How to: Use Linked Undo Management | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "editors [Visual Studio SDK], legacy - linked undo management"
ms.assetid: af5cc22a-c9cf-45b1-a894-1022d563f3ca
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# How to: Use Linked Undo Management
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Linked undo allows the user to simultaneously undo the same edits in multiple files. For example, simultaneous text changes across multiple program files, such as a header file and a Visual C++ file, is a linked undo transaction. Linked undo capability is built into the environment's implementation of the undo manager, and <xref:Microsoft.VisualStudio.TextManager.Interop.IVsLinkedUndoTransactionManager> lets you manipulate this capability. Linked undo is implemented by a parent undo unit that can link separate undo stacks together to be treated as a single undo unit. The procedure for using linked undo is detailed in the following section.  
  
### To use linked undo  
  
1. Call `QueryService` on `SVsLinkedUndoManager` to get a pointer to `IVsLinkedUndoTransactionManager`.  
  
2. Create the initial parent linked undo unit by calling <xref:Microsoft.VisualStudio.TextManager.Interop.IVsLinkedUndoTransactionManager.OpenLinkedUndo%2A>. This sets the starting point for a set of undo stacks to be grouped into linked undo stacks. In the `OpenLinkedUndo` method you will also need to specify whether you want the linked undo to be strict or non-strict. Non-strict linked undo behavior means that some of the documents with linked undo siblings can close and still leave the other linked undo siblings on their stacks. Strict linked undo behavior specifies that all the linked undo sibling stacks have to be undone together or not at all. Add the subsequent linked undo stacks by calling [IOleUndoManager::Add](/windows/desktop/api/ocidl/nf-ocidl-ioleundomanager-add) method.  
  
3. Call <xref:Microsoft.VisualStudio.TextManager.Interop.IVsLinkedUndoTransactionManager.CloseLinkedUndo%2A> to roll back all of the linked undo units as one.  
  
    > [!NOTE]
    > To implement linked undo management in an editor, add undo management. For more information on implementing linked undo management, see [How to: Implement Undo Management](../extensibility/how-to-implement-undo-management.md).  
  
## See Also  
 <xref:Microsoft.VisualStudio.TextManager.Interop.IVsCompoundAction>   
 [IOleParentUndoUnit](/windows/desktop/api/ocidl/nn-ocidl-ioleparentundounit)   
 [IOleUndoUnit](/windows/desktop/api/ocidl/nn-ocidl-ioleundounit)   
 [How to: Implement Undo Management](../extensibility/how-to-implement-undo-management.md)
