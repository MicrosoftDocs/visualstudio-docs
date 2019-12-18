---
title: "IDebugCookie::SetDebugCookie | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugCookie.SetDebugCookie"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugCookie::SetDebugCookie"
ms.assetid: 9cba3b05-ff81-4fb0-9382-e9338cb9192d
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugCookie::SetDebugCookie
Sets the debug application cookie.  
  
## Syntax  
  
```cpp
HRESULT SetDebugCookie(  
   DWORD  dwDebugAppCookie  
);  
```  
  
#### Parameters  
 `dwDebugAppCookie`  
 [in] A cookie that identifies the debug application.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method sets the debug application cookie, which allows more than one debugger to attach to a process.  
  
## See also  
 [IDebugCookie Interface](../../winscript/reference/idebugcookie-interface.md)