---
title: "setUTCMonth Method (Date) (JavaScript) | Microsoft Docs"
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
  - "setUTCMonth"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "dates, UTC"
  - "setUTCMonth method"
  - "Month method"
  - "UTC dates, setting"
ms.assetid: cdac5f64-c4fd-44cc-ba3a-9a8dd3dd3fad
caps.latest.revision: 13
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# setUTCMonth Method (Date) (JavaScript)
Sets the month value in the `Date` object using Universal Coordinated Time (UTC).  
  
## Syntax  
  
```  
  
dateObj.setUTCMonth(numMonth[, dateVal])   
```  
  
## Parameters  
 `dateObj`  
 Required. Any `Date` object.  
  
 `numMonth`  
 Required. A numeric value equal to the month. The value for January is 0, and other month values follow consecutively.  
  
 `dateVal`  
 Optional. A numeric value representing the day of the month. If it is not supplied, the value from a call to the `getUTCDate` method is used.  
  
## Remarks  
 To set the month value using local time, use the `setMonth` method.  
  
 If the value of `numMonth` is greater than 11 (January is month 0), or is a negative number, the stored year is incremented or decremented appropriately. For example, if the stored date is "Jan 5, 1996 00:00:00.00", and **setUTCMonth(14)** is called, the date is changed to "Mar 5, 1997 00:00:00.00."  
  
 The **setUTCFullYear** method can be used to set the year, month, and day of the month.  
  
## Example  
 The following example illustrates the use of the `setUTCMonth` method.  
  
```javascript  
function SetUTCMonthDemo(newmonth){  
   var d, s;                       // Declare variables.  
   d = new Date();                 // Create Date object.  
   d.setUTCMonth(newmonth);        // Set UTC month.  
   s = "Current setting is ";  
   s += d.toUTCString();   
   return(s);                      // Return new setting.  
}  
```  
  
## Requirements  
 [!INCLUDE[jsv3](../../javascript/reference/includes/jsv3-md.md)]  
  
 **Applies To**: [Date Object](../../javascript/reference/date-object-javascript.md)  
  
## See Also  
 [getMonth Method (Date)](../../javascript/reference/getmonth-method-date-javascript.md)   
 [getUTCMonth Method (Date)](../../javascript/reference/getutcmonth-method-date-javascript.md)   
 [setMonth Method (Date)](../../javascript/reference/setmonth-method-date-javascript.md)