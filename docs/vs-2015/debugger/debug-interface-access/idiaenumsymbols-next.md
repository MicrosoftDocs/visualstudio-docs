---
title: "IDiaEnumSymbols::Next | Microsoft Docs"
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
  - "IDiaEnumSymbols::Next method"
ms.assetid: bfe5fe27-6a84-4392-910f-e325146d7552
caps.latest.revision: 10
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDiaEnumSymbols::Next
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

  
Retrieves a specified number of symbols in the enumeration sequence.  
  
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
 [out] An array that is to be filled in with the [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md) objects that represent the desired symbols.  
  
 pceltFetched  
 [out] Returns the number of symbols in the fetched enumerator.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if there are no more symbols. Otherwise, returns an error code.  
  
## Example  
  
```cpp#  
IDiaEnumSymbols* pEnum  
CComPtr< IDiaSymbol> pSym;  
DWORD celt;  
pEnum->Next( 1, &pSym, &celt );  
```  
  
## See Also  
 [IDiaEnumSymbols](../../debugger/debug-interface-access/idiaenumsymbols.md)   
 [IDiaSession::findLinesByLinenum](../../debugger/debug-interface-access/idiasession-findlinesbylinenum.md)   
 [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)



