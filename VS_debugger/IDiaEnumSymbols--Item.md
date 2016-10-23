---
title: "IDiaEnumSymbols::Item"
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
ms.assetid: 2bd1ec04-e677-4e32-8e32-33334f1eed77
caps.latest.revision: 7
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
# IDiaEnumSymbols::Item
Retrieves a symbol by means of an index.  
  
## Syntax  
  
```cpp#  
HRESULT Item (   
   DWORD        index,  
   IDiaSymbol** symbol  
);  
```  
  
#### Parameters  
 index  
 [in] Index of the [IDiaSymbol](../VS_debugger/IDiaSymbol.md) object to be retrieved. The index is in the range 0 to `count`-1, where `count` is returned by the [IDiaEnumSymbols::get_Count](../VS_debugger/IDiaEnumSymbols--get_Count.md) method.  
  
 symbol  
 [out] Returns an [IDiaSymbol](../VS_debugger/IDiaSymbol.md) object representing the desired symbol.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumSymbols](../VS_debugger/IDiaEnumSymbols.md)   
 [IDiaSymbol](../VS_debugger/IDiaSymbol.md)