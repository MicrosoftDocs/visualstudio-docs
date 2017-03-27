---
title: "delete Method (WeakMap) (JavaScript) | Microsoft Docs"
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
ms.assetid: 7d54ae55-e514-45ba-b403-d1eee46837d2
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# delete Method (WeakMap) (JavaScript)
Removes the specified element from a `WeakMap` object.  
  
## Syntax  
  
```JavaScript  
weakmapObj.delete(key)  
```  
  
#### Parameters  
 `weakmapObj`  
 Required. A `WeakMap` object.  
  
 `key`  
 Required. The key of the element to remove.  
  
## Property Value/Return Value  
 `true` if the element has been removed.  
  
## Example  
 The following example shows how to add a member to a `WeakMap` and then delete it.  
  
```JavaScript  
function Dog(breed) {  
    this.breed = breed;  
}  
  
var dog = new Dog("yorkie");  
  
var wm = new WeakMap();  
wm.set(dog, "fido");  
wm.delete(dog);  
```  
  
## Requirements  
 [!INCLUDE[jsv11](../../javascript/reference/includes/jsv11-md.md)]