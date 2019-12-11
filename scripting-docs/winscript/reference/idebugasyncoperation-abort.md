---
title: "IDebugAsyncOperation::Abort | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugAsyncOperation.Abort"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugAsyncOperation::Abort"
ms.assetid: 232541c6-81b8-4eb7-96a7-a8e5fe087b31
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugAsyncOperation::Abort
Cancels an operation.  
  
## Syntax  
  
```cpp
HRESULT Abort();  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|The method succeeded.|  
|E_NOTIMPL|The operations cannot be canceled.|  
  
## Remarks  
 This method is typically called from within the debugger thread to cancel an unresponsive operation. This method causes the `InProgressAbort` method on the `IDebugSyncOperation` object to be called.  
  
## See also  
 [IDebugAsyncOperation Interface](../../winscript/reference/idebugasyncoperation-interface.md)   
 [IDebugAsyncOperation::Start](../../winscript/reference/idebugasyncoperation-start.md)   
 [IDebugSyncOperation::InProgressAbort](../../winscript/reference/idebugsyncoperation-inprogressabort.md)