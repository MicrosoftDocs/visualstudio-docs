---
title: "function Statement (JavaScript) | Microsoft Docs"
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
  - "function_JavaScriptKeyword"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "new operator"
  - "declaring functions, syntax"
  - "function statement"
  - "declaring functions"
ms.assetid: cc9cfd43-1305-41c8-ad67-545d20f4fafe
caps.latest.revision: 20
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# function Statement (JavaScript)
Declares a new function.  
  
## Syntax  
  
```  
function functionname ([arg1 [, arg2 [,...[, argN]]]]) {  
    statements  
}   
```  
  
## Parameters  
 `functionname`  
 Required. The name of the function.  
  
 `arg1...argN`  
 Optional. An optional, comma-separated list of arguments the function understands.  
  
 `statements`  
 Optional. One or more[!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] statements.  
  
## Remarks  
 Use the `function` statement to declare a function for later use. The code that is contained in `statements` is not executed until the function is called from elsewhere in the script.  
  
 The [return](../../javascript/reference/return-statement-javascript.md) statement is used to return a value from the function. You do not have to use a `return` statement; the program will return when it reaches the end of the function. If no `return` statement is executed in the function, or if the `return` statement has no expression, the function returns the value `undefined`.  
  
> [!NOTE]
>  When you call a function, be sure to include the parentheses and any required arguments. Calling a function without parentheses returns a reference to the function, not the results of the function.  
  
## Example  
 The following example illustrates the use of the `function` statement.  
  
```javascript  
function myfunction (arg1, arg2) {  
    var r = arg1 * arg2;  
    return(r);  
}  
```  
  
## Example  
 A function can be assigned to a variable. This is illustrated in the following example.  
  
```javascript  
function AddFive(x) {  
    return x + 5;  
}  
  
function AddTen(x) {  
    return x + 10;  
}  
  
var condition = false;  
  
var MyFunc;  
if (condition) {  
    MyFunc = AddFive;  
}  
else {  
    MyFunc = AddTen;  
}  
  
var result = MyFunc(123);  
// Output: 133  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
## See Also  
 [new Operator](../../javascript/reference/new-operator-decrementjavascript.md)