---
title: "IDiaLineNumber::get_addressSection | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaLineNumber::get_addressSection method"
ms.assetid: a01c1bae-04b2-4c30-8621-60939a3124c2
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaLineNumber::get_addressSection
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

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
 [IDiaLineNumber](../../debugger/debug-interface-access/idialinenumber.md)   
 [IDiaLineNumber::get_addressOffset](../../debugger/debug-interface-access/idialinenumber-get-addressoffset.md)
