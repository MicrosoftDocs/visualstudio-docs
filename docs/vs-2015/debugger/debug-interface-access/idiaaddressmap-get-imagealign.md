---
title: "IDiaAddressMap::get_imageAlign | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaAddressMap::get_imageAlign method"
ms.assetid: f1ba8071-669c-4cf7-9ac0-02f26d99f366
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaAddressMap::get_imageAlign
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves the current image alignment.  
  
## Syntax  
  
```cpp#  
HRESULT get_imageAlign (   
   DWORD* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns  the image alignment value from the executable.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 Images are aligned to specific memory boundaries depending how the image was loaded and created. The alignment is typically on 1, 2, 4, 8, 16, 32, or 64 byte boundaries. The image alignment can be set with a call to the [IDiaAddressMap::put_imageAlign](../../debugger/debug-interface-access/idiaaddressmap-put-imagealign.md) method.  
  
## See Also  
 [IDiaAddressMap](../../debugger/debug-interface-access/idiaaddressmap.md)   
 [IDiaAddressMap::put_imageAlign](../../debugger/debug-interface-access/idiaaddressmap-put-imagealign.md)
