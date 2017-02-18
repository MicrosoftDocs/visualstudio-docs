---
title: "WeakMap Object (JavaScript) | Microsoft Docs"
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
  - "WeakMap"
dev_langs: 
  - "JavaScript"
  - "DHTML"
ms.assetid: 4682d2dc-caf9-4fa8-8313-a0a0b804fd1d
caps.latest.revision: 9
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# WeakMap Object (JavaScript)
A collection of key/value pairs in which each key is an object reference.  
  
## Syntax  
  
```  
weakmapObj = new WeakMap()  
```  
  
## Remarks  
 A `WeakMap` object cannot be enumerated.  
  
 If you add a value to the collection using an existing key, the new value will replace the old value.  
  
 In a `WeakMap` object, references to key objects are held ‘weakly’. This means that `WeakMap` will not prevent a garbage collection from happening on the key objects. When there are no references (other than `WeakMap`) to the key objects, the garbage collector may collect the key objects.  
  
## Properties  
 The following table lists the properties of the `WeakMap` object.  
  
|Property|Description|  
|--------------|-----------------|  
|[constructor](../../javascript/reference/constructor-property-weakmap.md)|Specifies the function that creates a `WeakMap`.|  
|[prototype](../../javascript/reference/prototype-property-weakmap.md)|Returns a reference to the prototype for a `WeakMap`.|  
  
## Methods  
 The following table lists the methods of the `WeakMap` object.  
  
|Method|Description|  
|------------|-----------------|  
|[clear](../../javascript/reference/clear-method-weakmap-javascript.md)|Removes all elements from a `WeakMap`.|  
|[delete](../../javascript/reference/delete-method-weakmap-javascript.md)|Removes a specified element from a `WeakMap`.|  
|[get](../../javascript/reference/get-method-weakmap-javascript.md)|Returns a specified element from a `WeakMap`.|  
|[has](../../javascript/reference/has-method-weakmap-javascript.md)|Returns `true` if the `WeakMap` contains a specified element.|  
|[set](../../javascript/reference/set-method-weakmap-javascript.md)|Adds a new element to a `WeakMap`.|  
|[toString](../../javascript/reference/tostring-method-weakmap-javascript.md)|Returns a string representation of a `WeakMap`.|  
|[valueOf](../../javascript/reference/valueof-method-weakmap-javascript.md)|Returns the primitive value of the specified object.|  
  
## Example  
 The following example shows how to add members to a `WeakMap` object and then retrieve them.  
  
```javascript  
var dog = {  
    breed: "yorkie"  
}  
  
var cat = {  
    breed: "burmese"  
}  
  
var wm = new WeakMap();  
wm.set(dog, "fido");  
wm.set(cat, "pepper");  
  
document.write(wm.get(dog) + ": ");  
document.write(dog.breed);  
document.write("<br />");  
document.write(wm.get(cat) + ": ");  
document.write(cat.breed);  
  
// Output:  
// fido: yorkie  
// pepper: burmese  
  
```  
  
## Requirements  
 [!INCLUDE[jsv11](../../javascript/reference/includes/jsv11-md.md)]