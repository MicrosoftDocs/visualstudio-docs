---
title: "Object.defineProperty Function (JavaScript) | Microsoft Docs"
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
  - "defineProperty function [JavaScript]"
  - "Object.defineProperty function [JavaScript]"
ms.assetid: c5d05346-940a-40c2-b12a-e8b25abc8d46
caps.latest.revision: 74
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Object.defineProperty Function (JavaScript)
Adds a property to an object, or modifies attributes of an existing property.  
  
## Syntax  
  
```  
Object.defineProperty(object, propertyname, descriptor)  
```  
  
## Parameters  
 `object`  
 Required. The object on which to add or modify the property. This can be a native [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] object (that is, a user-defined object or a built in object) or a DOM object.  
  
 `propertyname`  
 Required. A string that contains the property name.  
  
 `descriptor`  
 Required. A descriptor for the property. It can be for a data property or an accessor property.  
  
## Return Value  
 The modified object.  
  
## Remarks  
 You can use the `Object.defineProperty` function to do the following:  
  
-   Add a new property to an object. This occurs when the object does not have the specified property name.  
  
-   Modify attributes of an existing property. This occurs when the object already has the specified property name.  
  
 The property definition is provided in a descriptor object, which describes the attributes of a data property or an accessor property. The descriptor object is a parameter of the `Object.defineProperty` function.  
  
 To add multiple properties to an object, or to modify multiple existing properties, you can use the [Object.defineProperties Function](../../javascript/reference/object-defineproperties-function-javascript.md).  
  
## Exceptions  
 A `TypeError` exception is thrown if any one of the following conditions is true:  
  
-   The `object` argument is not an object.  
  
-   The object is not [extensible](../../javascript/reference/object-isextensible-function-javascript.md) and the specified property name does not exist..  
  
-   The `descriptor` has a `value` or `writable` attribute, and has a `get` or `set` attribute.  
  
-   The `descriptor` has a `get` or `set` attribute that is not a function or undefined.  
  
-   The specified property name already exists, the existing property has a `configurable` attribute of `false`, and the `descriptor` contains one or more attributes that are different from those in the existing property. However, when the existing property has a `configurable` attribute of `false` and a `writable` attribute of `true`, it is permitted for the `value` or `writable` attribute to be different.  
  
## Adding a Data Property  
 In the following example, the `Object.defineProperty` function adds a data property to a user-defined object. To instead add the property to an existing DOM object, uncomment the `var = window.document` line.  
  
```javascript  
var newLine = "<br />";  
  
// Create a user-defined object.  
var obj = {};  
  
// Add a data property to the object.  
Object.defineProperty(obj, "newDataProperty", {  
    value: 101,  
    writable: true,  
    enumerable: true,  
    configurable: true  
});  
  
// Set the property value.  
obj.newDataProperty = 102;  
document.write("Property value: " + obj.newDataProperty + newLine);  
  
// Output:  
// Property value: 102  
```  
  
 To list the object properties, add the following code to this example.  
  
```javascript  
var names = Object.getOwnPropertyNames(obj);  
for (var i = 0; i < names.length; i++) {  
    var prop = names[i];  
  
    document.write(prop + ': ' + obj[prop]);  
    document.write(newLine);  
}  
  
// Output:  
//  newDataProperty: 102  
```  
  
## Modifying a Data Property  
 To modify a property attribute for the object, add the following code to the `addDataProperty` function shown earlier. The `descriptor` parameter contains only a `writable` attribute. The other data property attributes remain the same.  
  
```javascript  
// Modify the writable attribute of the property.  
Object.defineProperty(obj, "newDataProperty", { writable: false });  
  
// List the property attributes by using a descriptor.  
// Get the descriptor with Object.getOwnPropertyDescriptor.  
var descriptor = Object.getOwnPropertyDescriptor(obj, "newDataProperty");  
for (var prop in descriptor) {  
    document.write(prop + ': ' + descriptor[prop]);  
    document.write(newLine);  
}  
  
// Output  
// writable: false  
// value: 102  
// configurable: true  
// enumerable: true  
```  
  
