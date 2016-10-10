---
title: "IDiaSession::findLines"
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
ms.assetid: d6e84916-fd55-457e-b057-57f97b51fe73
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
# IDiaSession::findLines
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
 [in]An [IDiaSymbol](../VS_debugger/IDiaSymbol.md) object representing the compiland. Use this interface as a context in which to search for the line numbers.  
  
 `file`  
 [in] An [IDiaSourceFile](../VS_debugger/IDiaSourceFile.md) object representing the source file in which to search for the line numbers.  
  
 `ppResult`  
 [out] Returns an [IDiaEnumLineNumbers](../VS_debugger/IDiaEnumLineNumbers.md) object that contains a list of the line numbers retrieved.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumLineNumbers](../VS_debugger/IDiaEnumLineNumbers.md)   
 [IDiaSession](../VS_debugger/IDiaSession.md)   
 [IDiaSourceFile](../VS_debugger/IDiaSourceFile.md)   
 [IDiaSymbol](../VS_debugger/IDiaSymbol.md)