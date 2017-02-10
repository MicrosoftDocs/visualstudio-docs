---
title: "while Statement (JavaScript) | Microsoft Docs"
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
  - "while_JavaScriptKeyword"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "loop structures, while statements"
  - "while statement"
ms.assetid: d63777cf-0e1a-4555-8d3a-334381001f48
caps.latest.revision: 13
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# while Statement (JavaScript)
Executes a statement or series of statements until a specified condition is `false`.  
  
## Syntax  
  
```  
while (expression) {  
    statements  
}   
```  
  
## Parameters  
 `expression`  
 Required. A Boolean expression that is checked before each iteration of the loop. If `expression` is `true`, the loop is executed. If `expression` is `false`, the loop is terminated.  
  
 `statements`  
 Optional. One or more statements to be executed if `expression` is `true`.  
  
## Remarks  
 The `while` statement checks `expression` before a loop is first executed. If `expression` is `false` at this time, the loop is never executed.  
  
## Example  
 The following example illustrates the use of the `while` statement.  
  
```javascript  
var i = 0;  
var j = 10;  
while (i < 100) {  
    if (i == j)  
        break;  
    i++;  
}  
document.write(i);  
  
// Output: 10  
  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
## See Also  
 [break Statement](../../javascript/reference/break-statement-javascript.md)   
 [continue Statement](../../javascript/reference/continue-statement-javascript.md)   
 [do...while Statement](../../javascript/reference/do-dot-dot-dot-while-statement-javascript.md)   
 [for Statement](../../javascript/reference/for-statement-javascript.md)   
 [for...in Statement](../../javascript/reference/for-dot-dot-dot-in-statement-javascript.md)