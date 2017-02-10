---
title: "Operator Precedence (JavaScript) | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-javascript"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "operator precedence"
  - "order of precedence"
ms.assetid: cf3c510a-2214-4b47-b8fe-3521298efaab
caps.latest.revision: 15
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Operator Precedence (JavaScript)
Operator precedence describes the order in which operations are performed when an expression is evaluated. Operations with a higher precedence are performed before those with a lower precedence. For example, multiplication is performed before addition.  
  
## [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] Operators  
 The following table lists the [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] operators, ordered from highest to lowest precedence. Operators with the same precedence are evaluated left to right.  
  
|Operator|Description|  
|--------------|-----------------|  
|. [ ] ( )|Field access, array indexing, function calls, and expression grouping|  
|++ -- - ~ ! delete new typeof void|Unary operators, return data type, object creation, undefined values|  
|* / %|Multiplication, division, modulo division|  
|+ - +|Addition, subtraction, string concatenation|  
|<\< >> >>>|Bit shifting|  
|< \<= > >= instanceof|Less than, less than or equal, greater than, greater than or equal, instanceof|  
|== != === !==|Equality, inequality, strict equality, and strict inequality|  
|&|Bitwise AND|  
|^|Bitwise XOR|  
|&#124;|Bitwise OR|  
|&&|Logical AND|  
|&#124;&#124;|Logical OR|  
|?:|Conditional|  
|= *OP*=|Assignment, assignment with operation (such as += and &=)|  
|,|Multiple evaluation|  
  
 Parentheses are used to alter the order of evaluation determined by operator precedence. This means an expression within parentheses is fully evaluated before its value is used in the remainder of the expression.  
  
 For example:  
  
```javascript  
var result = 78 * 96 + 3;  
document.write(result);  
document.write("<br/>");  
  
result = 78 * (9 + 3);  
document.write(result);  
  
// Output:  
// 7491  
// 936  
```  
  
 There are three operators in the first expression: =, *, and +. According to the rules of operator precedence, they are evaluated in the following order: \*, +, = (78 \* 96 = 7488, 7488 + 3 = 7491).  
  
 In the second expression the ( ) operator is evaluated first, so that the addition expression is evaluated before the multiplication (9 + 3 = 12, 12 * 78 = 936).  
  
 The following example shows a statement that includes a variety of operators and resolves to `true`.  
  
```javascript  
var num = 10;  
  
if(5 == num / 2 && (2 + 2 * num).toString() === "22") {  
    document.write(true);  
}  
    // Output:  
    // true  
```  
  
 The operators are evaluated in this order: ( ) for the grouping, *, + (within the grouping), "." for the function, ( ) for the function, /, ==, ===, and &&.