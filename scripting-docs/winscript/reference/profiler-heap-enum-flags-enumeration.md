---
title: "PROFILER_HEAP_ENUM_FLAGS Enumeration | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: 17936b7a-40d5-4774-b92b-b24ee391591e
caps.latest.revision: 6
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# PROFILER_HEAP_ENUM_FLAGS Enumeration
Flags that represent whether extra information about a heap object pointed to in an object relationship is exposed. Used in the [EnumHeap2](../../winscript/reference/iactivescriptprofilercontrol5-enumheap2-method.md) method.  
  
## Syntax  
  
```cpp
typedef [v1_enum] enum {    PROFILER_HEAP_ENUM_FLAGS_NONE                      = 0x00000000,    PROFILER_HEAP_ENUM_FLAGS_STORE_RELATIONSHIP_FLAGS  = 0x00000001,} PROFILER_HEAP_ENUM_FLAGS;  
```  
  
## Members  
  
|Member|Value|Description|  
|------------|-----------|-----------------|  
|PROFILER_HEAP_ENUM_FLAGS_NONE|0x00000000|This heap object does not expose extra information about an object relationship. This heap object behaves in the same way as [IActiveScriptProfilerControl3::HeapEnum](../../winscript/reference/iactivescriptprofilercontrol3-enumheap-method.md).|  
|PROFILER_HEAP_ENUM_ENUM_ STORE_RELATIONSHIP_FLAGS|0x00000001|This heap object will expose information about whether or not an object pointed to in an object relationship is a getter or setter method. This information will be stored in the high 2 bytes (16 bits) of the [PROFILER_HEAP_OBJECT_RELATIONSHIP.relationshipInfo](../../winscript/reference/profiler-heap-object-relationship-structure.md) field as one of the [PROFILER_HEAP_OBJECT_RELATIONSHIP_FLAGS](../../winscript/reference/profiler-heap-object-relationship-flags-enumeration.md) enumeration values.|  
|PROFILER_HEAP_ENUM_FLAGS_SUBSTRINGS|0x00000002|This heap object is used to display the substring correctly.|  
|PROFILER_HEAP_ENUM_FLAGS_RELATIONSHIP_SUBSTRINGS|PROFILER_HEAP_ENUM_FLAGS_STORE_RELATIONSHIP_FLAGS &#124; PROFILER_HEAP_ENUM_FLAGS_SUBSTRINGS|This heap object is used to display the substring correctly.|