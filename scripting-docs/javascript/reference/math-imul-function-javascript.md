---
title: "Math.imul Function (JavaScript) | Microsoft Docs"
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
ms.assetid: dce5e11c-36b9-4c39-84d3-6cd494dd1cbf
caps.latest.revision: 3
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Math.imul Function (JavaScript)
Returns the product of two numbers that are treated as 32-bit signed integers.  
  
## Syntax  
  
```  
Math.imul(x, y);  
```  
  
#### Parameters  
 `x`  
 Required. The first number.  
  
 `y`  
 Required. The second number.  
  
## Remarks  
 This function is used for compilers like Emscripten and Mandreel, which don't implement integer multiplication in the same way as JavaScript.  
  
## Example  
 The following code example shows how to multiply numbers using `Math.imul`.  
  
```javascript  
var result1 = Math.imul(2, 5);  
// result1 == 10  
  
var result2 = Math.imul(Math.pow(2, 32) - 1, Math.pow(2, 32) - 2);  
// result2 == 2   
```  
  
## Requirements  
 [!INCLUDE[jsv12](../../javascript/reference/includes/jsv12-md.md)]