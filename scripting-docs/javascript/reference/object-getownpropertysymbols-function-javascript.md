---
title: "Object.getOwnPropertySymbols Function (JavaScript) | Microsoft Docs"
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
ms.assetid: 68dd69b9-5a33-44c2-ba5f-21a4ae6c0879
caps.latest.revision: 2
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Object.getOwnPropertySymbols Function (JavaScript)
Returns the own symbol properties of an object. The own symbol properties of an object are those that are defined directly on that object, and are not inherited from the object's prototype.  
  
## Syntax  
  
```  
Object.getOwnPropertySymbols(object);  
```  
  
#### Parameters  
 `object`  
 Required. The object that contains the own symbols.  
  
## Return Value  
 An array that contains the own symbols of the object.  
  
## Remarks  
 You need to use `Object.getOwnPropertySymbols` to get the symbol properties of an object. `Object.getOwnPropertyNames` will not return the symbol properties.  
  
## Example  
 The following code example shows how to get the symbol properties of an object.  
  
```JavaScript  
var obj = {};  
var key = Symbol('description');  
  
obj[key] = 'data';  
  
var symbols = Object.getOwnPropertySymbols(obj);  
  
console.log(symbols[0].toString());  
  
// Output:  
// undefined  
// Symbol(description)  
```  
  
## Requirements  
 [!INCLUDE[jsv12](../../javascript/reference/includes/jsv12-md.md)]