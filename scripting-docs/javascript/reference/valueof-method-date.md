---
title: "valueOf Method (Date) | Microsoft Docs"
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
ms.assetid: 39a1f96e-14b0-4db2-b53d-cdfd67cbb208
caps.latest.revision: 3
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# valueOf Method (Date)
Returns the stored time value in milliseconds since midnight, January 1, 1970 UTC.  
  
## Syntax  
  
```  
  
date.valueOf()  
```  
  
#### Parameters  
 The `date` object is any instance of a Date.  
  
## Return Value  
 The stored time value in milliseconds since midnight, January 1, 1970 UTC. This is the same value as `getTime`.  
  
## Example  
 The following example illustrates the use of the `valueOf` method with a date.  
  
```javascript  
var myDate = new Date();  
myDate.setFullYear(2100, 5, 5);  
if (myDate.getTime() == myDate.valueOf())  
    document.write("values are the same");  
else  
    document.write("values are different");  
  
// Output: values are the same  
  
```  
  
## Requirements  
 [!INCLUDE[jsv2](../../javascript/reference/includes/jsv2-md.md)]