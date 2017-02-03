---
title: "fill Method (Array) (JavaScript) | Microsoft Docs"
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
ms.assetid: 11526627-c0bb-4157-a8c4-0a039079b4a1
caps.latest.revision: 3
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# fill Method (Array) (JavaScript)
Populates an array with a specified value.  
  
## Syntax  
  
```  
arrayObj.fill(value [ , start [ , end ] ]);  
```  
  
#### Parameters  
 `arrayObj`  
 Required. The array object.  
  
 `value`  
 Required. The value used to populate the array.  
  
 `start`  
 Optional. The starting index used to populate array values. The default value is 0.  
  
 `end`  
 Optional. The ending index used to populate array values. The default value is the length property of the `this` object.  
  
## Remarks  
 If `start` is negative, `start` is treated as `length`+`start`, where `length` is the length of the array. If `end` is negative, `end` is treated as `length`+`end`.  
  
## Example  
 The following code examples populate an array with values.  
  
```javascript  
[0, 0, 0].fill(7, 1);  
// Array contains [0,7,7]  
  
[0, 0, 0].fill(7);  
// Array contains [7,7,7]  
  
```  
  
## Requirements  
 [!INCLUDE[jsv12](../../javascript/reference/includes/jsv12-md.md)]