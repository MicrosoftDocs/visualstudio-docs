---
title: "Object.seal Function (JavaScript) | Microsoft Docs"
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
  - "Object.seal function"
  - "seal function"
ms.assetid: e72c804a-4dab-4ec9-b9df-9c9c908aa12d
caps.latest.revision: 12
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Object.seal Function (JavaScript)
Prevents the modification of attributes of existing properties, and prevents the addition of new properties.  
  
## Syntax  
  
```JavaScript  
Object.seal(object)  
```  
  
#### Parameters  
 `object`  
 Required. The object on which to lock the attributes.  
  
## Return Value  
 The object that is passed to the function.  
  
## Exceptions  
 If the `object` argument is not an object, a `TypeError` exception is thrown.  
  
## Remarks  
 The `Object.seal` function does both of the following:  
  
-   Makes the object non-extensible, so that new properties cannot be added to it.  
  
-   Sets the `configurable` attribute to `false` for all properties of the object.  
  
 When the `configurable` attribute is `false`, property attributes cannot be changed and the property cannot be deleted. When `configurable` is `false` and `writable` is `true`, the `value` and `writable` attributes can be changed.  
  
 The `Object.seal` function does not change the `writable` attribute.  
  
 For more information about how to set property attributes, see [Object.defineProperty Function](../../javascript/reference/object-defineproperty-function-javascript.md). To get the attributes of a property, you can use the [Object.getOwnPropertyDescriptor Function](../../javascript/reference/object-getownpropertydescriptor-function-javascript.md).  
  
## Related Functions  
 The following related functions prevent the modification of object attributes.  
  
|Function|Object is made non-extensible|`configurable` is set to `false` for each property|`writable` is set to `false` for each property|  
|--------------|------------------------------------|--------------------------------------------------------|----------------------------------------------------|  
|[Object.preventExtensions](../../javascript/reference/object-preventextensions-function-javascript.md)|Yes|No|No|  
|`Object.seal`|Yes|Yes|No|  
|[Object.freeze](../../javascript/reference/object-freeze-function-javascript.md)|Yes|Yes|Yes|  
  
 The following functions return `true` if all of the conditions marked in the following table are true.  
  
|Function|Object is extensible?|`configurable` is `false` for all properties?|`writable` is `false` for all data properties?|  
|--------------|---------------------------|---------------------------------------------------|----------------------------------------------------|  
|[Object.isExtensible](../../javascript/reference/object-isextensible-function-javascript.md)|Yes|No|No|  
|[Object.isSealed](../../javascript/reference/object-issealed-function-javascript.md)|No|Yes|No|  
|[Object.isFrozen](../../javascript/reference/object-isfrozen-function-javascript.md)|No|Yes|Yes|  
  
## Example  
 The following example illustrates the use of the `Object.seal` function.  
  
```JavaScript  
// Create an object that has two properties.  
var obj = { pasta: "spaghetti", length: 10 };  
// Seal the object.  
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
 [Object.freeze Function](../../javascript/reference/object-freeze-function-javascript.md)   
 [Object.isExtensible Function](../../javascript/reference/object-isextensible-function-javascript.md)   
 [Object.isSealed Function](../../javascript/reference/object-issealed-function-javascript.md)   
 [Object.isFrozen Function](../../javascript/reference/object-isfrozen-function-javascript.md)