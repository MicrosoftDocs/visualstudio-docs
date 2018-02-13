---
title: "Object.getOwnPropertyDescriptor Function (JavaScript) | Microsoft Docs"
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
  - "getOwnPropertyDescriptor method [JavaScript]"
ms.assetid: 8f0e1c90-c4f9-44c4-bf76-726bacecbc14
caps.latest.revision: 45
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Object.getOwnPropertyDescriptor Function (JavaScript)
Gets the own property descriptor of the specified object. An own property descriptor is one that is defined directly on the object and is not inherited from the object's prototype.  
  
## Syntax  
  
```  
Object.getOwnPropertyDescriptor(object, propertyname)  
```  
  
## Parameters  
 `object`  
 Required. The object that contains the property.  
  
 `propertyname`  
 Required. The name of the property.  
  
## Return Value  
 The descriptor of the property.  
  
## Remarks  
 You can use the `Object.getOwnPropertyDescriptor` function to obtain a descriptor object that describes attributes of the property.  
  
 The [Object.defineProperty Function](../../javascript/reference/object-defineproperty-function-javascript.md) is used to add or modify properties.  
  
## Data Property Example  
 The following example gets a data property descriptor and uses it to make the property read-only.  
  
```JavaScript  
// Create a user-defined object.  
var obj = {};  
  
// Add a data property.  
obj.newDataProperty = "abc";  
  
// Get the property descriptor.  
var descriptor = Object.getOwnPropertyDescriptor(obj, "newDataProperty");  
  
// Change a property attribute.  
descriptor.writable = false;  
Object.defineProperty(obj, "newDataProperty", descriptor);  
  
```  
  
 To list the property attributes, you can add the following code to this example.  
  
```JavaScript  
// Get the descriptor from the object.  
var desc2 = Object.getOwnPropertyDescriptor(obj, "newDataProperty");  
  
// List the descriptor attributes.  
for (var prop in desc2) {  
    document.write(prop + ': ' + desc2[prop]);  
    document.write("<br />");  
}  
  
// Output:  
// value: abc  
// writable: false  
// enumerable: true  
// configurable: true  
```  
  
## Requirements  
 All features are supported in [!INCLUDE[jsv9text](../../javascript/includes/jsv9text-md.md)].  
  
 [!INCLUDE[jsv58textspecific](../../javascript/reference/includes/jsv58textspecific-md.md)] supports DOM objects but not user-defined objects. The `enumerable` and `configurable` attributes can be specified, but they are not used.  
  
## See Also  
 [Document Object Model Prototypes, Part 2: Accessor (getter/setter) Support](http://msdn.microsoft.com/library/dd229916\(v=VS.85\).aspx)   
 [Object.defineProperty Function](../../javascript/reference/object-defineproperty-function-javascript.md)