---
title: "IDiaSession::findInlineesByName | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
ms.assetid: 9860336d-f703-4ecb-bfc4-3f5beb175a76
caps.latest.revision: 6
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaSession::findInlineesByName
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves an enumeration that allows a client to iterate through the line number information of all inlined functions that match a specified name.  
  
## Syntax  
  
```cpp#  
HRESULT findInlineesByName (   
   LPCOLESTR             name,  
   DWORD                 option,  
   IDiaEnumLineNumbers** ppResult  
);  
```  
  
#### Parameters  
 `name`  
 [in] Specifies the name to use for comparison.  
  
 `option`  
 [in] Specifies the comparison options applied to name searching. Values from the [NameSearchOptions Enumeration](../../debugger/debug-interface-access/namesearchoptions.md) enumeration can be used alone or in combination.  
  
 `ppResult`  
 [out] Returns an [IDiaEnumLineNumbers](../../debugger/debug-interface-access/idiaenumlinenumbers.md) object that contains a list of the line numbers that were retrieved.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaSession](../../debugger/debug-interface-access/idiasession.md)   
 [IDiaSourceFile](../../debugger/debug-interface-access/idiasourcefile.md)   
 [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)   
 [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md)   
 [IDiaEnumLineNumbers](../../debugger/debug-interface-access/idiaenumlinenumbers.md)
