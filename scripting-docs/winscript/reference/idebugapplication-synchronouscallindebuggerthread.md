---
title: "IDebugApplication::SynchronousCallInDebuggerThread | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugApplication.SynchronousCallInDebuggerThread"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugApplication::SynchronousCallInDebuggerThread"
ms.assetid: 9daa1722-f25a-4691-aefc-fd28672fb883
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugApplication::SynchronousCallInDebuggerThread
Provides a mechanism for the caller to run code in the debugger thread.  
  
## Syntax  
  
```cpp
HRESULT SynchronousCallInDebuggerThread(  
   IDebugThreadCall*  pptc,  
   DWORD_PTR          dwParam1,  
   DWORD_PTR          dwParam2,  
   DWORD_PTR          dwParam3  
);  
```  
  
#### Parameters  
 `pptc`  
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
 Language engines and hosts typically use this method to implement free-threaded objects on top of their single threaded implementations.  
  
## See also  
 [IDebugApplication Interface](../../winscript/reference/idebugapplication-interface.md)   
 [IDebugThreadCall Interface](../../winscript/reference/idebugthreadcall-interface.md)