---
title: "pop Method (Array) (JavaScript) | Microsoft Docs"
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
  - "pop"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "Pop method"
ms.assetid: 4fae7f98-29f1-4041-ba43-601f2e5145ec
caps.latest.revision: 14
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# pop Method (Array) (JavaScript)
Removes the last element from an array and returns it.  
  
## Syntax  
  
```  
  
arrayObj.pop( )  
```  
  
## Remarks  
 The [push](../../javascript/reference/push-method-array-javascript.md) and `pop` methods enable you to simulate a stack, which uses the principle of last in, first out (LIFO) to store data.  
  
 The required `arrayObj` reference is an `Array` object.  
  
 If the array is empty, `undefined` is returned.  
  
## Example  
 The following example illustrates the use of the `pop` method.  
  
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
  
// Output: 9 8 7 6 5  
```  
  
## Requirements  
 [!INCLUDE[jsv55](../../javascript/reference/includes/jsv55-md.md)]  
  
## See Also  
 [push Method (Array)](../../javascript/reference/push-method-array-javascript.md)