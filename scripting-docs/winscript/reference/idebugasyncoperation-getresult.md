---
title: "IDebugAsyncOperation::GetResult | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugAsyncOperation.GetResult"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugAsyncOperation::GetResult"
ms.assetid: 56d43365-6b12-4213-a97c-953c40d7b7f6
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugAsyncOperation::GetResult
Provides the return value and return object parameter from the synchronous debug operation.  
  
## Syntax  
  
```cpp
HRESULT GetResult(  
   HRESULT*    phrResult,  
   IUnknown**  ppunkResult  
);  
```  
  
#### Parameters  
 `phrResult`  
 [out] If the operation is complete, `phrResult` is the return value of `IDebugSyncOperation::Execute`.  
  
 `ppunkResult`  
 [out] If the operation is complete, `ppunkResult` is the object parameter returned by the operation.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
|`E_PENDING`|The operation has not completed.|  
  
## Remarks  
 If the operation has completed, this method returns the `HRESULT` and object parameter from `IDebugSyncOperation::Execute`.  
  
## See also  
 [IDebugAsyncOperation Interface](../../winscript/reference/idebugasyncoperation-interface.md)   
 [IDebugSyncOperation::Execute](../../winscript/reference/idebugsyncoperation-execute.md)