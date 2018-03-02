---
title: "IDiaEnumLineNumbers::get__NewEnum | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaEnumLineNumbers::get__NewEnum method"
ms.assetid: 8b15f76b-a431-4f60-8bed-3206256b0d10
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: ghogen
ms.workload: 
  - "multiple"
---
# IDiaEnumLineNumbers::get__NewEnum
Retrieves the <xref:System.Runtime.InteropServices.ComTypes.IEnumVARIANT> version of this enumerator.  
  
## Syntax  
  
```C++  
HRESULT get__NewEnum (   
   IUnknown** pRetVal  
);  
```  
  
#### Parameters  
 pRetVal  
 [out] Returns the `IUnknown` interface that represents the <xref:System.Runtime.InteropServices.ComTypes.IEnumVARIANT> version of this enumerator.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumLineNumbers](../../debugger/debug-interface-access/idiaenumlinenumbers.md)