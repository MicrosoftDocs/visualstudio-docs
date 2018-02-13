---
title: "return Statement (JavaScript) | Microsoft Docs"
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
  - "return_JavaScriptKeyword"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "terminating execution"
  - "return statement"
  - "function statement"
  - "return statement, syntax"
  - "return statement, exiting functions in script"
ms.assetid: a9130d90-11fb-43f5-a819-7e5435f74c05
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# return Statement (JavaScript)
Exits from the current function and returns a value from that function.  
  
## Syntax  
  
```  
  
return[(][expression][)];   
```  
  
## Remarks  
 The optional *expression* argument is the value to be returned from the function. If omitted, the function does not return a value.  
  
 You use the `return` statement to stop execution of a function and return the value of *expression*. If *expression* is omitted, or no `return` statement is executed from within the function, the expression that called the current function is assigned the value undefined.  
  
## Example  
 The following example illustrates the use of the `return` statement.  
  
```JavaScript  
function myfunction(arg1, arg2){  
   var r;  
   r = arg1 * arg2;  
   return(r);  
}  
```  
  
## Example  
 The following example illustrates the use of the `return` statement to return a function.  
  
```JavaScript  
function doWork() {  
    return function calculate(y) { return y + 1; };  
}  
  
var func = doWork();  
var x = func(5);  
document.write(x);  
  
// Output: 6  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
## See Also  
 [function Statement](../../javascript/reference/function-statement-javascript.md)