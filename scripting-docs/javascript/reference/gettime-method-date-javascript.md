---
title: "getTime Method (Date) (JavaScript) | Microsoft Docs"
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
  - "getTime"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "GetTime method"
  - "time method"
ms.assetid: f0da1d4e-337c-497d-9205-093defbc6d3d
caps.latest.revision: 13
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# getTime Method (Date) (JavaScript)
Gets the time value in milliseconds.  
  
## Syntax  
  
```  
  
dateObj.getTime()   
```  
  
#### Parameters  
 The required `dateObj` reference is a `Date` object.  
  
## Return Value  
 Returns the number of milliseconds between midnight, January 1, 1970 and the time value in the `Date` object. The range of dates is approximately 285,616 years from either side of midnight, January 1, 1970. Negative numbers indicate dates prior to 1970.  
  
## Remarks  
 When doing multiple date and time calculations, you may want to define variables equal to the number of milliseconds in a day, hour, or minute. For example:  
  
```JavaScript  
var minute = 1000 * 60;  
var hour = minute * 60;  
var day = hour * 24;  
```  
  
 See [Calculating Dates and Times (JavaScript)](../../javascript/calculating-dates-and-times-javascript.md) for more information about how to use the `getTime` method.  
  
## Example  
 The following example shows how to use the `getTime` method.  
  
```JavaScript  
var minute = 1000 * 60;  
var hour = minute * 60;  
var day = hour * 24;  
  
date = new Date("1/1/2001");  
var time = date.getTime();  
  
document.write(Math.round(time / day) + " days from 1/1/1970 to 1/1/2001");  
  
// Output: 11323 days from 1/1/1970 to 1/1/2001  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
 **Applies To**: [Date Object](../../javascript/reference/date-object-javascript.md)  
  
## See Also  
 [setTime Method (Date)](../../javascript/reference/settime-method-date-javascript.md)