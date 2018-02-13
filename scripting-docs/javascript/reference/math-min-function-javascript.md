---
title: "Math.min Function (JavaScript) | Microsoft Docs"
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
  - "min"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "min method"
ms.assetid: a1d7dd85-27ef-45cd-aa2a-f8e80f0b2898
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Math.min Function (JavaScript)
Returns the smaller of a set of numeric expressions.  
  
## Syntax  
  
```  
Math.min([number1[, number2[... [,numberN]]]])  
```  
  
## Remarks  
 The optional `number1, number2, ..., numberN` arguments are numeric expressions to be evaluated.  
  
 If no arguments are provided, the return value is equal to [Number.POSITIVE_INFINITY](../../javascript/reference/number-constants-javascript.md). If any argument is `NaN`, the return value is also `NaN`.  
  
## Example  
 The following code shows how to get the smaller of two expressions.  
  
```JavaScript  
var x = Math.min(107 - 3, 48 * 90);  
document.write(x);  
  
// Output:  
// 104  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
## See Also  
 [Math.max Function](../../javascript/reference/math-max-function-javascript.md)