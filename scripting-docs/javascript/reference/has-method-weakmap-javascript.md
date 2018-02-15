---
title: "has Method (WeakMap) (JavaScript) | Microsoft Docs"
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
ms.assetid: 12bedca1-bde7-413a-a4e2-06c03559044f
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# has Method (WeakMap) (JavaScript)
Returns `true` if the `WeakMap` object contains the specified element.  
  
## Syntax  
  
```JavaScript  
weakmapObj.has(key)  
```  
  
#### Parameters  
 `weakmapObj`  
 Required. A `WeakMap` object.  
  
 `key`  
 Required. The key of the element to test.  
  
## Property Value/Return Value  
 `true` if the `WeakMap` contains the specified key.  
  
## Example  
 The following example shows how to add a member to a `WeakMap` and then use `has` to check whether it is present.  
  
```JavaScript  
var dog = {  
    breed: "yorkie"  
}  
  
var wm = new WeakMap();  
wm.set(dog, "fido");  
  
document.write(wm.has(dog));  
  
// Output:  
// true  
```  
  
## Requirements  
 [!INCLUDE[jsv11](../../javascript/reference/includes/jsv11-md.md)]