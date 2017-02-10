---
title: "getHours Method (Date) (JavaScript) | Microsoft Docs"
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
  - "getHours"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "Date object"
  - "GetHours method"
  - "Hours method"
ms.assetid: c3936496-a213-4d15-b308-d53926ed310c
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# getHours Method (Date) (JavaScript)
Gets the hours in a date, using local time.  
  
## Syntax  
  
```  
  
dateObj.getHours()   
```  
  
#### Parameters  
 The required `dateObj` reference is a `Date` object.  
  
## Return Value  
 An integer between 0 and 23, indicating the number of hours since midnight. Zero is returned if the time is before 1:00:00 am. If a `Date` object was created without specifying the time, by default the hour is 0.  
  
## Remarks  
 To get the hours value using Universal Coordinated Time (UTC), use the `getUTCHours` method.  
  
## Example  
 The following example shows how to use the `getHours` method.  
  
```javascript  
var date = new Date("1/1/2001");  
document.write(date.getHours());  
document.write("<br/>");  
  
date.setTime(50000000);  
document.write(date.getHours());  
  
// Output:  
// 0   
// 5  
  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
 **Applies To**: [Date Object](../../javascript/reference/date-object-javascript.md)  
  
## See Also  
 [getUTCHours Method (Date)](../../javascript/reference/getutchours-method-date-javascript.md)   
 [setHours Method (Date)](../../javascript/reference/sethours-method-date-javascript.md)   
 [setUTCHours Method (Date)](../../javascript/reference/setutchours-method-date-javascript.md)