---
title: "isNaN Function (JavaScript) | Microsoft Docs"
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
  - "isNaN"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "isNaN method"
ms.assetid: 5af4eb29-72f6-484f-93bd-04ae1261f849
caps.latest.revision: 14
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# isNaN Function (JavaScript)
Returns a Boolean value that indicates whether a value is the reserved value `NaN` (not a number).  
  
## Syntax  
  
```  
isNaN(numValue)   
```  
  
## Return Value  
 `true` if the value converted to the `Number` type is the `NaN`, otherwise `false`.  
  
## Remarks  
 The required `numValue` is the value to be tested against `NaN`.  
  
 You typically use this method to test return values from the `parseInt` and `parseFloat` methods.  
  
 Alternatively, a variable that contains `NaN` or another value could be compared to itself. If it compares as unequal, it is `NaN`. This is because `NaN` is the only value that is not equal to itself.  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
 **Applies To**: [Global Object](../../javascript/reference/global-object-javascript.md)  
  
## Example  
  
```javascript  
// Returns false.  
isNaN(100);  
  
// Returns false.  
isNaN("100");  
  
// Returns true.  
isNaN("ABC");  
  
// Returns true.  
isNaN("10C");  
  
// Returns true.  
isNaN("abc123");  
  
// Returns true.  
isNaN(Math.sqrt(-1));           
```  
  
## See Also  
 [isFinite Function](../../javascript/reference/isfinite-function-javascript.md)   
 [NaN Constant](../../javascript/reference/nan-constant-javascript.md)   
 [parseFloat Function](../../javascript/reference/parsefloat-function-javascript.md)   
 [parseInt Function](../../javascript/reference/parseint-function-javascript.md)