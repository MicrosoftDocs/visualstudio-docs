---
title: "reverse Method (JavaScript) | Microsoft Docs"
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
  - "reverse"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "arrays [Visual Studio], reversing elements"
  - "reverse method"
  - "transposing elements"
ms.assetid: 02ab051b-79b8-4646-b502-381671e78c12
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# reverse Method (JavaScript)
Reverses the elements in an `Array`.  
  
## Syntax  
  
```  
  
arrayObj.reverse()   
```  
  
## Parameters  
 `arrayObj`  
 Required. Any `Array` object.  
  
## Return Value  
 The reversed array.  
  
## Remarks  
 The required `arrayObj` reference is an `Array` object.  
  
 The `reverse` method reverses the elements of an `Array` object in place. It does not create a new `Array` object during execution.  
  
 If the array is not contiguous, the `reverse` method creates elements in the array that fill the gaps in the array. Each of these created elements has the value `undefined`.  
  
## Example  
 The following example illustrates the use of the `reverse` method.  
  
```JavaScript  
var arr = new Array(0,1,2,3,4);   
var reverseArr = arr.reverse();  
document.write(reverseArr);  
  
// Output:  
// 4,3,2,1,0  
  
```  
  
## Requirements  
 [!INCLUDE[jsv2](../../javascript/reference/includes/jsv2-md.md)]  
  
## See Also  
 [concat Method (Array)](../../javascript/reference/concat-method-array-javascript.md)