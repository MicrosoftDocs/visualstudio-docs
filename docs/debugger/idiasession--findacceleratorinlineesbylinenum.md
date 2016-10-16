---
title: "IDiaSession::findAcceleratorInlineesByLinenum"
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
ms.assetid: 386c87aa-f7b2-4d38-9dd6-fffba9ff01f0
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
# IDiaSession::findAcceleratorInlineesByLinenum
Returns an enumeration of symbols for inline frames that correspond to the specified source location.  
  
## Syntax  
  
```cpp#  
HRESULT findAcceleratorInlineeLinesByName (   
   IDiaSymbol*           parent,  
   IDiaSourceFile*       file,  
   DWORD                 linenum,  
   DWORD                 colnum,  
   IDiaEnumLineNumbers** ppResult  
);  
```  
  
#### Parameters  
 `parent`  
 [in] An `IDiaSymbol` that corresponds to the Accelerator stub function that needs to be searched.  
  
 `file`  
 [in] The `IDiaSourceFile` of the source location.  
  
 `linenum`  
 [in] The line number of the source location.  
  
 `colnum`  
 [in] The column number of the source location.  
  
 `ppResult`  
 [out] A pointer to an `IDiaEnumLineNumbers` interface pointer that is initialized with the result.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaSession](../debugger/idiasession.md)   
 [IDiaEnumLineNumbers](../debugger/idiaenumlinenumbers.md)   
 [IDiaSymbol](../debugger/idiasymbol.md)