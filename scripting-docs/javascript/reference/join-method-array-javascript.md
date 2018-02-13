---
title: "join Method (Array) (JavaScript) | Microsoft Docs"
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
  - "join"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "Join method"
  - "concatenating strings, join method"
  - "arrays [Visual Studio], joining"
ms.assetid: 20f8fde1-014b-488e-9008-464a86e6b21f
caps.latest.revision: 16
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# join Method (Array) (JavaScript)
Adds all the elements of an array separated by the specified separator string.  
  
## Syntax  
  
```  
  
arrayObj.join([separator])   
```  
  
## Parameters  
 `arrayObj`  
 Required. An `Array` object.  
  
 `separator`  
 Optional. A string used to separate one element of an array from the next in the resulting `String`. If omitted, the array elements are separated with a comma.  
  
## Remarks  
 If any element of the array is **undefined** or `null`, it is treated as an empty string.  
  
## Example  
 The following example illustrates the use of the **join** method.  
  
```JavaScript  
var a, b;  
a = new Array(0,1,2,3,4);  
b = a.join("-");  
document.write(b);  
  
// Output:  
// 0-1-2-3-4  
  
```  
  
## Requirements  
 [!INCLUDE[jsv2](../../javascript/reference/includes/jsv2-md.md)]  
  
## See Also  
 [String Object](../../javascript/reference/string-object-javascript.md)