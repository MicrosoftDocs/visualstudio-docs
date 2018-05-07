---
title: "Bitwise NOT Operator (~) (JavaScript) | Microsoft Docs"
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
  - "~"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "NOT operator"
  - "bitwise operators, NOT operator"
ms.assetid: 39f92474-fe05-4a8b-9ad8-caca93f82bca
caps.latest.revision: 10
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Bitwise NOT Operator (~) (JavaScript)
Performs a bitwise NOT (negation) on an expression.  
  
## Syntax  
  
```  
  
result = ~ expression  
```  
  
## Parameters  
 *result*  
 Any variable.  
  
 *expression*  
 Any expression.  
  
## Remarks  
 All unary operators, such as the `~` operator, evaluate expressions as follows:  
  
-   If applied to undefined or `null` expressions, a run-time error is raised.  
  
-   Objects are converted to strings.  
  
-   Strings are converted to numbers if possible. If not, a run-time error is raised.  
  
-   Boolean values are treated as numbers (0 if false, 1 if true).  
  
 The operator is applied to the resulting number.  
  
 The `~` operator looks at the binary representation of the values of the expression and does a bitwise negation operation on it.  
  
 Any digit that is a 1 in the expression becomes a 0 in the result. Any digit that is a 0 in the expression becomes a 1 in the result.  
  
 The following example illustrates use of the bitwise NOT (~) operator.  
  
```  
var temp = ~5;  
```  
  
 The resulting value is -6, as shown in the following table.  
  
|Expression|Binary value (two's complement)|Decimal value|  
|----------------|---------------------------------------|-------------------|  
|5|00000000 00000000 00000000 00000101|5|  
|~5|11111111 11111111 11111111 11111010|-6|  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
## See Also  
 [Logical NOT Operator (!)](../../javascript/reference/logical-not-operator-decrement-exclpt-javascript.md)   
 [Operator Precedence](../../javascript/operator-subtractprecedence-javascript.md)   
 [Operator Summary (JavaScript)](../../javascript/misc/operator-subtractsummary-javascript.md)