---
title: "has Method (WeakSet) (JavaScript) | Microsoft Docs"
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
ms.assetid: e24f0876-26bd-4007-b12a-360bb6fa0951
caps.latest.revision: 2
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# has Method (WeakSet) (JavaScript)
Returns `true` if the `WeakSet` contains the specified element.  
  
## Syntax  
  
```javascript  
setObj.has(obj)  
```  
  
#### Parameters  
 `setObj`  
 Required. A `WeakSet` object.  
  
 `obj`  
 Required. The element to test.  
  
## Property Value/Return Value  
 `true` if the set contains the specified element.  
  
## Example  
 The following example shows how to add members to a `WeakSet` and then check whether the set contains a specific member.  
  
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