## Adding an Accessor Property  
 In the following example, the `Object.defineProperty` function adds an accessor property to a user-defined object.  
  
```javascript  
var newLine = "<br />";  
  
// Create a user-defined object.  
var obj = {};  
  
// Add an accessor property to the object.  
Object.defineProperty(obj, "newAccessorProperty", {  
    set: function (x) {  
        document.write("in property set accessor" + newLine);  
        this.newaccpropvalue = x;  
    },  
    get: function () {  
        document.write("in property get accessor" + newLine);  
        return this.newaccpropvalue;  
    },  
    enumerable: true,  
    configurable: true  
});  
  
// Set the property value.  
obj.newAccessorProperty = 30;  
document.write("Property value: " + obj.newAccessorProperty + newLine);  
  
// Output:  
// in property set accessor  
// in property get accessor  
// Property value: 30  
  
```  
  
 To list the object properties, add the following code to this example.  
  
```javascript  
var names = Object.getOwnPropertyNames(obj);  
for (var i = 0; i < names.length; i++) {  
    var prop = names[i];  
  
    document.write(prop + ': ' + obj[prop]);  
    document.write(newLine);  
}  
// Output:  
// in property get accessor  
// newAccessorProperty: 30  
  
```  
  
## Modifying an Accessor Property  
 To modify a property attribute for the object, add the following code to the code shown earlier. The `descriptor` parameter contains only a `get` accessor definition. The other property attributes remain the same.  
  
```javascript  
// Modify the get accessor.  
Object.defineProperty(obj, "newAccessorProperty", {  
    get: function () { return this.newaccpropvalue; }  
});  
  
// List the property attributes by using a descriptor.  
// Get the descriptor with Object.getOwnPropertyDescriptor.  
var descriptor = Object.getOwnPropertyDescriptor(obj, "newAccessorProperty");  
for (var prop in descriptor) {  
    document.write(prop + ': ' + descriptor[prop]);  
    document.write(newLine);  
}  
  
// Output:  
// get: function () { return this.newaccpropvalue; }  
// set: function (x) { document.write("in property set accessor" + newLine); this.newaccpropvalue = x; }  
// configurable: true  
// enumerable: true  
```  
  
## Modifying a Property on a DOM Element  
 The following example demonstrates how to customize built-in DOM properties by using the `Object.getOwnPropertyDescriptor` function to get and modify the property's property descriptor. For this example, there must by a DIV element with an ID of "div".  
  
```javascript  
// Get the querySelector property descriptor.  
var descriptor = Object.getOwnPropertyDescriptor(Element.prototype, "querySelector");  
  
// Make the property read-only.  
descriptor.value = "query";  
descriptor.writable = false;  
// Apply the changes to the Element prototype.  
Object.defineProperty(Element.prototype, "querySelector", descriptor);  
  
// Get a DOM element from the HTML body.  
var elem = document.getElementById("div");  
  
// Attempt to change the value. This causes the revised value attribute to be called.  
elem.querySelector = "anotherQuery";  
document.write(elem.querySelector);  
  
// Output:  
// query  
  
```  
  
## Requirements  
 Internet Explorer 9 standards mode and Internet Explorer 10 standards mode, as well as [!INCLUDE[win8_appname_long](../../javascript/includes/win8-appname-long-md.md)] apps, support all features.  
  
 [!INCLUDE[jsv58textspecific](../../javascript/reference/includes/jsv58textspecific-md.md)] supports DOM objects but not user-defined objects. The `enumerable` and `configurable` attributes can be specified, but they are not used.  
  
## See Also  
 [Document Object Model Prototypes, Part 2: Accessor (getter/setter) Support](http://msdn.microsoft.com/library/dd229916\(v=VS.85\).aspx)   
 [Object.defineProperties Function](../../javascript/reference/object-defineproperties-function-javascript.md)   
 [Object.create Function](../../javascript/reference/object-create-function-javascript.md)   
 [Object.getOwnPropertyDescriptor Function](../../javascript/reference/object-getownpropertydescriptor-function-javascript.md)   
 [Object.getOwnPropertyNames Function](../../javascript/reference/object-getownpropertynames-function-javascript.md)