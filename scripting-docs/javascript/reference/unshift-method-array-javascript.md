---
title: "unshift Method (Array) (JavaScript) | Microsoft Docs"
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
  - "unshift"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "unshift method"
ms.assetid: 8c6a39ed-bab3-4ca4-9350-571a9427ec94
caps.latest.revision: 14
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# unshift Method (Array) (JavaScript)
Inserts new elements at the start of an array.  
  
## Syntax  
  
```  
  
arrayObj.unshift([item1[, item2 [, . . . [, itemN]]]])  
```  
  
## Parameters  
 `arrayObj`  
 Required. An `Array` object.  
  
 `item1, item2,. . ., itemN`  
 Optional. Elements to insert at the start of the `Array`.  
  
## Remarks  
 The `unshift` method inserts elements into the start of an array, so they appear in the same order in which they appear in the argument list.  
  
## Example  
 The following example illustrates the use of the `unshift` method.  
  
```JavaScript  
var ar = new Array();  
ar.unshift(10, 11);  
ar.unshift(12, 13, 14);  
document.write(ar.toString());  
  
// Output: 12,13,14,10,11  
```  
  
## Requirements  
 [!INCLUDE[jsv55](../../javascript/reference/includes/jsv55-md.md)]  
  
## See Also  
 [shift Method (Array)](../../javascript/reference/shift-method-array-javascript.md)