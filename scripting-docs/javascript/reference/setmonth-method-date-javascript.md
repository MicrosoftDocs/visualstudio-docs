---
title: "setMonth Method (Date) (JavaScript) | Microsoft Docs"
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
  - "setMonth"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "Month method"
  - "setMonth method"
ms.assetid: 4f5be295-d536-46c0-b3a4-ad06457efe82
caps.latest.revision: 15
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# setMonth Method (Date) (JavaScript)
Sets the month value in the `Date` object using local time.  
  
## Syntax  
  
```  
  
dateObj. setMonth(numMonth[, dateVal])   
```  
  
## Parameters  
 `dateObj`  
 Required. Any `Date` object.  
  
 `numMonth`  
 Required. A numeric value equal to the month. The value for January is 0, and other month values follow consecutively.  
  
 `dateVal`  
 Optional. A numeric value representing the day of the month. If this value is not supplied, the value from a call to the `getDate` method is used.  
  
## Remarks  
 To set the month value using Universal Coordinated Time (UTC), use the `setUTCMonth` method.  
  
 If the value of `numMonth` is greater than 11 (January is month 0) or is a negative number, the stored year is modified accordingly. For example, if the stored date is "Jan 5, 1996" and **setMonth(14)** is called, the date is changed to "Mar 5, 1997."  
  
 The **setFullYear** method can be used to set the year, month, and day of the month.  
  
## Example  
 The following example illustrates the use of the `setMonth` method.  
  
```javascript  
date = new Date('1/1/1990');  
date.setMonth(14);  
document.write(date);  
  
// Output: Fri Mar 1 00:00:00 PST 1991  
// Note that the time zone corresponds to the time zone on the local computer.  
  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
 **Applies To**: [Date Object](../../javascript/reference/date-object-javascript.md)  
  
## See Also  
 [getMonth Method (Date)](../../javascript/reference/getmonth-method-date-javascript.md)   
 [getUTCMonth Method (Date)](../../javascript/reference/getutcmonth-method-date-javascript.md)   
 [setUTCMonth Method (Date)](../../javascript/reference/setutcmonth-method-date-javascript.md)