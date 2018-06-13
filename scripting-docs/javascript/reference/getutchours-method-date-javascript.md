---
title: "getUTCHours Method (Date) (JavaScript) | Microsoft Docs"
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
  - "getUTCHours"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "hours"
  - "UTC times, returning"
  - "getUTCHours method"
ms.assetid: 7c9825dd-4b3a-4614-8e09-f40df123b630
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# getUTCHours Method (Date) (JavaScript)
Gets the hours value in a `Date` object using Universal Coordinated Time (UTC).  
  
## Syntax  
  
```  
  
dateObj.getUTCHours()   
```  
  
#### Parameters  
 The required `dateObj` reference is a `Date` object.  
  
## Return Value  
 Returns an integer between 0 and 23 indicating the number of hours since midnight. Zero is returned if the time is before 1:00:00 am. If a `Date` object was created without specifying the time, by default the hour is 0 in UTC time. This time may be non-zero in other time zones.  
  
## Remarks  
 To get the number of hours elapsed since midnight using local time, use the `getHours` method.  
  
## Example  
 The following example illustrates the use of the `getUTCHours` method.  
  
```JavaScript  
var date = new Date("1/1/2001");  
document.write(date.getUTCHours());  
document.write("<br/>");  
  
var date2 = new Date("1/1/2001 11:22:33");  
document.write(date2.getUTCHours());  
  
// Output (in the PST time zone):  
// 15 
// 2  
```  
  
## Requirements  
 [!INCLUDE[jsv3](../../javascript/reference/includes/jsv3-md.md)]  
  
 **Applies To**: [Date Object](../../javascript/reference/date-object-javascript.md)  
  
## See Also  
 [getHours Method (Date)](../../javascript/reference/gethours-method-date-javascript.md)   
 [setHours Method (Date)](../../javascript/reference/sethours-method-date-javascript.md)   
 [setUTCHours Method (Date)](../../javascript/reference/setutchours-method-date-javascript.md)
