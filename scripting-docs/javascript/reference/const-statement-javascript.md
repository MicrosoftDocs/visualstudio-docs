---
title: "const Statement (JavaScript) | Microsoft Docs"
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
  - "const_JavaScriptKeyword"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "declaring variables, const statement"
  - "const statement"
ms.assetid: 3ad0840f-437f-4163-9571-86ecc5ddb987
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# const Statement (JavaScript)
Declares a block-scoped variable with a constant value.  
  
## Syntax  
  
```  
const constant1 = value1  
```  
  
#### Parameters  
 `constant1`  
 The name of the variable being declared.  
  
 `value1`  
 The initial value assigned to the variable.  
  
## Remarks  
 Use the `const` statement to declare a variable with a constant value, the scope of which is restricted to the block in which it is declared. The value of the variable cannot be changed.  
  
 A variable declared using `const` must be initialized when it is declared.  
  
## Example  
 The following example illustrates the use of the `const` statement.  
  
```javascript  
var c = 10;  
{  
    const c = 2;  
   // At this point, c = 2.  
}  
// At this point, c = 10.  
  
// Additional ways to declare a variable using const.  
const name = "Thomas Jefferson";  
const answer = 42, numpages = 10;  
const myarray = new Array();  
  
```  
  
## Requirements  
 [!INCLUDE[jsv11](../../javascript/reference/includes/jsv11-md.md)]  
  
## See Also  
 [let Statement](../../javascript/reference/let-statement-javascript.md)   
 [new Operator](../../javascript/reference/new-operator-decrementjavascript.md)   
 [Array Object](../../javascript/reference/array-object-javascript.md)   
 [Variables](../../javascript/variables-javascript.md)