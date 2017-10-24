---
title: "Bitwise AND Assignment Operator (&amp;=) (JavaScript) | Microsoft Docs"
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
  - "&="
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "&= operator"
  - "assignment operators, bitwise [JavaScript]"
  - "AND operator"
  - "bitwise operators, AND operator"
ms.assetid: e7e2eabb-4fc1-4fdc-9dd8-1e6d715371fa
caps.latest.revision: 10
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Bitwise AND Assignment Operator (&amp;=) (JavaScript)
Sets the result of a bitwise AND operation on the value of a variable and the value of an expression. The variable and the expression are treated as 32-bit integers.  
  
## Syntax  
  
```  
  
result &= expression  
```  
  
## Parameters  
 `result`  
 Any variable.  
  
 `expression`  
 Any expression.  
  
## Remarks  
 Using this operator is the same as specifying:  
  
```JavaScript  
result = result & expression  
```  
  
 The [Bitwise AND Operator (&)](../../javascript/reference/bitwise-and-operator-decrement-javascript.md) looks at the binary representation of the values of `result` and `expression` and does a bitwise AND operation on them. The output of this operation behaves like this:  
  
```JavaScript  
// 9 is 00000000000000000000000000001001  
var expr1 = 9;  
  
// 5 is 00000000000000000000000000000101  
var expr2 = 5;  
  
// 1 is 00000000000000000000000000000001  
expr1 &= expr2;  
  
document.write(expr1);  
```  
  
 Any time both of the expressions have a 1 in a digit, the result has a 1 in that digit. Otherwise, the result has a 0 in that digit.  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
## See Also  
 [Bitwise AND Operator (&)](../../javascript/reference/bitwise-and-operator-decrement-javascript.md)   
 [Operator Precedence](../../javascript/operator-subtractprecedence-javascript.md)   
 [Operator Summary (JavaScript)](../../javascript/misc/operator-subtractsummary-javascript.md)