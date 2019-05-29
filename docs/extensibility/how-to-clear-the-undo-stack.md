---
title: "How to: Clear the Undo Stack | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "editors [Visual Studio SDK], legacy - clear undo stack"
ms.assetid: 2200d2d4-7f58-401c-87fc-ddd32d368193
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# How to: Clear the undo stack
The following procedure below explains how to clear the undo stack.

## To clear the undo stack

1. To clear the undo stack use the [IOleUndoManager::DiscardFrom](/windows/desktop/api/ocidl/nf-ocidl-ioleundomanager-discardfrom) method. The following is an example of this:

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

## See also
- [How to: Implement undo management](../extensibility/how-to-implement-undo-management.md)