---
title: "IActiveScriptProfilerHeapEnum::Next Method | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: 0336286f-1dcd-4df9-adf5-76b59b4e74bb
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptProfilerHeapEnum::Next Method
Gets the next object or objects in the set of heap objects from the [IActiveScriptProfilerControl3::EnumHeap Method](../../winscript/reference/iactivescriptprofilercontrol3-enumheap-method.md).  
  
## Syntax  
  
```cpp
HRESULT Next (    [in] ULONG celt,    [out, size_is(celt), length_is(*pceltFetched)] PROFILER_HEAP_OBJECT** heapObjects,     [out] ULONG *pceltFetched);  
```  
  
#### Parameters  
 `celt`  
 The number of objects to be returned.  
  
 `heapObjects`  
 [out] The next [PROFILER_HEAP_OBJECT Structure](../../winscript/reference/profiler-heap-object-structure.md) structures.  
  
 `pceltFetched`  
 [out] The number of objects returned,  
  
## Return Value  
 The HRESULT.