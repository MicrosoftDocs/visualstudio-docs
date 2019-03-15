---
title: "IActiveScriptProfilerHeapEnum::GetOptionalInfo Method | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: 99ed9df5-71cf-4c25-b189-af9accc466ee
caps.latest.revision: 6
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptProfilerHeapEnum::GetOptionalInfo Method
Gets optional information on the specified object (from the set of heap objects returned from the [IActiveScriptProfilerControl3::EnumHeap Method](../../winscript/reference/iactivescriptprofilercontrol3-enumheap-method.md)).  
  
 You should not free the returned memory assigned to the returned objects. Instead, you should call the [IActiveScriptProfilerHeapEnum::FreeObjectAndOptionalInfo Method](../../winscript/reference/iactivescriptprofilerheapenum-freeobjectandoptionalinfo-method.md).  
  
## Syntax  
  
```cpp
HRESULT GetOptionalInfo (    [in] PROFILER_HEAP_OBJECT* heapObject,    [in] ULONG celt,    [out, size_is(celt)] PROFILER_HEAP_OBJECT_OPTIONAL_INFO* optionalInfo);  
```  
  
#### Parameters  
 `heapObject`  
 The [PROFILER_HEAP_OBJECT Structure](../../winscript/reference/profiler-heap-object-structure.md) for which to return the information.  
  
 `celt`  
 The number of [PROFILER_HEAP_OBJECT_OPTIONAL_INFO Structure](../../winscript/reference/profiler-heap-object-optional-info-structure.md) structures to return.  
  
 `optionalInfo`  
 [out] An array of [PROFILER_HEAP_OBJECT_OPTIONAL_INFO Structure](../../winscript/reference/profiler-heap-object-optional-info-structure.md) structures for the specified object.  
  
## Return Value  
 The HRESULT.