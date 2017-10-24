---
title: "delete Method (Map) (JavaScript) | Microsoft Docs"
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
ms.assetid: a073e1a1-5862-485b-b2bd-26c66a3aff51
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# delete Method (Map) (JavaScript)
Removes the specified element from a map.  
  
## Syntax  
  
```JavaScript  
mapObj.delete(key)  
```  
  
#### Parameters  
 `mapObj`  
 Required. A `Map` object.  
  
 `key`  
 Required. The key of the element to remove.  
  
## Property Value/Return Value  
 `true` if the element has been removed.  
  
## Example  
 The following example shows how to add members to a `Map` and then delete one of them.  
  
```JavaScript  
var m = new Map();  
m.set(1, "black");  
m.set(2, "red");  
m.set("colors", 2);  
m.delete(1);  
  
m.forEach(function (item) {  
    document.write(item.toString() + "<br />");  
});  
  
// Output:  
// red  
// 2  
```  
  
## Requirements  
 [!INCLUDE[jsv11](../../javascript/reference/includes/jsv11-md.md)]