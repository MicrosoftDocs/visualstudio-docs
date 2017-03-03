---
title: "Object.freeze Function (JavaScript) | Microsoft Docs"
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
  - "Object.freeze function"
  - "freeze function"
ms.assetid: 83ffe193-0a37-4e0c-9b66-44c422765fb3
caps.latest.revision: 20
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Object.freeze Function (JavaScript)
Prevents the modification of existing property attributes and values, and prevents the addition of new properties.  
  
## Syntax  
  
```javascript  
Object.freeze(object)  
```  
  
#### Parameters  
 `object`  
 Required. The object on which to lock the attributes.  
  
## Return Value  
 The object that is passed to the function.  
  
## Exceptions  
 If the `object` argument is not an object, a `TypeError` exception is thrown.  
  
## Remarks  
 The `Object.freeze` function does the following:  
  
-   Makes the object non-extensible, so that new properties cannot be added to it.  
  
-   Sets the `configurable` attribute to `false` for all properties of the object. When `configurable` is `false`, the property attributes cannot be changed and the property cannot be deleted.  
  
-   Sets the `writable` attribute to `false` for all data properties of the object. When `writable` is false, the data property value cannot be changed.  
  
 For more information about how to set property attributes, see [Object.defineProperty Function](../../javascript/reference/object-defineproperty-function-javascript.md). To obtain the attributes of a property, you can use the [Object.getOwnPropertyDescriptor Function](../../javascript/reference/object-getownpropertydescriptor-function-javascript.md).  
  
## Related Functions  
 The following related functions prevent the modification of object attributes.  
  
|Function|Object is made non-extensible|`configurable` is set to `false` for each property|`writable` is set to `false` for each property|  
|--------------|------------------------------------|--------------------------------------------------------|----------------------------------------------------|  
|[Object.preventExtensions](../../javascript/reference/object-preventextensions-function-javascript.md)|Yes|No|No|  
|[Object.seal](../../javascript/reference/object-seal-function-javascript.md)|Yes|Yes|No|  
|`Object.freeze`|Yes|Yes|Yes|  
  
 The following functions return `true` if all of the conditions marked in the following table are true.  
  
|Function|Object is extensible?|`configurable` is `false` for all properties?|`writable` is `false` for all data properties?|  
|--------------|---------------------------|---------------------------------------------------|----------------------------------------------------|  
|[Object.isExtensible](../../javascript/reference/object-isextensible-function-javascript.md)|Yes|No|No|  
|[Object.isSealed](../../javascript/reference/object-issealed-function-javascript.md)|No|Yes|Yes|  
|[Object.isFrozen](../../javascript/reference/object-isfrozen-function-javascript.md)|No|Yes|Yes|  
  
## Example  
 The following example illustrates the use of the `Object.freeze` function.  
  
```javascript  
// Create an object that has two properties.  
var obj = { pasta: "spaghetti", length: 10 };  
  
// Freeze the object.  
Object.freeze(obj);  
  
// Try to add a new property, and then verify that it is not added.   
    obj.newProp = 50;  
    document.write(obj.newProp);  
    document.write("<br/>");  
  
// Try to delete a property, and then verify that it is still present.   
delete obj.length;  
document.write(obj.length);  
document.write("<br/>");  
  
// Try to change a property value, and then verify that it is not changed.   
obj.pasta = "linguini";  
document.write(obj.pasta);  
  
// Output:  
// undefined  
// 10  
// spaghetti  
  
```  
  
## Requirements  
 [!INCLUDE[jsv9](../../javascript/includes/jsv9-md.md)]  
  
## See Also  
 [Object.preventExtensions Function](../../javascript/reference/object-preventextensions-function-javascript.md)   
 [Object.seal Function](../../javascript/reference/object-seal-function-javascript.md)   
 [Object.isExtensible Function](../../javascript/reference/object-isextensible-function-javascript.md)   
 [Object.isSealed Function](../../javascript/reference/object-issealed-function-javascript.md)   
 [Object.isFrozen Function](../../javascript/reference/object-isfrozen-function-javascript.md)