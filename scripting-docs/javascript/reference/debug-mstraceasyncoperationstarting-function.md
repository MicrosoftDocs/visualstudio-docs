---
title: "Debug.msTraceAsyncOperationStarting Function | Microsoft Docs"
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
ms.assetid: c8458264-07e0-4cd6-8528-ff7cf009cf9e
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Debug.msTraceAsyncOperationStarting Function
Initiates a trace for an asynchronous operation.  
  
## Syntax  
  
```  
Debug.msTraceAsyncOperationStarting(operationName)  
```  
  
#### Parameters  
 `operationName`  
 Required. A string that identifies the asynchronous operation. If `operationName` is null or undefined, an empty string is used for the operation name.  
  
## Return Value  
 An integer representing the operation ID.  
  
## Remarks  
 Call this method before the asynchronous operation starts.  
  
> [!NOTE]
>  Some debugging tools do not display the information sent to the debugger.  
  
## Example  
 The following code provides an example of instrumenting an asynchronous call for a [!INCLUDE[win8_appname_long](../../javascript/includes/win8-appname-long-md.md)] app.  
  
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