---
title: "Number.isNaN Function (Number) (JavaScript) | Microsoft Docs"
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
ms.assetid: 2d9813d6-ec9c-433b-b060-8e3c3ff62ca4
caps.latest.revision: 3
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Number.isNaN Function (Number) (JavaScript)
Returns a Boolean value that indicates whether a value is the reserved value `NaN` (not a number).  
  
## Syntax  
  
```  
Number.isNaN(numValue)   
```  
  
#### Parameters  
 `numValue`  
 Required. The value to be tested against `NaN`.  
  
## Return Value  
 `true` if the value converted to the `Number` type is the `NaN`, otherwise `false`.  
  
## Remarks  
 You typically use this method to test return values from the `parseInt` and `parseFloat` methods.  
  
 `Number.isNaN` corrects problems with the global `isNaN` function. `Number.isNaN` only converts its argument to the type Number after comparing it with `NaN`. As a result, it returns `true` if and only if the argument passed in is exactly the same value as `NaN`. The global `isNaN` function converts its argument to the type Number before the comparison, which can lead to non-number values returning `true`, whereas they might not return `true` for `Number.isNaN`.  
  
## Requirements  
 [!INCLUDE[jsv12](../../javascript/reference/includes/jsv12-md.md)]  
  
 **Applies To**: [Number Object](../../javascript/reference/number-object-javascript.md)  
  
## Example  
  
```javascript  
// Returns true.  
Number.isNaN(NaN);  
Number.isNaN(Number.NaN);  
Number.isNaN(0 / 0);  
  
// Returns false.  
Number.isNaN(100);  
// Returns false.  
// Strings are converted to numbers and return false.  
Number.isNaN("100");  
Number.isNaN("ABC");  
Number.isNaN("10C");  
Number.isNaN("abc123");  
  
```