---
title: "Subtraction Operator (-) (JavaScript) | Microsoft Docs"
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
  - "-"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "- operator, about - operator"
  - "- operator"
  - "negation operator"
  - "subtraction operator, syntax"
  - "arithmetic operators, subtraction"
  - "operators, subtraction"
ms.assetid: cd0681d3-15cd-49fe-b4dd-e087de55d778
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Subtraction Operator (-) (JavaScript)
Subtracts the value of one expression from another or provides unary negation of a single expression.  
  
## Syntax  
  
```  
  
result = number1 - number2;  
```  
  
## Parameters  
 *result*  
 Any numeric variable.  
  
 `number`  
 Any numeric expression.  
  
 `number1`  
 Any numeric expression.  
  
 `number2`  
 Any numeric expression.  
  
## Remarks  
 In Syntax 1, the **-** operator is the arithmetic subtraction operator used to find the difference between two numbers. In Syntax 2, the **-** operator is used as the unary negation operator to indicate the negative value of an expression.  
  
 For Syntax 2, as for all unary operators, expressions are evaluated as follows:  
  
-   If applied to undefined or `null` expressions, a run-time error is raised.  
  
-   Objects are converted to strings.  
  
-   Strings are converted to numbers if possible. If not, a run-time error is raised.  
  
-   Boolean values are treated as numbers (0 if false, 1 if true).  
  
 The operator is applied to the resulting number. In Syntax 2, if the resulting number is nonzero, *result* is equal to the resulting number with its sign reversed. If the resulting number is zero, *result* is zero.  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
## See Also  
 [Subtraction Assignment Operator (-=)](../../javascript/reference/subtraction-assignment-operator-decrement-equal-javascript.md)   
 [Operator Precedence](../../javascript/operator-subtractprecedence-javascript.md)   
 [Operator Summary (JavaScript)](../../javascript/misc/operator-subtractsummary-javascript.md)