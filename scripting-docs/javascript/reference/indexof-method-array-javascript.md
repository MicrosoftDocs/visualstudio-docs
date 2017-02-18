---
title: "indexOf Method (Array) (JavaScript) | Microsoft Docs"
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
helpviewer_keywords: 
  - "arrays [JavaScript], indexOf method"
  - "indexOf method [JavaScript]"
ms.assetid: 5bee31ae-aaf1-4466-8cfd-ed287e3cdf17
caps.latest.revision: 12
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# indexOf Method (Array) (JavaScript)
Returns the index of the first occurrence of a value in an array.  
  
## Syntax  
  
```  
  
array1.indexOf(searchElement[, fromIndex])  
```  
  
#### Parameters  
  
|Parameter|Definition|  
|---------------|----------------|  
|`array1`|Required. An array object.|  
|`searchElement`|Required. The value to locate in `array1`.|  
|`fromIndex`|Optional. The array index at which to begin the search. If `fromIndex` is omitted, the search starts at index 0.|  
  
## Return Value  
 The index of the first occurrence of `searchElement` in the array, or -1 if `searchElement` is not found.  
  
## Remarks  
 The `indexOf` method searches an array for a specified value. The method returns the index of the first occurrence, or -1 if the specified value is not found.  
  
 The search occurs in ascending index order.  
  
 The array elements are compared to the `searchElement` value by strict equality, similar to the `===` operator. For more information, see [Comparison Operators](../../javascript/reference/comparison-operators-javascript.md).  
  
 The optional `fromIndex` argument specifies the array index at which to begin the search. If `fromIndex` is greater than or equal to the array length, -1 is returned. If `fromIndex` is negative, the search starts at the array length plus `fromIndex`.  
  
## Example  
 The following examples illustrate the use of the `indexOf` method.  
  
```javascript  
// Create an array. (The elements start at index 0.)  
var ar = ["ab", "cd", "ef", "ab", "cd"];  
  
// Determine the first location of "cd".  
document.write(ar.indexOf("cd") + "<br/>");  
  
// Output: 1  
  
// Find "cd" starting at index 2.  
document.write(ar.indexOf("cd", 2) + "<br/>");  
  
// Output: 4  
  
// Find "gh" (which is not found).  
document.write (ar.indexOf("gh")+ "<br/>");  
  
// Output: -1  
  
// Find "ab" with a fromIndex argument of -2.  
// The search starts at index 3, which is the array length plus -2.  
document.write (ar.indexOf("ab", -2) + "<br/>");  
// Output: 3  
  
```  
  
## Requirements  
 [!INCLUDE[jsv9](../../javascript/includes/jsv9-md.md)]  
  
## See Also  
 [JavaScript Methods](../../javascript/reference/javascript-methods.md)   
 [Array Object](../../javascript/reference/array-object-javascript.md)   
 [Using Arrays](../../javascript/advanced/using-arrays-javascript.md)