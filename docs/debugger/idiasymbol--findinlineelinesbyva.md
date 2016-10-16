---
title: "IDiaSymbol::findInlineeLinesByVA"
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
ms.assetid: 61427d33-30d2-4ac9-9bd6-c58c6c705072
caps.latest.revision: 3
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
# IDiaSymbol::findInlineeLinesByVA
Retrieves an enumeration that allows a client to iterate through the line number information of all functions that are inlined, directly or indirectly, in this symbol within the specified virtual address (VA).  
  
## Syntax  
  
```cpp#  
HRESULT findInlineeLinesByVA (   
   ULONGLONG             va,  
   DWORD                 length,  
   IDiaEnumLineNumbers** ppResult  
);  
```  
  
#### Parameters  
 `va`  
 [in] Specifies the address as a VA.  
  
 `length`  
 [in] Specifies the address range, in number of bytes, to cover with this query.  
  
 `ppResult`  
 [out] Holds an `IDiaEnumLineNumbers` object that contains the list of line numbers that are retrieved.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaSession](../debugger/idiasession.md)   
 [IDiaSymbol](../debugger/idiasymbol.md)   
 [SymTagEnum Enumeration](../debugger/symtagenum.md)   
 [IDiaEnumLineNumbers](../debugger/idiaenumlinenumbers.md)