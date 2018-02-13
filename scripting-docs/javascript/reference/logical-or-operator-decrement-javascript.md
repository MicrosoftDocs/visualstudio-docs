---
title: "Logical OR Operator (||) (JavaScript) | Microsoft Docs"
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
  - "||"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "|| operator"
  - "logical OR operator"
ms.assetid: 95295331-6269-4311-8391-dc1c68e116ab
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Logical OR Operator (||) (JavaScript)
Performs a logical disjunction on two expressions.  
  
## Syntax  
  
```  
  
result = expression1 || expression2  
```  
  
## Parameters  
 *result*  
 Any variable.  
  
 *expression1*  
 Any expression.  
  
 *expression2*  
 Any expression.  
  
## Remarks  
 If either or both expressions evaluate to **True**, *result* is **True**. The following table illustrates how *result* is determined:  
  
|If `expression1` is|And `expression2` is|The `result` is|  
|-------------------------|--------------------------|---------------------|  
|True|True|True|  
|True|False|True|  
|False|True|True|  
|False|False|False|  
  
 [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] uses the following rules for converting non-Boolean values to Boolean values:  
  
-   All objects are considered true.  
  
-   Strings are considered false if and only if they are empty.  
  
-   `null` and undefined are considered false.  
  
-   Numbers are false if, and only if, they are 0.  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
## See Also  
 [Operator Precedence](../../javascript/operator-subtractprecedence-javascript.md)   
 [Operator Summary (JavaScript)](../../javascript/misc/operator-subtractsummary-javascript.md)