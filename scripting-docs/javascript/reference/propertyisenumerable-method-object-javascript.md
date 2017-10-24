---
title: "propertyIsEnumerable Method (Object) (JavaScript) | Microsoft Docs"
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
  - "propertyIsEnumerable"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "propertyIsEnumerable property"
ms.assetid: d90c7c2e-ea23-4710-a957-9aefbbd1f68b
caps.latest.revision: 13
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# propertyIsEnumerable Method (Object) (JavaScript)
Determines whether a specified property is enumerable.  
  
## Syntax  
  
```  
  
object. propertyIsEnumerable(proName)  
```  
  
## Parameters  
 `object`  
 Required. Instance of an object.  
  
 `proName`  
 Required. String value of a property name.  
  
## Remarks  
 The `propertyIsEnumerable` method returns `true` if `proName` exists in `object` and can be enumerated using a `For` loop. The `propertyIsEnumerable` method returns `false` if `object` does not have a property of the specified name or if the specified property is not enumerable. Typically, predefined properties are not enumerable, but user-defined properties are always enumerable.  
  
 The `propertyIsEnumerable` method does not consider objects in the prototype chain.  
  
## Example  
  
```JavaScript  
var a = new Array("apple", "banana", "cactus");  
document.write(a.propertyIsEnumerable(1));  
  
// Output: true  
  
```  
  
## Requirements  
 [!INCLUDE[jsv55](../../javascript/reference/includes/jsv55-md.md)]  
  
## See Also  
 [prototype Property (Object)](../../javascript/reference/prototype-property-object-javascript.md)