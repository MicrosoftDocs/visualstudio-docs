---
title: "if...else Statement (JavaScript) | Microsoft Docs"
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
  - "else_JavaScriptKeyword"
  - "if_JavaScriptKeyword"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "if statement, if...else"
  - "loop structures, if...else statements"
ms.assetid: dfbe86e8-9c1e-4ef5-bb9c-7d1db7ce2506
caps.latest.revision: 18
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# if...else Statement (JavaScript)
Conditionally executes a group of statements, depending on the value of an expression.  
  
## Syntax  
  
```  
if (condition1) {  
    statement1  
}  
[else if (condition2) {  
    statement2  
}]  
[else {  
    statement3]   
}]  
```  
  
## Parameters  
 `condition1`  
 Required. A Boolean expression. If `condition1` is `null` or `undefined`, `condition1` is treated as `false`.  
  
 `statement1`  
 Optional. The statement to be executed if `condition1` is **true**. Can be a compound statement.  
  
 `condition2`  
 The condition to be evaluated.  
  
 `statement2`  
 Optional. The statement to be executed if `condition2` is `true`. Can be a compound statement.  
  
 `statement3`  
 If both `condition1` and `condition2` are `false`, this statement is executed.  
  
## Example  
 The following code shows how to use `if`, `if else`, and `else`.  
  
 It is good practice to enclose `statement1` and `statement2` in braces ({}) for clarity and to avoid inadvertent errors.  
  
```javascript  
var z = 3;  
if (x == 5) {  
    z = 10;  
}  
else if (x == 10) {  
    z = 15;  
}  
else {  
    z = 20;  
}  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
## See Also  
 [Conditional (Ternary) Operator (?:)](../../javascript/reference/conditional-ternary-operator-decrement-javascript.md)