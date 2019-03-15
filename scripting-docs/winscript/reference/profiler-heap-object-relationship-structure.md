---
title: "PROFILER_HEAP_OBJECT_RELATIONSHIP Structure | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: 3ab3d986-3314-4c7b-a1c8-18ed691a8b9c
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# PROFILER_HEAP_OBJECT_RELATIONSHIP Structure
Represents a relationship of a heap object.  
  
## Syntax  
  
```cpp
typedef struct _PROFILER_HEAP_OBJECT_RELATIONSHIP{    PROFILER_HEAP_OBJECT_NAME_ID relationshipId;    PROFILER_RELATIONSHIP_INFO relationshipInfo;    [switch_type(PROFILER_RELATIONSHIP_INFO), switch_is(relationshipInfo)] union    {        [case(PROFILER_PROPERTY_TYPE_NUMBER)] double numberValue;        [case(PROFILER_PROPERTY_TYPE_STRING)] LPCWSTR stringValue;        [case(PROFILER_PROPERTY_TYPE_HEAP_OBJECT)] PROFILER_HEAP_OBJECT_ID objectId;        [case(PROFILER_PROPERTY_TYPE_EXTERNAL_OBJECT)] PROFILER_EXTERNAL_OBJECT_ADDRESS externalObjectAddress;    };} PROFILER_HEAP_OBJECT_RELATIONSHIP;  
```  
  
## Members  
  
|Member|Value|Description|  
|------------|-----------|-----------------|  
|relationshipId|[PROFILER_HEAP_OBJECT_NAME_ID Type](../../winscript/reference/profiler-heap-object-name-id-type.md)|The ID of the relationship name, from [IActiveScriptProfilerHeapEnum::GetNameIdMap](../../winscript/reference/iactivescriptprofilerheapenum-getnameidmap.md).|  
|relationshipInfo|[PROFILER_RELATIONSHIP_INFO Enumeration](../../winscript/reference/profiler-relationship-info-enumeration.md)|Information about the relationship.|  
|numberValue|double|The number value. Only one of `numberValue`/`stringValue`/`objectId`/`externalObjectAddress` is set, based on the `relationshipInfo` value.|  
|stringValue|LPCWSTR|The string value.|  
|objectId|[PROFILER_HEAP_OBJECT_ID Type](../../winscript/reference/profiler-heap-object-id-type.md)|The ID of the heap object.|  
|externalObjectAddress|[PROFILER_EXTERNAL_OBJECT_ADDRESS Type](../../winscript/reference/profiler-external-object-address-type.md)|The external object address.|  
|subString|[PROFILER_PROPERTY_TYPE_SUBSTRING_INFO Structure](../../winscript/reference/profiler-property-type-substring-info-structure.md)|The information about the substring type.|