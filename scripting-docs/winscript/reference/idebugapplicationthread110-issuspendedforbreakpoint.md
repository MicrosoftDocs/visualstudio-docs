---
title: "IDebugApplicationThread110::IsSuspendedForBreakPoint | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IDebugApplicationThread110::IsSuspendedForBreakPoint"
ms.assetid: 60688222-557f-4a43-a19b-846cee393cd0
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugApplicationThread110::IsSuspendedForBreakPoint
Determines whether [IDebugApplicationThreadEvents110::OnSuspendForBreakPoint](../../winscript/reference/idebugapplicationthreadevents110-onsuspendforbreakpoint.md) has been called on this thread and has not yet completed.  
  
> [!IMPORTANT]
> [IDebugApplicationThread110 Interface](../../winscript/reference/idebugapplicationthread110-interface.md) is implemented by PDM v11.0 and greater. Found in activdbg100.h.  
  
## Syntax  
  
```cpp  
HRESULT IsSuspendedForBreakPoint([out, annotation("_Out_")] BOOL * pfIsSuspended);  
```  
  
#### Parameters  
 `pfIsSuspended`  
 [out] `true` if the thread is suspended for a breakpoint, otherwise `false`.  
  
## See also  
 [IDebugApplicationThread110 Interface](../../winscript/reference/idebugapplicationthread110-interface.md)