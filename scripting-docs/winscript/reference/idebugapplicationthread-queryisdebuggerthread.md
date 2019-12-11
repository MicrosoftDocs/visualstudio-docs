---
title: "IDebugApplicationThread::QueryIsDebuggerThread | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugApplicationThread.QueryIsDebuggerThread"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugApplicationThread::QueryIsDebuggerThread"
ms.assetid: 78a9cfbf-7c62-4aab-82a2-35037e2f9d46
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugApplicationThread::QueryIsDebuggerThread
Determines if this thread is the debugger thread.  
  
## Syntax  
  
```cpp
HRESULT QueryIsDebuggerThread();  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded and this is the debugger thread.|  
|`S_FALSE`|This is not the debugger thread.|  
  
## Remarks  
 This method determines if this thread is the debugger thread.  
  
## See also  
 [IDebugApplicationThread Interface](../../winscript/reference/idebugapplicationthread-interface.md)