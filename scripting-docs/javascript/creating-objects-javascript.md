---
title: "Creating Objects (JavaScript) | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-javascript"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "constructors, including properties and methods"
  - "function constructor"
  - "creating objects, constructor functions"
  - "constructor functions"
  - "prototype objects"
  - "creating objects"
  - "custom objects, creating"
  - "creating objects, about creating objects"
  - "objects, creating [JavaScript]"
  - "creating objects, prototypes"
  - "custom objects"
  - "initializing objects, using constructors"
ms.assetid: 58d1baa5-4fe8-4a56-a926-5b11765df704
caps.latest.revision: 19
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Creating Objects (JavaScript)
There are a number of ways you can create your own objects in JavaScript. You can directly instantiate an [Object Object](../javascript/reference/object-object-javascript.md) and then add your own properties and methods. Or you can use object literal notation to define your object. You can also use a constructor function to define an object. For more information about using constructor functions, see [Using Constructors to Define Types](../javascript/advanced/using-constructors-to-define-types.md).  
  
## Example  
 The following code shows how to instantiate an object and add some properties. In this case only the `pasta` object has the `grain`, `width`, and `shape` properties.  
  
```JavaScript  
const pasta = new Object();  
pasta.grain = "wheat";  
pasta.width = 0.5;  
pasta.shape = "round";  
pasta.getShape = function() {   
    return this.shape;   
};  
document.write(pasta.grain);  
document.write("<br/>");  
document.write(pasta.getShape());  
  
// Output:  
// wheat  
// round  
  
```  
  
## Object literals  
 You can also use object literal notation when you want to create only one instance of an object. The following code shows how to instantiate an object by using object literal notation.  
  
```JavaScript  
const pasta = {  
    grain: "wheat",  
    width: 0.5,  
    shape: "round"  
};  
```  
  
 You can also use an object literal inside a constructor.  
  
> [!CAUTION]
>  The features described below are supported only in [!INCLUDE[jsv12text](../javascript/includes/jsv12text-md.md)].  
  
 In [!INCLUDE[jsv12text](../javascript/includes/jsv12text-md.md)], you can use shorthand syntax to create an object literal.  
  
```JavaScript  
const key = 'a';  
const value = 5;  
  
// Older version  
const obj1 = {  
    key: key,  
    value: value  
};  
  
// Edge mode  
const obj2 = {key, value};  
  
console.log(obj2);  
  
// Output:  
// [object Object] {key: "a", value: 5}  
```  
  
 The following example shows the use of shorthand syntax to define methods in object literals.  
  
```JavaScript  
// Older versions  
const obj = {  
    method1: function() {},  
    method2: function() {}  
};  
  
// Edge mode  
const obj = {  
    method1() {},  
    method2() {}  
};  
```  
  
 You can also set property names dynamically in object literals in [!INCLUDE[jsv12text](../javascript/includes/jsv12text-md.md)]. The following code example creates a property name for an object dynamically using the set syntax.  
  
```JavaScript  
const propName = "prop_42";  
  
const obj = {  
    value: 0,  
    set [propName](v) {  
        this.value = v;  
    }  
}  
  
console.log(obj.value);  
// Runs the setter property.  
obj.prop_42 = 777;  
console.log(obj.value);  
  
// Output:  
// 0  
// 777  
  
```  
  
 The following code example creates a property name for an object dynamically using the get syntax.  
  
```JavaScript  
const propName = "prop_42";  
  
const obj = {  
    get [propName]() {  
        return 777;  
    }  
}  
  
console.log(obj.prop_42);  
  
// Output:  
// 777  
```  
  
 The following code example creates a computed property using [arrow function syntax](../javascript/functions-javascript.md) to append 42 to the property name.  
  
```JavaScript  
const obj = {  
    [ 'prop_' + (() => 42)() ]: 42  
};  
```
