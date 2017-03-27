---
title: "Object.preventExtensions Function (JavaScript) | Microsoft Docs"
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
  - "properties [JavaScript], preventing new"
  - "preventing new properties [JavaScript]"
  - "preventExtensions function [JavaScript]"
  - "Object.preventExtensions function [JavaScript]"
ms.assetid: e6b48197-2374-4437-a9fe-519dd45a2077
caps.latest.revision: 9
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Object.preventExtensions Function (JavaScript)
Prevents the addition of new properties to an object.  
  
## Syntax  
  
```JavaScript  
Object.preventExtensions(object)  
```  
  
#### Parameters  
 `object`  
 Required. The object to make non-extensible.  
  
## Return Value  
 The object that is passed to the function.  
  
## Exceptions  
 If the `object` argument is not an object, a `TypeError` exception is thrown.  
  
## Remarks  
 The `Object.preventExtensions` function makes an object non-extensible, so that new named properties cannot be added to it. After an object is made non-extensible, it cannot be made extensible.  
  
 For information about how to set property attributes, see [Object.defineProperty Function](../../javascript/reference/object-defineproperty-function-javascript.md).  
  
## Related Functions  
 The following related functions prevent the modification of object attributes.  
  
|Function|Object is made non-extensible|`configurable` is set to `false` for each property|`writable` is set to `false` for each property|  
|--------------|------------------------------------|--------------------------------------------------------|----------------------------------------------------|  
|`Object.preventExtensions`|Yes|No|No|  
|[Object.seal](../../javascript/reference/object-seal-function-javascript.md)|Yes|Yes|No|  
|[Object.freeze](../../javascript/reference/object-freeze-function-javascript.md)|Yes|Yes|Yes|  
  
 The following functions return `true` if all of the conditions marked in the following table are true.  
  
|Function|Object is extensible?|`configurable` is `false` for all properties?|`writable` is `false` for all data properties?|  
|--------------|---------------------------|---------------------------------------------------|----------------------------------------------------|  
|[Object.isExtensible](../../javascript/reference/object-isextensible-function-javascript.md)|Yes|No|No|  
|[Object.isSealed](../../javascript/reference/object-issealed-function-javascript.md)|No|Yes|No|  
|[Object.isFrozen](../../javascript/reference/object-isfrozen-function-javascript.md)|No|Yes|Yes|  
  
## Example  
 The following example illustrates the use of the `Object.preventExtensions` function.  
  
```JavaScript  
// Create an object that has two properties.  
var obj = { pasta: "spaghetti", length: 10 };  
  
// Make the object non-extensible.  
Object.preventExtensions(obj);  
document.write(Object.isExtensible(obj));  
document.write("<br/>");  
  
// Try to add a new property, and then verify that it is not added.  
obj.newProp = 50;  
document.write(obj.newProp);  
  
// Output:  
// false  
// undefined  
  
```  
  
## Requirements  
 [!INCLUDE[jsv9](../../javascript/includes/jsv9-md.md)]  
  
## See Also  
 [Object.seal Function](../../javascript/reference/object-seal-function-javascript.md)   
 [Object.freeze Function](../../javascript/reference/object-freeze-function-javascript.md)   
 [Object.isExtensible Function](../../javascript/reference/object-isextensible-function-javascript.md)   
 [Object.isSealed Function](../../javascript/reference/object-issealed-function-javascript.md)   
 [Object.isFrozen Function](../../javascript/reference/object-isfrozen-function-javascript.md)