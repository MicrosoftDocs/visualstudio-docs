---
title: "call Method (Function) (JavaScript) | Microsoft Docs"
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
  - "call"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "call method"
ms.assetid: fa356dec-48e6-4f75-8bf3-c1814a76818f
caps.latest.revision: 10
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# call Method (Function) (JavaScript)
Calls a method of an object, substituting another object for the current object.  
  
## Syntax  
  
```  
call([thisObj[, arg1[, arg2[,  [, argN]]]]])  
```  
  
## Parameters  
 `thisObj`  
 Optional. The object to be used as the current object.  
  
 `arg1, arg2, , argN`  
 Optional. A list of arguments to be passed to the method.  
  
## Remarks  
 The `call` method is used to call a method on behalf of another object. It allows you to change the `this` object of a function from the original context to the new object specified by `thisObj`.  
  
 If `thisObj` is not supplied, the `global` object is used as `thisObj`.  
  
## Example  
 The following code shows how to use the `call` method.  
  
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
  
document.write("Function called with call: <br/>");  
document.write(callMe.call(3, 4, 5));  
  
// Output:   
// Original function:   
// this value: [object Window]  
// arguments: 1  
// arguments: 2  
  
// Function called with call:   
// this value: 3  
// arguments: 4  
// arguments: 5  
  
```  
  
## Requirements  
 [!INCLUDE[jsv55](../../javascript/reference/includes/jsv55-md.md)]  
  
## See Also  
 [Function Object](../../javascript/reference/function-object-javascript.md)   
 [apply Method (Function)](../../javascript/reference/apply-method-function-javascript.md)