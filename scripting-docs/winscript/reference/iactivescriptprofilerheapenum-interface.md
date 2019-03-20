---
title: "IActiveScriptProfilerHeapEnum Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: 16756d0e-547a-4825-8b7b-a7e0e4708a04
caps.latest.revision: 6
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptProfilerHeapEnum Interface
An iterator over the heap objects associated with a script engine, gathered by the [IActiveScriptProfilerControl3::EnumHeap Method](../../winscript/reference/iactivescriptprofilercontrol3-enumheap-method.md).  
  
## Syntax  
  
```vb  
interface IActiveScriptProfilerHeapEnum : IUnknown  
```  
  
## Methods  
 [IActiveScriptProfilerHeapEnum::Next Method](../../winscript/reference/iactivescriptprofilerheapenum-next-method.md)  
 Gets the next object or objects in the set of heap objects gathered by the [IActiveScriptProfilerControl3::EnumHeap Method](../../winscript/reference/iactivescriptprofilercontrol3-enumheap-method.md).  
  
 [IActiveScriptProfilerHeapEnum::GetOptionalInfo Method](../../winscript/reference/iactivescriptprofilerheapenum-getoptionalinfo-method.md)  
 Gets optional information on the specified object in the set of heap objects gathered by the [IActiveScriptProfilerControl3::EnumHeap Method](../../winscript/reference/iactivescriptprofilercontrol3-enumheap-method.md).  
  
 [IActiveScriptProfilerHeapEnum::FreeObjectAndOptionalInfo Method](../../winscript/reference/iactivescriptprofilerheapenum-freeobjectandoptionalinfo-method.md)  
 Frees the specified [PROFILER_HEAP_OBJECT Structure](../../winscript/reference/profiler-heap-object-structure.md) structures and their associated [PROFILER_HEAP_OBJECT_OPTIONAL_INFO Structure](../../winscript/reference/profiler-heap-object-optional-info-structure.md) elements.  
  
 [IActiveScriptProfilerHeapEnum::GetNameIdMap](../../winscript/reference/iactivescriptprofilerheapenum-getnameidmap.md)  
 Returns the string names corresponding to [PROFILER_HEAP_OBJECT_NAME_ID Type](../../winscript/reference/profiler-heap-object-name-id-type.md) values..