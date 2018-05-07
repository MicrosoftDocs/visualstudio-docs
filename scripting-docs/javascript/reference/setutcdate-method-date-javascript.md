---
title: "setUTCDate Method (Date) (JavaScript) | Microsoft Docs"
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
  - "setUTCDate"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "dates, UTC"
  - "dates, setting"
  - "UTC dates, setting"
  - "setUTCDate method"
ms.assetid: e6c3b876-70fe-4103-b197-6c84c078ce10
caps.latest.revision: 14
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# setUTCDate Method (Date) (JavaScript)
Sets the numeric day of the month in the `Date` object using Universal Coordinated Time (UTC).  
  
## Syntax  
  
```  
  
dateObj.setUTCDate(numDate)   
```  
  
## Parameters  
 `dateObj`  
 Required. Any `Date` object.  
  
 *numDate*  
 Required. A numeric value equal to the day of the month.  
  
## Remarks  
 To set the day of the month using local time, use the `setDate` method.  
  
 If the value of *numDate* is greater than the number of days in the month stored in the **Date** object or is a negative number, the date is set to a date equal to *numDate* minus the number of days in the stored month. For example, if the stored date is January 5, 1996, and **setUTCDate(32)** is called, the date changes to February 1, 1996. Negative numbers have a similar behavior.  
  
 The **setUTCFullYear** method can be used to set the year, month, and day of the month.  
  
## Example  
 The following example illustrates the use of the `setUTCDate` method.  
  
```JavaScript  
function SetUTCDateDemo(newdayofmonth){  
   var d = new Date();           // Create Date object.  
   d.setUTCDate(newdayofmonth);  // Set UTC day of month.  
   var s = "Current setting is ";  
   s += d.toUTCString();   
   return(s);                    // Return new setting.  
}  
```  
  
## Requirements  
 [!INCLUDE[jsv3](../../javascript/reference/includes/jsv3-md.md)]  
  
 **Applies To**: [Date Object](../../javascript/reference/date-object-javascript.md)  
  
## See Also  
 [getDate Method (Date)](../../javascript/reference/getdate-method-date-javascript.md)   
 [getUTCDate Method (Date)](../../javascript/reference/getutcdate-method-date-javascript.md)   
 [setDate Method (Date)](../../javascript/reference/setdate-method-date-javascript.md)