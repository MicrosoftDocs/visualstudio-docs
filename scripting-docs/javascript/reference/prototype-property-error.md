---
title: "prototype Property (Error) | Microsoft Docs"
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
ms.assetid: 6c268a51-1a3d-4397-abf8-e54ca4e598fe
caps.latest.revision: 2
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# prototype Property (Error)
Returns a reference to the prototype for an error.  
  
## Syntax  
  
```  
  
error.prototype  
```  
  
## Remarks  
 The `error` argument is the name of an error.  
  
 Use the `prototype` property to provide a base set of functionality to an Error. New instances of an object "inherit" the behavior of the prototype assigned to that object.  
  
 For example, to add a method to the `Error` object that returns the value of the largest element of the array, declare the function, add it to `Error.prototype`, and then use it.  
  
```JavaScript  
function getSeverity(){  
    if (this.number > 1000)  
        return "high";  
    else  
        return "low";  
}  
Error.prototype.getSev = getSeverity;  
var myError = new Error();  
myError.number = 5000;  
  
document.write(myError.getSev());   
  
// Output: high  
  
```  
  
 All intrinsic [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] objects have a `prototype` property that is read-only. Properties and methods may be added to the prototype, but the object may not be assigned a different prototype. However, user-defined objects may be assigned a new prototype.  
  
## Requirements  
 [!INCLUDE[jsv2](../../javascript/reference/includes/jsv2-md.md)]