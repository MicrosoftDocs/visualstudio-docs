---
title: "IDiaSectionContrib::get_relocationsCrc | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaSectionContrib::get_relocationsCrc method"
ms.assetid: 8c29c91a-062d-4566-a9b7-49251036a15a
caps.latest.revision: 12
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaSectionContrib::get_relocationsCrc
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves the cyclic redundancy check (CRC) of the relocation information for the section.  
  
## Syntax  
  
```cpp#  
HRESULT get_relocationsCrc (   
   DWORD* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns the CRC of the relocation information for the section.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.  
  
## See Also  
 [IDiaSectionContrib](../../debugger/debug-interface-access/idiasectioncontrib.md)
