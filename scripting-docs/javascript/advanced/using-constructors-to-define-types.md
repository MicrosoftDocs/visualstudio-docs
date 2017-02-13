---
title: "Using Constructors to Define Types | Microsoft Docs"
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
  - "DHTML"
helpviewer_keywords: 
  - "creating objects, constructor functions"
  - "constructor functions"
  - "functions, constructor functions"
  - "objects, creating [JavaScript]"
  - "constructors, creating"
ms.assetid: e869702e-4caf-4513-8dd5-fe690535f8aa
caps.latest.revision: 17
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Using Constructors to Define Types
A constructor is a function that instantiates a particular type of [Object](../../javascript/objects-and-arrays-javascript.md). You invoke a constructor with the **new** keyword. Here are a few examples of constructors with built-in JavaScript objects and custom objects.  
  
## Constructor Examples  
  
```javascript  
// Creates a generic object.  
var myObject = new Object();  
// Creates a Date object.  
var myBirthday = new Date(1961, 5, 10);  
// Creates a user defined object.  
var myCar = new Car();  
```  
  
 The constructor function contains the **this** keyword, which is a reference to a newly created empty object. It initializes the new object by creating properties and giving them initial values. The constructor returns a reference to the object it constructed.  
  
## Writing Constructors  
 You can create objects using the **new** operator in conjunction with predefined constructor functions such as **Object()**, **Date()**, and **Function()**. You can also create custom constructor functions that define a set of properties and methods. Here is an example of a custom constructor.  
  
```javascript  
function Circle (xPoint, yPoint, radius) {  
    this.x = xPoint;  // The x component of the center of the circle.  
    this.y = yPoint;  // The y component of the center of the circle.  
    this.r = radius;  // The radius of the circle.  
}  
```  
  
 When you invoke the Circle constructor, you supply values for the circle's center point and the radius. You end up with a Circle object that contains three properties. Here is how you would instantiate a Circle object.  
  
```javascript  
var aCircle = new Circle(5, 11, 99);  
```  
  
 The type of all objects created with a custom constructor is `object`. There are only six types in JavaScript: `object`, `function`, `string`, `number`, `boolean`, and `undefined`. For more information, see [typeof Operator](../../javascript/reference/typeof-operator-decrementjavascript.md)  
  
## See Also  
 [Using the bind method](../../javascript/advanced/using-the-bind-method-javascript.md)