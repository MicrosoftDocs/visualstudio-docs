---
title: "Debug.msTraceAsyncOperationCompleted Function | Microsoft Docs"
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
  - "DHTML"
ms.assetid: 9b628b71-61f1-478a-857f-5e1f607db56c
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Debug.msTraceAsyncOperationCompleted Function
Indicates that an asynchronous operation has completed.  
  
## Syntax  
  
```  
Debug.msTraceAsyncOperationCompleted(asyncOperationId, status)  
```  
  
#### Parameters  
 `asyncOperationId`  
 Required. The ID associated with an asynchronous operation.  
  
 `status`  
 Optional. The status of the asynchronous operation. If not specified, `Debug.MS_ASYNC_OP_STATUS_SUCCESS` is used.  
  
## Remarks  
 Call this function when the asynchronous operation completes.  
  
 `asyncOperationId` must correspond to the operation ID previously returned from `Debug.msTraceAsyncOperationStarting`.  
  
 The possible values for `status` include:  
  
-   `Debug.MS_ASYNC_OP_STATUS_SUCCESS`  
  
-   `Debug.MS_ASYNC_OP_STATUS_CANCELED`  
  
-   `Debug.MS_ASYNC_OP_STATUS_ERROR`  
  
> [!NOTE]
>  Some debugging tools do not display the information sent to the debugger.  
  
## Example  
 The following code provides an example of tracing an asynchronous call for a [!INCLUDE[win8_appname_long](../../javascript/includes/win8-appname-long-md.md)] app.  
  
```javascript  
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