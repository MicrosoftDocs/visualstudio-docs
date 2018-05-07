---
title: "splice Method (Array) (JavaScript) | Microsoft Docs"
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
  - "splice"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "splice method"
ms.assetid: 85fdfb13-e3d9-4c89-b524-3ccee7001c93
caps.latest.revision: 9
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# splice Method (Array) (JavaScript)
Removes elements from an array and, if necessary, inserts new elements in their place, returning the deleted elements.  
  
## Syntax  
  
```  
  
arrayObj.splice(start, deleteCount, [item1[, item2[, . . . [,itemN]]]])  
```  
  
## Parameters  
 `arrayObj`  
 Required. An `Array` object.  
  
 `start`  
 Required. The zero-based location in the array from which to start removing elements.  
  
 `deleteCount`  
 Required. The number of elements to remove.  
  
 `item1, item2,. . ., itemN`  
 Optional. Elements to insert into the array in place of the deleted elements.  
  
## Remarks  
 The `splice` method modifies `arrayObj` by removing the specified number of elements from position `start` and inserting new elements. The deleted elements are returned as a new `Array` object.  
  
## Example  
 The following code shows how to use the `splice` method.  
  
```JavaScript  
var arr = new Array("4", "11", "2", "10", "3", "1");  
arr.splice(2, 2, "21", "31");  
document.write(arr);  
  
// Output: 4,11,21,31,3,1  
  
```  
  
## Requirements  
 [!INCLUDE[jsv55](../../javascript/reference/includes/jsv55-md.md)]  
  
## See Also  
 [slice Method (Array)](../../javascript/reference/slice-method-array-javascript.md)