---
title: "isPrototypeOf Method (Object) (JavaScript) | Microsoft Docs"
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
  - "isPrototypeOf"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "isPrototypeOf method"
ms.assetid: 9c821319-c208-480f-915e-565ef6e017b6
caps.latest.revision: 12
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# isPrototypeOf Method (Object) (JavaScript)
Determines whether an object exists in another object's prototype chain.  
  
## Syntax  
  
```  
  
prototype.isPrototypeOf(object)  
```  
  
## Parameters  
 `prototype`  
 Required. An object prototype.  
  
 `object`  
 Required. Another object whose prototype chain is to be checked.  
  
## Remarks  
 The `isPrototypeOf` method returns `true` if `object` has `prototype` in its prototype chain. The prototype chain is used to share functionality between instances of the same object type. The `isPrototypeOf` method returns `false` when `object` is not an object or when `prototype` does not appear in the prototype chain of the `object`.  
  
## Example  
 The following example illustrates the use of the `isPrototypeOf` method.  
  
```JavaScript  
function Rectangle() {  
}  
  
var rec = new Rectangle();  
  
document.write(Rectangle.prototype.isPrototypeOf(rec));  
  
// Output: true  
```  
  
## Requirements  
 [!INCLUDE[jsv55](../../javascript/reference/includes/jsv55-md.md)]  
  
## See Also  
 [prototype Property (Object)](../../javascript/reference/prototype-property-object-javascript.md)