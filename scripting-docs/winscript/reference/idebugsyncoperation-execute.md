---
title: "IDebugSyncOperation::Execute | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugSyncOperation.Execute"
apilocation: 
  - "jscript.dll"
helpviewer_keywords: 
  - "IDebugSyncOperation::Execute"
ms.assetid: a45b8c7d-c51a-4098-877f-fbec2f1f6947
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugSyncOperation::Execute
Synchronously performs the operation and returns.  
  
## Syntax  
  
```cpp
HRESULT Execute(  
   IUnknown**  ppunkResult  
);  
```  
  
#### Parameters  
 `ppunkResult`  
 [out] The object parameter returned by the operation.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
|`E_ABORT`|The operation was aborted by calling the `IDebugSyncOperation::InProgressAbort` method.|  
  
## Remarks  
 The Process Debug Manager in the target thread calls the `Execute` method synchronously.  
  
## See also  
 [IDebugSyncOperation Interface](../../winscript/reference/idebugsyncoperation-interface.md)