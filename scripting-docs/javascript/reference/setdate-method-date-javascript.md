---
title: "setDate Method (Date) (JavaScript) | Microsoft Docs"
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
  - "setDate"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "setDate method"
  - "dates, setting"
ms.assetid: a84b9b01-a6d0-489f-8a13-e7af9e9630b2
caps.latest.revision: 16
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# setDate Method (Date) (JavaScript)
Sets the numeric day-of-the-month value of the `Date` object using local time.  
  
## Syntax  
  
```  
  
dateObj.setDate(numDate)   
```  
  
## Parameters  
 `dateObj`  
 Required. Any `Date` object.  
  
 `numDate`  
 Required. A numeric value equal to the day of the month.  
  
## Remarks  
 To set the day-of-the-month value using Universal Coordinated Time (UTC), use the `setUTCDate` method.  
  
 If the value of `numDate` is greater than the number of days in the month, the date rolls over to a later month and/or year. For example, if the stored date is January 5, 1996 and `setDate(32)` is called, the date changes to February 1, 1996. If `numDate` is a negative number, the date rolls back to an earlier month and/or year. For example, if the stored date is January 5, 1996 and `setDate(-32)` is called, the date changes to November 29, 1995.  
  
 The [setFullYear Method (Date)](../../javascript/reference/setfullyear-method-date-javascript.md) can be used to set the year, month, and day of the month.  
  
## Example  
 The following example shows how to use the `setDate` method.  
  
```JavaScript  
var date = new Date("12/15/1990");  
date.setDate(30);  
document.write(date);  
  
// Output (for the PST time zone): Sun Dec 30 00:00:00 PST 1990  
  
```  
  
## Requirements  
 [!INCLUDE[jsv3](../../javascript/reference/includes/jsv3-md.md)]  
  
 **Applies To**: [Date Object](../../javascript/reference/date-object-javascript.md)  
  
## See Also  
 [getDate Method (Date)](../../javascript/reference/getdate-method-date-javascript.md)   
 [setFullYear Method (Date)](../../javascript/reference/setfullyear-method-date-javascript.md)   
 [setMonth Method (Date)](../../javascript/reference/setmonth-method-date-javascript.md)   
 [setUTCDate Method (Date)](../../javascript/reference/setutcdate-method-date-javascript.md)