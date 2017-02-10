---
title: "Math.max Function (JavaScript) | Microsoft Docs"
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
  - "max"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "max method"
ms.assetid: f3ea1b8a-5fd0-482a-971b-b7f8e2b9b7eb
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Math.max Function (JavaScript)
Returns the larger of a set of supplied numeric expressions.  
  
## Syntax  
  
```  
Math.max([number1[, number2[... [, numberN]]]])   
```  
  
## Remarks  
 The optional `number1, number2, ..., numberN` arguments are numeric expressions to be evaluated.  
  
 If no arguments are provided, the return value is equal to [Number.NEGATIVE_INFINITY](../../javascript/reference/number-constants-javascript.md). If any argument is `NaN`, the return value is also `NaN`.  
  
## Example  
 The following code shows how to get the larger of two expressions.  
  
```javascript  
var x = Math.max(107 - 3,  48 * 90);  
document.write(x);  
  
// Output:  
// 4320  
  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
## See Also  
 [Math.min Function](../../javascript/reference/math-min-function-javascript.md)