---
title: "Object.create Function (JavaScript) | Microsoft Docs"
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
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "create function [JavaScript]"
  - "Object.create function [JavaScript]"
ms.assetid: 0ad31f36-a9ee-444e-b0fe-c87843d03196
caps.latest.revision: 14
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Object.create Function (JavaScript)
Creates an object that has the specified prototype, and that optionally contains specified properties.  
  
## Syntax  
  
```  
Object.create(prototype, descriptors)  
```  
  
#### Parameters  
 `prototype`  
 Required. The object to use as a prototype. May be `null`.  
  
 `descriptors`  
 Optional. A [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] object that contains one or more property descriptors.  
  
 A *data property* is a property that can get and set a value. A data property descriptor contains a `value` attribute, plus `writable`, `enumerable`, and `configurable` attributes. If the last three attributes are not specified, they default to `false`. An *accessor property* calls a user-provided function every time the value is retrieved or set. An accessor property descriptor contains a `set` attribute, a `get` attribute, or both. For more information, see [Object.defineProperty Function](../../javascript/reference/object-defineproperty-function-javascript.md).  
  
## Return Value  
 A new object that has the specified internal prototype and contains the specified properties, if any.  
  
## Exceptions  
 A `TypeError` exception is thrown if any of the following conditions is true:  
  
-   The `prototype` argument is not an object and is not `null`.  
  
-   A descriptor in the `descriptors` argument has a `value` or `writable` attribute, and has a `get` or `set` attribute.  
  
-   A descriptor in the `descriptors` argument has a `get` or `set` attribute that is not a function.  
  
## Remarks  
 You can use this function using a `null``prototype` parameter in order to stop the prototype chain. The object created will have no prototype.  
  
## Example  
 The following example creates an object using a `null` prototype and adds two enumerable properties.  
  
```JavaScript  
var newObj = Object.create(null, {  
            size: {  
                value: "large",  
                enumerable: true  
            },  
            shape: {  
                value: "round",  
                enumerable: true  
            }  
        });  
  
document.write(newObj.size + "<br/>");  
document.write(newObj.shape + "<br/>");  
document.write(Object.getPrototypeOf(newObj));  
  
// Output:  
// large  
// round  
// null  
  
```  
  
## Example  
 The following example creates an object that has the same internal prototype as the Object object. You can see that it has the same prototype as an object created by using an object literal. The [Object.getPrototypeOf](../../javascript/reference/object-getprototypeof-function-javascript.md) function gets the prototype of the original object. To get the object's property descriptor, you can use [Object.getOwnPropertyDescriptor Function](../../javascript/reference/object-getownpropertydescriptor-function-javascript.md).  
  
```JavaScript  
var firstLine = { x: undefined, y: undefined };  
  
var secondLine = Object.create(Object.prototype, {  
        x: {  
                value: undefined,   
                writable: true,   
                configurable: true,   
                enumerable: true  
            },  
            y: {  
                value: undefined,   
                writable: true,   
                configurable: true,   
                enumerable: true  
            }  
});  
  
document.write("first line prototype = " + Object.getPrototypeOf(firstLine));  
document.write("<br/>");  
document.write("second line prototype = " + Object.getPrototypeOf(secondLine));  
  
// Output:  
// first line prototype = [object Object]  
// second line prototype = [object Object]  
```  
  
## Example  
 The following example creates an object that has the same internal prototype as the Shape object.  
  
```JavaScript  
  
// Create the shape object.  
var Shape = { twoDimensional: true, color: undefined, hasLineSegments: undefined };  
  
var Square = Object.create(Object.getPrototypeOf(Shape));  
  
```  
  
## Requirements  
 [!INCLUDE[jsv9](../../javascript/includes/jsv9-md.md)]  
  
## See Also  
 [Object.getPrototypeOf Function](../../javascript/reference/object-getprototypeof-function-javascript.md)   
 [isPrototypeOf Method (Object)](../../javascript/reference/isprototypeof-method-object-javascript.md)   
 [Creating Objects](../../javascript/creating-objects-javascript.md)