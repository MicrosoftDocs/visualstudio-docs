---
title: "get Method (Map) (JavaScript) | Microsoft Docs"
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
ms.assetid: bebbd6bc-6e61-4674-8196-7e907798973f
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# get Method (Map) (JavaScript)
Returns a specified element from a map.  
  
## Syntax  
  
```JavaScript  
mapObj.get(key)  
```  
  
#### Parameters  
 `mapObj`  
 Required. A `Map` object.  
  
 `key`  
 Required. The key of an element in the `Map`.  
  
## Property Value/Return Value  
 Returns the object associated with the key. If the `Map` does not contain the key, this method returns an `undefined` value.  
  
## Example  
 The following example shows how to retrieve an element from a `Map` object.  
  
```JavaScript  
var m = new Map();  
m.set(1, "black");  
m.set(2, "red");  
m.set("colors", 2);  
  
document.write(m.get(2));  
  
// Output:  
// red  
  
```  
  
## Requirements  
 [!INCLUDE[jsv11](../../javascript/reference/includes/jsv11-md.md)]