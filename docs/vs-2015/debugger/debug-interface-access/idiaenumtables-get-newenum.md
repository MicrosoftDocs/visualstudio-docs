---
title: "IDiaEnumTables::get__NewEnum | Microsoft Docs"
ms.custom: ""
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaEnumTables::get__NewEnum method"
ms.assetid: 7b1159c7-a5f0-4baa-861a-dc11437d8b93
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDiaEnumTables::get__NewEnum
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IDiaEnumTables::get__NewEnum](https://docs.microsoft.com/visualstudio/debugger/debug-interface-access/idiaenumtables-get-newenum).  
  
Retrieves the <xref:System.Runtime.InteropServices.ComTypes.IEnumVARIANT> version of this enumerator.  
  
## Syntax  
  
```cpp#  
HRESULT get__NewEnum (   
   IUnknown** pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns the `IUnknown` interface that represents the <xref:System.Runtime.InteropServices.ComTypes.IEnumVARIANT> version of this enumerator.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumTables](../../debugger/debug-interface-access/idiaenumtables.md)



