---
title: "IDebugApplication::QueryCurrentThreadIsDebuggerThread | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugApplication.QueryCurrentThreadIsDebuggerThread"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugApplication::QueryCurrentThreadIsDebuggerThread"
ms.assetid: e22ad8a4-a8be-423d-80f2-28256a7448ed
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugApplication::QueryCurrentThreadIsDebuggerThread
Determines if the current running thread is the debugger thread.  
  
## Syntax  
  
```cpp
HRESULT QueryCurrentThreadIsDebuggerThread();  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded and the current running thread is the debugger thread.|  
|`S_FALSE`|The current running thread is not the debugger thread.|  
  
## Remarks  
 This method determines if the current running thread is the debugger thread.  
  
## See also  
 [IDebugApplication Interface](../../winscript/reference/idebugapplication-interface.md)