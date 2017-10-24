---
title: "Object.is Function (JavaScript) | Microsoft Docs"
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
ms.assetid: 6e2f6c6d-7cd2-47c4-a513-3ba53988d27d
caps.latest.revision: 2
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Object.is Function (JavaScript)
Returns a value that indicates whether two values are the same value.  
  
## Syntax  
  
```JavaScript  
Object.is(value1, value2)  
```  
  
#### Parameters  
 `value1`  
 Required. The first value to test.  
  
 `value2`  
 Required. The second value to test.  
  
## Return Value  
 `true` if the value is the same value; otherwise, `false`.  
  
## Remarks  
 Unlike the == operator, `Object.is` does not coerce any types when testing values.  
  
 The comparison applied by `Object.is` is similar to the comparison applied by the === operator, except that `Object.is` treats `Number.isNaN` as the same value as `NaN`. It also treats +0 and -0 as different values.  
  
## Requirements  
 [!INCLUDE[jsv12](../../javascript/reference/includes/jsv12-md.md)]