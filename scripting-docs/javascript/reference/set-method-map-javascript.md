---
title: "set Method (Map) (JavaScript) | Microsoft Docs"
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
ms.assetid: 31ee71a0-b09d-442a-9e02-825accf94ffa
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# set Method (Map) (JavaScript)
Adds a new element to a map.  
  
## Syntax  
  
```javascript  
mapObj.set(key, value)  
```  
  
#### Parameters  
 `mapObj`  
 Required. A `Map` object.  
  
 `key`  
 Required. The key for the new element.  
  
 `value`  
 Required. The value of the element to add.  
  
## Property Value/Return Value  
 Returns the `Map` object that contains the new key/value pair.  
  
## Remarks  
 If you add a value to the collection using an existing key, the new value will replace the old value.  
  
## Example  
 The following example shows how to add members to a `Map` and then retrieve them.  
  
```javascript  
var m = new Map();  
m.set(1, "black");  
m.set(2, "red");  
m.set("colors", 2);  
  
m.forEach(function (item) {  
    document.write(item.toString() + "<br />");  
});  
  
// Output:  
// black  
// red  
// 2  
```  
  
## Requirements  
 [!INCLUDE[jsv11](../../javascript/reference/includes/jsv11-md.md)]