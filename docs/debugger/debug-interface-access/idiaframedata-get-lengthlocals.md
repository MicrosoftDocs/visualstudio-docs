---
title: "IDiaFrameData::get_lengthLocals | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaFrameData::get_lengthLocals method"
ms.assetid: 51fe15c3-4cd6-4a06-8a41-a56502209762
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: ghogen
ms.workload: 
  - "multiple"
---
# IDiaFrameData::get_lengthLocals
Retrieves the number of bytes of local variables pushed on the stack.  
  
## Syntax  
  
```C++  
HRESULT get_lengthLocals (   
   DWORD* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns the number of bytes of local variables.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.  
  
## Remarks  
 The value returned by this method is typically used in the interpretation of a program string (see the [IDiaFrameData::get_program](../../debugger/debug-interface-access/idiaframedata-get-program.md) method for the definition of a program string).  
  
## See Also  
 [IDiaFrameData](../../debugger/debug-interface-access/idiaframedata.md)   
 [IDiaFrameData::get_program](../../debugger/debug-interface-access/idiaframedata-get-program.md)