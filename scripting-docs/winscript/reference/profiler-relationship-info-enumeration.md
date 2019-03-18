---
title: "PROFILER_RELATIONSHIP_INFO Enumeration | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: fae69317-6224-4a6a-8e9e-ccaa6a330818
caps.latest.revision: 6
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# PROFILER_RELATIONSHIP_INFO Enumeration
Represents information about the object in the relationship. Used in [PROFILER_HEAP_OBJECT_RELATIONSHIP Structure](../../winscript/reference/profiler-heap-object-relationship-structure.md).  
  
## Syntax  
  
```cpp
typedef [v1_enum] enum {    PROFILER_PROPERTY_TYPE_NUMBER = 0x01,    PROFILER_PROPERTY_TYPE_STRING = 0x02,    PROFILER_PROPERTY_TYPE_HEAP_OBJECT = 0x03,    PROFILER_PROPERTY_TYPE_EXTERNAL_OBJECT = 0x04,    PROFILER_PROPERTY_TYPE_BSTR = 0x05,} PROFILER_RELATIONSHIP_INFO;  
```  
  
## Members  
  
|Member|Value|Description|  
|------------|-----------|-----------------|  
|PROFILER_PROPERTY_TYPE_NUMBER|0x01|The object is a number.|  
|PROFILER_PROPERTY_TYPE_STRING|0x02|The object is a string.|  
|PROFILER_PROPERTY_TYPE_HEAP_OBJECT|0x03|The object is a heap object.|  
|PROFILER_PROPERTY_TYPE_EXTERNAL_OBJECT|0x04|The object is external, that is, not on the garbage collection heap.|  
|PROFILER_PROPERTY_TYPE_BSTR|0x05|The object is a BSTR.|  
|PROFILER_PROPERTY_TYPE_SUBSTRING|0x06|The object is a SUBSTRING.|