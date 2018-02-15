---
title: "getMinutes Method (Date) (JavaScript) | Microsoft Docs"
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
  - "getMinutes"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "GetMinutes method"
  - "minutes method"
ms.assetid: d4139b5d-04e1-474c-9a83-e9d40597243a
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# getMinutes Method (Date) (JavaScript)
Gets the minutes of a `Date` object, using local time.  
  
## Syntax  
  
```  
  
dateObj.getMinutes()   
```  
  
#### Parameters  
 The required `dateObj` reference is a `Date` object.  
  
## Return Value  
 Returns an integer between 0 and 59. Zero is returned the time is less than one minute after the hour. If a `Date` object was created without specifying the time, by default the minute value is 0.  
  
## Remarks  
 To get the minutes value using Universal Coordinated Time (UTC), use the `getUTCMinutes` method.  
  
## Example  
 The following example shows how to the `getMinutes` method.  
  
```JavaScript  
var date = new Date("1/1/2001");  
document.write(date.getMinutes());  
document.write("<br/>");  
  
date.setMinutes(5);  
document.write(date.getMinutes());  
  
// Output:  
// 0  
// 5  
```  
  
## Requirements  
 [!INCLUDE[jsv3](../../javascript/reference/includes/jsv3-md.md)]  
  
 **Applies To**: [Date Object](../../javascript/reference/date-object-javascript.md)  
  
## See Also  
 [getUTCMinutes Method (Date)](../../javascript/reference/getutcminutes-method-date-javascript.md)   
 [setMinutes Method (Date)](../../javascript/reference/setminutes-method-date-javascript.md)   
 [setUTCMinutes Method (Date)](../../javascript/reference/setutcminutes-method-date-javascript.md)