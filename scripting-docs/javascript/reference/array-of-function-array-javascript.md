---
title: "Array.of Function (Array) (JavaScript) | Microsoft Docs"
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
ms.assetid: 2884dda3-65d1-4990-9afe-87865c2d4f7f
caps.latest.revision: 3
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Array.of Function (Array) (JavaScript)
Returns an array from the passed in arguments.  
  
## Syntax  
  
```  
Array.of(element0[, element1][, ...][,elementN]);  
```  
  
#### Parameters  
 `element0,...,elementN`  
 Optional. The elements to place in the array. This creates an array with n + 1 elements, and a length of n + 1.  
  
## Remarks  
 This function is similar to calling `new Array(args)`, but `Array.of` does not include special behavior when one argument is passed in.  
  
## Example  
 The following example creates an array from passed in numbers.  
  
```javascript  
var arr = Array.of(1, 2, 3);  
// arr[0] == 1   
```  
  
## Example  
 The following example shows the difference between using `Array.of` and `new Array`.  
  
```javascript  
var arr1 = Array.of(3);  
// arr1[0] == 3  
  
// With new Array, a single argument specifies  
// the length of the new array.  
var arr2 = new Array(3);  
// arr2[0] is undefined  
// arr2.length == 3  
  
```  
  
## Requirements  
 [!INCLUDE[jsv12](../../javascript/reference/includes/jsv12-md.md)]