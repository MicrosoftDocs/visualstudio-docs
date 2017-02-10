---
title: "get Method (WeakMap) (JavaScript) | Microsoft Docs"
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
ms.assetid: d922c55d-486d-4feb-aedc-1f4867c417d2
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# get Method (WeakMap) (JavaScript)
Returns a specified element from a `WeakMap` object.  
  
## Syntax  
  
```javascript  
weakmapObj.get(key)  
```  
  
#### Parameters  
 `weakmapObj`  
 Required. A `WeakMap` object.  
  
 `key`  
 Required. The key of an element in the `WeakMap`.  
  
## Property Value/Return Value  
 Returns the object associated with the key. If the `WeakMap` does not contain the key, this method returns an `undefined` value.  
  
## Example  
 The following example shows how to retrieve members from a `WeakMap` object.  
  
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