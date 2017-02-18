---
title: "Math.hypot Function (JavaScript) | Microsoft Docs"
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
  - "DHTML"
ms.assetid: 31488f5a-2230-4114-911e-b6d854c7b0a0
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Math.hypot Function (JavaScript)
Returns the square root of the sum of the squares of the arguments.  
  
## Syntax  
  
```  
Math.hypot ( value1[, value2[, ...values] );  
```  
  
#### Parameters  
 `value1`  
 Required. The first number.  
  
 `value2`  
 Optional. The second number.  
  
 `values`  
 Optional. One or more numbers.  
  
## Remarks  
 If any argument is NaN, function returns NaN. If no arguments are provide, the function returns 0.  
  
## Example  
 The following example shows an example of using the `Math.hypot` function.  
  
```javascript  
Math.hypot(3, 4);  
// Returns 5  
  
Math.hypot(3, "4");  
// Returns 5  
  
Math.hypot(3, "four");  
// Returns NaN   
  
Math.hypot(3, 4, 10);  
// Returns 11.180339887498949  
```  
  
## Requirements  
 [!INCLUDE[jsv12](../../javascript/reference/includes/jsv12-md.md)]