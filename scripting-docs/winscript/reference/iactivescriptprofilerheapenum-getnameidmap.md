---
title: "IActiveScriptProfilerHeapEnum::GetNameIdMap | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: 88514c93-850b-48d4-9a68-1e27d7411f0d
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptProfilerHeapEnum::GetNameIdMap
Returns the string names corresponding to [PROFILER_HEAP_OBJECT_NAME_ID Type](../../winscript/reference/profiler-heap-object-name-id-type.md) values.  
  
## Syntax  
  
```cpp
HRESULT GetNameIdMap (    [out, size_is(,*pcelt)] LPCWSTR* pNameList[],     [out] UINT *pcelt);  
```  
  
#### Parameters  
 `pNameList`  
 [out] An array of names associated with [PROFILER_HEAP_OBJECT_NAME_ID Type](../../winscript/reference/profiler-heap-object-name-id-type.md) values.  
  
 `pcelt`  
 [out] The number of names in the array.  
  
## Return Value  
 The HRESULT.