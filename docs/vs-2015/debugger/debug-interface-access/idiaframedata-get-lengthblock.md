---
title: "IDiaFrameData::get_lengthBlock | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaFrameData::get_lengthBlock method"
ms.assetid: 2e54deb7-7744-428e-913c-1d47a2aa89b0
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaFrameData::get_lengthBlock
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves the length, in bytes, of the block of code described by the frame.  
  
## Syntax  
  
```cpp#  
HRESULT get_lengthBlock (   
   DWORD* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns the number of bytes of code in the frame.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.  
  
## Remarks  
 The value returned by this method is typically used in the interpretation of a program string (see the [IDiaFrameData::get_program](../../debugger/debug-interface-access/idiaframedata-get-program.md) method for the definition of a program string).  
  
## See Also  
 [IDiaFrameData](../../debugger/debug-interface-access/idiaframedata.md)   
 [IDiaFrameData::get_program](../../debugger/debug-interface-access/idiaframedata-get-program.md)
