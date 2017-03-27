---
title: "Debug.msTraceAsyncCallbackStarting Function | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-javascript"
ms.tgt_pltfrm: ""
ms.topic: "language-reference"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
ms.assetid: 0e2ca7c4-103c-44f2-b76c-102fb1e42543
caps.latest.revision: 6
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Debug.msTraceAsyncCallbackStarting Function
Associates the callback stack with a previously specified asynchronous operation.  
  
## Syntax  
  
```  
Debug.msTraceAsyncCallbackStarting(asyncOperationId)  
```  
  
#### Parameters  
 `asyncOperationId`  
 Required. The ID associated with the asynchronous operation.  
  
## Remarks  
 Call this function in the callback function for the asynchronous operation after the call to `Debug.msTraceAsyncOperationCompleted`.  
  
> [!NOTE]
>  Some debugging tools do not display the information sent to the debugger.  
  
 `asyncOperationId` must correspond to the operation name previously returned from `Debug.msTraceAsyncOperationStarting`.  
  
## Example  
 The following code provides an example of tracing an asynchronous call for a [!INCLUDE[win8_appname_long](../../javascript/includes/win8-appname-long-md.md)] app.  
  
```JavaScript  
function asyncWrapperFunction() {  
    var opID = Debug.msTraceAsyncOperationStarting('async trace');  
    doSomethingAsync().then(function (result) {  
        Debug.msTraceAsyncOperationCompleted(opID, Debug.MS_ASYNC_OP_STATUS_SUCCESS);  
        Debug.msTraceAsyncCallbackStarting(opID);  
        // Process result of async operation.  
    }, function (error) {  
        Debug.msTraceAsyncOperationCompleted(opID, Debug.MS_ASYNC_OP_STATUS_ERROR);  
        Debug.msTraceAsyncCallbackStarting(opID);  
    });  
  
    Debug.msTraceAsyncCallbackCompleted();  
}  
  
function doSomethingAsync() {  
    return WinJS.Promise.as(true);  
}  
  
asyncWrapperFunction();  
```  
  
## Requirements  
 [!INCLUDE[jsv11](../../javascript/reference/includes/jsv11-md.md)]