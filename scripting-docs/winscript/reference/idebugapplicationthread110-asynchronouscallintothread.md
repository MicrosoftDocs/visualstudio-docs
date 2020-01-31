---
title: "IDebugApplicationThread110::AsynchronousCallIntoThread | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: 06b3031a-4aec-4a47-afaa-04642a4c4870
caps.latest.revision: 2
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugApplicationThread110::AsynchronousCallIntoThread
Makes an asynchronous call on the main thread.  
  
> [!IMPORTANT]
> [IDebugApplicationThread110 Interface](../../winscript/reference/idebugapplicationthread110-interface.md) is implemented by PDM v11.0 and greater. Found in activdbg100.h.  
  
## Syntax  
  
```cpp  
HRESULT AsynchronousCallInMainThread([in] IDebugThreadCall* pptc, [in] DWORD_PTR dwParam1, [in] DWORD_PTR dwParam2, [in] DWORD_PTR dwParam3);  
```  
  
#### Parameters  
 `pptc`  
 The [IDebugThreadCall Interface](../../winscript/reference/idebugthreadcall-interface.md) object to call.  
  
 `dwParam1`  
 The first parameter of the call.  
  
 `dwParam1`  
 The first parameter of the call.  
  
 `dwParam2`  
 The second parameter of the call.  
  
 `dwParam3`  
 The third parameter of the call.  
  
## See also  
 [IDebugApplication110 Interface](../../winscript/reference/idebugapplication110-interface.md)