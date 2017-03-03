---
title: "Array.isArray Function (JavaScript) | Microsoft Docs"
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
helpviewer_keywords: 
  - "isArray function [JavaScript]"
  - "Array.isArray function [JavaScript]"
ms.assetid: 58f7d2e0-d310-4292-b9bc-37a73c585780
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Array.isArray Function (JavaScript)
Determines whether an object is an array.  
  
## Syntax  
  
```  
Array.isArray(object)   
```  
  
#### Parameters  
 `object`  
 Required. The object to test.  
  
## Return Value  
 `true` if `object` is an array; otherwise, `false`. If the `object` argument is not an object, `false` is returned.  
  
## Example  
 The following example illustrates the use of the `Array.isArray` function.  
  
```javascript  
var ar = [];  
var result = Array.isArray(ar);  
// Output: true  
  
var ar = new Array();  
var result = Array.isArray(ar);  
// Output: true  
  
var ar = [1, 2, 3];  
var result = Array.isArray(ar);  
// Output: true  
  
var result = Array.isArray("an array");  
document.write(result);  
// Output: false  
```  
  
## Requirements  
 [!INCLUDE[jsv9](../../javascript/includes/jsv9-md.md)]  
  
## See Also  
 [Array Object](../../javascript/reference/array-object-javascript.md)   
 [Using Arrays](../../javascript/advanced/using-arrays-javascript.md)   
 [typeof Operator](../../javascript/reference/typeof-operator-decrementjavascript.md)