---
title: "IDiaEnumSymbolsByAddr::Prev | Microsoft Docs"
ms.custom: ""
ms.date: "2018-06-30"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaEnumSymbolsByAddr::Prev method"
ms.assetid: da3b3dca-68cb-4cb0-b25c-e28a1ffe49d3
caps.latest.revision: 10
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDiaEnumSymbolsByAddr::Prev
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IDiaEnumSymbolsByAddr::Prev](https://docs.microsoft.com/visualstudio/debugger/debug-interface-access/idiaenumsymbolsbyaddr-prev).  
  
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
 [out] An array that is to be filled in with [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md) objects that represent the desired symbols.  
  
 pceltFetched  
 [out] Returns the number of symbols in the fetched enumerator.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if there are no previous symbols. Otherwise, returns an error code.  
  
## Remarks  
 This method updates the enumerator position by the number of elements fetched.  
  
## See Also  
 [IDiaEnumSymbolsByAddr](../../debugger/debug-interface-access/idiaenumsymbolsbyaddr.md)   
 [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)



