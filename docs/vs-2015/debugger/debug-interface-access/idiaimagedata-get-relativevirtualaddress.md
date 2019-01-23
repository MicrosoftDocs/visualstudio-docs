---
title: "IDiaImageData::get_relativeVirtualAddress | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaImageData::get_relativeVirtualAddress method"
ms.assetid: e6d6deee-dc12-4b38-af15-f917b2d4368e
caps.latest.revision: 13
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaImageData::get_relativeVirtualAddress
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves the location in virtual memory of the module relative to the application.  
  
## Syntax  
  
```cpp#  
HRESULT get_relativeVirtualAddress (   
   DWORD* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns the relative virtual memory offset of the module.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaImageData](../../debugger/debug-interface-access/idiaimagedata.md)
