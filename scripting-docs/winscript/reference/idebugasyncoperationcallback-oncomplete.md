---
title: "IDebugAsyncOperationCallBack::onComplete | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugAsyncOperationCallBack.onComplete"
apilocation: 
  - "jscript.dll"
helpviewer_keywords: 
  - "IDebugAsyncOperationCallBack::onComplete"
ms.assetid: d4023f5a-41f9-4948-b0dc-3317d61bb783
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugAsyncOperationCallBack::onComplete
Signals that a result is available from an asynchronous debug operation.  
  
## Syntax  
  
```cpp
HRESULT onComplete();  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method signals that a result is available from an `IDebugAsyncOperation` object. The event fires in the debugger thread.  
  
## See also  
 [IDebugAsyncOperationCallBack Interface](../../winscript/reference/idebugasyncoperationcallback-interface.md)   
 [IDebugAsyncOperation Interface](../../winscript/reference/idebugasyncoperation-interface.md)