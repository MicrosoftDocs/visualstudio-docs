---
title: "break Statement (JavaScript) | Microsoft Docs"
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
  - "break_JavaScriptKeyword"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "do...while statement"
  - "break statement"
ms.assetid: 5be0f2a8-5fe7-4a6c-89af-ca20a925ce87
caps.latest.revision: 23
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# break Statement (JavaScript)
Terminates the current loop, or if in conjunction with a `label`, terminates the associated statement.  
  
## Syntax  
  
```  
break [label];  
```  
  
## Remarks  
 The optional `label` argument specifies the label of the statement you are breaking from.  
  
 You typically use the `break` statement in `switch` statements and in `while`, `for`, `for...in`, or `do...while` loops. You most commonly use the `label` argument in `switch` statements, but it can be used in any statement, whether simple or compound.  
  
 Executing the `break` statement exits from the current loop or statement, and begins script execution with the statement immediately following.  
  
## Examples  
 In this example, the counter is set up to count from 1 to 99; however, the `break` statement terminates the loop after 14 counts.  
  
```JavaScript  
for (var i = 1; i < 100; i++) {  
    if (i == 15) {  
        break;  
    }  
    document.write (i);  
    document.write (" ");  
}  
  
// Output: 1234567891011121314  
```  
  
 In the following code, the `break` statement refers to the `for` loop that is preceded by the `Inner:` statement. When `j` is equal to 24, the `break` statement causes the program flow to exit that loop. The numbers 21 through 23 print on each line.  
  
```JavaScript  
Outer:  
for (var i = 1; i <= 10; i++) {  
    document.write ("<br />");  
    document.write ("i: " + i);  
    document.write (" j: ");  
Inner:  
    for (var j = 21; j <= 30; j++) {  
        if (j == 24) {  
            break Inner;  
        }  
        document.write (j + " ");  
    }  
}  
  
// Output:   
// i: 1 j: 21 22 23   
// i: 2 j: 21 22 23   
// i: 3 j: 21 22 23   
// i: 4 j: 21 22 23   
// i: 5 j: 21 22 23   
// i: 6 j: 21 22 23   
// i: 7 j: 21 22 23   
// i: 8 j: 21 22 23   
// i: 9 j: 21 22 23   
// i: 10 j: 21 22 23  
  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
## See Also  
 [continue Statement](../../javascript/reference/continue-statement-javascript.md)   
 [do...while Statement](../../javascript/reference/do-dot-dot-dot-while-statement-javascript.md)   
 [for Statement](../../javascript/reference/for-statement-javascript.md)   
 [for...in Statement](../../javascript/reference/for-dot-dot-dot-in-statement-javascript.md)   
 [Labeled Statement](../../javascript/reference/labeled-statement-javascript.md)   
 [while Statement](../../javascript/reference/while-statement-javascript.md)