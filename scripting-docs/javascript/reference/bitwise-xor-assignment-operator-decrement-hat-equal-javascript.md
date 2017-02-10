---
title: "Bitwise XOR Assignment Operator (^=) (JavaScript) | Microsoft Docs"
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
  - "^="
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "^= operator, about ^= operator"
  - "assignment operators, bitwise [JavaScript]"
  - "bitwise operators, XOR operator"
  - "XOR operator"
  - "^= operator"
ms.assetid: a6ded216-27b6-4fc4-a51b-7d10cc6f820c
caps.latest.revision: 9
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Bitwise XOR Assignment Operator (^=) (JavaScript)
Performs a bitwise exclusive OR on a variable and an expression and assigns the result to the variable.  
  
## Syntax  
  
```  
  
result ^= expression  
```  
  
## Parameters  
 *result*  
 Any variable.  
  
 *expression*  
 Any expression.  
  
## Remarks  
 Using the **^=** operator is exactly the same as specifying:  
  
```javascript  
result = result ^ expression  
```  
  
 The **^=** operator looks at the binary representation of the values of two expressions and does a bitwise exclusive OR operation on them. The result of this operation behaves as follows:  
  
```javascript  
0101    (result)  
1100    (expression)  
----  
1001    (result)  
```  
  
 When one, and only one, of the expressions has a 1 in a digit, the result has a 1 in that digit. Otherwise, the result has a 0 in that digit.  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
## See Also  
 [Bitwise XOR Operator (^)](../../javascript/reference/bitwise-xor-operator-decrement-hat-javascript.md)   
 [Operator Precedence](../../javascript/operator-subtractprecedence-javascript.md)   
 [Operator Summary (JavaScript)](../../javascript/misc/operator-subtractsummary-javascript.md)