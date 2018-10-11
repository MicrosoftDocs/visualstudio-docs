---
title: "IDiaFrameData::get_lengthSavedRegisters | Microsoft Docs"
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
  - "IDiaFrameData::get_lengthSavedRegisters method"
ms.assetid: dfda4e91-9bfa-4b9d-9133-b73015bfa4d5
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDiaFrameData::get_lengthSavedRegisters
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IDiaFrameData::get_lengthSavedRegisters](https://docs.microsoft.com/visualstudio/debugger/debug-interface-access/idiaframedata-get-lengthsavedregisters).  
  
Retrieves the number of bytes of saved registers pushed on the stack.  
  
## Syntax  
  
```cpp#  
HRESULT get_lengthSavedRegisters (   
   DWORD* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns the number of bytes of saved registers.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.  
  
## Remarks  
 The value returned by this method is typically used in the interpretation of a program string (see the [IDiaFrameData::get_program](../../debugger/debug-interface-access/idiaframedata-get-program.md) method for the definition of a program string).  
  
## See Also  
 [IDiaFrameData](../../debugger/debug-interface-access/idiaframedata.md)   
 [IDiaFrameData::get_program](../../debugger/debug-interface-access/idiaframedata-get-program.md)



