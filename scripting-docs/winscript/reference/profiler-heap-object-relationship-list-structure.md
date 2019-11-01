---
title: "PROFILER_HEAP_OBJECT_RELATIONSHIP_LIST Structure | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: 46ca87ea-5b0f-437d-a33f-b2d9a457e036
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# PROFILER_HEAP_OBJECT_RELATIONSHIP_LIST Structure
Represents a list of relationships that belong to a heap object.  
  
## Syntax  
  
```cpp
typedef struct _PROFILER_HEAP_OBJECT_RELATIONSHIP_LIST{    UINT count;    [size_is(count)] PROFILER_HEAP_OBJECT_RELATIONSHIP elements[];} PROFILER_HEAP_OBJECT_RELATIONSHIP_LIST;  
```  
  
## Members  
  
|Member|Type|Description|  
|------------|----------|-----------------|  
|count|UINT|The number of relationships of a heap object.|  
|elements|[PROFILER_HEAP_OBJECT_RELATIONSHIP Structure](../../winscript/reference/profiler-heap-object-relationship-structure.md)|The relationships of a heap object.|