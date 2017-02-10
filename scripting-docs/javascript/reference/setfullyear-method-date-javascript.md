---
title: "setFullYear Method (Date) (JavaScript) | Microsoft Docs"
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
  - "setFullYear"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "Year method"
  - "setFullYear method"
  - "dates, setting"
ms.assetid: 635e4f5a-0210-4c01-8152-b0da4146f6ff
caps.latest.revision: 16
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# setFullYear Method (Date) (JavaScript)
Sets the year of the `Date` object using local time.  
  
## Syntax  
  
```  
  
dateObj.setFullYear(numYear[, numMonth[, numDate]])   
```  
  
## Parameters  
 `dateObj`  
 Required. Any `Date` object.  
  
 `numYear`  
 Required. A numeric value for the year.  
  
 `numMonth`  
 Optional. A zero-based numeric value for the month (0 for January, 11 for December). Must be specified if `numDate` is specified.  
  
 `numDate`  
 Optional. A numeric value equal for the day of the month.  
  
## Remarks  
 All **set** methods taking optional arguments use the value returned from corresponding **get** methods, if you do not specify the optional argument. For example, if the `numMonth` argument is optional, but not specified, [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] uses the value returned from the **getMonth** method.  
  
 In addition, if the value of an argument is greater than its calendar range or is negative, the date rolls forward or backward as appropriate.  
  
 To set the year using Universal Coordinated Time (UTC), use the `setUTCFullYear` method.  
  
 The range of years supported in the date object is approximately 285,616 years before and after 1970.  
  
## Example  
 The following example illustrates the use of the `setFullYear` method:  
  
```javascript  
var date1 = new Date("1/1/2001");  
date1.setFullYear(2007);  
  
var date2 = new Date("1/1/2001");  
date2.setFullYear(2008, 10, 3);   
  
document.write (date1.toLocaleString());  
document.write ("<br />");  
document.write (date2.toLocaleString());  
  
// Output:  
// Monday, January 01, 2007 12:00:00 AM  
// Monday, November 03, 2008 12:00:00 AM  
```  
  
## Requirements  
 [!INCLUDE[jsv3](../../javascript/reference/includes/jsv3-md.md)]  
  
 **Applies To**: [Date Object](../../javascript/reference/date-object-javascript.md)  
  
## See Also  
 [getFullYear Method (Date)](../../javascript/reference/getfullyear-method-date-javascript.md)   
 [getUTCFullYear Method (Date)](../../javascript/reference/getutcfullyear-method-date-javascript.md)   
 [setUTCFullYear Method (Date)](../../javascript/reference/setutcfullyear-method-date-javascript.md)