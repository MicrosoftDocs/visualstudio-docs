---
title: "IDebugApplication::StepOutComplete | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugApplication.StepOutComplete"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugApplication::StepOutComplete"
ms.assetid: 9675b214-7be5-4cf7-a63f-7865f3c54371
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugApplication::StepOutComplete
Notifies the process debug manager that a language engine in single-step mode is about to return to its caller.  
  
## Syntax  
  
```cpp
HRESULT StepOutComplete();  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 Language engines call this method in single-step mode just before they return to their caller. The process debug manager uses this opportunity to notify all other script engines that they should break at the first opportunity. This technique is how cross-language step modes are implemented.  
  
## See also  
 [IDebugApplication Interface](../../winscript/reference/idebugapplication-interface.md)