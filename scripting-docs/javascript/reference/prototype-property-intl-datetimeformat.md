---
title: "prototype Property (Intl.DateTimeFormat) | Microsoft Docs"
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
ms.assetid: e1e693ff-1775-407e-b655-18a60d238ded
caps.latest.revision: 2
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# prototype Property (Intl.DateTimeFormat)
Returns a reference to the prototype for a formatter.  
  
## Syntax  
  
```JavaScript  
dateTimeFormat.prototype  
```  
  
## Remarks  
 The `dateTimeFormat` argument is the name of a formatter.  
  
 Use the `prototype` property to provide a base set of functionality to a class of objects. New instances of an object "inherit" the behavior of the prototype assigned to that object.  
  
 For example, to add a method to the `Intl.DateTimeFormat` object that returns the value of the largest element of the set, declare the function, add it to `Intl.DateTimeFormat.prototype`, and then use it.  
  
## Requirements  
 [!INCLUDE[jsv11](../../javascript/reference/includes/jsv11-md.md)]