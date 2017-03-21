---
title: "constructor Property (Array) | Microsoft Docs"
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
ms.assetid: b78d517b-cb56-4866-b30f-ef8121a27843
caps.latest.revision: 2
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# constructor Property (Array)
Specifies the function that creates an array.  
  
## Syntax  
  
```  
  
array.constructor  
```  
  
## Remarks  
 The required `array` is the name of an array.  
  
 The `constructor` property is a member of the prototype of every object that has a prototype. This includes all intrinsic [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] objects except the `Global` and `Math` objects. The `constructor` property contains a reference to the function that constructs instances of that particular object.  
  
## Example  
 The following example illustrates the use of the constructor property.  
  
```JavaScript  
var x = new Array();  
  
if (x.constructor == Array)  
    document.write("Object is an Array.");  
else  
    document.write("Object is not an Array.");  
  
// Output:  
// Object is an Array.  
  
```  
  
## Requirements  
 [!INCLUDE[jsv2](../../javascript/reference/includes/jsv2-md.md)]