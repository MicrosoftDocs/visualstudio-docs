---
title: "setSeconds Method (Date) (JavaScript) | Microsoft Docs"
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
  - "setSeconds"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "setSeconds method"
  - "seconds method"
ms.assetid: 986ffa54-1db6-4af2-ab8b-8353f64f0b57
caps.latest.revision: 15
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# setSeconds Method (Date) (JavaScript)
Sets the seconds value in the `Date` object using local time.  
  
## Syntax  
  
```  
  
dateObj  
.setSeconds(  
numSeconds[, numMilli])   
```  
  
## Parameters  
 `dateObj`  
 Required. Any `Date` object.  
  
 *numSeconds*  
 Required. A numeric value equal to the seconds value.  
  
 `numMilli`  
 Optional. A numeric value equal to the milliseconds value.  
  
## Remarks  
 All **set** methods taking optional arguments use the value returned from corresponding **get** methods, if you do not specify an optional argument. For example, if the `numMilli` argument is not specified, [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] uses the value returned from the **getMilliseconds** method.  
  
 To set the seconds value using Universal Coordinated Time (UTC), use the `setUTCSeconds` method.  
  
 If the value of an argument is greater than its range or is a negative number, other stored values are modified accordingly. For example, if the stored date is "Jan 5, 1996 00:00:00" and **setSeconds(150)** is called, the date is changed to "Jan 5, 1996 00:02:30."  
  
 The `setHours` method can be used to set the hours, minutes, seconds, and milliseconds.  
  
## Example  
 The following example illustrates the use of the `setSeconds` method.  
  
```javascript  
function SetSecondsDemo(nsec){  
   var d = new Date();         //Create Date object.  
   d.setSeconds(nsec);         //Set seconds.  
   var s = "Current setting is ";  
   s += d.toLocaleString();  
   return(s);                  //Return new setting.  
}  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
 **Applies To**: [Date Object](../../javascript/reference/date-object-javascript.md)  
  
## See Also  
 [getSeconds Method (Date)](../../javascript/reference/getseconds-method-date-javascript.md)   
 [getUTCSeconds Method (Date)](../../javascript/reference/getutcseconds-method-date-javascript.md)   
 [setUTCSeconds Method (Date)](../../javascript/reference/setutcseconds-method-date-javascript.md)