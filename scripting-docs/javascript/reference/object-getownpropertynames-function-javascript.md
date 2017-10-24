---
title: "Object.getOwnPropertyNames Function (JavaScript) | Microsoft Docs"
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
  - "getOwnPropertyNames method [JavaScript]"
  - "Object.getOwnPropertyNames method [JavaScript]"
ms.assetid: 59f4b6b1-02be-44b3-a06c-a5ca8f70c3d8
caps.latest.revision: 9
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Object.getOwnPropertyNames Function (JavaScript)
Returns the names of the own properties of an object. The own properties of an object are those that are defined directly on that object, and are not inherited from the object's prototype. The properties of an object include both fields (objects) and functions.  
  
## Syntax  
  
```JavaScript  
Object.getOwnPropertyNames(object)  
```  
  
#### Parameters  
  
|Parameter|Definition|  
|---------------|----------------|  
|`object`|Required. The object that contains the own properties.|  
  
## Return Value  
 An array that contains the names of the own properties of the object.  
  
## Exceptions  
 If the value supplied for the `object` argument is not the name of an object, a `TypeError` exception is thrown.  
  
## Remarks  
 The `getOwnPropertyNames` method returns the names of both enumerable and non-enumerable properties and methods. To return only the names of enumerable properties and methods, you can use the [Object.keys Function](../../javascript/reference/object-keys-function-javascript.md).  
  
## Example  
 The following example creates an object that has three properties and a method. It then uses the `getOwnPropertyNames` method to obtain the own properties (including the method) of the object.  
  
```JavaScript  
function Pasta(grain, width, shape) {  
    // Define properties.  
    this.grain = grain;  
    this.width = width;  
    this.shape = shape;  
    this.toString = function () {  
        return (this.grain + ", " + this.width + ", " + this.shape);  
    }  
}  
  
// Create an object.  
var spaghetti = new Pasta("wheat", 0.2, "circle");  
  
// Get the own property names.  
var arr = Object.getOwnPropertyNames(spaghetti);  
document.write (arr);  
  
// Output:  
//   grain,width,shape,toString  
```  
  
## Example  
 The following example displays the names of properties that start with the letter 's' in a **spaghetti** object constructed with the **Pasta** constructor.  
  
```JavaScript  
function Pasta(grain, size, shape) {  
    this.grain = grain;   
    this.size = size;   
    this.shape = shape;   
}  
  
var spaghetti = new Pasta("wheat", 2, "circle");  
  
var names = Object.getOwnPropertyNames(spaghetti).filter(CheckKey);  
document.write(names);   
  
// Check whether the first character of a string is 's'.   
function CheckKey(value) {  
    var firstChar = value.substr(0, 1);   
    if (firstChar.toLowerCase() == 's')  
        return true;   
    else  
         return false;   
}  
// Output:  
// size,shape  
```  
  
## Requirements  
 [!INCLUDE[jsv9](../../javascript/includes/jsv9-md.md)]  
  
## See Also  
 [Object.keys Function](../../javascript/reference/object-keys-function-javascript.md)