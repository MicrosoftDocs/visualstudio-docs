---
title: "Bitwise Left Shift Operator (&lt;&lt;) (JavaScript) | Microsoft Docs"
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
  - "<<"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "<< operator"
  - "left shift operators"
  - "<< operator, about << operator"
  - "bitwise operators, Left Shift operator"
ms.assetid: 18148596-7b86-4add-aeef-106991c69435
caps.latest.revision: 9
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Bitwise Left Shift Operator (&lt;&lt;) (JavaScript)
Left shifts the bits of an expression.  
  
## Syntax  
  
```  
  
result = expression1 << expression2  
```  
  
## Parameters  
 *result*  
 Any variable.  
  
 *expression1*  
 Any expression.  
  
 *expression2*  
 Any expression.  
  
## Remarks  
 The **<<** operator shifts the bits of *expression1* left by the number of bits specified in *expression2*. For example:  
  
```JavaScript  
var temp  
temp = 14 << 2  
```  
  
 The variable *temp* has a value of 56 because 14 (00001110 in binary) shifted left two bits equals 56 (00111000 in binary).  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
## See Also  
 [Left Shift Assignment Operator (<\<=)](../../javascript/reference/left-shift-assignment-operator-decrement-equal-javascript.md)   
 [Bitwise Right Shift Operator (>>)](../../javascript/reference/bitwise-right-shift-operator-decrement-javascript.md)   
 [Unsigned Right Shift Operator (>>>)](../../javascript/reference/unsigned-right-shift-operator-decrement-javascript.md)   
 [Operator Precedence](../../javascript/operator-subtractprecedence-javascript.md)   
 [Operator Summary (JavaScript)](../../javascript/misc/operator-subtractsummary-javascript.md)