---
title: "Reflect Object (JavaScript) | Microsoft Docs"
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
ms.assetid: 1df74f34-2eb4-42f1-a930-b943c86daa0e
caps.latest.revision: 3
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Reflect Object (JavaScript)
Provides methods for use in operations that are intercepted.  
  
## Syntax  
  
```  
Reflect.[method]  
```  
  
#### Parameters  
 `method`  
 Required. Name of one of the methods of the `Reflect` object.  
  
## Remarks  
 The Reflect object cannot be instantiated with the `new` operator.  
  
 Reflect methods are often used with [proxies](../../javascript/reference/proxy-object-javascript.md) because they allow you to delegate to default behavior without implementing the default behavior in your code.  
  
 Reflect provides a static method with the same name as each proxy trap. The descriptions in the table are not exhaustive.  
  
|Method|Description|  
|------------|-----------------|  
|`Reflect.apply(target, thisArg, args)`|Similar to the [apply](../../javascript/reference/apply-method-function-javascript.md) method of the Function object.|  
|`Reflect.construct(target, args)`|A function equivalent for the `new` operator.|  
|`Reflect.defineProperty(target, propertyName, descriptor)`|Similar to [Object.defineProperty](../../javascript/reference/object-defineproperty-function-javascript.md). Returns a boolean value indicating whether the call succeeded.|  
|`Reflect.deleteProperty(target, propertyName)`|Similar to the `delete` statement. Returns a boolean value indicating whether the call succeeded.|  
|`Reflect.enumerate(target)`|Similar to [for…in](../../javascript/reference/for-dot-dot-dot-in-statement-javascript.md) statement, [Object.getOwnPropertySymbols](../../javascript/reference/object-getownpropertysymbols-function-javascript.md), [Object.keys](../../javascript/reference/object-keys-function-javascript.md) function, and [JSON.stringify](../../javascript/reference/json-stringify-function-javascript.md).|  
|`Reflect.get(target, propertyName, receiver)`|A function equivalent for any [getter](../../javascript/creating-objects-javascript.md) properties.|  
|`Reflect.getOwnPropertyDescriptor(target, propertyName)`|Similar to [Object.getOwnPropertyDescriptor](../../javascript/reference/object-getownpropertydescriptor-function-javascript.md). Returns a Boolean value indicating whether the call succeeded.|  
|`Reflect.getPrototypeOf(target)`|Similar to [Object.getPrototypeOf](../../javascript/reference/object-getprototypeof-function-javascript.md).|  
|`Reflect.has(target, propertyName)`|Similar to the `in` operator, [hasOwnProperty Method (Object)](../../javascript/reference/hasownproperty-method-object-javascript.md), and other methods. Returns a Boolean value indicating whether the call succeeded.|  
|`Reflect.isExtensible(target)`|Similar to [Object.isExtensible](../../javascript/reference/object-isextensible-function-javascript.md).|  
|`Reflect.ownKeys(target)`|Similar to [Object.getOwnPropertyNames](../../javascript/reference/object-getownpropertynames-function-javascript.md).|  
|`Reflect.preventExtensions(target)`|Similar to [Object.preventExtensions](../../javascript/reference/object-preventextensions-function-javascript.md). Returns a boolean value indicating whether the call succeeded.|  
|`Reflect.set(target, propertyName, value, receiver)`|Similar to using any [setter](../../javascript/creating-objects-javascript.md) property. Returns a Boolean value indicating whether the call succeeded.|  
|`Reflect.setPrototypeOf(target, prototype)`|Similar to [Object.setPrototypeOf](../../javascript/reference/object-setprototypeof-function-javascript.md). Returns a boolean value indicating whether the call succeeded.|  
  
## Example  
 The following code example shows how use `Reflect.get` to write a proxy that blocks get operations for properties that begin with an underscore.  
  
```JavaScript  
var p = new Proxy({}, {  
    get(k, t, r) {  
        // return undefined if key begins with underscore  
        if(k[0] === '_') return undefined;  
  
       // otherwise do default behavior  
       return Reflect.get(k, t, r);  
    }  
});  
  
p._foo = 1;  
console.log(p._foo);  
  
p.foo = 1;  
console.log(p.foo);  
  
// Output:  
// undefined  
// 1  
  
```  
  
## Requirements  
 [!INCLUDE[jsv12](../../javascript/reference/includes/jsv12-md.md)]