---
title: "Object.assign Function (Object) (JavaScript) | Microsoft Docs"
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
ms.assetid: 2dd6b312-dcd3-414e-8d53-088c6341c46d
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Object.assign Function (Object) (JavaScript)
Copies the values from one or more source objects to a target object.  
  
## Syntax  
  
```  
Object.assign(target, ...sources );  
```  
  
#### Parameters  
 `target`  
 Required. A object to which enumerable properties are copied.  
  
 `...sources`  
 Required. One or more objects from which enumerable properties are copied.  
  
## Exceptions  
 This function throws a `TypeError` if there is an assignment error, which terminates the copying operation. A `TypeError` will be thrown if a target property is not writable.  
  
## Remarks  
 This function returns the target object. Only *enumerable own* properties are copied from the source object to the target object. You can use this function to merge or clone objects.  
  
 `null` or `undefined` sources are treated like empty objects and contribute nothing to the target object.  
  
## Example  
 The following code example shows how to merge an object using `Object.assign`.  
  
```javascript  
var first = { name: "Bob" };  
var last = { lastName: "Smith" };  
  
var person = Object.assign(first, last);  
console.log(person);  
  
// Output:  
// { name: "Bob", lastName: "Smith" }   
```  
  
## Example  
 The following example shows how to clone an object using `Object.assign`.  
  
```javascript  
var obj = { person: "Bob Smith"};  
var clone = Object.assign({}, obj);  
```  
  
## Requirements  
 [!INCLUDE[jsv12](../../javascript/reference/includes/jsv12-md.md)]