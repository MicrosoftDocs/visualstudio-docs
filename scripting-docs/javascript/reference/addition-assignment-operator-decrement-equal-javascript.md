---
title: "Addition Assignment Operator (+=) (JavaScript) | Microsoft Docs"
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
  - "+="
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "addition assignment operator (+=)"
  - "+= operator"
  - "assignment operators, JavaScript"
ms.assetid: 8517d05c-38b0-4107-bea4-253eb420f438
caps.latest.revision: 10
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Addition Assignment Operator (+=) (JavaScript)
Adds the value of an expression to the value of a variable and assigns the result to the variable.  
  
## Syntax  
  
```  
  
result += expression   
```  
  
## Parameters  
 `result`  
 Any variable.  
  
 `expression`  
 Any expression.  
  
## Remarks  
 Using this operator is exactly the same as specifying: `result = result + expression`.  
  
 The types of the two expressions determine the behavior of the `+=` operator.  
  
|If|Then|  
|--------|----------|  
|Both expressions are numeric or Boolean|Add|  
|Both expressions are strings|Concatenate|  
|One expression is numeric and the other is a string|Concatenate|  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
## See Also  
 [Addition Operator (+)](../../javascript/reference/addition-operator-decrement-javascript.md)   
 [Operator Precedence](../../javascript/operator-subtractprecedence-javascript.md)   
 [Operator Summary (JavaScript)](../../javascript/misc/operator-subtractsummary-javascript.md)