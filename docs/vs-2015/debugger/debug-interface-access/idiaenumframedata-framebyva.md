---
title: "IDiaEnumFrameData::frameByVA | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaEnumFrameData::frameByVA method"
ms.assetid: 0b1e441b-710a-46d8-8060-bed39071c834
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaEnumFrameData::frameByVA
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Returns a frame by virtual address (VA).  
  
## Syntax  
  
```cpp#  
HRESULT frameByVA(   
   ULONGLONG       virtualAddress,  
   IDiaFrameData** frame  
);  
```  
  
#### Parameters  
 virtualAddress  
 [in] VA of the frame of interest.  
  
 frame  
 [out] Returns an [IDiaFrameData](../../debugger/debug-interface-access/idiaframedata.md) object that represents the frame that contains the address provided.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if no frame data matches the specified address. Otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumFrameData](../../debugger/debug-interface-access/idiaenumframedata.md)   
 [IDiaFrameData](../../debugger/debug-interface-access/idiaframedata.md)
