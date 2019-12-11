---
title: "IActiveScriptProfilerHeapEnum::FreeObjectAndOptionalInfo Method | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: fdd5f7cc-be4e-4c13-a181-6320d26b44eb
caps.latest.revision: 3
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptProfilerHeapEnum::FreeObjectAndOptionalInfo Method
Frees the specified [PROFILER_HEAP_OBJECT Structure](../../winscript/reference/profiler-heap-object-structure.md) structures and their associated [PROFILER_HEAP_OBJECT_OPTIONAL_INFO Structure](../../winscript/reference/profiler-heap-object-optional-info-structure.md) elements.  
  
## Syntax  
  
```cpp
HRESULT FreeObjectAndOptionalInfo (    [in] ULONG celt,    [in, size_is(celt)] PROFILER_HEAP_OBJECT** heapObjects);  
```  
  
#### Parameters  
 `celt`  
 The number of objects to free.  
  
 `heapObjects`  
 An array of [PROFILER_HEAP_OBJECT Structure](../../winscript/reference/profiler-heap-object-structure.md) structures.  
  
## Return Value  
 The HRESULT.