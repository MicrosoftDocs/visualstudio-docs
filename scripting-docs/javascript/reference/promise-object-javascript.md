---
title: "Promise Object (JavaScript) | Microsoft Docs"
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
ms.assetid: 358ad98b-f7fa-448c-9ee0-ef1e2a45e9c6
caps.latest.revision: 9
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Promise Object (JavaScript)
Provides a mechanism to schedule work to be done on a value that has not yet been computed. It is an abstraction for managing interactions with asynchronous APIs.  
  
## Syntax  
  
```  
var promise = new Promise(function(resolve, reject) { ... });  
```  
  
#### Parameters  
 `promise`  
 Required. The variable name to which the promise is assigned.  
  
 `resolve`  
 Required. A function that runs to indicate that the promise has completed successfully.  
  
 `reject`  
 Optional. A function that runs to indicate that the promise has been rejected with an error.  
  
## Remarks  
 A Promise must either be completed with a value, or it must be rejected with a reason. The `then` method of the Promise object runs when the promise is completed or rejected, whichever occurs first. If the promise is completed successfully, the fulfillment handler function  of the `then` method runs. If the promise is rejected, the error handler function of the `then` method (or the `catch` method) runs.  
  
## Example  
 The following example shows how to call a function (`timeout`) that returns a promise. The fulfillment handler of the `then` method runs after the 5000ms timeout period expires.  
  
```javascript  
function timeout(duration) {  
    return new Promise(function(resolve, reject) {  
        setTimeout(resolve, duration);  
    });  
}  
  
// Note: This code uses arrow function syntax  
var m = timeout(5000).then(() => {  
    console.log("done!");  
})  
  
// Output (after 5 seconds):  
// done!  
```  
  
## Example  
 You can also chain calls to the `then` method as shown in the following code. Each completion handler must itself return a promise to support chaining. In this code, which calls the same `timeout` function, the first call to timeout returns after 1000 ms. The first completion handler calls `timeout` again, and this promise returns after 2000ms. Its completion handler then throws an error. The error handler calls `Promise.all`, which returns only when both calls to timeout are completed or rejected.  
  
```javascript  
var p = timeout(1000).then(() => {  
    return timeout(2000);  
}).then(() => {  
    throw new Error("error");  
}).catch(err => {  
    return Promise.all([timeout(100), timeout(200)]);  
})  
```  
  
## Requirements  
 [!INCLUDE[jsv12](../../javascript/reference/includes/jsv12-md.md)]  
  
## Functions  
 The following table describes the functions of the `Promise` object.  
  
|Function|Description|  
|--------------|-----------------|  
|[Promise.all Function](../../javascript/reference/promise-all-function-promise.md)|Joins two or more promises and returns only when all the specified promises have completed or been rejected.|  
|[Promise.race Function](../../javascript/reference/promise-race-function-promise.md)|Creates a new promise that will resolve or reject with the same result value as the first promise to resolve or reject among the passed in arguments.|  
|[Promise.reject Function](../../javascript/reference/promise-reject-function-promise.md)|Creates a new rejected promise with a result equal to the passed in argument.|  
|[Promise.resolve Function](../../javascript/reference/promise-resolve-function-promise.md)|Creates a new resolved promise with a result equal to its argument.|  
  
## Methods  
 The following table describes the methods of the `Promise` object.  
  
|Method|Description|  
|------------|-----------------|  
|[catch Method](../../javascript/reference/catch-method-promise.md)|Allows you to specify work to be done on the rejection of a promise.|  
|[then Method](../../javascript/reference/then-method-promise.md)|Allows you to specify work to be done on the fulfillment of a promise.|