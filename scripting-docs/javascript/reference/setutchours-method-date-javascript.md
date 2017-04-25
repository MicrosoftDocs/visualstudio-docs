---
title: "setUTCHours Method (Date) (JavaScript) | Microsoft Docs"
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
  - "setUTCHours"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "dates, UTC"
  - "UTC times, setting"
  - "setUTCHours method"
ms.assetid: 257e36fd-fb06-4a4d-8634-d66a020a1511
caps.latest.revision: 12
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# setUTCHours Method (Date) (JavaScript)
Sets the hours value in the `Date` object using Universal Coordinated Time (UTC).  
  
## Syntax  
  
```  
  
dateObj.setUTCHours(numHours[, numMin[, numSec[, numMilli]]])   
```  
  
## Parameters  
 `dateObj`  
 Required. Any `Date` object.  
  
 `numHours`  
 Required. A numeric value equal to the hours value.  
  
 `numMin`  
 Optional. A numeric value equal to the minutes value. Must be supplied if either `numSec` or `numMilli` are used.  
  
 `numSec`  
 Optional. A numeric value equal to the seconds value. Must be supplied if `numMilli` argument is used.  
  
 `numMilli`  
 Optional. A numeric value equal to the milliseconds value.  
  
## Remarks  
 All **set** methods taking optional arguments use the value returned from corresponding **get** methods, if you do not specify an optional argument. For example, if the `numMin` argument is not specified, [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] uses the value returned from the `getUTCMinutes` method.  
  
 To set the hours value using local time, use the `setHours` method.  
  
 If the value of an argument is greater than its range, or is a negative number, other stored values are modified accordingly. For example, if the stored date is "Jan 5, 1996 00:00:00.00", and **setUTCHours(30)** is called, the date is changed to "Jan 6, 1996 06:00:00.00."  
  
## Example  
 The following example illustrates the use of the `setUTCHours` method.  
  
```JavaScript  
function SetUTCHoursDemo(nhr, nmin, nsec){     
   var d, s;                        // Declare variables.  
   d = new Date();                  // Create Date object.  
   d.setUTCHours(nhr, nmin, nsec);  // Set UTC hours, minutes, seconds.  
   s = "Current setting is " + d.toUTCString()   
   return(s);                       // Return new setting.  
}  
```  
  
## Requirements  
 [!INCLUDE[jsv3](../../javascript/reference/includes/jsv3-md.md)]  
  
 **Applies To**: [Date Object](../../javascript/reference/date-object-javascript.md)  
  
## See Also  
 [getHours Method (Date)](../../javascript/reference/gethours-method-date-javascript.md)   
 [getUTCHours Method (Date)](../../javascript/reference/getutchours-method-date-javascript.md)   
 [setHours Method (Date)](../../javascript/reference/sethours-method-date-javascript.md)