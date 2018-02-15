---
title: "Logical AND Operator (&amp;&amp;) (JavaScript) | Microsoft Docs"
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
  - "&&"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "logical AND operator"
  - "&& operator"
ms.assetid: 4714dea9-1999-444a-8acd-72f0851e4f65
caps.latest.revision: 10
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Logical AND Operator (&amp;&amp;) (JavaScript)
Performs a logical conjunction on two expressions.  
  
## Syntax  
  
```  
  
result = expression1 && expression2   
```  
  
## Parameters  
 `result`  
 Any variable.  
  
 `expression1`  
 Any expression.  
  
 `expression2`  
 Any expression.  
  
## Remarks  
 If `expression1` evaluates to `false`, `result` is `expression1`. Otherwise, `result` is `expression2`. Consequently, the operation returns `true` if both operands are true; otherwise, it returns `false`.  
  
 [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] uses the following rules for converting non-Boolean values to Boolean values:  
  
-   All objects are considered to be `true`.  
  
-   Strings are considered to be `false` if they are empty.  
  
-   `null` and `undefined` are considered to be `false`.  
  
-   A Number is `false` if it is zero.  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
## See Also  
 [Operator Precedence](../../javascript/operator-subtractprecedence-javascript.md)   
 [Operator Summary (JavaScript)](../../javascript/misc/operator-subtractsummary-javascript.md)