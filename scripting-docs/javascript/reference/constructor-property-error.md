---
title: "constructor Property (Error) | Microsoft Docs"
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
ms.assetid: 18aea278-2bd5-457b-83a5-d8d8f1226e0c
caps.latest.revision: 2
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# constructor Property (Error)
Specifies the function that creates an Error.  
  
## Syntax  
  
```  
  
error.constructor  
```  
  
## Remarks  
 The required `error` is the name of an error object.  
  
 The `constructor` property is a member of the prototype of every object that has a prototype. The `constructor` property contains a reference to the function that constructs instances of that particular object.  
  
## Example  
 The following example illustrates the use of the constructor property.  
  
```javascript  
var x = new Error("This is an error");  
  
if (x.constructor == Error)  
    document.write("Object is an error.");  
  
// Output:  
// Object is an error.  
  
```  
  
## Requirements  
 [!INCLUDE[jsv2](../../javascript/reference/includes/jsv2-md.md)]