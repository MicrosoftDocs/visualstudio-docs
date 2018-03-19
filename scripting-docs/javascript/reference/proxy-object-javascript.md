---
title: "Proxy Object (JavaScript) | Microsoft Docs"
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
ms.assetid: 2b89abee-04fa-47e6-9676-980016cff5f8
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Proxy Object (JavaScript)
Enables custom behavior for an object.  
  
## Syntax  
  
```  
proxyObj = new Proxy(target, handler)  
```  
  
#### Parameters  
 `target`  
 Required. An object or function to be virtualized by the proxy.  
  
 `handler`  
 Required. An object with methods (traps) that implement the custom behavior.  
  
## Remarks  
 A `Proxy` object is used to intercept internal low-level operations on another object. Proxy objects can be used for interception, object virtualization, logging/profiling, and other purposes.  
  
 If a trap for a specific operation has not been defined in the handler for the proxy, the operation is forwarded to the target.  
  
 The handler object defines the following methods (traps) to implement custom behavior. The examples here are not exhaustive. To support conditional default behavior in the handler method, use methods of [Reflect Object](../../javascript/reference/reflect-object-javascript.md).  
  
|Handler method (trap) syntax|Examples of usage|  
|------------------------------------|-----------------------|  
|`apply: function(target, thisArg, args)`|A trap for a function call.|  
|`construct: function(target, args)`|A trap for a constructor.|  
|`defineProperty: function(target, propertyName, descriptor)`|A trap for [Object.defineProperty Function](../../javascript/reference/object-defineproperty-function-javascript.md).|  
|`deleteProperty: function(target, propertyName)`|A trap for the `delete` statement.|  
|`enumerate: function(target)`|A trap for the [for...in](../../javascript/reference/for-dot-dot-dot-in-statement-javascript.md) statement, [Object.getOwnPropertySymbols](../../javascript/reference/object-getownpropertysymbols-function-javascript.md), [Object.keys](../../javascript/reference/object-keys-function-javascript.md) function, and [JSON.stringify](../../javascript/reference/json-stringify-function-javascript.md).|  
|`get: function(target, propertyName, receiver)`|A trap for any [getter](../../javascript/creating-objects-javascript.md) properties.|  
|`getOwnPropertyDescriptor: function(target, propertyName)`|A trap for [Object.getOwnPropertyDescriptor Function](../../javascript/reference/object-getownpropertydescriptor-function-javascript.md).|  
|`getPrototypeOf: function(target)`|A trap for [Object.getPrototypeOf Function](../../javascript/reference/object-getprototypeof-function-javascript.md).|  
|`has: function(target, propertyName)`|A trap for the `in` operator, [hasOwnProperty Method (Object)](../../javascript/reference/hasownproperty-method-object-javascript.md), and other methods.|  
|`isExtensible: function(target)`|A trap for [Object.isExtensible Function](../../javascript/reference/object-isextensible-function-javascript.md).|  
|`ownKeys: function(target)`|A trap for [Object.getOwnPropertyNames Function](../../javascript/reference/object-getownpropertynames-function-javascript.md).|  
|`preventExtensions: function(target)`|A trap for [Object.preventExtensions Function](../../javascript/reference/object-preventextensions-function-javascript.md).|  
|`set: function(target, propertyName, value, receiver)`|A trap for any [setter](../../javascript/creating-objects-javascript.md) properties.|  
|`setPrototypeOf: function(target, prototype)`|A trap for [Object.setPrototypeOf](../../javascript/reference/object-setprototypeof-function-javascript.md).|  
  
## Example  
 The following code example shows how to create a proxy for an object literal using the `get` trap.  
  
```JavaScript  
var target = {};  
var handler = {  
  get: function (target, property, receiver) {  
    // This example includes a template string.  
    return `Hello, ${property}!`;  
  }  
};  
  
var p = new Proxy(target, handler);  
console.log(p.world);  
  
// Output:  
// Hello, world!  
  
```  
  
## Example  
 The following code example shows how to create a proxy for a function using the `apply` trap.  
  
```JavaScript  
var target = function () { return 'I am the target'; };  
var handler = {  
  // This example includes a rest parameter.  
  apply: function (receiver, ...args) {  
    return 'I am the proxy';  
  }  
};  
  
var p = new Proxy(target, handler);  
console.log(target()):  
console.log(p()):  
  
// Output:  
// I am the target  
// I am the proxy  
```  
  
## Requirements  
 [!INCLUDE[jsv12](../../javascript/reference/includes/jsv12-md.md)]
