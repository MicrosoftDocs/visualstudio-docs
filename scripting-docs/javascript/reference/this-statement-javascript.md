---
title: "this Statement (JavaScript) | Microsoft Docs"
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
  - "this_JavaScriptKeyword"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "this statement"
  - "constructors, referring to current object"
ms.assetid: 8510a00b-2f14-4700-a276-4d9a523c5112
caps.latest.revision: 12
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# this Statement (JavaScript)
Refers to the current object.  
  
## Syntax  
  
```  
this.property  
```  
  
## Remarks  
 The required `property` argument is one of the current object's properties  
  
 The `this` keyword can be used in object constructors to refer to the current object.  
  
## Example  
 In the following example, **this** refers to the newly created Car object, and assigns values to three properties:  
  
```javascript  
function Car(color, make, model){  
   this.color = color;  
   this.make = make;  
   this.model = model;  
}  
```  
  
 The **this** keyword generally refers to the **window** object if used outside of the scope of any other object. However, inside event handlers `this` refers to the DOM element that raised the event.  
  
 In the following code (for Internet Explorer 9 and later), the event handler prints the string version of a button that has an ID of "clicker".  
  
```javascript  
document.getElementById("clicker").addEventListener("click", eventHandler, false);  
  
        function eventHandler(ev) {  
            document.write(this.toString());  
        }  
  
// Output (when you click the button): [object HTMLButtonElement]  
  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
## See Also  
 [new Operator](../../javascript/reference/new-operator-decrementjavascript.md)   
 [Using the bind method](../../javascript/advanced/using-the-bind-method-javascript.md)