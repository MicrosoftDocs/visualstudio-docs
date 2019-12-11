---
title: "IDebugApplication::StartDebugSession | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugApplication.StartDebugSession"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugApplication::StartDebugSession"
ms.assetid: 737f8424-bbcf-473f-9cf1-6601b9aa250d
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugApplication::StartDebugSession
Starts the default debugger integrated development environment (IDE) and attaches a debug session to this application, if one is not already attached.  
  
## Syntax  
  
```cpp
HRESULT StartDebugSession();  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method is used to implement just-in-time debugging.  
  
## See also  
 [IDebugApplication Interface](../../winscript/reference/idebugapplication-interface.md)