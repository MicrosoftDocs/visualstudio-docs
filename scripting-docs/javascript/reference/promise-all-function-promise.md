---
title: "Promise.all Function (Promise) | Microsoft Docs"
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
ms.assetid: 02a7b90c-96f6-4484-9466-d261efa1b494
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Promise.all Function (Promise)
Joins two or more promises and returns only when all the specified promises have completed or been rejected.  
  
## Syntax  
  
```  
Promise.all(func1, func2 [,funcN])  
```  
  
#### Parameters  
 `func1`  
 Required. A function that returns a promise.  
  
 `func2`  
 Required. A function that returns a promise.  
  
 `funcN`  
 Optional. One or more functions that return a promise.  
  
## Remarks  
 The result returned is an array of values returned by the completed promises. If one of the joined promises is rejected, `Promise.all` immediately returns with the reason for the rejected promise (all other returns values are discarded).  
  
## Example  
 In this code, the first call to timeout returns after 5000ms. The completion handler calls `Promise.all`, which returns only when both calls to timeout are completed or rejected.  
  
```javascript  
function timeout(duration) {  
    return new Promise(function(resolve, reject) {  
        setTimeout(resolve, duration);  
    });  
}  
  
var p = timeout(5000).then(() => {  
    return Promise.all([timeout(100), timeout(200)]);  
})  
```  
  
## Requirements  
 [!INCLUDE[jsv12](../../javascript/reference/includes/jsv12-md.md)]  
  
## See Also  
 [Promise Object](../../javascript/reference/promise-object-javascript.md)