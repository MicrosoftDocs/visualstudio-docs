---
title: "IDiaEnumTables::get_Count | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaEnumTables::get_Count method"
ms.assetid: 30fa316b-a746-4028-acae-4efcd2066f38
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaEnumTables::get_Count
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves the number of tables.  
  
## Syntax  
  
```cpp#  
HRESULT get_Count (    LONG* pRetVal  
);  
  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns the number of tables.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumTables](../../debugger/debug-interface-access/idiaenumtables.md)   
 [IDiaEnumTables::Item](../../debugger/debug-interface-access/idiaenumtables-item.md)
