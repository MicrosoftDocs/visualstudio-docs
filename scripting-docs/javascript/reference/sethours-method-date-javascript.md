---
title: "setHours Method (Date) (JavaScript) | Microsoft Docs"
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
  - "setHours"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "hours"
  - "setHours method"
  - "dates, setting"
ms.assetid: 460f742d-f8d2-4874-9d07-2fb969fef066
caps.latest.revision: 12
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# setHours Method (Date) (JavaScript)
Sets the hour value in the `Date` object using local time.  
  
## Syntax  
  
```  
  
dateObj.setHours(numHours[, numMin[, numSec[, numMilli]]])   
```  
  
## Parameters  
 `dateObj`  
 Required. Any `Date` object.  
  
 `numHours`  
 Required. A numeric value equal to the hours value.  
  
 `numMin`  
 Optional. A numeric value equal to the minutes value. Must be supplied if either of the following arguments is used.  
  
 `numSec`  
 Optional. A numeric value equal to the seconds value. Must be supplied if the following argument is used.  
  
 `numMilli`  
 Optional. A numeric value equal to the milliseconds value.  
  
## Remarks  
 All **set** methods taking optional arguments use the value returned from corresponding **get** methods, if you do not specify an optional argument. For example, if the `numMinutes` argument is not specified, [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] uses the value returned from the `getMinutes` method.  
  
 To set the hours value using Universal Coordinated Time (UTC), use the `setUTCHours` method.  
  
 If the value of an argument is greater than its range or is a negative number, other stored values are modified accordingly. For example, if the stored date is "Jan 5, 1996 00:00:00", and **setHours(30)** is called, the date is changed to "Jan 6, 1996 06:00:00." Negative numbers have a similar behavior.  
  
## Example  
 The following example illustrates the use of the `setHours` method.  
  
```JavaScript  
function SetHoursDemo(nhr, nmin, nsec){  
   var d, s;                     //Declare variables.  
   d = new Date();               //Create Date object.  
   d.setHours(nhr, nmin, nsec);  //Set hours, minutes, & seconds.  
   s = "Current setting is " + d.toLocaleString()   
   return(s);                    //Return new date setting.  
}  
```  
  
## Requirements  
 [!INCLUDE[jsv3](../../javascript/reference/includes/jsv3-md.md)]  
  
 **Applies To**: [Date Object](../../javascript/reference/date-object-javascript.md)  
  
## See Also  
 [getHours Method (Date)](../../javascript/reference/gethours-method-date-javascript.md)   
 [getUTCHours Method (Date)](../../javascript/reference/getutchours-method-date-javascript.md)   
 [setUTCHours Method (Date)](../../javascript/reference/setutchours-method-date-javascript.md)