---
title: "IDiaSession::findLines | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaSession::findLines method"
ms.assetid: d6e84916-fd55-457e-b057-57f97b51fe73
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaSession::findLines
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves line numbers within specified compiland and source file identifiers.  
  
## Syntax  
  
```cpp#  
HRESULT findLines (   
   IDiaSymbol*           compiland,  
   IDiaSourceFile*       file,  
   IDiaEnumLineNumbers** ppResult  
);  
```  
  
#### Parameters  
 `compiland`  
 [in]An [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md) object representing the compiland. Use this interface as a context in which to search for the line numbers.  
  
 `file`  
 [in] An [IDiaSourceFile](../../debugger/debug-interface-access/idiasourcefile.md) object representing the source file in which to search for the line numbers.  
  
 `ppResult`  
 [out] Returns an [IDiaEnumLineNumbers](../../debugger/debug-interface-access/idiaenumlinenumbers.md) object that contains a list of the line numbers retrieved.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumLineNumbers](../../debugger/debug-interface-access/idiaenumlinenumbers.md)   
 [IDiaSession](../../debugger/debug-interface-access/idiasession.md)   
 [IDiaSourceFile](../../debugger/debug-interface-access/idiasourcefile.md)   
 [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
