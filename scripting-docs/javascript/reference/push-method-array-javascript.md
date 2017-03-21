---
title: "push Method (Array) (JavaScript) | Microsoft Docs"
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
  - "push"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "Push method"
ms.assetid: fa6e5799-dabe-4b3d-bd1f-0afc68c77134
caps.latest.revision: 15
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# push Method (Array) (JavaScript)
Appends new elements to an array, and returns the new length of the array.  
  
## Syntax  
  
```  
  
arrayObj.push([item1 [item2 [. . . [itemN ]]]])  
```  
  
## Parameters  
 `arrayObj`  
 Required. An `Array` object.  
  
 `item, item2,. . ., itemN`  
 Optional. New elements of the `Array`.  
  
## Remarks  
 The `push` and `pop` methods allow you to simulate a last in, first out stack.  
  
 The `push` method appends elements in the order in which they appear. If one of the arguments is an array, it is added as a single element. Use the `concat` method to join the elements from two or more arrays.  
  
## Example  
 The following example illustrates the use of the `push` method.  
  
```JavaScript  
var number;  
var my_array = new Array();  
  
my_array.push (5, 6, 7);  
my_array.push (8, 9);  
  
number = my_array.pop();  
while (number != undefined)  
   {  
   document.write (number + " ");  
   number = my_array.pop();  
   }  
  
// Output:  
// 9 8 7 6 5  
```  
  
## Requirements  
 [!INCLUDE[jsv55](../../javascript/reference/includes/jsv55-md.md)]  
  
## See Also  
 [concat Method (Array)](../../javascript/reference/concat-method-array-javascript.md)   
 [pop Method (Array)](../../javascript/reference/pop-method-array-javascript.md)