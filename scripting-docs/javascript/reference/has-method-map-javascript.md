---
title: "has Method (Map) (JavaScript) | Microsoft Docs"
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
ms.assetid: 876df854-2941-4db2-92c6-1b497840b169
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# has Method (Map) (JavaScript)
Returns `true` if the map contains the specified element.  
  
## Syntax  
  
```javascript  
mapObj.has(key)  
```  
  
#### Parameters  
 `mapObj`  
 Required. A `Map` object.  
  
 `key`  
 Required. The key of the element to test.  
  
## Property Value/Return Value  
 `true` if the map contains the specified element.  
  
## Example  
 The following example shows how to add a member to a `Map` and then check whether the map contains it.  
  
```javascript  
var m = new Map();  
m.set(2, "red");  
  
document.write(m.has(2));  
  
// Output:  
// true  
```  
  
## Requirements  
 [!INCLUDE[jsv11](../../javascript/reference/includes/jsv11-md.md)]