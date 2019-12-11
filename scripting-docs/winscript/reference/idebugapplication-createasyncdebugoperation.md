---
title: "IDebugApplication::CreateAsyncDebugOperation | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugApplication.CreateAsyncDebugOperation"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugApplication::CreateAsyncDebugOperation"
ms.assetid: bc32b101-6364-4498-8458-bd5f3ab5ad94
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugApplication::CreateAsyncDebugOperation
Provides asynchronous access to a given synchronous debug operation.  
  
## Syntax  
  
```cpp
HRESULT CreateAsyncDebugOperation(  
   IDebugSyncOperation*    psdo,  
   IDebugAsyncOperation**  ppado  
);  
```  
  
#### Parameters  
 `psdo`  
 [in] The synchronous debug operation object.  
  
 `ppado`  
 [out] The asynchronous debug operation object.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method allows language engines to evaluate expressions asynchronously without explicitly synchronizing with the debugger thread. For more information, see [IDebugSyncOperation Interface](../../winscript/reference/idebugsyncoperation-interface.md) and [IDebugAsyncOperation Interface](../../winscript/reference/idebugasyncoperation-interface.md).  
  
## See also  
 [IDebugApplication Interface](../../winscript/reference/idebugapplication-interface.md)   
 [IDebugSyncOperation Interface](../../winscript/reference/idebugsyncoperation-interface.md)   
 [IDebugAsyncOperation Interface](../../winscript/reference/idebugasyncoperation-interface.md)