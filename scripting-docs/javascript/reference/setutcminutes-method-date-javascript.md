---
title: "setUTCMinutes Method (Date) (JavaScript) | Microsoft Docs"
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
  - "setUTCMinutes"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "minutes"
  - "dates, UTC"
  - "UTC times, setting"
  - "setUTCMinutes method"
ms.assetid: 2415e788-6d28-46dd-a103-0931a1fd1446
caps.latest.revision: 13
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# setUTCMinutes Method (Date) (JavaScript)
Sets the minutes value in the `Date` object using Universal Coordinated Time (UTC).  
  
## Syntax  
  
```  
  
dateObj.setUTCMinutes(numMinutes[, numSeconds[, numMilli]])   
```  
  
## Parameters  
 `dateObj`  
 Required. Any `Date` object.  
  
 `numMinutes`  
 Required. A numeric value equal to the minutes value. Must be supplied if either of the following arguments is used.  
  
 *numSeconds*  
 Optional. A numeric value equal to the seconds value. Must be supplied if `numMilli` is used.  
  
 `numMilli`  
 Optional. A numeric value equal to the milliseconds value.  
  
## Remarks  
 All **set** methods taking optional arguments use the value returned from corresponding **get** methods, if you do not specify an optional argument. For example, if the *numSeconds* argument is not specified, [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] uses the value returned from the `getUTCSeconds` method.  
  
 To modify the minutes value using local time, use the `setMinutes` method.  
  
 If the value of an argument is greater than its range, or is a negative number, other stored values are modified accordingly. For example, if the stored date is "Jan 5, 1996 00:00:00.00", and **setUTCMinutes(70)** is called, the date is changed to "Jan 5, 1996 01:10:00.00."  
  
 The **setUTCHours** method can be used to set the hours, minutes, seconds, and milliseconds.  
  
## Example  
 The following example illustrates the use of the `setUTCMinutes` method:  
  
```javascript  
function SetUTCMinutesDemo(nmin, nsec){  
   var d, s;                    // Declare variables.  
   d = new Date();              // Create Date object.  
   d.setUTCMinutes(nmin,nsec);  // Set UTC minutes.  
   s = "Current setting is " + d.toUTCString()   
   return(s);                   // Return new setting.  
}  
```  
  
## Requirements  
 [!INCLUDE[jsv3](../../javascript/reference/includes/jsv3-md.md)]  
  
 **Applies To**: [Date Object](../../javascript/reference/date-object-javascript.md)  
  
## See Also  
 [getMinutes Method (Date)](../../javascript/reference/getminutes-method-date-javascript.md)   
 [getUTCMinutes Method (Date)](../../javascript/reference/getutcminutes-method-date-javascript.md)   
 [setMinutes Method (Date)](../../javascript/reference/setminutes-method-date-javascript.md)