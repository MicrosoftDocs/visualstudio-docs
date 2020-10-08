---
title: "IDiaEnumSourceFiles::get__NewEnum | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaEnumSourceFiles::get__NewEnum method"
ms.assetid: 8405966c-64b4-4743-9a83-0e27ca2047c7
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaEnumSourceFiles::get__NewEnum
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves the <xref:System.Runtime.InteropServices.ComTypes.IEnumVARIANT> version of this enumerator.  
  
## Syntax  
  
```cpp#  
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
 [IDiaEnumSourceFiles](../../debugger/debug-interface-access/idiaenumsourcefiles.md)
