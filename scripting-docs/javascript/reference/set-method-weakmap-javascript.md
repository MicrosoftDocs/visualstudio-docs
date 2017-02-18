---
title: "set Method (WeakMap) (JavaScript) | Microsoft Docs"
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
ms.assetid: 29fc72b1-224f-4f19-8c06-5d926d695b03
caps.latest.revision: 6
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# set Method (WeakMap) (JavaScript)
Adds a new element to a `WeakMap` object.  
  
## Syntax  
  
```javascript  
weakmapObj.set(key, value)  
```  
  
#### Parameters  
 `weakmapObj`  
 Required. A `WeakMap` object.  
  
 `key`  
 Required. An object representing the key of the element to add. This must be an object reference.  
  
 `value`  
 Required. The value of the element to add.  
  
## Property Value/Return Value  
 Returns the `WeakMap` object that contains the new key/value pair.  
  
## Remarks  
 If you add a value to the collection using an existing key, the new value will replace the old value.  
  
## Example  
 The following example shows how to add members to a `WeakMap` object.  
  
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
```  
  
## Requirements  
 [!INCLUDE[jsv11](../../javascript/reference/includes/jsv11-md.md)]