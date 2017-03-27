---
title: "Modulus Operator (JavaScript) | Microsoft Docs"
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
  - "%"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "modulus operator, JavaScript"
  - "% operator [JavaScript]"
  - "Modulo function [JavaScript]"
ms.assetid: 087d654f-623b-498d-95ff-596d26bf674d
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Modulus Operator (JavaScript)
Divides the value of one expression by the value of another, and returns the remainder.  
  
## Syntax  
  
```  
  
result = number1 % number2  
```  
  
## Arguments  
 `result`  
 Any variable.  
  
 `number1`  
 Any numeric expression.  
  
 `number2`  
 Any numeric expression.  
  
## Remarks  
 The modulus, or remainder, operator divides `number1` by `number2`and returns only the remainder as `result`. The sign of `result` is the same as the sign of `number1`. The value of `result` is between 0 and the absolute value of `number2`.  
  
 The following code shows how to use the modulus operator.  
  
```  
var modResult = 19 % 6.7;  
document.write(modResult);  
  
// Output: 5.6  
  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
## See Also  
 [Operator Precedence](../../javascript/operator-subtractprecedence-javascript.md)   
 [Operator Summary (JavaScript)](../../javascript/misc/operator-subtractsummary-javascript.md)