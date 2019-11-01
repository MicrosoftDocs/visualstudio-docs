---
title: "IDebugApplication110::CallableWaitForHandles | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IDebugApplication110::CallableWaitForHandles"
ms.assetid: 02e79b60-0d67-47f9-bf78-b65a02c9c014
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugApplication110::CallableWaitForHandles
Waits for any of the specified handles to be signaled while allowing cross-thread calls to be posted to this thread. This method must be called from the debugger thread.  
  
> [!IMPORTANT]
> [IDebugApplication110 Interface](../../winscript/reference/idebugapplication110-interface.md) is implemented by PDM v11.0 and greater. Found in activdbg100.h.  
  
## Syntax  
  
```cpp  
HRESULT CallableWaitForHandles([in] DWORD handleCount, [in, size_is(handleCount)] const HANDLE* pHandles, [out] DWORD* pIndex);  
```  
  
#### Parameters  
 `handleCount`  
 The number of handles to wait for.  
  
 `pHandles`  
 The set of handles to wait for.  
  
 `pIndex`  
 When the HRESULT value is S_OK, the index into `pHandles` for the handle that was signaled.  
  
## See also  
 [IDebugApplication110 Interface](../../winscript/reference/idebugapplication110-interface.md)