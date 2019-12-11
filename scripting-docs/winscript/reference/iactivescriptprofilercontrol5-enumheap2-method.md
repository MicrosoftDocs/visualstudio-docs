---
title: "IActiveScriptProfilerControl5::EnumHeap2 Method | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: a25859eb-ac28-4a97-bcb3-33788982a76b
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptProfilerControl5::EnumHeap2 Method
Returns an interface ([IActiveScriptProfilerHeapEnum Interface](../../winscript/reference/iactivescriptprofilerheapenum-interface.md)) that can be used to iterate over the GC heap objects in the context of the associated script engine.  
  
 You can call this method in either debug or release mode. This method should be called when UI thread is idle. After the method has been called, no operations should be performed against the script engine except [IActiveScriptProfilerHeapEnum::Next Method](../../winscript/reference/iactivescriptprofilerheapenum-next-method.md) until [IActiveScriptProfilerHeapEnum::Next Method](../../winscript/reference/iactivescriptprofilerheapenum-next-method.md) returns S_FALSE or the [IActiveScriptProfilerHeapEnum Interface](../../winscript/reference/iactivescriptprofilerheapenum-interface.md) interface pointer is released.  
  
## Syntax  
  
```cpp
HRESULT EnumHeap2(    [in] PROFILER_HEAP_ENUM_FLAGS enumFlags,    [out] IActiveScriptProfilerHeapEnum** ppEnum);  
```  
  
#### Parameters  
 enumFlags  
 Value that specifies whether extra information about an object pointed to in an object relationship is exposed. Extra information may indicate whether the object pointed to is a getter or setter method. For more info, see [PROFILER_HEAP_ENUM_FLAGS Enumeration](../../winscript/reference/profiler-heap-enum-flags-enumeration.md).  
  
 ppEnum  
 [out] Returns the [IActiveScriptProfilerHeapEnum Interface](../../winscript/reference/iactivescriptprofilerheapenum-interface.md).  
  
## Return Value  
 Returns an HRESULT. Possible values are as follows:  
  
|Return Value|Meaning|  
|------------------|-------------|  
|`S_OK`|The heap enumeration completed successfully.|  
|`E_OUTOFMEMORY`|There was not enough memory available to perform heap enumeration.|  
|`E_FAIL`|An internal error occurred.|