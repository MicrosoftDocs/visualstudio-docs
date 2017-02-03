---
title: "Increment (++) and Decrement (--) Operators (JavaScript) | Microsoft Docs"
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
  - "--"
  - "++"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "increment operators, syntax"
  - "++ operator"
  - "++ operator, about ++ operator"
  - "decrement operators, syntax"
  - "-- operator"
ms.assetid: 49eaf4cf-8818-478d-a429-cdd2ece20811
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Increment (++) and Decrement (--) Operators (JavaScript)
The increment operator increments, and the decrement operator decrements the value of a variable by one.  
  
## Syntax  
  
```  
  
      result = ++variable  
result = --variable  
result = variable++  
result = variable--  
```  
  
## Parameters  
 `result`  
 Any variable.  
  
 `variable`  
 Any variable.  
  
## Remarks  
 If the operator appears before the variable, the value is modified before the expression is evaluated. If the operator appears after the variable, the value is modified after the expression is evaluated.  In other words, given `j = ++k;`, the value of `j` is the original value of `k` plus one; given `j = k++;`, the value of `j` is the original value of `k`, which is incremented after its value is assigned to `j`.  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
## See Also  
 [Operator Precedence](../../javascript/operator-subtractprecedence-javascript.md)   
 [Operator Summary (JavaScript)](../../javascript/misc/operator-subtractsummary-javascript.md)