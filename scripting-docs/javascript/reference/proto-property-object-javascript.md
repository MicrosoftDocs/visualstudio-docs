---
title: "__proto__ Property (Object) (JavaScript) | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-javascript"
ms.tgt_pltfrm: ""
ms.topic: "language-reference"
f1_keywords: 
  - "__proto__"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
ms.assetid: 97c3f84d-125e-4905-b921-b021264964ee
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# __proto__ Property (Object) (JavaScript)
Contains a reference to the internal prototype of the specified object.  

> [!WARNING]
> The `__proto__` property is a legacy feature. Use [Object.getPrototypeOf](../reference/object-getprototypeof-function-javascript.md) instead.
  
## Syntax  
  
```  
object.__proto__  
```  
  
#### Parameters  
 `object`  
 Required. The object on which to set the prototype.  
  
## Remarks  
 The `__proto__` property can be used to set the prototype for an object.  
  
 The object or function inherits all methods and properties of the new prototype, along with all methods and properties in the new prototype's prototype chain. An object can have only a single prototype (not including inherited prototypes in the prototype chain), so when you call the `__proto__` property, you replace the previous prototype.  
  
 You can set the prototype only on an extensible object. For more info, see [Object.preventExtensions Function](../../javascript/reference/object-preventextensions-function-javascript.md).  
  
> [!NOTE]
>  The `__proto__` property name begins and ends with two underscores.  
  
## Example  
 The following code example shows how to set the prototype for an object.  
  
```JavaScript  
function Rectangle() {  
}  
  
var rec = new Rectangle();  
  
if (console && console.log) {  
    console.log(rec.__proto__ === Rectangle.prototype);  // Returns true  
    rec.__proto__ = Object.prototype;  
    console.log(rec.__proto__ === Rectangle.prototype);  // Returns false  
}  
```  
  
## Example  
 The following code example shows how to add properties to an object by adding them to the prototype.  
  
```JavaScript  
var proto = { y: 2 };  
  
var obj = { x: 10 };  
obj.__proto__ = proto;  
  
proto.y = 20;  
proto.z = 40;  
  
if (console && console.log) {  
    console.log(obj.x === 10);  // Returns true  
    console.log(obj.y === 20);  // Returns true  
    console.log(obj.z === 40);  // Returns true  
}  
```  
  
## Example  
 The following code example adds properties to the `String` object by setting a new prototype on it.  
  
```JavaScript  
var stringProp = { desc: "description" };  
  
String.__proto__ = stringProp;  
var s1 = "333";  
var s2 = new String("333");  
  
if (console && console.log) {  
  
    console.log(String.desc === "description"); // Returns true  
    console.log(s1.desc === "description");     // Returns false  
    console.log(s2.desc === "description");     // Returns false  
  
    s1.__proto__ = String;  // Can't be set.  
    s2.__proto__ = String;  
  
    console.log(s1.desc === "description"); // Returns false  
    console.log(s2.desc === "description"); // Returns true  
}  
```  
  
## Requirements  
 [!INCLUDE[jsv11](../../javascript/reference/includes/jsv11-md.md)]  
  
## See Also  
 [Prototypes and Prototype Inheritance](../../javascript/advanced/prototypes-and-prototype-inheritance.md)