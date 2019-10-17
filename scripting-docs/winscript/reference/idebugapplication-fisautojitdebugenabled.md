---
title: "IDebugApplication::FIsAutoJitDebugEnabled | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugApplication.FIsAutoJitDebugEnabled"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugApplication::FIsAutoJitDebugEnabled"
ms.assetid: 0551dd3b-e6eb-442a-8201-418f96fe62df
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugApplication::FIsAutoJitDebugEnabled
Determines if a just-in-time (JIT) debugger is registered to auto-debug dumb hosts.  
  
## Syntax  
  
```cpp
BOOL FIsAutoJitDebugEnabled();  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 If the method succeeds and a JIT debugger is registered to auto-debug dumb hosts, the method returns `TRUE`. Otherwise, it returns `FALSE`.  
  
## Remarks  
 This method determines if a JIT debugger is registered to auto-debug dumb hosts.  
  
## See also  
 [IDebugApplication Interface](../../winscript/reference/idebugapplication-interface.md)