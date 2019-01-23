---
title: "IDiaSession::findAcceleratorInlineesByLinenum | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
ms.assetid: 386c87aa-f7b2-4d38-9dd6-fffba9ff01f0
caps.latest.revision: 6
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaSession::findAcceleratorInlineesByLinenum
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

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
 [IDiaSession](../../debugger/debug-interface-access/idiasession.md)   
 [IDiaEnumLineNumbers](../../debugger/debug-interface-access/idiaenumlinenumbers.md)   
 [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
