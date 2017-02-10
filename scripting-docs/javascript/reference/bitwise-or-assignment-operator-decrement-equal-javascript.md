---
title: "Bitwise OR Assignment Operator (|=) (JavaScript) | Microsoft Docs"
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
  - "|="
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "assignment operators, bitwise [JavaScript]"
  - "|= operator"
  - "bitwise operators, OR operator"
  - "OR operator"
ms.assetid: 9b424ff6-4442-4621-b3b6-83e7fd1e5cd5
caps.latest.revision: 9
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Bitwise OR Assignment Operator (|=) (JavaScript)
Performs a bitwise OR on the value of a variable and the value of an expression and assigns the result to the variable.  
  
## Syntax  
  
```  
  
result |= expression  
```  
  
## Parameters  
 *result*  
 Any variable.  
  
 *expression*  
 Any expression.  
  
## Remarks  
 Using this operator is exactly the same as specifying:  
  
```javascript  
result = result | expression  
```  
  
 The **&#124;=** operator looks at the binary representation of the values of *result* and *expression* and does a bitwise OR operation on them. The result of this operation behaves like this:  
  
```javascript  
0101    (result)  
1100    (expression)  
----  
1101    (output)  
```  
  
 Any time either of the expressions has a 1 in a digit, the result has a 1 in that digit. Otherwise, the result has a 0 in that digit.  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
## See Also  
 [Bitwise OR Operator (&#124;)](../../javascript/reference/bitwise-or-operator-decrement-javascript.md)   
 [Operator Precedence](../../javascript/operator-subtractprecedence-javascript.md)   
 [Operator Summary (JavaScript)](../../javascript/misc/operator-subtractsummary-javascript.md)