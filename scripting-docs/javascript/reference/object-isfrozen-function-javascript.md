---
title: "Object.isFrozen Function (JavaScript) | Microsoft Docs"
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
  - "isFrozen function [JavaScript]"
  - "Object.isFrozen function [JavaScript]"
ms.assetid: 6cf1bbc6-56e8-429b-8e2c-0024fa614acc
caps.latest.revision: 10
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Object.isFrozen Function (JavaScript)
Returns `true` if existing property attributes and values cannot be modified in an object, and new properties cannot be added to the object.  
  
## Syntax  
  
```JavaScript  
Object.isFrozen(object)  
```  
  
#### Parameters  
 `object`  
 Required. The object to test.  
  
## Return Value  
 `true` if all of the following are true:  
  
-   The object is non-extensible, which indicates that new properties cannot be added to the object.  
  
-   The `configurable` attribute is `false` for all existing properties.  
  
-   The `writable` attribute is `false` for all existing data properties.  
  
 If the object has no existing properties, the function returns `true` if the object is non-extensible.  
  
## Exceptions  
 If the `object` argument is not an object, a `TypeError` exception is thrown.  
  
## Remarks  
 When the `configurable` attribute of a property is `false`, the property attributes cannot be changed and the property cannot be deleted. When `writable` is `false`, the data property value cannot be changed. When `configurable` is `false` and `writable` is `true`, the `value` and `writable` attributes can be changed.  
  
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
|[Object.isSealed](../../javascript/reference/object-issealed-function-javascript.md)|No|Yes|No|  
|`Object.isFrozen`|No|Yes|Yes|  
  
## Example  
 The following example illustrates the use of the `Object.isFrozen` function.  
  
```JavaScript  
// Create an object that has two properties.  
var obj = { pasta: "spaghetti", length: 10 };  
  
// Freeze the object, and verify that it is frozen.  
Object.freeze(obj);  
document.write(obj.isFrozen());  
  
// Try to add a new property, and then verify that it is not added.   
obj.newProp = 50;  
document.write (obj.newProp);  
document.write ("<br/>");  
  
// Try to delete a property, and then verify that it is still present.  
delete obj.length;  
document.write (obj.length);  
document.write ("<br/> ");  
  
// Try to change a property value, and then verify that it is not changed.  
obj.pasta = "linguini";  
document.write (obj.pasta);  
  
// Output:  
// true  
// undefined  
// 10  
// spaghetti  
  
```  
  
## Requirements  
 [!INCLUDE[jsv9](../../javascript/includes/jsv9-md.md)]  
  
## See Also  
 [Object.preventExtensions Function](../../javascript/reference/object-preventextensions-function-javascript.md)   
 [Object.seal Function](../../javascript/reference/object-seal-function-javascript.md)   
 [Object.freeze Function](../../javascript/reference/object-freeze-function-javascript.md)   
 [Object.isExtensible Function](../../javascript/reference/object-isextensible-function-javascript.md)   
 [Object.isSealed Function](../../javascript/reference/object-issealed-function-javascript.md)   
 [Object.defineProperty Function](../../javascript/reference/object-defineproperty-function-javascript.md)   
 [Object.getOwnPropertyDescriptor Function](../../javascript/reference/object-getownpropertydescriptor-function-javascript.md)   
 [Object.getOwnPropertyNames Function](../../javascript/reference/object-getownpropertynames-function-javascript.md)