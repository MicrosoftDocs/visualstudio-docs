---
title: "Prototypes and Prototype Inheritance | Microsoft Docs"
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
  - "prototype [JavaScript]"
  - "prototype inheritance [JavaScript]"
ms.assetid: 1e1d0631-2a9f-4011-b9fe-fa338e1ef34c
caps.latest.revision: 6
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Prototypes and Prototype Inheritance
In JavaScript, a `prototype` is a property of functions and of objects that are created by constructor functions. The prototype of a function is an object. Its main use is when a function is used as a constructor.  
  
```JavaScript  
function Vehicle(wheels, engine) {  
    this.wheels = wheels;  
    this.engine = engine;  
}  
```  
  
 In the example above, the prototype of the `Vehicle` function is the prototype of any object that is instantiated with the `Vehicle` constructor.  
  
## Using Prototypes to Add Properties and Methods  
 You can use the `prototype` property to add properties and methods to objects, even the ones that have already been created:  
  
```JavaScript  
var testVehicle = new Vehicle(2, false);  
Vehicle.prototype.color = "red";  
var testColor = testVehicle.color;  
```  
  
 The value of `testColor` is "red".  
  
 You can even add properties and methods to predefined objects. For example, you can define a `Trim` method on the `String` prototype object, and all the strings in your script will inherit the method.  
  
```JavaScript  
String.prototype.trim = function()  
{  
    // Replace leading and trailing spaces with the empty string  
    return this.replace(/(^\s*)|(\s*$)/g, "");  
}  
var s = "    leading and trailing spaces    ";  
// Displays "    leading and trailing spaces     (35)"  
window.alert(s + " (" + s.length + ")");  
// Remove the leading and trailing spaces  
s = s.trim();  
// Displays "leading and trailing spaces (27)"  
window.alert(s + " (" + s.length + ")");  
```  
  
### Using Prototypes to Derive One Object from Another with Object.create  

The prototype `Object` can be used to derive one object from another. For example, you can use the [Object.create](../../javascript/reference/object-create-function-javascript.md) function to derive a new object `Bicycle` using the prototype of the `Vehicle` object we defined earlier (plus any new properties you need).  
  
```JavaScript  
var bicycle = Object.create(Object.getPrototypeOf(Vehicle), {  
    "pedals" :{value: true}  
});  
  
```  
  
 The `bicycle` object has the properties `wheels`, `engine`, `color`, and `pedals`, and its prototype is `Vehicle.prototype`. The JavaScript engine finds the `pedals` property on `bicycle`, and it looks up the prototype chain to find the `wheels`, `engine`, and `color` properties on `Vehicle`.  
  
### Changing an Object's Prototype  
In Internet Explorer 11, you can replace the internal prototype of an object or function with a new prototype by using the [__proto__](../../javascript/reference/proto-property-object-javascript.md) property. When you use this property, you inherit the properties and methods of the new prototype along with other properties and methods in its prototype chain.  

> [!WARNING]
> The `__proto__` property is a legacy feature. Use [Object.getPrototypeOf](../reference/object-getprototypeof-function-javascript.md) instead.
  
The following example shows how you can change the prototype of an object. This example shows how the object's inherited properties change when you change its prototype.  
  
```JavaScript  
function Friend() {  
    this.demeanor = "happy";  
}  
  
function Foe() {  
    this.demeanor = "suspicious";  
}  
  
var friend = new Friend();  
var foe = new Foe();  
  
var player = new Object();  
player.__proto__ = foe;  
  
friend.ally = "Tom";  
  
if (console && console.log) {  
    console.log(player.demeanor === "happy" );      // Returns false  
    console.log(player.demeanor === "suspicious");  // Returns true  
    console.log(player.ally === "Tom");             // Returns false  
    // Turn the foe to a friend.  
    player.__proto__ = friend;  
    console.log(player.demeanor === "happy");       // Returns true  
    console.log(player.demeanor === "suspicious");  // Returns false  
    console.log(player.ally === "Tom");             // Returns true  
}  
```
