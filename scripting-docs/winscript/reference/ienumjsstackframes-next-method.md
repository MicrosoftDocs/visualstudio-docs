---
title: "IEnumJsStackFrames::Next Method | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IEnumJsStackFrames.Next"
apilocation: 
  - "jscript9diag.dll"
ms.assetid: efceb3a1-9239-4f55-9cbb-94670679988b
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IEnumJsStackFrames::Next Method
Gets the specified number of frames.  
  
## Syntax  
  
```cpp
HRESULT Next(  
   ULONG cFrameCount,  
   JS_NATIVE_FRAME *pFrames,  
   ULONG *pcFetched  
);  
```  
  
#### Parameters  
 `cFrameCount`  
 [in] The number of frames to get.  
  
 `pFrames`  
 [out] The array to store the frames.  
  
 `pcFetched`  
 [out] The number of frames returned.  
  
## Return Value  
  
## Requirements  
 **Header:** jscript9diag.h  
  
## See also  
 [IEnumJsStackFrames Interface](../../winscript/reference/ienumjsstackframes-interface.md)