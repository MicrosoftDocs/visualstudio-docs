---
title: "Right Shift Assignment Operator (&gt;&gt;=) (JavaScript) | Microsoft Docs"
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
  - ">>="
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - ">>= operator [JavaScript]"
  - "right shift operators [JavaScript]"
  - "assignment operators, JavaScript"
ms.assetid: 8c1f7f90-e3ac-42ee-94f2-5ccc47d7aef6
caps.latest.revision: 9
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Right Shift Assignment Operator (&gt;&gt;=) (JavaScript)
Right shifts the value of a variable by the number of bits specified in the value of an expression, maintaining the sign, and assigns the result to the variable.  
  
## Syntax  
  
```  
  
result >>= expression  
```  
  
## Parameters  
 *result*  
 Any variable.  
  
 *expression*  
 Any expression.  
  
## Remarks  
 Using the **>>=** operator is exactly the same as specifying:  
  
```javascript  
result = result >> expression  
```  
  
 The **>>=** operator shifts the bits of *result* right by the number of bits specified in *expression*. The sign bit of *result* is used to fill the digits from the left. Digits shifted off the right are discarded. For example, after the following code is evaluated, *temp* has a value of -4: 14 (11110010 in binary) shifted right two bits equals -4 (11111100 in binary).  
  
```javascript  
var temp  
temp = -14  
temp >>= 2  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
## See Also  
 [Bitwise Left Shift Operator (<\<)](../../javascript/reference/bitwise-left-shift-operator-decrement-javascript.md)   
 [Bitwise Right Shift Operator (>>)](../../javascript/reference/bitwise-right-shift-operator-decrement-javascript.md)   
 [Unsigned Right Shift Operator (>>>)](../../javascript/reference/unsigned-right-shift-operator-decrement-javascript.md)   
 [Operator Precedence](../../javascript/operator-subtractprecedence-javascript.md)   
 [Operator Summary (JavaScript)](../../javascript/misc/operator-subtractsummary-javascript.md)