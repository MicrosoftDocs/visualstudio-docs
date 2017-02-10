---
title: "prototype Property (Boolean) | Microsoft Docs"
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
ms.assetid: e4f07cb5-3462-488c-a418-76064ab10eae
caps.latest.revision: 3
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# prototype Property (Boolean)
Returns a reference to the prototype for a Boolean.  
  
## Syntax  
  
```  
  
boolean.prototype  
```  
  
## Remarks  
 The `boolean` argument is the name of an object.  
  
 The `prototype` property provides a base set of functionality to a class of objects. New instances of an object "inherit" the behavior of the prototype assigned to that object. Properties and methods may be added to the prototype, but builtin objects may not be assigned a different prototype.  
  
 For example, to add a method to the `Boolean` object that returns the value of the largest element of the array, declare the function, add it to `Boolean.prototype`, and then use it.  
  
```javascript  
function isFalse( ){  
    if (this.toString() == "false")  
         return true;  
    else  
        return false;  
}  
Boolean.prototype.isFalse = isFalse;  
var bool = new Boolean(1);  
document.write(bool.isFalse());  
  
// Output:  
// false  
  
```  
  
## Requirements  
 [!INCLUDE[jsv2](../../javascript/reference/includes/jsv2-md.md)]