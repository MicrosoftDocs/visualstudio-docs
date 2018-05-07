---
title: "getSeconds Method (Date) (JavaScript) | Microsoft Docs"
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
  - "getSeconds"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "seconds method"
  - "GetSeconds method"
ms.assetid: 97b10674-af0b-4681-a846-38f972196501
caps.latest.revision: 13
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# getSeconds Method (Date) (JavaScript)
Gets the seconds of a `Date` object, using local time.  
  
## Syntax  
  
```  
  
dateObj.getSeconds()   
```  
  
#### Parameters  
 The required `dateObj` reference is a `Date` object.  
  
## Return Value  
 Returns an integer between 0 and 59. Zero is returned when the time is less than one second into the current minute. If a `Date` object was created without specifying the time, by default the seconds value is 0.  
  
## Remarks  
 To get the seconds value using Universal Coordinated Time (UTC), use the `getUTCSeconds` method.  
  
## Example  
 The following example shows how to use the `getSeconds` method.  
  
```JavaScript  
var date = new Date("1/1/2001");  
document.write(date.getSeconds());  
document.write("<br/>");  
  
date.setSeconds(5);  
document.write(date.getSeconds());  
  
// Output:  
// 0  
// 5  
  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
 **Applies To**: [Date Object](../../javascript/reference/date-object-javascript.md)  
  
## See Also  
 [getUTCSeconds Method (Date)](../../javascript/reference/getutcseconds-method-date-javascript.md)   
 [setSeconds Method (Date)](../../javascript/reference/setseconds-method-date-javascript.md)   
 [setUTCSeconds Method (Date)](../../javascript/reference/setutcseconds-method-date-javascript.md)