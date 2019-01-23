---
title: "IDiaEnumTables::Next | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaEnumTables::Next method"
ms.assetid: 8d7bd359-d33e-4317-9674-d89283efd7de
caps.latest.revision: 12
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaEnumTables::Next
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves a specified number of tables in the enumeration sequence.  
  
## Syntax  
  
```cpp#  
HRESULT Next (   
   ULONG       celt,  
   IDiaTable** rgelt,  
   ULONG*      pceltFetched  
);  
```  
  
#### Parameters  
 `celt`  
 [in] The number of tables in the enumerator to be retrieved.  
  
 `rgelt`  
 [out] An array that is to be filled in with the [IDiaTable](../../debugger/debug-interface-access/idiatable.md) objects that represent the desired tables.  
  
 `pceltFetched`  
 [out] Returns the number of tables in the fetched enumerator.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if there are no more tables. Otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumTables](../../debugger/debug-interface-access/idiaenumtables.md)   
 [IDiaTable](../../debugger/debug-interface-access/idiatable.md)
