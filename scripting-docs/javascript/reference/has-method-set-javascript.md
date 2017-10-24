---
title: "has Method (Set) (JavaScript) | Microsoft Docs"
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
ms.assetid: fb80f2e0-fc5e-4508-af14-1c3b3b833636
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# has Method (Set) (JavaScript)
Returns `true` if the set contains the specified element.  
  
## Syntax  
  
```JavaScript  
setObj.has(value)  
```  
  
#### Parameters  
 `setObj`  
 Required. A `Set` object.  
  
 `value`  
 Required. The element to test.  
  
## Property Value/Return Value  
 `true` if the set contains the specified element.  
  
## Example  
 The following example shows how to add members to a `Set` and then check whether the set contains a specific member.  
  
```JavaScript  
var s = new Set();  
s.add("Thomas Jefferson");  
s.add(1776);  
  
document.write(s.has(1776));  
document.write(s.has("1776"));  
  
// Output:  
// true  
// false  
  
```  
  
## Requirements  
 [!INCLUDE[jsv11](../../javascript/reference/includes/jsv11-md.md)]