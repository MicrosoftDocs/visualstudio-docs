---
title: "Object.isSealed Function (JavaScript) | Microsoft Docs"
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
  - "properties [JavaScript], locking attributes"
  - "isSealed function [JavaScript]"
  - "Object.isSealed [JavaScript]"
ms.assetid: af4f192e-cebe-44b9-8eef-90c096f5ae8f
caps.latest.revision: 13
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Object.isSealed Function (JavaScript)
Returns `true` if existing property attributes cannot be modified in an object and new properties cannot be added to the object.  
  
## Syntax  
  
```JavaScript  
Object.isSealed(object)  
```  
  
#### Parameters  
 `object`  
 Required. The object to test.  
  
## Return Value  
 `true` if both of the following are true:  
  
-   The object is non-extensible, which indicates that new properties cannot be added to the object.  
  
-   The `configurable` attribute is `false` for all existing properties.  
  
 If the object does not have any properties, the function returns `true` if the object is non-extensible.  
  
## Exceptions  
 If the `object` argument is not an object, a `TypeError` exception is thrown.  
  
## Remarks  
 When the `configurable` attribute of a property is `false`, the property attributes cannot be changed and the property cannot be deleted. When `writable` is `false`, the data property value cannot be changed. When `configurable` is `false` and `writable` is `true`, the `value` and `writable` attributes can be changed.  
  
 The `Object.isSealed` function does not use the `writable` attribute of properties to determine its return value.  
  
 For information about how to set property attributes, see [Object.defineProperty Function](../../javascript/reference/object-defineproperty-function-javascript.md). To obtain the attributes of a property, you can use the [Object.getOwnPropertyDescriptor Function](../../javascript/reference/object-getownpropertydescriptor-function-javascript.md).  
  
## Related Functions  
 The following related functions prevent the modification of object attributes.  
  
|Function|Object is made non-extensible|`configurable` is set to `false` for each property|`writable` is set to `false` for each property|  
|--------------|------------------------------------|--------------------------------------------------------|----------------------------------------------------|  
|[Object.preventExtensions](../../javascript/reference/object-preventextensions-function-javascript.md)|Yes|No|No|  
|[Object.seal](../../javascript/reference/object-seal-function-javascript.md)|Yes|Yes|No|  
|[Object.freeze](../../javascript/reference/object-freeze-function-javascript.md)|Yes|Yes|Yes|  
  
 The following functions return `true` if all of the conditions marked in the following table are true.  
  
|Function|Object is extensible?|`configurable` is `false` for all properties?|`writable` is `false` for all data properties?|  
|--------------|---------------------------|---------------------------------------------------|----------------------------------------------------|  
|[Object.isExtensible](../../javascript/reference/object-isextensible-function-javascript.md)|Yes|No|No|  
|`Object.isSealed`|No|Yes|No|  
|[Object.isFrozen](../../javascript/reference/object-isfrozen-function-javascript.md)|No|Yes|Yes|  
  
## Example  
 The following example illustrates the use of the `Object.isSealed` function.  
  
```JavaScript  
// Create an object that has two properties.  
var obj = { pasta: "spaghetti", length: 10 };  
  
// Seal the object, and verify that it is sealed.  
Object.seal(obj);  
document.write(Object.isSealed(obj));  
document.write("<br/>");  
  
// Try to add a new property, and then verify that it is not added.   
obj.newProp = 50;  
document.write(obj.newProp);  
document.write("<br/>");  
  
// Try to delete a property, and then verify that it is still present.   
delete obj.length;  
document.write(obj.length);  
  
// Output:  
// true  
// undefined  
// 10  
  
```  
  
## Requirements  
 [!INCLUDE[jsv9](../../javascript/includes/jsv9-md.md)]  
  
## See Also  
 [Object.preventExtensions Function](../../javascript/reference/object-preventextensions-function-javascript.md)   
 [Object.seal Function](../../javascript/reference/object-seal-function-javascript.md)   
 [Object.freeze Function](../../javascript/reference/object-freeze-function-javascript.md)   
 [Object.isExtensible Function](../../javascript/reference/object-isextensible-function-javascript.md)   
 [Object.isFrozen Function](../../javascript/reference/object-isfrozen-function-javascript.md)   
 [Object.defineProperty Function](../../javascript/reference/object-defineproperty-function-javascript.md)   
 [Object.getOwnPropertyDescriptor Function](../../javascript/reference/object-getownpropertydescriptor-function-javascript.md)