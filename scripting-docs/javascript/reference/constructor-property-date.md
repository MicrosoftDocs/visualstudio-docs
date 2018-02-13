---
title: "constructor Property (Date) | Microsoft Docs"
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
ms.assetid: 5db153a1-788b-4a61-bfc8-2d2ec38f36ea
caps.latest.revision: 2
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# constructor Property (Date)
Specifies the function that creates a date.  
  
## Syntax  
  
```  
  
date.constructor  
```  
  
## Remarks  
 The required `date` is the name of a date object.  
  
 The `constructor` property is a member of the prototype of every object that has a prototype. The `constructor` property contains a reference to the function that constructs instances of that particular object.  
  
## Example  
 The following example illustrates the use of the constructor property.  
  
```JavaScript  
var x = new Date("Hi");  
  
if (x.constructor == Date)  
    document.write("Object is a date.");  
  
// Output:  
// Object is a date.  
  
```  
  
## Requirements  
 [!INCLUDE[jsv2](../../javascript/reference/includes/jsv2-md.md)]