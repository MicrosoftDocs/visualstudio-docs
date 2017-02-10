---
title: "setUTCSeconds Method (Date) (JavaScript) | Microsoft Docs"
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
  - "setUTCSeconds"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "dates, UTC"
  - "setUTCSeconds method"
  - "UTC times, setting"
  - "seconds method"
ms.assetid: e035e282-b39d-4d1d-8771-c17542fd6493
caps.latest.revision: 13
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# setUTCSeconds Method (Date) (JavaScript)
Sets the seconds value in the `Date` object using Universal Coordinated Time (UTC).  
  
## Syntax  
  
```  
  
dateObj.setUTCSeconds(numSeconds[, numMilli])   
```  
  
## Parameters  
 `dateObj`  
 Required. Any `Date` object.  
  
 *numSeconds*  
 Required. A numeric value equal to the seconds value.  
  
 `numMilli`  
 Optional. A numeric value equal to the milliseconds value.  
  
## Remarks  
 All **set** methods taking optional arguments use the value returned from corresponding **get** methods, if you do not specify an optional argument. For example, if the `numMilli` argument is not specified, [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] uses the value returned from the `getUTCMilliseconds` method.  
  
 To set the seconds value using local time, use the `setSeconds` method.  
  
 If the value of an argument is greater than its range or is a negative number, other stored values are modified accordingly. For example, if the stored date is "Jan 5, 1996 00:00:00.00" and **setSeconds(150)** is called, the date is changed to "Jan 5, 1996 00:02:30.00."  
  
 The **setUTCHours** method can be used to set the hours, minutes, seconds, and milliseconds.  
  
## Example  
 The following example illustrates the use of the `setUTCSeconds` method.  
  
```javascript  
function SetUTCSecondsDemo(nsec){  
// Create Date object.  
    var d = new Date();       
// Set UTC seconds.  
    d.setUTCSeconds(nsec);    
    var s = "Current setting is ";  
    s += d.toUTCString();  
// Return new setting.  
    return(s);                
}  
```  
  
## Requirements  
 [!INCLUDE[jsv3](../../javascript/reference/includes/jsv3-md.md)]  
  
 **Applies To**: [Date Object](../../javascript/reference/date-object-javascript.md)  
  
## See Also  
 [getSeconds Method (Date)](../../javascript/reference/getseconds-method-date-javascript.md)   
 [getUTCSeconds Method (Date)](../../javascript/reference/getutcseconds-method-date-javascript.md)   
 [setSeconds Method (Date)](../../javascript/reference/setseconds-method-date-javascript.md)