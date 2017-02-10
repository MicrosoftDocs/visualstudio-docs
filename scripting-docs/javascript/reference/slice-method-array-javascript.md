---
title: "slice Method (Array) (JavaScript) | Microsoft Docs"
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
  - "slice"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "zero-based index"
  - "Array object"
  - "slice method"
ms.assetid: 3c122219-14de-4126-b091-809659c026d6
caps.latest.revision: 14
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# slice Method (Array) (JavaScript)
Returns a section of an array.  
  
## Syntax  
  
```  
  
arrayObj.slice(start, [end])   
```  
  
## Parameters  
 `arrayObj`  
 Required. An `Array` object.  
  
 `start`  
 Required. The beginning of the specified portion of `arrayObj`.  
  
 `end`  
 Optional. The end of the specified portion of `arrayObj`.  
  
## Remarks  
 The `slice` method returns an `Array` object containing the specified portion of `arrayObj`.  
  
 The `slice` method copies up to, but not including, the element indicated by `end`. If `start` is negative, it is treated as `length` + `start`, where `length` is the length of the array. If `end` is negative, it is treated as `length` + `end` where `length` is the length of the array. If `end` is omitted, extraction continues to the end of `arrayObj`. If `end` occurs before `start`, no elements are copied to the new array.  
  
## Example  
 The following examples show how to use the `slice` method. In the first example, all but the last element of `myArray` is copied into `newArray`. In the second example, only the last two elements of `myArray` are copied into `newArray`.  
  
```javascript  
var origArray = [3, 5, 7, 9];  
var newArray = origArray. slice(0, -1);  
document.write(origArray);  
document.write("<br/>");  
newArray = origArray. slice(-2);  
document.write(newArray);  
  
// Output:  
// 3,5,7,9  
// 7,9  
  
```  
  
## Requirements  
 [!INCLUDE[jsv3](../../javascript/reference/includes/jsv3-md.md)]  
  
## See Also  
 [slice Method (String)](../../javascript/reference/slice-method-string-javascript.md)   
 [String Object](../../javascript/reference/string-object-javascript.md)