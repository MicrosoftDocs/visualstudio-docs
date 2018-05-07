---
title: "IDiaLineNumber::get_addressSection | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.technology: "vs-ide-debug"
ms.topic: "conceptual"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaLineNumber::get_addressSection method"
ms.assetid: a01c1bae-04b2-4c30-8621-60939a3124c2
author: "mikejo5000"
ms.author: "mikejo"
manager: douge
ms.workload: 
  - "multiple"
---
# IDiaLineNumber::get_addressSection
Retrieves the section part of the memory address where a block begins.  
  
## Syntax  
  
```C++  
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
  
```C++  
CComPtr< IDiaLineNumber > pLine;  
DWORD seg;  
pLine->get_addressSection( &seg );  
```  
  
## See Also  
 [IDiaLineNumber](../../debugger/debug-interface-access/idialinenumber.md)   
 [IDiaLineNumber::get_addressOffset](../../debugger/debug-interface-access/idialinenumber-get-addressoffset.md)