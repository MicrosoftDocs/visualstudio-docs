---
title: "Logical NOT Operator (!) (JavaScript) | Microsoft Docs"
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
  - "!"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "Logical NOT operator"
  - "! operator"
  - "! operator, about ! operator"
ms.assetid: 68c3dc71-ae95-4293-9155-67405846d71d
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Logical NOT Operator (!) (JavaScript)
Performs logical negation on an expression.  
  
## Syntax  
  
```  
  
result = !expression  
```  
  
## Parameters  
 *result*  
 Any variable.  
  
 *expression*  
 Any expression.  
  
## Remarks  
 The following table illustrates how *result* is determined.  
  
|If `expression` is|Then `result` is|  
|------------------------|----------------------|  
|True|False|  
|False|True|  
  
 All unary operators, such as the **!** operator, evaluate expressions as follows:  
  
-   If applied to undefined or `null` expressions, a run-time error is raised.  
  
-   Objects are converted to strings.  
  
-   Strings are converted to numbers if possible. If not, a run-time error is raised.  
  
-   Boolean values are treated as numbers (0 if false, 1 if true).  
  
 The operator is applied to the resulting number.  
  
 For the **!** operator, if *expression* is nonzero, *result* is zero. If *expression* is zero, *result* is 1.  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
## See Also  
 [Bitwise NOT Operator (~)](../../javascript/reference/bitwise-not-operator-decrement-tilde-javascript.md)   
 [Operator Precedence](../../javascript/operator-subtractprecedence-javascript.md)   
 [Operator Summary (JavaScript)](../../javascript/misc/operator-subtractsummary-javascript.md)