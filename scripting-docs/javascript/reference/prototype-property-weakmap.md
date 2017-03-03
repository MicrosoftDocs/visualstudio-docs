---
title: "prototype Property (WeakMap) | Microsoft Docs"
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
ms.assetid: d28b8a9b-38c9-443d-9586-7cc74784bd99
caps.latest.revision: 3
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# prototype Property (WeakMap)
Returns a reference to the prototype for a `WeakMap` object.  
  
## Syntax  
  
```javascript  
weakmap.prototype  
```  
  
## Remarks  
 The `weakmap` argument is the name of a `WeakMap` object.  
  
 Use the `prototype` property to provide a base set of functionality to a class of objects. New instances of an object "inherit" the behavior of the prototype assigned to that object.  
  
 For example, to add a method to the `WeakMap` object that returns the value of the largest element of the `WeakMap`, declare the function, add it to `WeakMap.prototype`, and then use it.  
  
## Requirements  
 [!INCLUDE[jsv11](../../javascript/reference/includes/jsv11-md.md)]