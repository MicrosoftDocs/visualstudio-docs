---
title: "Object.keys Function (JavaScript) | Microsoft Docs"
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
  - "Object.keys method [JavaScript]"
  - "keys method [JavaScript]"
ms.assetid: cf4a7daf-cf28-4467-bc6b-f7f106ec3876
caps.latest.revision: 12
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Object.keys Function (JavaScript)
Returns the names of the enumerable properties and methods of an object.  
  
## Syntax  
  
```javascript  
Object.keys(object)  
```  
  
#### Parameters  
  
|Parameter|Definition|  
|---------------|----------------|  
|`object`|Required. The object that contains the properties and methods. This can be an object that you created or an existing Document Object Model (DOM) object.|  
  
## Return Value  
 An array that contains the names of the enumerable properties and methods of the object.  
  
## Exceptions  
 If the value supplied for the `object` argument is not the name of an object, a `TypeError` exception is thrown.  
  
## Remarks  
 The `keys` method returns only the names of enumerable properties and methods. To return the names of both enumerable and non-enumerable properties and methods, you can use [Object.getOwnPropertyNames Function](../../javascript/reference/object-getownpropertynames-function-javascript.md).  
  
 For information about the `enumerable` attribute of a property, see [Object.defineProperty Function](../../javascript/reference/object-defineproperty-function-javascript.md) and [Object.getOwnPropertyDescriptor Function](../../javascript/reference/object-getownpropertydescriptor-function-javascript.md).  
  
## Example  
 The following example creates an object that has three properties and a method. It then uses the `keys` method to get the properties and methods of the object.  
  
```javascript  
// Create a constructor function.  
function Pasta(grain, width, shape) {  
    this.grain = grain;  
    this.width = width;  
    this.shape = shape;  
  
    // Define a method.  
    this.toString = function () {  
        return (this.grain + ", " + this.width + ", " + this.shape);  
    }  
}  
  
// Create an object.  
var spaghetti = new Pasta("wheat", 0.2, "circle");  
  
// Put the enumerable properties and methods of the object in an array.  
var arr = Object.keys(spaghetti);  
document.write (arr);  
  
// Output:  
// grain,width,shape,toString  
```  
  
## Example  
 The following example displays the names of all enumerable properties that start with the letter "g" in the Pasta object.  
  
```javascript  
// Create a constructor function.  
function Pasta(grain, width, shape) {  
    this.grain = grain;  
    this.width = width;  
    this.shape = shape;  
}  
  
var polenta = new Pasta("corn", 1, "mush");  
  
var keys = Object.keys(polenta).filter(CheckKey);  
document.write(keys);  
  
// Check whether the first character of a string is "g".  
function CheckKey(value) {  
    var firstChar = value.substr(0, 1);  
    if (firstChar.toLowerCase() == "g")  
        return true;  
    else  
        return false;  
}  
  
// Output:  
// grain  
```  
  
## Requirements  
 [!INCLUDE[jsv9](../../javascript/includes/jsv9-md.md)]  
  
## See Also  
 [Object.getOwnPropertyNames Function](../../javascript/reference/object-getownpropertynames-function-javascript.md)