---
title: "IActiveScriptProfilerControl3::EnumHeap Method | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: 2799d06d-20dd-4c12-9646-554c0ea3606e
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptProfilerControl3::EnumHeap Method
Returns an interface ([IActiveScriptProfilerHeapEnum Interface](../../winscript/reference/iactivescriptprofilerheapenum-interface.md)) that can be used to iterate over the GC heap objects in the context of the associated script engine.  
  
 You can call this method in either debug or release mode. This method should be called when UI thread is idle. After the method has been called, no operations should be performed against the script engine except [IActiveScriptProfilerHeapEnum::Next Method](../../winscript/reference/iactivescriptprofilerheapenum-next-method.md) until [IActiveScriptProfilerHeapEnum::Next Method](../../winscript/reference/iactivescriptprofilerheapenum-next-method.md) returns S_FALSE or the [IActiveScriptProfilerHeapEnum Interface](../../winscript/reference/iactivescriptprofilerheapenum-interface.md) interface pointer is released.  
  
## Syntax  
  
```cpp
HRESULT EnumHeap([out] IActiveScriptProfilerHeapEnum** ppEnum);  
```  
  
#### Parameters  
 ppEnum  
 [out] Returns the [IActiveScriptProfilerHeapEnum Interface](../../winscript/reference/iactivescriptprofilerheapenum-interface.md).  
  
## Return Value  
 The HRESULT.