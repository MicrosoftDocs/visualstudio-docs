---
title: "continue Statement (JavaScript) | Microsoft Docs"
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
  - "continue_JavaScriptKeyword"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "do...while statement"
  - "continue statement"
  - "loop structures, continue statement"
ms.assetid: f8a30d9f-e2de-4e1f-8668-4e4cf95f7df9
caps.latest.revision: 21
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# continue Statement (JavaScript)
Stops the current iteration of a loop, and starts a new iteration.  
  
## Syntax  
  
```  
continue [label];  
```  
  
## Remarks  
 The optional `label` argument specifies the statement to which `continue` applies.  
  
 You can use the `continue` statement only inside a `while`, `do...while`, **for**, or `for...in` loop. Executing the `continue` statement stops the current iteration of the loop and continues program flow with the beginning of the loop. This has the following effects on the different types of loops:  
  
-   `while` and `do...while` loops test their condition, and if true, execute the loop again.  
  
-   `for` loops execute their increment expression, and if the test expression is true, execute the loop again.  
  
-   `for...in` loops proceed to the next field of the specified variable and execute the loop again.  
  
## Examples  
 In this example, a loop iterates from 1 through 9. The statements between `continue` and the end of the `for` body are skipped because of the use of the `continue` statement together with the expression `(i < 5)`.  
  
```javascript  
for (var i = 1; i < 10; i++) {  
    if (i < 5) {  
        continue;  
    }  
    document.write (i);  
    document.write (" ");  
}  
  
// Output: 5 6 7 8 9  
```  
  
 In the following code, the `continue` statement refers to the `for` loop that is preceded by the `Inner:` label. When `j` is 24, the `continue` statement causes that `for` loop to go to the next iteration. The numbers 21 through 23 and 25 through 30 print on each line.  
  
```javascript  
Outer:  
for (var i = 1; i <= 10; i++) {  
    document.write ("<br />");  
    document.write ("i: " + i);  
    document.write (" j: ");  
  
Inner:  
    for (var j = 21; j <= 30; j++) {  
        if (j == 24) {  
             continue Inner;  
        }  
        document.write (j + " ");  
    }  
}  
  
//Output:  
//i: 1 j: 21 22 23 25 26 27 28 29 30   
//i: 2 j: 21 22 23 25 26 27 28 29 30   
//i: 3 j: 21 22 23 25 26 27 28 29 30   
//i: 4 j: 21 22 23 25 26 27 28 29 30   
//i: 5 j: 21 22 23 25 26 27 28 29 30   
//i: 6 j: 21 22 23 25 26 27 28 29 30   
//i: 7 j: 21 22 23 25 26 27 28 29 30   
//i: 8 j: 21 22 23 25 26 27 28 29 30   
//i: 9 j: 21 22 23 25 26 27 28 29 30   
//i: 10 j: 21 22 23 25 26 27 28 29 30  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
## See Also  
 [break Statement](../../javascript/reference/break-statement-javascript.md)   
 [do...while Statement](../../javascript/reference/do-dot-dot-dot-while-statement-javascript.md)   
 [for Statement](../../javascript/reference/for-statement-javascript.md)   
 [for...in Statement](../../javascript/reference/for-dot-dot-dot-in-statement-javascript.md)   
 [Labeled Statement](../../javascript/reference/labeled-statement-javascript.md)   
 [while Statement](../../javascript/reference/while-statement-javascript.md)