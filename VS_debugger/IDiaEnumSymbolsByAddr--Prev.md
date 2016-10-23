---
title: "IDiaEnumSymbolsByAddr::Prev"
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
ms.assetid: da3b3dca-68cb-4cb0-b25c-e28a1ffe49d3
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
# IDiaEnumSymbolsByAddr::Prev
Retrieves the previous symbols in order by address.  
  
## Syntax  
  
```cpp#  
HRESULT Prev (   
   ULONG        celt,   
   IDiaSymbol** rgelt,  
   ULONG*       pceltFetched  
);  
```  
  
#### Parameters  
 celt  
 [in] The number of symbols in the enumerator to be retrieved.  
  
 rgelt  
 [out] An array that is to be filled in with [IDiaSymbol](../VS_debugger/IDiaSymbol.md) objects that represent the desired symbols.  
  
 pceltFetched  
 [out] Returns the number of symbols in the fetched enumerator.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if there are no previous symbols. Otherwise, returns an error code.  
  
## Remarks  
 This method updates the enumerator position by the number of elements fetched.  
  
## See Also  
 [IDiaEnumSymbolsByAddr](../VS_debugger/IDiaEnumSymbolsByAddr.md)   
 [IDiaSymbol](../VS_debugger/IDiaSymbol.md)