---
title: "Using Arrays (JavaScript) | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-javascript"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "arrays [JavaScript]"
  - "arrays [JavaScript], objects"
ms.assetid: 785c5acd-b8b3-4152-af9a-dd42ecdd75ba
caps.latest.revision: 13
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Using Arrays (JavaScript)
Arrays in [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] are *sparse*. That is, if you have an array with three elements that are numbered 0, 1, and 2, you can create element 50 without worrying about elements 3 through 49. If the array has an automatic length variable (see [Intrinsic Objects](../../javascript/intrinsic-objects-javascript.md) for an explanation of automatic monitoring of array length), the length variable is set to 51, rather than to 4. You can create arrays in which there are no gaps in the numbering of elements, but you are not required to do so.  
  
 In [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)], objects and arrays are almost identical to each other. The two main differences are that non-array objects do not have an automatic length property, and arrays do not have the properties and methods of an object.  
  
## Addressing Arrays  
 You address arrays by using brackets ([]), as shown in the following example. The brackets enclose either a numeric value or an expression that evaluates to a whole number.  
  
```JavaScript  
var entryNum = 5;  
  
sample = new Array();  
  
sample[1] = "Maple Street";  
sample[entryNum] = 25;  
  
document.write (sample[1]);  
document.write (" ");  
document.write (sample[entryNum]);  
  
// Output: Maple Street 25  
  
```  
  
## Objects as Associative Arrays  
 You generally use the dot operator "." to access an object's properties. For example,  
  
```JavaScript  
myObject.aProperty  
```  
  
 In this case the property name is an identifier. You can also access an object's properties by using the index operator ([]). In this case you are treating the object as an *associative array* in which data values are associated with strings. For example,  
  
```JavaScript  
myObject["aProperty"] // Same as above.  
```  
  
 The index operator is more commonly associated with accessing array elements. When it is used with objects, the index is a string literal that represents the property name.  
  
 Notice the important differences between the two ways of accessing object properties.  
  
1.  A property name treated like an identifier (the dot (.) syntax) cannot be manipulated like data.  
  
2.  A property name treated like an index (the braces ([]) syntax) can be manipulated like data.  
  
 This difference becomes useful when you do not know what the property names will be until runtime (for example, when you are constructing objects based on user input). To extract all the properties from an associative array, you must use the `for…in` loop.