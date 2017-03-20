---
title: "then Method (Promise) | Microsoft Docs"
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
ms.assetid: c7f3259d-78f7-4ca7-8bdf-99fbd3f41e8d
caps.latest.revision: 6
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# then Method (Promise)
Allows you to specify work to be done on the fulfillment of a promise.  
  
## Syntax  
  
```  
  
promise.then(onCompleted, onRejected);  
```  
  
#### Parameters  
 `promise`  
 Required. The promise object.  
  
 `onCompleted`  
 Required. The fulfillment handler function to run when the promise completes successfully.  
  
 `onRejected`  
 Optional. The error handler function to run when the promise is rejected.  
  
## Remarks  
 A Promise must either be completed with a value, or it must be rejected with a reason. The `then` method of the Promise object runs when the promise is completed or rejected, whichever occurs first. If the promise is completed successfully, the fulfillment handler function of the `then` method runs. If the promise is rejected, the error handler function of the `then` method (or the `catch` method) runs.  
  
## Example  
 The following example shows how to call a function (`timeout`) that returns a promise. The fulfillment handler of the `then` method runs after the 5000ms timeout period expires.  
  
```JavaScript  
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
  
## Requirements  
 [!INCLUDE[jsv12](../../javascript/reference/includes/jsv12-md.md)]  
  
## See Also  
 [Promise Object](../../javascript/reference/promise-object-javascript.md)