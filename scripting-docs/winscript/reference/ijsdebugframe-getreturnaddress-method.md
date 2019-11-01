---
title: "IJsDebugFrame::GetReturnAddress Method | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IJsDebugFrame.GetReturnAddress"
apilocation: 
  - "jscript9diag.dll"
ms.assetid: 7f10c1d6-d7b9-402e-9020-04cded37f9d3
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IJsDebugFrame::GetReturnAddress Method
Gets the return address pushed at the 'start' (see GetStackRange) of the frame.  
  
## Syntax  
  
```cpp
HRESULT GetReturnAddress(  
   UINT64 *pReturnAddress  
);  
```  
  
#### Parameters  
 `pReturnAddress`  
 [out] The return address.  
  
## Return Value  
  
## Requirements  
 **Header:** jscript9diag.h  
  
## See also  
 [IJsDebugFrame Interface](../../winscript/reference/ijsdebugframe-interface.md)