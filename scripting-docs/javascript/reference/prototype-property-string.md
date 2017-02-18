---
title: "prototype Property (String) | Microsoft Docs"
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
ms.assetid: 437ce478-9c45-45f7-8952-bd71856cfcd8
caps.latest.revision: 3
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# prototype Property (String)
Returns a reference to the prototype for a class of string.  
  
## Syntax  
  
```  
  
string.prototype  
```  
  
## Remarks  
 The `string` argument is the name of a string.  
  
 Use the `prototype` property to provide a base set of functionality to a class of objects. New instances of an object "inherit" the behavior of the prototype assigned to that object.  
  
 For example, to add a method to the `String` object that returns the value of the last element of the string, declare the function, add it to `String.prototype`, and then use it.  
  
```javascript  
function string_last( ){  
    return this.charAt(this.length - 1);  
}  
String.prototype.last = string_last;  
var myString = new String("every good boy does fine");  
document.write(myString.last());  
  
// Output:  
// e  
```  
  
 All intrinsic [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] objects have a `prototype` property that is read-only. Properties and methods may be added to the prototype, but the object may not be assigned a different prototype. However, user-defined objects may be assigned a new prototype.  
  
 The method and property lists for each intrinsic object in this language reference indicate which ones are part of the object's prototype, and which are not.  
  
## Requirements  
 [!INCLUDE[jsv2](../../javascript/reference/includes/jsv2-md.md)]