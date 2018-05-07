---
title: "catch Method (Promise) | Microsoft Docs"
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
ms.assetid: 55266f6a-db4d-4de8-857a-8bc7d35ed4b8
caps.latest.revision: 6
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# catch Method (Promise)
Allows you to specify work to be done on the rejection of a promise.  
  
## Syntax  
  
```  
  
promise.catch(onRejected)  
```  
  
#### Parameters  
 `promise`  
 Required. The promise object.  
  
 `onRejected`  
 Required. The error handler function to run when a promise is rejected.  
  
## Remarks  
  
## Example  
 In the following code example, the first call to timeout returns after 5000ms. In this code, the promise is rejected, and the error handler function runs.  
  
```JavaScript  
function timeout(duration) {  
    return new Promise(function(resolve, reject) {  
        setTimeout(reject, duration);  
    });  
}  
  
var p = timeout(5000).then(() => {  
    console.log("done!");  
}).catch(err => {  
    console.log("error!");  
})  
  
// Output (after five seconds):  
// error!  
```  
  
## Requirements  
 [!INCLUDE[jsv12](../../javascript/reference/includes/jsv12-md.md)]