---
title: "prototype Property (Map) | Microsoft Docs"
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
ms.assetid: c7b429cb-97b7-400e-a214-1b18bddd6b02
caps.latest.revision: 3
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# prototype Property (Map)
Returns a reference to the prototype for a map.  
  
## Syntax  
  
```JavaScript  
map.prototype  
```  
  
## Remarks  
 The `map` argument is the name of a map.  
  
 Use the `prototype` property to provide a base set of functionality to a class of objects. New instances of an object "inherit" the behavior of the prototype assigned to that object.  
  
 For example, to add a method to the `Map` object that returns the value of the largest element of the set, declare the function, add it to `Map.prototype`, and then use it.  
  
## Requirements  
 [!INCLUDE[jsv11](../../javascript/reference/includes/jsv11-md.md)]