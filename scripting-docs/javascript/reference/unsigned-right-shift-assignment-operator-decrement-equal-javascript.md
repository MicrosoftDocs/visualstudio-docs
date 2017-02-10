---
title: "Unsigned Right Shift Assignment Operator (&gt;&gt;&gt;=) (JavaScript) | Microsoft Docs"
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
  - ">>>="
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - ">>>= operator"
  - "unsigned right shift assignment operator (>>>=)"
  - "assignment operators, JavaScript"
ms.assetid: f67c3737-7d39-41ae-9c11-8b16d38f6179
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Unsigned Right Shift Assignment Operator (&gt;&gt;&gt;=) (JavaScript)
Right shifts the value of a variable by the number of bits specified in the value of an expression, without maintaining sign, and assigns the result to the variable.  
  
## Syntax  
  
```  
  
result >>>= expression  
```  
  
## Parameters  
 *result*  
 Any variable.  
  
 *expression*  
 Any expression.  
  
## Remarks  
 Using the >>>= operator is exactly the same as doing the following:  
  
```javascript  
result = result >>> expression  
```  
  
 The **>>>=** operator shifts the bits of *result* right by the number of bits specified in *expression*. Zeroes are filled in from the left. Digits shifted off the right are discarded. For example:  
  
```javascript  
var temp  
temp = -14  
temp >>>= 2  
```  
  
 The variable *temp* has an initial value of -14 (11111111 11111111 11111111 11110010 in two's complement binary). When shifted right two bits, the value equals 1073741820 (00111111 11111111 11111111 11111100 in binary).  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
## See Also  
 [Unsigned Right Shift Operator (>>>)](../../javascript/reference/unsigned-right-shift-operator-decrement-javascript.md)   
 [Bitwise Left Shift Operator (<\<)](../../javascript/reference/bitwise-left-shift-operator-decrement-javascript.md)   
 [Bitwise Right Shift Operator (>>)](../../javascript/reference/bitwise-right-shift-operator-decrement-javascript.md)   
 [Operator Precedence](../../javascript/operator-subtractprecedence-javascript.md)   
 [Operator Summary (JavaScript)](../../javascript/misc/operator-subtractsummary-javascript.md)