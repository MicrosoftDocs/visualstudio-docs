---
title: "apply Method (Function) (JavaScript) | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-javascript"
ms.tgt_pltfrm: ""
ms.topic: "language-reference"
f1_keywords: 
  - "apply"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "Apply method"
ms.assetid: b36df78e-b14b-46ca-b5cb-de752d80f40a
caps.latest.revision: 10
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# apply Method (Function) (JavaScript)
Calls the function, substituting the specified object for the `this` value of the function, and the specified array for the arguments of the function.  
  
## Syntax  
  
```  
apply([thisObj[,argArray]])  
```  
  
## Parameters  
 `thisObj`  
 Optional. The object to be used as the `this` object.  
  
 `argArray`  
 Optional. A set of arguments to be passed to the function.  
  
## Remarks  
 If `argArray` is not a valid object, then an "Object expected" error occurs.  
  
 If neither `argArray` nor `thisObj` are supplied, the original `this` object is used as `thisObj` and no arguments are passed.  
  
## Example  
 The following code shows how to use the apply method.  
  
```JavaScript  
function callMe(arg1, arg2){  
    var s = "";  
  
    s += "this value: " + this;  
    s += "<br />";  
    for (i in callMe.arguments) {  
        s += "arguments: " + callMe.arguments[i];  
        s += "<br />";  
    }  
    return s;  
}  
  
document.write("Original function: <br/>");  
document.write(callMe(1, 2));  
document.write("<br/>");  
  
document.write("Function called with apply: <br/>");  
document.write(callMe.apply(3, [ 4, 5 ]));  
  
// Output:   
// Original function:   
// this value: [object Window]  
// arguments: 1  
// arguments: 2  
  
// Function called with apply:   
// this value: 3  
// arguments: 4  
// arguments: 5  
  
```  
  
## Requirements  
 [!INCLUDE[jsv55](../../javascript/reference/includes/jsv55-md.md)]  
  
## See Also  
 [Function Object](../../javascript/reference/function-object-javascript.md)