---
title: "let Statement (JavaScript) | Microsoft Docs"
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
  - "let_JavaScriptKeyword"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "let statement"
  - "declaring variables, let statement"
ms.assetid: c7e4f8a9-8f54-47b6-aed2-956959c1ecfd
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# let Statement (JavaScript)
Declares a block-scoped variable.  
  
## Syntax  
  
```  
let variable1 = value1  
```  
  
#### Parameters  
 `variable1`  
 The name of the variable being declared.  
  
 `value1`  
 The initial value assigned to the variable.  
  
## Remarks  
 Use the `let` statement to declare a variable, the scope of which is restricted to the block in which it is declared. You can assign values to the variables when you declare them or later in your script.  
  
 A variable declared using `let` cannot be used before its declaration or an error will result.  
  
 If you do not initialize your variable in the `let` statement, it is automatically assigned the [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] value `undefined`.  
  
## Example  
 The following example illustrates the use of the `let` statement.  
  
```JavaScript  
var  l = 10;  
{  
    let l = 2;  
   // At this point, l = 2.  
}  
// At this point, l = 10.  
  
// Additional ways to declare a variable using let.  
let index;  
let name = "Thomas Jefferson";  
let answer = 42, counter, numpages = 10;  
let myarray = new Array();  
  
```  
  
## Requirements  
 [!INCLUDE[jsv11](../../javascript/reference/includes/jsv11-md.md)]  
  
## See Also  
 [const Statement](../../javascript/reference/const-statement-javascript.md)   
 [new Operator](../../javascript/reference/new-operator-decrementjavascript.md)   
 [Array Object](../../javascript/reference/array-object-javascript.md)   
 [Variables](../../javascript/variables-javascript.md)