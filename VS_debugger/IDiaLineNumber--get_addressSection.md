---
title: "IDiaLineNumber::get_addressSection"
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
ms.assetid: a01c1bae-04b2-4c30-8621-60939a3124c2
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
# IDiaLineNumber::get_addressSection
Retrieves the section part of the memory address where a block begins.  
  
## Syntax  
  
```cpp#  
HRESULT get_addressSection (   
   DWORD* pRetVal  
);  
```  
  
#### Parameters  
 pRetVal  
 [out] Returns the section part of the memory address where a block begins.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.  
  
## Example  
  
```cpp#  
CComPtr< IDiaLineNumber > pLine;  
DWORD seg;  
pLine->get_addressSection( &seg );  
```  
  
## See Also  
 [IDiaLineNumber](../VS_debugger/IDiaLineNumber.md)   
 [IDiaLineNumber::get_addressOffset](../VS_debugger/IDiaLineNumber--get_addressOffset.md)