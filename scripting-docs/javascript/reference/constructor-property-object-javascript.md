---
title: "constructor Property (Object) (JavaScript) | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-javascript"
ms.tgt_pltfrm: ""
ms.topic: "language-reference"
f1_keywords: 
  - "constructor"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "constructor property"
ms.assetid: 6f5d0e9d-e85f-4fde-b558-744510483d69
caps.latest.revision: 17
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# constructor Property (Object) (JavaScript)
Specifies the function that creates an object.  
  
## Syntax  
  
```  
  
object.constructor  
```  
  
## Remarks  
 The required `object` is the name of an object or function.  
  
 The `constructor` property is a member of the prototype of every object that has a prototype. This includes all intrinsic [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] objects except the `Global` and `Math` objects. The `constructor` property contains a reference to the function that constructs instances of that particular object.  
  
## Example  
 The following example illustrates the use of the constructor property.  
  
```JavaScript  
// A constructor function.  
function MyObj() {  
    this.number = 1;  
}  
  
var x = new String("Hi");  
  
if (x.constructor == String)  
    document.write("Object is a String.");  
document.write ("<br />");  
  
var y = new MyObj;  
if (y.constructor == MyObj)  
    document.write("Object constructor is MyObj.");  
  
// Output:  
// Object is a String.  
// Object constructor is MyObj.  
  
```  
  
## Requirements  
 [!INCLUDE[jsv2](../../javascript/reference/includes/jsv2-md.md)]  
  
## See Also  
 [prototype Property (Object)](../../javascript/reference/prototype-property-object-javascript.md)