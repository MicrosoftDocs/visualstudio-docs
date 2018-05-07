---
title: "do...while Statement (JavaScript) | Microsoft Docs"
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
  - "do_JavaScriptKeyword"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "do...while statement"
  - "terminating loops"
  - "loop structures, do and do-while"
ms.assetid: 8b7782ba-fbad-48cd-9639-193566da6ae5
caps.latest.revision: 20
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# do...while Statement (JavaScript)
Executes a statement block once, and then repeats execution of the loop until a condition expression evaluates to `false`.  
  
## Syntax  
  
```  
do {  
    statement  
}  
while (expression) ;   
```  
  
## Parameters  
 `statement`  
 Required. The statement to be executed if `expression` is `true`. Can be a compound statement.  
  
 `expression`  
 Required. An expression that can be coerced to Boolean `true` or `false`. If `expression` is `true`, the loop is executed again. If `expression` is `false`, the loop is terminated.  
  
## Remarks  
 Unlike the `while` statement, a `do...while` loop is executed one time before the conditional expression is evaluated.  
  
 On any line in a `do...while` block, you can use the `break` statement to cause the program flow to exit the loop, or you can use the `continue` statement to go directly to the `while` expression.  
  
## Example  
 In the following example, the statements in the `do...while` loop continue to execute as long as the variable `i` is less than 10.  
  
```JavaScript  
var i = 0;  
do {  
    document.write(i + " ");  
    i++;  
} while (i < 10);  
  
// Output: 0 1 2 3 4 5 6 7 8 9   
```  
  
## Example  
 In the following example, the statements inside the loop are executed once even though the condition is not met.  
  
```JavaScript  
var i = 10;  
do {  
    document.write(i + " ");  
    i++;  
} while (i < 10);  
  
// Output: 10  
```  
  
## Requirements  
 [!INCLUDE[jsv3](../../javascript/reference/includes/jsv3-md.md)]  
  
## See Also  
 [break Statement](../../javascript/reference/break-statement-javascript.md)   
 [continue Statement](../../javascript/reference/continue-statement-javascript.md)   
 [for Statement](../../javascript/reference/for-statement-javascript.md)   
 [for...in Statement](../../javascript/reference/for-dot-dot-dot-in-statement-javascript.md)   
 [while Statement](../../javascript/reference/while-statement-javascript.md)   
 [Labeled Statement](../../javascript/reference/labeled-statement-javascript.md)