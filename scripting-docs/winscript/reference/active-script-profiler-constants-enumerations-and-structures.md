---
title: "Active Script Profiler Constants, Enumerations and Structures | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: 6e079d84-9dde-46fc-8a6a-18e902f60ecc
caps.latest.revision: 12
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Active Script Profiler Constants, Enumerations and Structures
The following enumerations are used by Active Script Profiler Interfaces.  
  
## Constants, Enumerations, and Structures  
  
|Constants|Description|  
|---------------|-----------------|  
|[PROFILER_EXTERNAL_OBJECT_ADDRESS Type](../../winscript/reference/profiler-external-object-address-type.md)|The external object address of the profiler. Used in [PROFILER_HEAP_OBJECT Structure](../../winscript/reference/profiler-heap-object-structure.md) and [PROFILER_HEAP_OBJECT_RELATIONSHIP Structure](../../winscript/reference/profiler-heap-object-relationship-structure.md).|  
|[PROFILER_HEAP_OBJECT_ID Type](../../winscript/reference/profiler-heap-object-id-type.md)|The ID of the heap object. Used in [PROFILER_HEAP_OBJECT Structure](../../winscript/reference/profiler-heap-object-structure.md)[PROFILER_HEAP_OBJECT_SCOPE_LIST Structure](../../winscript/reference/profiler-heap-object-scope-list-structure.md), [PROFILER_HEAP_OBJECT_OPTIONAL_INFO Structure](../../winscript/reference/profiler-heap-object-optional-info-structure.md), and [PROFILER_HEAP_OBJECT_RELATIONSHIP Structure](../../winscript/reference/profiler-heap-object-relationship-structure.md).|  
|[PROFILER_HEAP_OBJECT_NAME_ID Type](../../winscript/reference/profiler-heap-object-name-id-type.md)|The ID of the name of the heap object. Used in [PROFILER_HEAP_OBJECT Structure](../../winscript/reference/profiler-heap-object-structure.md).|  
  
|Enumerations|Description|  
|------------------|-----------------|  
|[PROFILER_EVENT_MASK Enumeration](../../winscript/reference/profiler-event-mask-enumeration.md)|Indicates the types of events that should be profiled.|  
|[PROFILER_HEAP_ENUM_FLAGS Enumeration](../../winscript/reference/profiler-heap-enum-flags-enumeration.md)|Flags that represent whether extra information about a heap object pointed to in an object relationship is exposed. Used in the [IActiveScriptProfilerControl5::EnumHeap2 Method](../../winscript/reference/iactivescriptprofilercontrol5-enumheap2-method.md).|  
|[PROFILER_HEAP_OBJECT_FLAGS Enumeration](../../winscript/reference/profiler-heap-object-flags-enumeration.md)|Flags that represent basic information about the heap object. Used in the [PROFILER_HEAP_OBJECT Structure](../../winscript/reference/profiler-heap-object-structure.md).|  
|[PROFILER_HEAP_OBJECT_OPTIONAL_INFO_TYPE Enumeration](../../winscript/reference/profiler-heap-object-optional-info-type-enumeration.md)|Represents different types of optional information. Used in [PROFILER_HEAP_OBJECT_OPTIONAL_INFO Structure](../../winscript/reference/profiler-heap-object-optional-info-structure.md).|  
|[PROFILER_RELATIONSHIP_INFO Enumeration](../../winscript/reference/profiler-relationship-info-enumeration.md)|Represents information about the object in the relationship. Used in [PROFILER_HEAP_OBJECT_RELATIONSHIP Structure](../../winscript/reference/profiler-heap-object-relationship-structure.md).|  
|[PROFILER_SCRIPT_TYPE Enumeration](../../winscript/reference/profiler-script-type-enumeration.md)|Specifies the type of script.|  
  
|Structures|Description|  
|----------------|-----------------|  
|[PROFILER_HEAP_OBJECT Structure](../../winscript/reference/profiler-heap-object-structure.md)|Represents the heap objects gathered by [IActiveScriptProfilerControl3::EnumHeap Method](../../winscript/reference/iactivescriptprofilercontrol3-enumheap-method.md).|  
|[PROFILER_HEAP_OBJECT_OPTIONAL_INFO Structure](../../winscript/reference/profiler-heap-object-optional-info-structure.md)|Represents optional information about heap objects.|  
|[PROFILER_HEAP_OBJECT_RELATIONSHIP Structure](../../winscript/reference/profiler-heap-object-relationship-structure.md)|Represents a relationship of a heap object.|  
|[PROFILER_HEAP_OBJECT_RELATIONSHIP_LIST Structure](../../winscript/reference/profiler-heap-object-relationship-list-structure.md)|Represents a list of relationships that belong to a heap object.|  
|[PROFILER_HEAP_OBJECT_SCOPE_LIST Structure](../../winscript/reference/profiler-heap-object-scope-list-structure.md)|This structure is associated with function objects only. The scope list represents the closure for the function as a list of scopes where each scope is a heap object with an associated property list that represents variables in each given scope. In some cases, the names of objects in that scope might not be available, only their ids.|  
|[PROFILER_PROPERTY_TYPE_SUBSTRING_INFO Structure](../../winscript/reference/profiler-property-type-substring-info-structure.md)|Represents information about the type of the substring.|  
  
## See also  
 [Active Script Profiler Interfaces](../../winscript/reference/active-script-profiler-interfaces.md)