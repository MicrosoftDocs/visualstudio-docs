---
title: "Comparison Operators (JavaScript) | Microsoft Docs"
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
  - "Comparison"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "comparison operators, script"
  - "greater than operator"
  - "comparison operators"
  - "greater than or equal to operator"
  - "inequity operator"
  - "identity operator"
ms.assetid: 084f90f0-d010-47cf-96dd-13d637fc9b68
caps.latest.revision: 9
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Comparison Operators (JavaScript)
Returns a Boolean value indicating the result of the comparison.  
  
## Syntax  
  
```  
  
expression1 comparisonoperator expression2  
```  
  
## Parameters  
 `expression1`  
 Any expression.  
  
 `comparisonoperator`  
 Any comparison operator.  
  
 `expression2`  
 Any expression.  
  
## Remarks  
 When comparing strings, [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] uses the Unicode character value of the string expression.  
  
 The following describes how the different groups of operators behave depending on the types and values of `expression1` and `expression2`:  
  
 Relational operators: `<`, `>`, `<=`,  `>=`  
  
-   Attempt to convert both `expression1` and `expression2` into numbers.  
  
-   If both expressions are strings, do a string comparison.  
  
-   If either expression is `NaN`, return `false`.  
  
-   Negative zero equals Positive zero.  
  
-   Negative Infinity is less than everything including itself.  
  
-   Positive Infinity is greater than everything including itself.  
  
 Equality operators: `==`, `!=`  
  
-   If the types of the two expressions are different, attempt to convert them to a String, Number, or Boolean.  
  
-   `NaN` is not equal to anything including itself.  
  
-   Negative zero equals positive zero.  
  
-   `null` equals both `null` and `undefined`.  
  
-   Values are considered equal if they are identical strings, numerically equivalent numbers, the same object, identical Boolean values, or (if different types) they can be coerced into one of these situations.  
  
-   Every other comparison is considered unequal.  
  
 Identity operators: `===`, `!==`  
  
 These operators behave the same as the equality operators, except that no type conversion is done. If the types of both expressions are not the same, these expressions always return `false`.  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
## See Also  
 [Operator Precedence](../../javascript/operator-subtractprecedence-javascript.md)   
 [Operator Summary (JavaScript)](../../javascript/misc/operator-subtractsummary-javascript.md)