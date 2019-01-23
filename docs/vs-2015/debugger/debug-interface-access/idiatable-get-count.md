---
title: "IDiaTable::get_Count | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaTable::get_Count method"
ms.assetid: bb47abe8-6706-4679-bc52-79f6444dae7e
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaTable::get_Count
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves the number of items in the table.  
  
## Syntax  
  
```cpp#  
HRESULT get_Count (   
   LONG* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns the number of items in the table.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaTable](../../debugger/debug-interface-access/idiatable.md)   
 [IDiaTable::Item](../../debugger/debug-interface-access/idiatable-item.md)
