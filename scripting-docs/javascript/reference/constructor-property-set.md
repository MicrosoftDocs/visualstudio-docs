---
title: "constructor Property (Set) | Microsoft Docs"
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
ms.assetid: f350b7eb-8994-40bf-9011-f8b20fcef34f
caps.latest.revision: 3
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# constructor Property (Set)
Specifies the function that creates a set.  
  
## Syntax  
  
```JavaScript  
set.constructor  
```  
  
## Remarks  
 The required `set` is the name of the set.  
  
 The `constructor` property is a member of the prototype of every object that has a prototype. This includes all intrinsic JavaScript objects except the `Global` and `Math` objects. The `constructor` property contains a reference to the function that constructs instances of that particular object.  
  
## Requirements  
 [!INCLUDE[jsv11](../../javascript/reference/includes/jsv11-md.md)]