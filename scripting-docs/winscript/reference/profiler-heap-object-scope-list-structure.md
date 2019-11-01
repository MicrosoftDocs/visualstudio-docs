---
title: "PROFILER_HEAP_OBJECT_SCOPE_LIST Structure | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: 33ebaa31-0a35-47d5-a4e3-afd83e16f53e
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# PROFILER_HEAP_OBJECT_SCOPE_LIST Structure
This structure is associated with function objects only. The scope list represents the closure for the function as a list of scopes where each scope is a heap object with an associated property list that represents variables in each given scope. In some cases, the names of objects in that scope might not be available, and only their index into the property list is available.  
  
## Syntax  
  
```cpp
typedef struct _PROFILER_HEAP_OBJECT_SCOPE_LIST{    UINT count;    [size_is(count)] PROFILER_HEAP_OBJECT_ID scopes[];} PROFILER_HEAP_OBJECT_SCOPE_LIST;  
```  
  
## Members  
  
|Member|Type|Description|  
|------------|----------|-----------------|  
|count|UINT|The number of scopes|  
|scopes|[PROFILER_HEAP_OBJECT_ID Type](../../winscript/reference/profiler-heap-object-id-type.md)|An array of scopes.|