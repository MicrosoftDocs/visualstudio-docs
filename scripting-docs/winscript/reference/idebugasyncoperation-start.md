---
title: "IDebugAsyncOperation::Start | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugAsyncOperation.Start"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugAsyncOperation::Start"
ms.assetid: a7272364-28e0-48ae-8405-b8bce8a6b9fd
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugAsyncOperation::Start
Causes the asynchronous operation to begin.  
  
## Syntax  
  
```cpp
HRESULT Start(  
   IDebugAsyncOperationCallBack*  padocb  
);  
```  
  
#### Parameters  
 `padocb`  
 The callback interface that receives status events from this operation.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
|`E_UNEXPECTED`|An operation is already pending.|  
  
## Remarks  
 This method causes `IDebugSyncOperation::Execute` to be called asynchronously in the thread obtained from `IDebugSyncOperation::GetTargetThread`. This method should be called only from within the debugger thread; otherwise, it will not return until the operation is complete.  
  
## See also  
 [IDebugAsyncOperation::Abort](../../winscript/reference/idebugasyncoperation-abort.md)   
 [IDebugAsyncOperation Interface](../../winscript/reference/idebugasyncoperation-interface.md)   
 [IDebugSyncOperation::Execute](../../winscript/reference/idebugsyncoperation-execute.md)   
 [IDebugSyncOperation::GetTargetThread](../../winscript/reference/idebugsyncoperation-gettargetthread.md)