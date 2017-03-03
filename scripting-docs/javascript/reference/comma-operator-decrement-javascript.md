---
title: "Comma Operator (,) (JavaScript) | Microsoft Docs"
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
  - "%2C"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "comma operator"
ms.assetid: 699fa0bf-cd0a-45ee-a291-2fbed4ecd470
caps.latest.revision: 13
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Comma Operator (,) (JavaScript)
Causes two expressions to be executed sequentially.  
  
## Syntax  
  
```  
  
expression1, expression2  
```  
  
## Parameters  
 `expression1`  
 Any expression.  
  
 `expression2`  
 Any expression.  
  
## Remarks  
 The `,` operator causes the expressions to be executed in left-to-right order. A common use for the `,` operator is in the increment expression of a `for` loop. For example:  
  
```javascript  
j=25;  
for (i = 0; i < 10; i++, j++)  
{  
   k = i + j;  
}  
```  
  
 The `for` statement allows only a single expression to be executed at the end of every pass through a loop. The `,` operator allows multiple expressions to be treated as a single expression, so both variables can be incremented.  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
## See Also  
 [for Statement](../../javascript/reference/for-statement-javascript.md)   
 [Operator Precedence](../../javascript/operator-subtractprecedence-javascript.md)   
 [Operator Summary (JavaScript)](../../javascript/misc/operator-subtractsummary-javascript.md)