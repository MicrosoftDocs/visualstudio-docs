---
title: "PROFILER_HEAP_OBJECT_OPTIONAL_INFO Structure | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: 77e638bd-ae36-4292-a170-90a0c500e610
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# PROFILER_HEAP_OBJECT_OPTIONAL_INFO Structure
Represents optional information about heap objects.  
  
## Syntax  
  
```cpp
typedef struct _PROFILER_HEAP_OBJECT_OPTIONAL_INFO{    PROFILER_HEAP_OBJECT_OPTIONAL_INFO_TYPE infoType;    [switch_type(PROFILER_HEAP_OBJECT_OPTIONAL_INFO_TYPE), switch_is(infoType)] union    {        [case(PROFILER_HEAP_OBJECT_OPTIONAL_INFO_PROTOTYPE)] PROFILER_HEAP_OBJECT_ID prototype;        [case(PROFILER_HEAP_OBJECT_OPTIONAL_INFO_FUNCTION_NAME)] LPCWSTR functionName;        [case(PROFILER_HEAP_OBJECT_OPTIONAL_INFO_ELEMENT_ATTRIBUTES_SIZE)] UINT elementAttributesSize;        [case(PROFILER_HEAP_OBJECT_OPTIONAL_INFO_ELEMENT_TEXT_CHILDREN_SIZE)] UINT elementTextChildrenSize;        [case(PROFILER_HEAP_OBJECT_OPTIONAL_INFO_SCOPE_LIST)] PROFILER_HEAP_OBJECT_SCOPE_LIST* scopeList;        [case(PROFILER_HEAP_OBJECT_OPTIONAL_INFO_INTERNAL_PROPERTY)] PROFILER_HEAP_OBJECT_RELATIONSHIP* internalProperty;        [case(PROFILER_HEAP_OBJECT_OPTIONAL_INFO_NAME_PROPERTIES)] PROFILER_HEAP_OBJECT_RELATIONSHIP_LIST* namePropertyList;        [case(PROFILER_HEAP_OBJECT_OPTIONAL_INFO_INDEX_PROPERTIES)] PROFILER_HEAP_OBJECT_RELATIONSHIP_LIST* indexPropertyList;        [case(PROFILER_HEAP_OBJECT_OPTIONAL_INFO_RELATIONSHIPS)] PROFILER_HEAP_OBJECT_RELATIONSHIP_LIST* relationshipList;        [case(PROFILER_HEAP_OBJECT_OPTIONAL_INFO_WINRTEVENTS)] PROFILER_HEAP_OBJECT_RELATIONSHIP_LIST* eventList;    };} PROFILER_HEAP_OBJECT_OPTIONAL_INFO;  
```  
  
## Members  
  
|Member|Type|Description|  
|------------|----------|-----------------|  
|infoType|[PROFILER_HEAP_OBJECT_OPTIONAL_INFO_TYPE Enumeration](../../winscript/reference/profiler-heap-object-optional-info-type-enumeration.md)|The type of the optional information.|  
|prototype|[PROFILER_HEAP_OBJECT_ID Type](../../winscript/reference/profiler-heap-object-id-type.md)|The ID of the heap object's prototype object.|  
|functionName|LPCWSTR|The heap object's function name.|  
|elementAttributesSize|UINT|The size of the heap object's element attributes.|  
|elementTextChildrenSize|UINT|The size of the heap object's text children.|  
|scopeList|[PROFILER_HEAP_OBJECT_SCOPE_LIST Structure](../../winscript/reference/profiler-heap-object-scope-list-structure.md)|The heap object's scope list.|  
|internalProperty|[PROFILER_HEAP_OBJECT_RELATIONSHIP Structure](../../winscript/reference/profiler-heap-object-relationship-structure.md)|The heap object's internal property.|  
|namePropertyList|[PROFILER_HEAP_OBJECT_RELATIONSHIP_LIST Structure](../../winscript/reference/profiler-heap-object-relationship-list-structure.md)|A list of the heap object's name properties.|  
|indexPropertyList|[PROFILER_HEAP_OBJECT_RELATIONSHIP_LIST Structure](../../winscript/reference/profiler-heap-object-relationship-list-structure.md)|A list of the heap object's index properties.|  
|relationshipList|[PROFILER_HEAP_OBJECT_RELATIONSHIP_LIST Structure](../../winscript/reference/profiler-heap-object-relationship-list-structure.md)|A list of the heap object's relationships.|  
|eventList|[PROFILER_HEAP_OBJECT_RELATIONSHIP_LIST Structure](../../winscript/reference/profiler-heap-object-relationship-list-structure.md)|A list of the heap object's events.|