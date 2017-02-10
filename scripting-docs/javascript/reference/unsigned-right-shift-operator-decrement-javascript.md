---
title: "Unsigned Right Shift Operator (&gt;&gt;&gt;) (JavaScript) | Microsoft Docs"
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
  - ">>>"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "unsigned right shift operator (>>>)"
  - ">>> operator"
ms.assetid: df48bdfc-8741-46ab-b681-449da57ac95c
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Unsigned Right Shift Operator (&gt;&gt;&gt;) (JavaScript)
Right shifts the bits of an expression, without maintaining sign.  
  
## Syntax  
  
```  
  
result = expression1 >>> expression2  
```  
  
## Parameters  
 *result*  
 Any variable.  
  
 *expression1*  
 Any expression.  
  
 *expression2*  
 Any expression.  
  
## Remarks  
 The **>>>** operator shifts the bits of *expression1* right by the number of bits specified in *expression2*. Zeroes are filled in from the left. Digits shifted off the right are discarded. For example:  
  
```javascript  
var temp  
temp = -14 >>> 2  
```  
  
 The variable *temp* has an initial value -14 (11111111 11111111 11111111 11110010 in two's complement binary). When it is shifted right two bits, the value equals 1073741820 (00111111 11111111 11111111 11111100 in binary).  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
## See Also  
 [Unsigned Right Shift Assignment Operator (>>>=)](../../javascript/reference/unsigned-right-shift-assignment-operator-decrement-equal-javascript.md)   
 [Bitwise Left Shift Operator (<\<)](../../javascript/reference/bitwise-left-shift-operator-decrement-javascript.md)   
 [Bitwise Right Shift Operator (>>)](../../javascript/reference/bitwise-right-shift-operator-decrement-javascript.md)   
 [Operator Precedence](../../javascript/operator-subtractprecedence-javascript.md)   
 [Operator Summary (JavaScript)](../../javascript/misc/operator-subtractsummary-javascript.md)