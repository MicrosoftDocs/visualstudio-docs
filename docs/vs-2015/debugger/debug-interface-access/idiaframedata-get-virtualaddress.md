---
title: "IDiaFrameData::get_virtualAddress | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaFrameData::get_virtualAddress method"
ms.assetid: de137bee-132f-4aae-a067-9578b7a3e6d4
caps.latest.revision: 12
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaFrameData::get_virtualAddress
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves the virtual address (VA) of the code for the frame.  
  
## Syntax  
  
```cpp#  
HRESULT get_virtualAddress (   
   ULONGLONG* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns the virtual address of the code for the frame.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.  
  
## See Also  
 [IDiaFrameData](../../debugger/debug-interface-access/idiaframedata.md)
