---
title: "Math Constants (JavaScript) | Microsoft Docs"
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
helpviewer_keywords: 
  - "LN2 constant [JavaScript]"
  - "E constant [JavaScript]"
  - "LOG10E constant [JavaScript]"
  - "SQRT1_2 constant [JavaScript]"
  - "LOG2E constant [JavaScript]"
  - "Math.SQRT2 constant [JavaScript]"
  - "PI constant [JavaScript]"
  - "Math.LOG2E constant [JavaScript]"
  - "constants [JavaScript], math"
  - "Math.E constant [JavaScript]"
  - "logarithm consants [JavaScript]"
  - "Math.LOG10E constant [JavaScript]"
  - "Math.SQRT1_2 constant [JavaScript]"
  - "SQRT2 constant [JavaScript]"
  - "square root constants [JavaScript]"
  - "Math.PI constant [JavaScript]"
  - "math constants [JavaScript]"
  - "LN10 constant [JavaScript]"
  - "Math.LN2 constant [JavaScript]"
  - "Math.LN10 constant [JavaScript]"
ms.assetid: 8a674046-cb99-4103-92be-83697fba6344
caps.latest.revision: 13
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Math Constants (JavaScript)
Math constants return constant values that are properties of the `Math` object.  
  
## Math Object Constants  
 The following table lists constant values that are properties of the [Math object](../../javascript/reference/math-object-javascript.md).  
  
|Constant|Description|Approximate value|  
|--------------|-----------------|-----------------------|  
|`Math.E`|The mathematical constant e. This is Euler's number, the base of natural logarithms.|2.718|  
|`Math.LN2`|The natural logarithm of 2.|0.693|  
|`Math.LN10`|The natural logarithm of 10.|2.302|  
|`Math.LOG2E`|The base-2 logarithm of e.|1.443|  
|`Math.LOG10E`|The base-10 logarithm of e.|0.434|  
|`Math.PI`|Pi. This is the ratio of the circumference of a circle to its diameter.|3.14159|  
|`Math.SQRT1_2`|The square root of 0.5, or, equivalently, one divided by the square root of 2.|0.707|  
|`Math.SQRT2`|The square root of 2.|1.414|  
  
## Example  
 The following example illustrates how to use the `Math.PI` constant.  
  
```JavaScript  
var radius = 3;  
var area = Math.PI * radius * radius;  
document.write(area);  
  
// Output: 28.274333882308138  
  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
 **Applies To**: [Math Object](../../javascript/reference/math-object-javascript.md)  
  
## See Also  
 [Number Constants](../../javascript/reference/number-constants-javascript.md)   
 [JavaScript Constants](../../javascript/reference/javascript-constants.md)