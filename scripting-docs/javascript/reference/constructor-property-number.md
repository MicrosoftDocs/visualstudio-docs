---
title: "constructor Property (Number) | Microsoft Docs"
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
ms.assetid: a348fe53-1b4a-42f5-964b-53d57342c906
caps.latest.revision: 2
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# constructor Property (Number)
Specifies the function that creates a Number.  
  
## Syntax  
  
```  
  
number.constructor  
```  
  
## Remarks  
 The required `number` is the name of a string.  
  
 The `constructor` property is a member of the prototype of every object that has a prototype. This includes all intrinsic [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] objects except the `Global` and `Math` objects. The `constructor` property contains a reference to the function that constructs instances of that particular object.  
  
## Example  
 The following example illustrates the use of the constructor property.  
  
```JavaScript  
var num = new Number();  
  
if (num.constructor == Number)  
    document.write("Object is a Number.");  
else  
    document.write("Object is not a Number.");  
  
// Output:  
// Object is a Number.  
  
```  
  
## Requirements  
 [!INCLUDE[jsv2](../../javascript/reference/includes/jsv2-md.md)]