---
title: "concat Method (Array) (JavaScript) | Microsoft Docs"
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
  - "concat"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "concat method (array)"
  - "Concat method"
ms.assetid: bc2b4a6a-209e-4d59-8c24-59db01d53b1e
caps.latest.revision: 16
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# concat Method (Array) (JavaScript)
Combines two or more arrays.  
  
## Syntax  
  
```  
  
array1.concat([item1[, item2[, . . . [, itemN]]]])   
```  
  
## Parameters  
 `array1`  
 Required. The `Array` object to which the other arrays are concatenated.  
  
 `item1,. . ., itemN`  
 Optional. Additional items to add to the end of `array1`.  
  
## Remarks  
 The `concat` method returns an `Array` object containing the concatenation of `array1` and any other supplied items.  
  
 The items to be added (*item1  itemN*) to the array are added, in order, starting from the first item in the list. If one of the items is an array, its contents are added to the end of `array1`. If the item is anything other than an array, it is added to the end of the array as a single array element.  
  
 Elements of source arrays are copied to the resulting array as follows:  
  
-   If an object is copied from any of the arrays being concatenated to the new array, the object reference continues to point to the same object. A change in either the new array or the original array will result in a change to the other.  
  
-   If a number or string value is added to the new array, only the value is copied. Changing the value in one array does not affect the value in the other.  
  
## Example  
 The following example shows how to use the `concat` method when used with an array:  
  
```JavaScript  
var a, b, c, d;  
a = new Array(1,2,3);  
b = "dog";  
c = new Array(42, "cat");  
d = a.concat(b, c);  
document.write(d);  
  
//Output:   
1, 2, 3, "dog", 42, "cat"  
  
```  
  
## Requirements  
 [!INCLUDE[jsv3](../../javascript/reference/includes/jsv3-md.md)]  
  
## See Also  
 [concat Method (String)](../../javascript/reference/concat-method-string-javascript.md)   
 [join Method (Array)](../../javascript/reference/join-method-array-javascript.md)