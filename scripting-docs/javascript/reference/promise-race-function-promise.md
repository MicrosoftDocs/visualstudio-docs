---
title: "Promise.race Function (Promise) | Microsoft Docs"
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
ms.assetid: 9236eced-d313-4d03-8c3e-d89d762b3084
caps.latest.revision: 6
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Promise.race Function (Promise)
Creates a new promise that will resolve or reject with the same result value as the first promise to resolve or reject among the passed in arguments.  
  
## Syntax  
  
```  
Promise.race(iterable)  
```  
  
#### Parameters  
 `iterable`  
 Required. One or more promises.  
  
## Remarks  
 If one of the promises in `iterable` is already in a resolved or rejected state, `Promise.race` returns a promise resolved or rejected in the same way with the result value equal to the value used to resolve (or reject) that promise. If multiple promises in `iterable` are already resolved or rejected, `Promise.race` returns a promise resolved in the same way as the first promise iterated. If no promise in iterable resolves or rejects, the promise returned from `Promise.race` also does not resolve or reject.  
  
## Example  
  
```JavaScript  
var p1 = new Promise(function(resolve, reject) {  
    setTimeout(resolve, 0, 'success');  
});  
var p2 = new Promise(function(resolve, reject) { });  
var p3 = new Promise(function(resolve, reject) { });  
  
var race = Promise.race( [p1, p2, p3] );  
race.then(function(result) {  
    console.log(result);  
});  
  
// Output:  
// success  
  
var race = Promise.race( [Promise.reject('failure'),  
    Promise.resolve('success')] );  
race.catch(function(result) {  
    console.log(result);  
});  
  
// Output:  
// failure  
  
```  
  
## Requirements  
 [!INCLUDE[jsv12](../../javascript/reference/includes/jsv12-md.md)]  
  
## See Also  
 [Promise Object](../../javascript/reference/promise-object-javascript.md)
