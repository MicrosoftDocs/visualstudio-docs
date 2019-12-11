---
title: "PROFILER_HEAP_OBJECT_RELATIONSHIP_FLAGS Enumeration | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: 1a41b642-c9a9-4d83-b943-d59b232eebf6
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# PROFILER_HEAP_OBJECT_RELATIONSHIP_FLAGS Enumeration
Flags that represent whether a heap object pointed to in an object relationship is a getter or setter method. Used in the [EnumHeap2](../../winscript/reference/iactivescriptprofilercontrol5-enumheap2-method.md) method when the PROFILER_HEAP_OBJECT_RELATIONSHIP_FLAGS value is specified in the `enumFlags` parameter.  
  
## Syntax  
  
```cpp
typedef [v1_enum] enum {    PROFILER_HEAP_OBJECT_RELATIONSHIP_FLAGS_NONE                      = 0x00000000,    PROFILER_HEAP_OBJECT_RELATIONSHIP_FLAGS_IS_GET_ACCESSOR           = 0x00010000,    PROFILER_HEAP_OBJECT_RELATIONSHIP_FLAGS_IS_SET_ACCESSOR           = 0x00020000,} PROFILER_HEAP_OBJECT_RELATIONSHIP_FLAGS;  
```  
  
## Members  
  
|Member|Value|Description|  
|------------|-----------|-----------------|  
|PROFILER_HEAP_OBJECT_RELATIONSHIP_FLAGS_NONE|0x00000000|This heap object pointed to in an object relationship is not identified as either a getter or setter method.|  
|PROFILER_HEAP_OBJECT_RELATIONSHIP_FLAGS_IS_GET_ACCESSOR|0x00010000|The heap object pointed to in an object relationship is a getter method. This information will be stored in the high 2 bytes (16 bits) of the [PROFILER_HEAP_OBJECT_RELATIONSHIP.relationshipInfo](../../winscript/reference/profiler-heap-object-relationship-structure.md) field.|  
|PROFILER_HEAP_OBJECT_RELATIONSHIP_FLAGS_IS_SET_ACCESSOR|0x00020000|The heap object pointed to in an object relationship is a setter method. This information will be stored in the high 2 bytes (16 bits) of the `PROFILER_HEAP_OBJECT_RELATIONSHIP.relationshipInfo` field.|