---
title: "Object.isExtensible Function (JavaScript) | Microsoft Docs"
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
  - "Object.isExtensible function [JavaScript]"
  - "isExtensible function [JavaScript]"
ms.assetid: a7d10beb-0d01-4e2d-8263-59ff07ac4352
caps.latest.revision: 10
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Object.isExtensible Function (JavaScript)
Returns a value that indicates whether new properties can be added to an object.  
  
## Syntax  
  
```JavaScript  
Object.isExtensible(object)  
```  
  
#### Parameters  
 `object`  
 Required. The object to test.  
  
## Return Value  
 `true` if the object is extensible, which indicates that new properties can be added to the object; otherwise, `false`.  
  
## Exceptions  
 If the `object` argument is not an object, a `TypeError` exception is thrown.  
  
## Remarks  
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
|`Object.isExtensible`|Yes|No|No|  
|[Object.isSealed](../../javascript/reference/object-issealed-function-javascript.md)|No|Yes|No|  
|[Object.isFrozen](../../javascript/reference/object-isfrozen-function-javascript.md)|No|Yes|Yes|  
  
## Example  
 The following example illustrates the use of the `Object.isExtensible` function.  
  
```JavaScript  
// Create an object that has two properties.  
var obj = { pasta: "spaghetti", length: 10 };  
  
// Make the object non-extensible.  
Object.preventExtensions(obj);  
  
// Try to add a new property, and then verify that it is not added.  
obj.newProp = 50;  
document.write(obj.newProp);  
  
// Output:  
undefined  
  
```  
  
## Requirements  
 [!INCLUDE[jsv9](../../javascript/includes/jsv9-md.md)]  
  
## See Also  
 [Object.preventExtensions Function](../../javascript/reference/object-preventextensions-function-javascript.md)   
 [Object.seal Function](../../javascript/reference/object-seal-function-javascript.md)   
 [Object.freeze Function](../../javascript/reference/object-freeze-function-javascript.md)   
 [Object.isSealed Function](../../javascript/reference/object-issealed-function-javascript.md)   
 [Object.isFrozen Function](../../javascript/reference/object-isfrozen-function-javascript.md)