---
title: "PROFILER_HEAP_OBJECT Structure | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: 9f35362c-6856-4cfb-b990-031a156a58eb
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# PROFILER_HEAP_OBJECT Structure
Represents the heap objects gathered by [IActiveScriptProfilerControl3::EnumHeap Method](../../winscript/reference/iactivescriptprofilercontrol3-enumheap-method.md).  
  
## Syntax  
  
```cpp
typedef struct _PROFILER_HEAP_OBJECT  
{  
    UINT size;    union {        PROFILER_HEAP_OBJECT_ID objectId;        PROFILER_EXTERNAL_OBJECT_ADDRESS externalObjectAddress;    };    PROFILER_HEAP_OBJECT_NAME_ID typeNameId;    USHORT flags;     USHORT optionalInfoCount;} PROFILER_HEAP_OBJECT;  
```  
  
## Members  
  
|Member|Type|Description|  
|------------|----------|-----------------|  
|objectId|[PROFILER_HEAP_OBJECT_ID Type](../../winscript/reference/profiler-heap-object-id-type.md)|The ID of the heap object.|  
|externalObjectAddress|[PROFILER_EXTERNAL_OBJECT_ADDRESS Type](../../winscript/reference/profiler-external-object-address-type.md)|The external object address of an object, such as a C++-allocated object, that is outside the JavaScript heap.|  
|typeNameId|[PROFILER_HEAP_OBJECT_NAME_ID Type](../../winscript/reference/profiler-heap-object-name-id-type.md)|The ID of the heap object type name, retrieved from [IActiveScriptProfilerHeapEnum::GetNameIdMap](../../winscript/reference/iactivescriptprofilerheapenum-getnameidmap.md). Only one of `externalObjectAddress` or `typeName` is present depending on the `flags` value.|  
|flags|[PROFILER_HEAP_OBJECT_FLAGS Enumeration](../../winscript/reference/profiler-heap-object-flags-enumeration.md)|The flags that contain basic information about the heap object.|  
|optionalInfoCount|USHORT|The number of [PROFILER_HEAP_OBJECT_OPTIONAL_INFO Structure](../../winscript/reference/profiler-heap-object-optional-info-structure.md) records that are available for the heap object.|