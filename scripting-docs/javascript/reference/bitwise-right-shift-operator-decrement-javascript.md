---
title: "Bitwise Right Shift Operator (&gt;&gt;) (JavaScript) | Microsoft Docs"
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
  - ">>"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - ">> operator"
  - ">> operator, about >> operator"
  - ">> operator, bitsets"
  - "bitwise operators, right shift operator"
ms.assetid: 89dc57e0-0b0d-49a4-a8ed-56d8bb20f3e3
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Bitwise Right Shift Operator (&gt;&gt;) (JavaScript)
Right shifts the bits of an expression, maintaining sign.  
  
## Syntax  
  
```  
  
result = expression1 >> expression2  
```  
  
## Parameters  
 *result*  
 Any variable.  
  
 *expression1*  
 Any expression.  
  
 *expression2*  
 Any expression.  
  
## Remarks  
 The >> operator shifts the bits of *expression1* right by the number of bits specified in *expression2*. The sign bit of *expression1* is used to fill the digits from the left. Digits shifted off the right are discarded. For example, after the following code is evaluated, *temp* has a value of -4: -14 (11110010 in two's complement binary) shifted right two bits equals -4 (11111100 in two's complement binary).  
  
```JavaScript  
var temp  
temp = -14 >> 2  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
## See Also  
 [Bitwise Left Shift Operator (<\<)](../../javascript/reference/bitwise-left-shift-operator-decrement-javascript.md)   
 [Right Shift Assignment Operator (>>=)](../../javascript/reference/right-shift-assignment-operator-decrement-equal-javascript.md)   
 [Unsigned Right Shift Operator (>>>)](../../javascript/reference/unsigned-right-shift-operator-decrement-javascript.md)   
 [Operator Precedence](../../javascript/operator-subtractprecedence-javascript.md)   
 [Operator Summary (JavaScript)](../../javascript/misc/operator-subtractsummary-javascript.md)