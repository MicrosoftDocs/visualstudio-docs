---
title: "var Statement (JavaScript) | Microsoft Docs"
ms.custom: ""
ms.date: "01/22/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-javascript"
ms.tgt_pltfrm: ""
ms.topic: "language-reference"
f1_keywords: 
  - "var_JavaScriptKeyword"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "declaring variables, var statement"
  - "var statement"
ms.assetid: 56f900af-a5c4-4667-9664-5956d30f0aae
caps.latest.revision: 18
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# var Statement (JavaScript)
Declares a variable.  
  
## Syntax  
  
```  
var variable1 = value1  
```  
  
## Parameters  
 `variable1`  
 The name of the variable being declared.  
  
 `value1`  
 The initial value assigned to the variable.  
  
## Remarks  
 Use the `var` statement to declare variables. You can assign values to the variables when you declare them or later in your script.  
  
 A variable is declared the first time it appears in your script.  
  
 You can declare a variable without using the `var` keyword and assign a value to it. This is known as an *implicit declaration*, and it is not recommended. An implicit declaration gives the variable global scope. When you declare a variable at the procedure level, though, you typically do not want it to have global scope. To avoid giving the variable global scope, you must use the `var` keyword in your variable declaration.  
  
 If you do not initialize your variable in the `var` statement, it is automatically assigned the [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] value `undefined`.  
  
## Example  
 The following examples illustrate the use of the `var` statement.  
  
```JavaScript  
var index;  
var name = "Thomas Jefferson";  
var answer = 42, counter, numpages = 10;  
var myarray = new Array();  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
## See Also  
 [function Statement](../../javascript/reference/function-statement-javascript.md)   
 [new Operator](../../javascript/reference/new-operator-decrementjavascript.md)   
 [Array Object](../../javascript/reference/array-object-javascript.md)   
 [Variables](../../javascript/variables-javascript.md)