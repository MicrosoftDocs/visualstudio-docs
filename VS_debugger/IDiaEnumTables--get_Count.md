---
title: "IDiaEnumTables::get_Count"
ms.custom: na
ms.date: 10/03/2016
ms.devlang: 
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 30fa316b-a746-4028-acae-4efcd2066f38
caps.latest.revision: 8
manager: ghogen
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# IDiaEnumTables::get_Count
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
 [IDiaEnumTables](../VS_debugger/IDiaEnumTables.md)   
 [IDiaEnumTables::Item](../VS_debugger/IDiaEnumTables--Item.md)