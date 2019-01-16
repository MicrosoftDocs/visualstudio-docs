---
title: "PROFILER_PROPERTY_TYPE_SUBSTRING_INFO Structure | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 3845c872-4302-47b6-8912-7b2d7a3b3357
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
---
# PROFILER_PROPERTY_TYPE_SUBSTRING_INFO Structure
Represents information about the substring type used in the relationship. Used in [PROFILER_HEAP_OBJECT_RELATIONSHIP Structure](../../winscript/reference/profiler-heap-object-relationship-structure.md).  
  
## Syntax  
  
```cpp
typedef struct _PROFILER_PROPERTY_TYPE_SUBSTRING_INFO {    UINT length;    LPCWSTR value; } PROFILER_PROPERTY_TYPE_SUBSTRING_INFO;  
```  
  
## Members  
  
|Member|Type|Description|  
|------------|----------|-----------------|  
|length|UINT|The object is a UINT.|  
|value|LPCWSTR|The object is a LPCWSTR.|