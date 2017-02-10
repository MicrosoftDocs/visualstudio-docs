---
title: "values Method (Array) (JavaScript) | Microsoft Docs"
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
ms.assetid: b20699d6-f8b1-4744-8551-9e81c82850dd
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# values Method (Array) (JavaScript)
Returns an iterator that returns the values of the array.  
  
## Syntax  
  
```  
arrayObj.values();  
```  
  
#### Parameters  
 `arrayObj`  
 Required. The array object.  
  
## Remarks  
  
## Example  
 The following example shows how to get the values of an array.  
  
```javascript  
var v = ["a", "b", "c"].values();  
// v.next().value == "a"  
// v.next().value == "b"  
// v.next().value == "c"   
```  
  
## Requirements  
 [!INCLUDE[jsv12](../../javascript/reference/includes/jsv12-md.md)]