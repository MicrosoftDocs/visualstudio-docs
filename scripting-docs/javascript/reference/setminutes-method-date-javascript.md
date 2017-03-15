---
title: "setMinutes Method (Date) (JavaScript) | Microsoft Docs"
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
  - "setMinutes"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "minutes"
  - "setMinutes method"
ms.assetid: 34c959cd-cd29-4cee-8e04-9061cf6d42f3
caps.latest.revision: 13
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# setMinutes Method (Date) (JavaScript)
Sets the minutes value in the **Date** object using local time.  
  
## Syntax  
  
```  
  
dateObj.setMinutes(numMinutes[, numSeconds[, numMilli]])   
```  
  
## Parameters  
 `dateObj`  
 Required. Any `Date` object.  
  
 `numMinutes`  
 Required. A numeric value equal to the minutes value. Must be supplied if either of the following arguments is used.  
  
 *numSeconds*  
 Optional. A numeric value equal to the seconds value. Must be supplied if the `numMilli` argument is used.  
  
 `numMilli`  
 Optional. A numeric value equal to the milliseconds value.  
  
## Remarks  
 All **set** methods taking optional arguments use the value returned from corresponding **get** methods, if you do not specify an optional argument. For example, if the *numSeconds* argument not specified, [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] uses the value returned from the `getSeconds` method.  
  
 To set the minutes value using Universal Coordinated Time (UTC), use the `setUTCMinutes` method.  
  
 If the value of an argument is greater than its range or is a negative number, other stored values are modified accordingly. For example, if the stored date is "Jan 5, 1996 00:00:00" and **setMinutes(90)** is called, the date is changed to "Jan 5, 1996 01:30:00." Negative numbers have a similar behavior.  
  
## Example  
 The following example illustrates the use of the `setMinutes` method.  
  
```JavaScript  
function SetMinutesDemo(nmin, nsec){  
   var d, s;                     // Declare variables.  
   d = new Date();               // Create Date object.  
   d.setMinutes(nmin, nsec);     // Set minutes.  
   s = "Current setting is " + d.toLocaleString()   
   return(s);                    // Return new setting.  
}  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
 **Applies To**: [Date Object](../../javascript/reference/date-object-javascript.md)  
  
## See Also  
 [getMinutes Method (Date)](../../javascript/reference/getminutes-method-date-javascript.md)   
 [getUTCMinutes Method (Date)](../../javascript/reference/getutcminutes-method-date-javascript.md)   
 [setUTCMinutes Method (Date)](../../javascript/reference/setutcminutes-method-date-javascript.md)