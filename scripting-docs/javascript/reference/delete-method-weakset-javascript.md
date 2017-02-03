---
title: "delete Method (WeakSet) (JavaScript) | Microsoft Docs"
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
ms.assetid: 19e93366-7d42-4abf-b7b9-fcf943fa17a3
caps.latest.revision: 2
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# delete Method (WeakSet) (JavaScript)
Removes the specified element from a `WeakSet`.  
  
## Syntax  
  
```javascript  
weaksetObj.delete(obj)  
```  
  
#### Parameters  
 `weaksetObj`  
 Required. A `WeakSet` object.  
  
 `obj`  
 Required. The element to remove.  
  
## Property Value/Return Value  
 `true` if the element has been removed.  
  
## Example  
 The following example shows how to add and delete elements of a `WeakSet`.  
  
```javascript  
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