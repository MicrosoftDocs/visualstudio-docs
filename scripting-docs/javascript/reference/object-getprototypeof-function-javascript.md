---
title: "Object.getPrototypeOf Function (JavaScript) | Microsoft Docs"
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
helpviewer_keywords: 
  - "getPrototypeOf function [JavaScript]"
  - "Object.getPrototypeOf function [JavaScript]"
ms.assetid: 1c59cd7a-a7e2-4c5c-83ec-e6bd2b104d9f
caps.latest.revision: 9
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Object.getPrototypeOf Function (JavaScript)
Returns the prototype of an object.  
  
## Syntax  
  
```javascript  
Object.getPrototypeOf(object)  
```  
  
#### Parameters  
 `object`  
 Required. The object that references the prototype.  
  
## Return Value  
 The prototype of the `object` argument. The prototype is also an object.  
  
## Exceptions  
 If the `object` argument is not an object, a `TypeError` exception is thrown.  
  
## Example  
 The following example illustrates the use of the `Object.getPrototypeOf` function.  
  
```javascript  
// Create a constructor function.  
function Pasta(grain, width) {  
    this.grain = grain;  
    this.width = width;  
}  
// Create an object from the pasta constructor.  
var spaghetti = new Pasta("wheat", 0.2);  
  
// Obtain the prototype from the object.  
var proto = Object.getPrototypeOf(spaghetti);  
  
// Add a property to the prototype and validate that  
// the original object has the property.  
proto.foodgroup = "carbohydrates";  
document.write(spaghetti.foodgroup + " ");  
  
// Verify that the prototype obtained from the object  
// is the same as the prototype of the constructor.  
var result = (proto === Pasta.prototype);  
document.write(result + " ");  
  
// Verify that prototype obtained from the object  
// is a prototype of the original object.  
var result = proto.isPrototypeOf(spaghetti);  
document.write(result);  
  
// Output: carbohydrates true true  
```  
  
## Example  
 The following example uses the `Object.getPrototypeOf` function to validate data types.  
  
```javascript  
var reg = /a/;  
var result = (Object.getPrototypeOf(reg) === RegExp.prototype);  
document.write(result + " ");  
  
var err = new Error("an error");  
var result = (Object.getPrototypeOf(err) === Error.prototype);  
document.write(result);  
  
// Output: true true  
  
```  
  
## Requirements  
 [!INCLUDE[jsv9](../../javascript/includes/jsv9-md.md)]  
  
## See Also  
 [prototype Property (Object)](../../javascript/reference/prototype-property-object-javascript.md)   
 [isPrototypeOf Method (Object)](../../javascript/reference/isprototypeof-method-object-javascript.md)