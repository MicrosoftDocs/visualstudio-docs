---
title: "IDiaEnumSymbolsByAddr::Next | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaEnumSymbolsByAddr::Next method"
ms.assetid: a1320587-7ce7-401f-9548-2f8bcece5cc3
caps.latest.revision: 10
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaEnumSymbolsByAddr::Next
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves the next symbols in order by address.  
  
## Syntax  
  
```cpp#  
HRESULT Next (   
   ULONG        celt,   
   IDiaSymbol** rgelt,  
   ULONG*       pceltFetched  
);  
```  
  
#### Parameters  
 celt  
 [in] The number of symbols in the enumerator to be retrieved.  
  
 rgelt  
 [out] An array that is to be filled in with the [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md) object that represent the desired symbols.  
  
 pceltFetched  
 [out] Returns the number of symbols in the fetched enumerator.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if there are no more symbols. Otherwise, returns an error code.  
  
## Remarks  
 This method updates the enumerator position by the number of elements fetched.  
  
## See Also  
 [IDiaEnumSymbolsByAddr](../../debugger/debug-interface-access/idiaenumsymbolsbyaddr.md)   
 [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
