---
title: "How to: Clear the Undo Stack | Microsoft Docs"
ms.custom: ""
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "editors [Visual Studio SDK], legacy - clear undo stack"
ms.assetid: 2200d2d4-7f58-401c-87fc-ddd32d368193
caps.latest.revision: 8
ms.author: "gregvanl"
manager: "ghogen"
---
# How to: Clear the Undo Stack
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The latest version of this topic can be found at [How to: Clear the Undo Stack](https://docs.microsoft.com/visualstudio/extensibility/how-to-clear-the-undo-stack).  
  
The following procedure below explains how to clear the undo stack.  
  
### To clear the undo stack  
  
1.  To clear the undo stack use the [IOleUndoManager::DiscardFrom](http://msdn.microsoft.com/library/windows/desktop/ms693799) method. The following is an example of this:  
  
    ```  
    HRESULT CCmdWindow::ClearUndoStack()  
    {  
      HRESULT hr = S_OK;  
  
      if (m_pUndoMgr == NULL)  
        {  
        IfFailGo(m_pTextLines->GetUndoManager(&m_pUndoMgr));  
        ASSERT(m_pUndoMgr != NULL, "",;);  
        }  
  
      IfFailGo(m_pUndoMgr->DiscardFrom(NULL));  
  
    Error:  
      return hr;  
    }  
    ```  
  
## See Also  
 [How to: Implement Undo Management](../extensibility/how-to-implement-undo-management.md)

