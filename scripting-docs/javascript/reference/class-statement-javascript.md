---
title: "class Statement (JavaScript) | Microsoft Docs"
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
ms.assetid: bf45ebad-4678-4062-88df-55d32b603c69
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# class Statement (JavaScript)
Declares a new class.  
  
## Syntax  
  
```  
class classname () [extends object] {    [constructor([arg1 [,... [,argN]]]) {        statements    }]    [[static] method([arg1 [,... [,argN]]]) {        statements    }]}  
```  
  
#### Parameters  
 `classname`  
 Required. The name of the class.  
  
 `object`  
 Optional. An object or class from which the new class inherits properties and methods.  
  
 `constructor`  
 Optional. A constructor function that initializes the new class instance.  
  
 `arg1...argN`  
 Optional. An optional, comma-separated list of arguments the function understands.  
  
 `statements`  
 Optional. One or more [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] statements.  
  
 `static`  
 Optional. Specifies a static method.  
  
 `method`  
 Optional. One or more [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] instance or static methods that can be called on a class instance.  
  
## Remarks  
 A class allows you to create new objects using prototype-based inheritance, constructors, instance methods, and static methods. You can use the `super` object within a class constructor or class method to call the same constructor or method in the parent class or object. Optionally, use the `extends` statement after the class name to specify the class or object from which the new class inherits methods.  
  
## Example  
  
```javascript  
class Spelunking extends EXPERIENCE.Outdoor {  
  constructor(name, location) {  
    super(name, location);  
  
    this.minSkill = Spelunking.defaultSkill();  
    //...  
  }  
  update(minSkill) {  
    //...  
    super.update(minSkill);  
  }  
  static defaultSkill() {  
    return new EXPERIENCE.Level3();  
  }  
}  
```  
  
## Example  
 You can also create computed property names for classes. The following code example creates a computed property name using `set` syntax.  
  
```javascript  
var propName = "prop_42";  
  
class Spelunking {  
    set [propName](v) {  
        this.value = v;  
    }  
};  
  
var s = new Spelunking();  
console.log(s.value);  
s.prop_42 = 42;  
console.log(s.value);  
  
// Output:  
// undefined  
// 42  
  
```  
  
## Example  
 The following code example creates a property name for a class dynamically using `get` syntax.  
  
```javascript  
var propName = "prop_42";  
  
class Spelunking {  
    get [propName]() {  
        return 777;  
    }  
}  
  
var s = new Spelunking();  
console.log(s.prop_42);  
  
// Output:  
// 777  
```  
  
## Requirements  
 [!INCLUDE[jsv12exp](../../javascript/reference/includes/jsv12exp-md.md)]