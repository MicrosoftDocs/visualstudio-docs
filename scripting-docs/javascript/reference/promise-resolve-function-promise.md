---
title: "Promise.resolve Function (Promise) | Microsoft Docs"
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
ms.assetid: 0fb6bff9-54ab-41be-97d7-04f7e6fe9cff
caps.latest.revision: 6
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Promise.resolve Function (Promise)
Creates a new resolved promise with a result equal to its argument.  
  
## Syntax  
  
```  
Promise.resolve(x)  
```  
  
#### Parameters  
 `x`  
 Required. The value returned with the completed promise.  
  
## Remarks  
 The fulfillment handling function of the `then` method runs when the completed promise object is returned.  
  
## Example  
  
```javascript  
var p = Promise.resolve('success');  
p.then(function(result) {  
    console.log(result);  
});  
  
// Output:  
// success  
```  
  
## Requirements  
 [!INCLUDE[jsv12](../../javascript/reference/includes/jsv12-md.md)]  
  
## See Also  
 [Promise Object](../../javascript/reference/promise-object-javascript.md)