---
title: "add Method (WeakSet) (JavaScript) | Microsoft Docs"
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
ms.assetid: d35d0287-6b33-4720-b9d7-8954c428ce4e
caps.latest.revision: 2
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# add Method (WeakSet) (JavaScript)
Adds a new element to a `WeakSet`.  
  
## Syntax  
  
```JavaScript  
weaksetObj.add(obj)  
```  
  
#### Parameters  
 `weaksetObj`  
 Required. A `WeakSet` object.  
  
 `obj`  
 Required. New element of the `WeakSet`.  
  
## Remarks  
 The new element must be an object, rather than an arbitrary value, and must be unique. If you add a non-unique element to a `WeakSet`, the new element will not be added to the collection.  
  
## Example  
 The following example shows how to add members to a set and verify that they have been added.  
  
```JavaScript  
var ws = new WeakSet();  
  
var str = new String("Thomas Jefferson");  
var num = new Number(1776);  
  
ws.add(str);  
ws.add(num);  
  
console.log(ws.has(str));  
console.log(ws.has(num));  
  
ws.delete(str);  
console.log(ws.has(str));  
  
// Output:  
// true  
// true  
// false  
```  
  
## Requirements  
 [!INCLUDE[jsv12](../../javascript/reference/includes/jsv12-md.md)]