---
title: "add Method (Set) (JavaScript) | Microsoft Docs"
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
ms.assetid: b4eea447-fd5b-4380-978e-1b95f6dbc438
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# add Method (Set) (JavaScript)
Adds a new element to a set.  
  
## Syntax  
  
```JavaScript  
setObj.add(value)  
```  
  
#### Parameters  
 `setObj`  
 Required. A `Set` object.  
  
 `value`  
 Required. New element of the `Set`.  
  
## Remarks  
 The new element can be of any type and must be unique. If you add a non-unique element to a `Set`, the new element will not be added to the collection.  
  
## Example  
 The following example shows how to add members to a set and then retrieve them.  
  
```JavaScript  
var s = new Set();  
s.add("Thomas Jefferson");  
s.add(1776);  
s.add("founding father");  
  
s.forEach(function (item) {  
    document.write(item.toString() + ", ");  
});  
  
// Output:  
// Thomas Jefferson, 1776, founding father,  
  
```  
  
## Requirements  
 [!INCLUDE[jsv11](../../javascript/reference/includes/jsv11-md.md)]