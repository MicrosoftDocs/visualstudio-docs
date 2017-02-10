---
title: "delete Method (Set) (JavaScript) | Microsoft Docs"
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
ms.assetid: 052c409e-10c9-49f2-955d-5ad7e31c14f3
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# delete Method (Set) (JavaScript)
Removes the specified element from a set.  
  
## Syntax  
  
```javascript  
setObj.delete(value)  
```  
  
#### Parameters  
 `setObj`  
 Required. A `Set` object.  
  
 `value`  
 Required. The element to remove.  
  
## Property Value/Return Value  
 `true` if the element has been removed.  
  
## Example  
 The following example shows how to add members to a `Set` and then delete one of them.  
  
```javascript  
var s = new Set();  
s.add("Thomas Jefferson");  
s.add(1776);  
s.add("founding father");  
s.delete("founding father");  
  
s.forEach(function (item) {  
    document.write(item.toString() + ", ");  
});  
  
// Output:  
// Thomas Jefferson, 1776,  
```  
  
## Requirements  
 [!INCLUDE[jsv11](../../javascript/reference/includes/jsv11-md.md)]