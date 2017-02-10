---
title: "Array.from Function (Array) (JavaScript) | Microsoft Docs"
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
ms.assetid: 1bf59a99-f860-4c4d-b4c6-d5f1f946a490
caps.latest.revision: 3
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Array.from Function (Array) (JavaScript)
Returns an array from an array-like or iterable object.  
  
## Syntax  
  
```  
Array.from (arrayLike [ , mapfn [ , thisArg ] ] );  
```  
  
#### Parameters  
 `arrayLike`  
 Required. An array-like object or an iterable object.  
  
 `mapfn`  
 Optional. A mapping function to call on each element in `arrayLike`.  
  
 `thisArg`  
 Optional. Specifies the `this` object in the mapping function.  
  
## Remarks  
 The `arrayLike` parameter must be either an object with indexed elements and a `length` property or an iterable object, such as a `Set` object.  
  
 The optional mapping function is called on each element in the array.  
  
## Example  
 The following example returns an array from a collection of DOM element nodes.  
  
```javascript  
var elemArr = Array.from(document.querySelectorAll('*'));  
var elem = elemArr[0]; // elem contains a reference to the first DOM element  
  
```  
  
## Example  
 The following example returns an array of characters.  
  
```javascript  
var charArr = Array.from("abc");  
// charArr[0] == "a";  
```  
  
## Example  
 The following example returns an array of objects contained in the collection.  
  
```javascript  
var setObj = new Set("a", "b", "c");  
var objArr = Array.from(setObj);  
// objArr[1] == "b";   
```  
  
## Example  
 The following example shows the use of arrow syntax and a mapping function to change the value of elements.  
  
```javascript  
var arr = Array.from([1, 2, 3], x => x * 10);  
// arr[0] == 10;  
// arr[1] == 20;  
// arr[2] == 30;  
```  
  
## Requirements  
 [!INCLUDE[jsv12](../../javascript/reference/includes/jsv12-md.md)]