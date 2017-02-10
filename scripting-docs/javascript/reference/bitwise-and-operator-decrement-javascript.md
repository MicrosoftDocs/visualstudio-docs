---
title: "Bitwise AND Operator (&amp;) (JavaScript) | Microsoft Docs"
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
  - "&"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "assignment operators, bitwise [JavaScript]"
  - "& operator, about & operator"
  - "AND operator"
  - "& operator"
  - "bitwise operators, AND operator"
  - "& operator, bitwise operators"
ms.assetid: a8c17a55-2599-4518-98d7-671699f4d5f3
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Bitwise AND Operator (&amp;) (JavaScript)
Performs a bitwise AND operation on two 32-bit expressions.  
  
## Syntax  
  
```  
  
result = expression1 & expression2  
```  
  
## Parameters  
 `result`  
 The result of the operation.  
  
 `expression1`  
 Any expression.  
  
 `expression2`  
 Any expression.  
  
## Remarks  
 The `&` does a bitwise AND operation on the each of the bits of two 32-bit expressions. If both of the bits are 1, the result is 1. Otherwise, the result is 0.  
  
|Bit1|Bit2|ANDed Value|  
|----------|----------|-----------------|  
|0|0|0|  
|1|1|1|  
|1|0|0|  
|0|1|0|  
  
 The following examples show how to use the `&` operator.  
  
```javascript  
// 9 is 00000000000000000000000000001001  
var expr1 = 9;  
  
// 5 is 00000000000000000000000000000101  
var expr2 = 5;  
  
// 1 is 00000000000000000000000000000001  
var result = expr1 & expr2;  
  
document.write(result);  
// Output: 1  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
## See Also  
 [Bitwise AND Assignment Operator (&=)](../../javascript/reference/bitwise-and-assignment-operator-decrement-equal-javascript.md)   
 [Operator Precedence](../../javascript/operator-subtractprecedence-javascript.md)   
 [Operator Summary (JavaScript)](../../javascript/misc/operator-subtractsummary-javascript.md)