---
title: "IDebugApplicationThread::SynchronousCallIntoThread | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugApplicationThread.SynchronousCallIntoThread"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugApplicationThread::SynchronousCallIntoThread"
ms.assetid: 8a91157f-dade-418a-ad02-5607ce12c95c
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugApplicationThread::SynchronousCallIntoThread
Provides a mechanism for the caller to run code in the application thread.  
  
## Syntax  
  
```cpp
HRESULT SynchronousCallIntoThread(  
   IDebugThreadCall*  pstcb,  
   DWORD_PTR          dwParam1,  
   DWORD_PTR          dwParam2,  
   DWORD_PTR          dwParam3  
);  
```  
  
#### Parameters  
 `pstcb`  
 [in] The object to call.  
  
 `dwParam1`  
 [in] First parameter to pass to the `IDebugThreadCall::ThreadCallHandler` method.  
  
 `dwParam2`  
 [in] Second parameter to pass to the `IDebugThreadCall::ThreadCallHandler` method.  
  
 `dwParam3`  
 [in] Third parameter to pass to the `IDebugThreadCall::ThreadCallHandler` method.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method provides a mechanism for the caller to run code in the debugger thread. Language engines and hosts typically use this method to implement free-threaded objects on top of their single threaded implementations.  
  
## See also  
 [IDebugApplicationThread Interface](../../winscript/reference/idebugapplicationthread-interface.md)   
 [IDebugThreadCall Interface](../../winscript/reference/idebugthreadcall-interface.md)