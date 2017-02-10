---
title: "prototype Property (Date) | Microsoft Docs"
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
ms.assetid: 44f9c637-7da7-4833-906d-358506f32ced
caps.latest.revision: 2
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# prototype Property (Date)
Returns a reference to the prototype for a date.  
  
## Syntax  
  
```  
  
date.prototype  
```  
  
## Remarks  
 The `date` argument is the name of an object.  
  
 Use the `prototype` property to provide a base set of functionality to a Date. New instances of an object "inherit" the behavior of the prototype assigned to that object.  
  
 For example, to add a method to the `Date` object that returns the value of the largest element of the array, declare the function, add it to `Date.prototype`, and then use it.  
  
```javascript  
function max( ){  
    var max = new Date();  
    max.setFullYear(2200, 01, 01);  
    return max;  
}  
Date.prototype.maxDate = max;  
var myDate = new Date();  
  
if (myDate < myDate.maxDate())  
    document.write("today isn't the max");  
else if (myDate == myDate.maxDate())  
    document.write("today is the max");   
  
// Output:  
// today isn't the max  
  
```  
  
 All intrinsic [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] objects have a `prototype` property that is read-only. Properties and methods may be added to the prototype, but the object may not be assigned a different prototype. However, user-defined objects may be assigned a new prototype.  
  
## Requirements  
 [!INCLUDE[jsv2](../../javascript/reference/includes/jsv2-md.md)]