---
title: "IDiaSession::get_globalScope"
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
ms.assetid: 75d128a8-3dce-40ed-b392-de3fdda041b7
caps.latest.revision: 8
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
# IDiaSession::get_globalScope
Retrieves a reference to the global scope.  
  
## Syntax  
  
```cpp#  
HRESULT get_globalScope (   
   IDiaSymbol** pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns an [IDiaSymbol](../VS_debugger/IDiaSymbol.md) object that represents the global scope.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [Exe](../VS_debugger/Exe.md)   
 [IDiaSession](../VS_debugger/IDiaSession.md)   
 [IDiaSymbol](../VS_debugger/IDiaSymbol.md)