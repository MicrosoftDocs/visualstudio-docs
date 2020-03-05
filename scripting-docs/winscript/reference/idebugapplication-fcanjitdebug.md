---
title: "IDebugApplication::FCanJitDebug | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugApplication.FCanJitDebug"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugApplication::FCanJitDebug"
ms.assetid: d7ddac65-4864-411f-bf66-34a46c03f239
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugApplication::FCanJitDebug
Determines if a just-in-time (JIT) debugger is registered.  
  
## Syntax  
  
```cpp
BOOL FCanJitDebug();  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 If the method succeeds and a JIT debugger is registered, the method returns `TRUE`. Otherwise, it returns `FALSE`.  
  
## Remarks  
 This method determines if a JIT debugger is registered.  
  
## See also  
 [IDebugApplication Interface](../../winscript/reference/idebugapplication-interface.md)