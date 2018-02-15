---
title: "lastIndexOf Method (Array) (JavaScript) | Microsoft Docs"
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
  - "arrays [JavaScript], lastIndexOf method"
  - "lastIndexOf method [JavaScript]"
ms.assetid: 04f5145d-007e-498f-b06f-11ab384c2968
caps.latest.revision: 10
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# lastIndexOf Method (Array) (JavaScript)
Returns the index of the last occurrence of a specified value in an array.  
  
## Syntax  
  
```  
  
array1.lastIndexOf(searchElement[, fromIndex])  
```  
  
#### Parameters  
  
|Parameter|Definition|  
|---------------|----------------|  
|`array1`|Required. The array object to search.|  
|`searchElement`|Required. The value to locate in `array1`.|  
|`fromIndex`|Optional. The array index at which to begin the search. If `fromIndex` is omitted, the search starts at the last index in the array.|  
  
## Return Value  
 The index of the last occurrence of `searchElement` in the array, or -1 if `searchElement` is not found.  
  
## Remarks  
 The `lastIndexOf` method searches an array for a specified value. The method returns the index of the first occurrence, or -1 if the specified value is not found.  
  
 The search occurs in descending index order (last member first). To search in ascending order, use the [indexOf Method (Array)](../../javascript/reference/indexof-method-array-javascript.md).  
  
 The array elements are compared to the `searchElement` value by strict equality, similar to the comparison made by the `===` operator. For more information, see [Comparison Operators](../../javascript/reference/comparison-operators-javascript.md).  
  
 The optional `fromIndex` argument specifies the array index at which to begin the search. If `fromIndex` is greater than or equal to the array length, the whole array is searched. If `fromIndex` is negative, the search starts at the array length plus `fromIndex`. If the computed index is less than 0, -1 is returned.  
  
## Example  
 The following examples illustrate the use of the `lastIndexOf` method.  
  
```JavaScript  
// Create an array.  
var ar = ["ab", "cd", "ef", "ab", "cd"];  
  
// Determine the first location, in descending order, of "cd".  
document.write(ar.lastIndexOf("cd") + "<br/>");  
  
// Output: 4  
  
// Find "cd" in descending order, starting at index 2.  
document.write(ar.lastIndexOf("cd", 2) + "<br/>");  
  
// Output: 1  
  
// Search for "gh" (which is not found).  
document.write(ar.lastIndexOf("gh")+ "<br/>");  
  
// Output: -1  
  
// Find "ab" with a fromIndex argument of -3.  
// The search in descending order starts at index 3,  
// which is the array length minus 2.  
document.write(ar.lastIndexOf("ab", -3) + "<br/>");  
// Output: 0  
  
```  
  
## Requirements  
 [!INCLUDE[jsv9](../../javascript/includes/jsv9-md.md)]  
  
## See Also  
 [indexOf Method (Array)](../../javascript/reference/indexof-method-array-javascript.md)   
 [Array Object](../../javascript/reference/array-object-javascript.md)   
 [Using Arrays](../../javascript/advanced/using-arrays-javascript.md)