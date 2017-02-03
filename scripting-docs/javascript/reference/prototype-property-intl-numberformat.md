---
title: "prototype Property (Intl.NumberFormat) | Microsoft Docs"
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
ms.assetid: 7f6a7e26-108b-4b32-97c2-7f96b9252c50
caps.latest.revision: 2
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# prototype Property (Intl.NumberFormat)
Returns a reference to the prototype for a formatter.  
  
## Syntax  
  
```javascript  
numberFormat.prototype  
```  
  
## Remarks  
 The `numberFormat` argument is the name of a formatter.  
  
 Use the `prototype` property to provide a base set of functionality to a class of objects. New instances of an object "inherit" the behavior of the prototype assigned to that object.  
  
 For example, to add a method to the `Intl.NumberFormat` object that returns the value of the largest element of the set, declare the function, add it to `Intl.NumberFormat.prototype`, and then use it.  
  
## Requirements  
 [!INCLUDE[jsv11](../../javascript/reference/includes/jsv11-md.md)]