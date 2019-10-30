---
title: "IDebugApplicationThread::QueryIsCurrentThread | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugApplicationThread.QueryIsCurrentThread"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugApplicationThread::QueryIsCurrentThread"
ms.assetid: 1580d3aa-3be8-4779-ac7b-41ab5c9edede
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugApplicationThread::QueryIsCurrentThread
Determines if this thread is the currently running thread.  
  
## Syntax  
  
```cpp
HRESULT QueryIsCurrentThread();  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded and this is the currently running thread.|  
|`S_FALSE`|This is not the currently running thread.|  
  
## Remarks  
 This method determines if this thread is the currently running thread.  
  
## See also  
 [IDebugApplicationThread Interface](../../winscript/reference/idebugapplicationthread-interface.md)