---
title: "sort Method (Array) (JavaScript) | Microsoft Docs"
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
  - "sort"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "Sort method"
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# sort Method (Array) (JavaScript)
Sorts an `Array`.  
  
## Syntax  
  
```  
  
arrayobj.sort(sortFunction)   
```  
  
## Parameters  
 `arrayObj`  
 Required. Any `Array` object.  
  
 `sortFunction`  
 Optional. The name of the function used to determine the order of the elements. If omitted, the elements are sorted in ascending, ASCII character order.  
  
## Return Value  
 The sorted array.  
  
## Remarks  
 The `sort` method sorts the `Array` object in place; no new `Array` object is created during execution.  
  
 `sortFunction` takes two arguments and must return one of the following values:  
  
-   A negative value (less than 0) if the first argument passed is less than the second argument.  The first argument is sorted to a lower index.
  
-   Zero (0) if the two arguments are equivalent.  The two arguments are sorted with respect to other elements in the array, but are not sorted with respect to each other.
  
-   A positive value (greater than 0) if the first argument is greater than the second argument.  The second argument is sorted to a lower index.
  
## Example  
 The following example shows how to use the `sort` method.  
  
```JavaScript  
var a = new Array(4, 11, 2, 10, 3, 1);  
  
var b = a.sort();  
document.write(b);  
document.write("<br/>");  
  
// This is ASCII character order.  
// Output: 1,10,11,2,3,4)  
  
// Sort the array elements with a function that compares array elements.  
b = a.sort(CompareForSort);  
document.write(b);  
document.write("<br/>");  
// Output: 1,2,3,4,10,11.  
  
// Sorts array elements in ascending order numerically.  
function CompareForSort(first, second)  
{  
    if (first == second)  
        return 0;  
    if (first < second)  
        return -1;  
    else  
        return 1;   
}  
```  
  
## Requirements  
 [!INCLUDE[jsv2](../../javascript/reference/includes/jsv2-md.md)]