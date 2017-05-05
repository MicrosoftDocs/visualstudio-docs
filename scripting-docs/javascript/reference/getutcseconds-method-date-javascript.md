---
title: "getUTCSeconds Method (Date) (JavaScript) | Microsoft Docs"
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
  - "getUTCSeconds"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "UTC times, returning"
  - "seconds method"
  - "getUTCSeconds method"
ms.assetid: 2d8ea7dc-79f8-4a9b-b2ab-732db2bcd5fd
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# getUTCSeconds Method (Date) (JavaScript)
Gets the seconds of a `Date` object using Universal Coordinated Time (UTC).  
  
## Syntax  
  
```  
  
dateObj.getUTCSeconds()   
```  
  
#### Parameters  
 The required `dateObj` reference is a `Date` object.  
  
## Return Value  
 Returns an integer between 0 and 59. Zero is returned when the time is less than one second into the current minute. If a `Date` object was created without specifying the time, by default the UTC seconds value is 0.  
  
## Remarks  
 To get the number of seconds in local time, use the `getSeconds` method.  
  
## Example  
 The following example shows how to use the `getUTCSeconds` method.  
  
```JavaScript  
var date = new Date("1/1/2001");  
document.write(date. getUTCSeconds());  
  
// Output: 0  
```  
  
## Requirements  
 [!INCLUDE[jsv3](../../javascript/reference/includes/jsv3-md.md)]  
  
 **Applies To**: [Date Object](../../javascript/reference/date-object-javascript.md)  
  
## See Also  
 [getSeconds Method (Date)](../../javascript/reference/getseconds-method-date-javascript.md)   
 [setSeconds Method (Date)](../../javascript/reference/setseconds-method-date-javascript.md)   
 [setUTCSeconds Method (Date)](../../javascript/reference/setutcseconds-method-date-javascript.md)