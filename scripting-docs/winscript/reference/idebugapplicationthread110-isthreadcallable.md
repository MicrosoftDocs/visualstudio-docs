---
title: "IDebugApplicationThread110::IsThreadCallable | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IDebugApplicationThread110::IsThreadCallable"
ms.assetid: 2a75a366-801d-47e0-bba3-51aa669e03a7
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugApplicationThread110::IsThreadCallable
Determines whether this thread is in a state that will process calls made using the PDM's thread switching mechanisms, such as SynchronousCallInThread.  
  
> [!IMPORTANT]
> [IDebugApplicationThread110 Interface](../../winscript/reference/idebugapplicationthread110-interface.md) is implemented by PDM v11.0 and greater. Found in activdbg100.h.  
  
## Syntax  
  
```cpp  
HRESULT IsThreadCallable([out, annotation("_Out_")] BOOL * pfIsCallable);  
```  
  
#### Parameters  
 `pfIsCallable`  
 [out] `true` if the thread is callable, otherwise `false`.  
  
## See also  
 [IDebugApplicationThread110 Interface](../../winscript/reference/idebugapplicationthread110-interface.md)