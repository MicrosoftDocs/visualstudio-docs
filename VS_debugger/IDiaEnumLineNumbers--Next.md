---
title: "IDiaEnumLineNumbers::Next"
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
ms.assetid: 363d5b40-1316-4ab8-836f-63637f619e0a
caps.latest.revision: 7
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
# IDiaEnumLineNumbers::Next
Retrieves a specified number of line numbers in the enumeration sequence.  
  
## Syntax  
  
```cpp#  
HRESULT Next (   
   ULONG            celt,  
   IDiaLineNumber** rgelt,  
   ULONG*           pceltFetched  
);  
```  
  
#### Parameters  
 celt  
 [in] The number of line numbers in the enumerator to be retrieved.  
  
 rgelt  
 [out] Returns an array of [IDiaLineNumber](../VS_debugger/IDiaLineNumber.md) objects that represent the desired line numbers.  
  
 pceltFetched  
 [out] Returns the number of line numbers in the fetched enumerator.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if there are no more line numbers. Otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumLineNumbers](../VS_debugger/IDiaEnumLineNumbers.md)   
 [IDiaLineNumber](../VS_debugger/IDiaLineNumber.md)   
 [IDiaSession::findLinesByLinenum](../VS_debugger/IDiaSession--findLinesByLinenum.md)