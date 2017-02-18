---
title: "keys Method (Array) (JavaScript) | Microsoft Docs"
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
ms.assetid: fc5b6a30-642c-4bd7-ad31-a42667af2f3f
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# keys Method (Array) (JavaScript)
Returns an iterator that returns the index values of the array.  
  
## Syntax  
  
```  
arrayObj.keys();  
```  
  
#### Parameters  
 `arrayObj`  
 Required. The array object.  
  
## Remarks  
  
## Example  
 The following example shows how to get the key values of an array.  
  
```javascript  
var k = ["a", "b", "c"].keys();  
// k.next().value == 0  
// k.next().value == 1  
// k.next().value == 2   
```  
  
## Requirements  
 [!INCLUDE[jsv12](../../javascript/reference/includes/jsv12-md.md)]