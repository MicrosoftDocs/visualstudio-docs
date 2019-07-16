---
title: "IDiaSectionContrib::get_dataCrc | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaSectionContrib::get_dataCrc method"
ms.assetid: 33b7488f-dc9c-47b3-b08c-737e0eb1bf7d
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaSectionContrib::get_dataCrc
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves the cyclic redundancy check (CRC) of the data in the section.  
  
## Syntax  
  
```cpp#  
HRESULT get_dataCrc (   
   DWORD* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns the CRC of the data in the section.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.  
  
## See Also  
 [IDiaSectionContrib](../../debugger/debug-interface-access/idiasectioncontrib.md)
