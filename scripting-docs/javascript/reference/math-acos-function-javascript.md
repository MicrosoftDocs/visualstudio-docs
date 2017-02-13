---
title: "Math.acos Function (JavaScript) | Microsoft Docs"
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
  - "acos"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "acos method"
  - "arcosine method"
ms.assetid: 828cb3c3-bdf7-4bb7-97ae-3617ce4b2d62
caps.latest.revision: 13
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Math.acos Function (JavaScript)
Returns the arc cosine (or inverse cosine) of a number.  
  
## Syntax  
  
```  
Math.acos(number)  
```  
  
#### Parameters  
 The required `number` argument is a numeric expression.  
  
## Return Value  
 The arc cosine of the `number` argument, in radians.  
  
## Example  
 The following code shows how to use the `acos` function.  
  
```javascript  
var v1 = Math.acos(-1.0);  
var v2 = Math.cos(-1.0);  
  
document.write(v1);  
document.write("<br/>");  
document.write(v2);  
  
// Output:  
// 3.141592653589793  
// 0.5403023058681398  
  
```  
  
## Remarks  
 **Applies To**: [Math Object](../../javascript/reference/math-object-javascript.md)  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
## See Also  
 [Math.asin Function](../../javascript/reference/math-asin-function-javascript.md)   
 [Math.atan Function](../../javascript/reference/math-atan-function-javascript.md)   
 [Math.cos Function](../../javascript/reference/math-cos-function-javascript.md)   
 [Math.sin Function](../../javascript/reference/math-sin-function-javascript.md)   
 [Math.tan Function](../../javascript/reference/math-tan-function-javascript.md)   
 [Math Object](../../javascript/reference/math-object-javascript.md)