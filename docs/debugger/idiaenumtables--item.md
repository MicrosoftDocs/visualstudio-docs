---
title: "IDiaEnumTables::Item"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaEnumTables::Item method"
ms.assetid: d65ab262-10c6-48ce-95a3-b5e4cb2c85af
caps.latest.revision: 11
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# IDiaEnumTables::Item
Retrieves a table by means of an index or name.  
  
## Syntax  
  
```cpp#  
HRESULT Item (   
   VARIANT     index,  
   IDiaTable** table  
);  
```  
  
#### Parameters  
 `index`  
 [in] Index or name of the [IDiaTable](../debugger/idiatable.md) to be retrieved. If an integer variant is used, it must be in the range 0 to `count`-1, where `count` is as returned by the [IDiaEnumTables::get_Count](../debugger/idiaenumtables--get_count.md) method.  
  
 `table`  
 [out] Returns an [IDiaTable](../debugger/idiatable.md) object representing the desired table.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 If a string variant is specified, then the string names a particular table. The name should be one of the table names as defined in [Constants (Debug Interface Access SDK)](../debugger/constants--debug-interface-access-sdk-.md).  
  
## Example  
  
```cpp#  
VARIANT var;  
var.vt = VT_BSTR;  
var.bstrVal = SysAllocString(DiaTable_Symbols );  
IDiaTable* pTable;  
pEnumTables->Item( var, &pTable );  
```  
  
## See Also  
 [IDiaEnumTables](../debugger/idiaenumtables.md)   
 [IDiaTable](../debugger/idiatable.md)   
 [IDiaEnumTables::get_Count](../debugger/idiaenumtables--get_count.md)   
 [Constants (Debug Interface Access SDK)](../debugger/constants--debug-interface-access-sdk-.md)