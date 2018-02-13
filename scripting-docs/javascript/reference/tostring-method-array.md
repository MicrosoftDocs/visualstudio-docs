---
title: "toString Method (Array) | Microsoft Docs"
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
ms.assetid: 71fbea85-3e00-41b0-b167-25e4281e5e8a
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# toString Method (Array)
Returns a string representation of an array.  
  
## Syntax  
  
```  
  
array.toString()  
```  
  
## Parameters  
 `array`  
 Required. The array to represent as a string.  
  
## Return Value  
 The string representation of the array.  
  
## Remarks  
 The elements of an `Array` are converted to strings. The resulting strings are concatenated and separated by commas.  
  
## Example  
 The following example illustrates the use of the **toString** method with an array.  
  
```JavaScript  
var arr = [1, 2, 3, 4];  
var s = arr.toString();  
document.write(s);  
  
// Output: 1,2,3,4  
  
```  
  
## Requirements  
 [!INCLUDE[jsv2](../../javascript/reference/includes/jsv2-md.md)]