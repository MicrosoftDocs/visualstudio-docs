---
title: "Function Object (JavaScript) | Microsoft Docs"
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
  - "function"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "Function object"
ms.assetid: d3834767-203c-475e-848c-95c423ba15b6
caps.latest.revision: 12
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Function Object (JavaScript)
Creates a new function.  
  
## Syntax  
  
```  
function functionName([argname1  [, ...[, argnameN]]])  
{  
   body  
}  
```  
  
## Syntax  
  
```  
  
functionName = new Function( [argname1,  [... argnameN,]] body );  
```  
  
## Parameters  
 `functionName`  
 Required. The name of the newly created function  
  
 `argname1...argnameN`  
 Optional. A list of arguments the function accepts.  
  
 `body`  
 Optional. A string that contains the block of [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] code to be executed when the function is called.  
  
## Remarks  
 The function is a basic data type in [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)]. Syntax 1 creates a function value that [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] converts into a `Function` object when necessary. [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] converts `Function` objects created by Syntax 2 into function values at the time the function is called.  
  
 Syntax 1 is the standard way to create new functions in [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)]. Syntax 2 is an alternative form used to create function objects explicitly.  
  
 For example, to declare a function that adds the two arguments passed to it, you can do it in one of two ways:  
  
## Example 1  
  
```JavaScript  
function add(x, y)  
{  
   return(x + y);  
}  
```  
  
## Example 2  
  
```  
var add = function(x, y) {  
     return(x+y);  
}  
```  
  
 In either case, you call the function with a line of code similar to the following:  
  
```JavaScript  
add(2, 3);  
```  
  
> [!NOTE]
>  When you call a function, make sure that you always include the parentheses and any required arguments. Calling a function without parentheses causes the function itself to be returned, instead of the return value of the function.  
  
## Properties  
 [0...n Properties](../../javascript/reference/0-dot-dot-dot-n-properties-arguments-javascript.md) &#124;[arguments Property](../../javascript/reference/arguments-property-function-javascript.md) &#124; [callee Property](../../javascript/reference/callee-property-arguments-javascript.md) &#124; [caller Property](../../javascript/reference/caller-property-function-javascript.md) &#124; [constructor Property](../../javascript/reference/constructor-property-object-javascript.md) &#124; [length Property (Function)](../../javascript/reference/length-property-function-javascript.md) &#124; [prototype Property](../../javascript/reference/prototype-property-object-javascript.md)  
  
## Methods  
 [apply Method](../../javascript/reference/apply-method-function-javascript.md) &#124; [bind Method](../../javascript/reference/bind-method-function-javascript.md) &#124; [call Method](../../javascript/reference/call-method-function-javascript.md) &#124; [toString Method](../../javascript/reference/tostring-method-object-javascript.md) &#124; [valueOf Method](../../javascript/reference/valueof-method-object-javascript.md)  
  
## Requirements  
 [!INCLUDE[jsv2](../../javascript/reference/includes/jsv2-md.md)]  
  
## See Also  
 [function Statement](../../javascript/reference/function-statement-javascript.md)   
 [new Operator](../../javascript/reference/new-operator-decrementjavascript.md)   
 [var Statement](../../javascript/reference/var-statement-javascript.md)