---
title: "IDiaSession::findInlineesByName"
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
ms.assetid: 9860336d-f703-4ecb-bfc4-3f5beb175a76
caps.latest.revision: 3
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
# IDiaSession::findInlineesByName
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
 [in] Specifies the comparison options applied to name searching. Values from the [NameSearchOptions Enumeration](../VS_debugger/NameSearchOptions.md) enumeration can be used alone or in combination.  
  
 `ppResult`  
 [out] Returns an [IDiaEnumLineNumbers](../VS_debugger/IDiaEnumLineNumbers.md) object that contains a list of the line numbers that were retrieved.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaSession](../VS_debugger/IDiaSession.md)   
 [IDiaSourceFile](../VS_debugger/IDiaSourceFile.md)   
 [IDiaSymbol](../VS_debugger/IDiaSymbol.md)   
 [SymTagEnum Enumeration](../VS_debugger/SymTagEnum.md)   
 [IDiaEnumLineNumbers](../VS_debugger/IDiaEnumLineNumbers.md)