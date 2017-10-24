---
title: "Promise.reject Function (Promise) | Microsoft Docs"
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
ms.assetid: 9746e15b-9717-4e36-bf6b-910dcc6cd667
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Promise.reject Function (Promise)
Creates a new rejected promise with a result equal to the passed in argument.  
  
## Syntax  
  
```  
Promise.reject(r);  
```  
  
#### Parameters  
 `r`  
 Required. The reason why the promise was rejected.  
  
## Remarks  
 The error handling function of the `then` or `catch` method runs when the rejected promise is returned.  
  
## Example  
  
```JavaScript  
var p = Promise.reject('failure');  
p.catch(function(result) {  
    console.log(result);  
});  
  
// Output:  
// failure  
```  
  
## Requirements  
 [!INCLUDE[jsv12](../../javascript/reference/includes/jsv12-md.md)]  
  
## See Also  
 [Promise Object](../../javascript/reference/promise-object-javascript.md)