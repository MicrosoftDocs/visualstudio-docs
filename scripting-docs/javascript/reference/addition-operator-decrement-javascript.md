---
title: "Addition Operator (+) (JavaScript) | Microsoft Docs"
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
  - "+"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "arithmetic operators, addition"
  - "strings [Visual Studio], concatenating"
  - "concatenation operators, vs. addition operator"
  - "addition operator"
  - "+ operator"
ms.assetid: ec1237d3-e78b-4e77-bd7d-c0204cf03acd
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Addition Operator (+) (JavaScript)
Adds the value of one numeric expression to another, or concatenates two strings.  
  
## Syntax  
  
```  
  
result = expression1 + expression2  
```  
  
## Parameters  
 `result`  
 Any variable.  
  
 `expression1`  
 Any expression.  
  
 `expression2`  
 Any expression.  
  
## Remarks  
 The types of the two expressions determine the behavior of the **+** operator.  
  
|If|Then|  
|--------|----------|  
|Both expressions are numeric or Boolean|Add|  
|Both expressions are strings|Concatenate|  
|One expression is numeric and the other is a string|Concatenate|  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
## See Also  
 [Addition Assignment Operator (+=)](../../javascript/reference/addition-assignment-operator-decrement-equal-javascript.md)   
 [Operator Precedence](../../javascript/operator-subtractprecedence-javascript.md)   
 [Operator Summary (JavaScript)](../../javascript/misc/operator-subtractsummary-javascript.md)