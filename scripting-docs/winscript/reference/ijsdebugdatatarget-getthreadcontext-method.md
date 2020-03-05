---
title: "IJsDebugDataTarget::GetThreadContext Method | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IJsDebugDataTarget.GetThreadContext"
apilocation: 
  - "jscript9diag.dll"
ms.assetid: faf2a689-6c49-4a7d-b5a6-2b323e2257a7
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IJsDebugDataTarget::GetThreadContext Method
Retrieves context for given thread.  
  
## Syntax  
  
```cpp
HRESULT GetThreadContext(  
   DWORD threadId,  
   ULONG32 contextFlags,  
   ULONG32 contextSize,  
   void *pContext  
);  
```  
  
#### Parameters  
 `threadId`  
 [in] Thread running in the target process.  
  
 `contextFlags`  
 [in] Specifies context flags. This is same as the ContextFlags field of CONTEXT (for more information, see winnt.h, search for CONTEXT_ALL).  
  
 `contextSize`  
 [in] The size of the buffer specified by pContext.  
  
 `pContext`  
 [out] Receives platform-specific CONTEXT structure into the buffer specified by pContext.  
  
## Return Value  
  
## Requirements  
 **Header:** jscript9diag.h  
  
## See also  
 [IJsDebugDataTarget Interface](../../winscript/reference/ijsdebugdatatarget-interface.md)