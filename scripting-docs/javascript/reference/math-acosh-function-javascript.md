---
title: "Math.acosh Function (JavaScript) | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-javascript"
ms.tgt_pltfrm: ""
ms.topic: "language-reference"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
ms.assetid: 881dd2a0-36a5-403b-a3dc-523d8e1e1317
caps.latest.revision: 3
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Math.acosh Function (JavaScript)
Returns the hyperbolic arccosine (or inverse hyperbolic cosine) of a number.  
  
## Syntax  
  
```  
Math.acosh(number)  
```  
  
#### Parameters  
 The required `number` argument is a numeric expression.  
  
## Return Value  
 The inverse hyperbolic cosine of the `number` argument, in radians.  
  
## Example  
 The following code shows how to use the `acosh` function.  
  
```JavaScript  
var v1 = Math.acosh(3);  
vary v2 = Math.acosh(-1);  
  
document.write(v1);  
document.write("</br>");  
document.write(v2);  
  
// Output:  
// 1.762747174039086  
// NaN  
  
```  
  
## Remarks  
 **Applies To**: [Math Object](../../javascript/reference/math-object-javascript.md)  
  
## Requirements  
 [!INCLUDE[jsv12](../../javascript/reference/includes/jsv12-md.md)]  
  
## See Also  
 [Math.acos Function](../../javascript/reference/math-acos-function-javascript.md)   
 [Math.asin Function](../../javascript/reference/math-asin-function-javascript.md)   
 [Math.atan Function](../../javascript/reference/math-atan-function-javascript.md)   
 [Math.cos Function](../../javascript/reference/math-cos-function-javascript.md)   
 [Math.sin Function](../../javascript/reference/math-sin-function-javascript.md)   
 [Math.tan Function](../../javascript/reference/math-tan-function-javascript.md)   
 [Math Object](../../javascript/reference/math-object-javascript.md)