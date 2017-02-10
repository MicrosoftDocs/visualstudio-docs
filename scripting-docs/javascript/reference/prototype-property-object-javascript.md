---
title: "prototype Property (Object) (JavaScript) | Microsoft Docs"
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
  - "Prototype"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "inheritance, objects"
  - "Prototype property"
ms.assetid: 9fc434a1-5995-4fcb-a4e8-00e7f615aaa2
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# prototype Property (Object) (JavaScript)
Returns a reference to the prototype for a class of objects.  
  
## Syntax  
  
```  
  
objectName.prototype  
```  
  
## Remarks  
 The `objectName` argument is the name of an object.  
  
 Use the `prototype` property to provide a base set of functionality to a class of objects. New instances of an object "inherit" the behavior of the prototype assigned to that object.  
  
 For example, to add a method to the `Array` object that returns the value of the largest element of the array, declare the function, add it to `Array.prototype`, and then use it.  
  
```javascript  
function array_max( ){  
    var i, max = this[0];  
    for (i = 1; i < this.length; i++)  
    {  
    if (max < this[i])  
    max = this[i];  
    }  
    return max;  
}  
Array.prototype.max = array_max;  
var myArray = new Array(7, 1, 3, 11, 25, 9  
);  
document.write(myArray.max());  
  
// Output:  
// 25  
  
```  
  
 All intrinsic [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] objects have a `prototype` property that is read-only. Properties and methods may be added to the prototype, but the object may not be assigned a different prototype. However, user-defined objects may be assigned a new prototype.  
  
 The method and property lists for each intrinsic object in this language reference indicate which ones are part of the object's prototype, and which are not.  
  
## Requirements  
 [!INCLUDE[jsv2](../../javascript/reference/includes/jsv2-md.md)]  
  
## See Also  
 [constructor Property (Object)](../../javascript/reference/constructor-property-object-javascript.md)