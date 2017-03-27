---
title: "setUTCFullYear Method (Date) (JavaScript) | Microsoft Docs"
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
  - "setUTCFullYear"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "dates, UTC"
  - "setUTCFullYear method"
  - "UTC dates, setting"
ms.assetid: e6c51b49-0149-4f9a-aa74-c73c0306f98e
caps.latest.revision: 13
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# setUTCFullYear Method (Date) (JavaScript)
Sets the year value in the `Date` object using Universal Coordinated Time (UTC).  
  
## Syntax  
  
```  
  
dateObj.setUTCFullYear(numYear[, numMonth[, numDate]])   
```  
  
## Parameters  
 `dateObj`  
 Required. Any `Date` object.  
  
 `numYear`  
 Required. A numeric value equal to the year.  
  
 `numMonth`  
 Optional. A numeric value equal to the month. The value for January is 0, and other month values follow consecutively. Must be supplied if *numDate* is supplied.  
  
 *numDate*  
 Optional. A numeric value equal to the day of the month.  
  
## Remarks  
 All **set** methods taking optional arguments use the value returned from corresponding **get** methods, if you do not specify an optional argument. For example, if the `numMonth` argument is not specified, [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] uses the value returned from the `getUTCMonth` method.  
  
 In addition, if the value of an argument is greater that its range or is a negative number, other stored values are modified accordingly.  
  
 To set the year using local time, use the `setFullYear` method.  
  
 The range of years supported in the `Date` object is approximately 285,616 years from either side of 1970.  
  
## Example  
 The following example illustrates the use of the `setUTCFullYear` method.  
  
```JavaScript  
var dtFirst = new Date();  
dtFirst.setUTCFullYear(2007);  
  
var dtSecond = new Date();  
// 10 is the value for November.   
dtSecond.setUTCFullYear(2008, 10, 3);   
  
document.write (dtFirst.toUTCString());  
document.write ("<br />");  
document.write (dtSecond.toUTCString());  
```  
  
## Requirements  
 [!INCLUDE[jsv3](../../javascript/reference/includes/jsv3-md.md)]  
  
 **Applies To**: [Date Object](../../javascript/reference/date-object-javascript.md)  
  
## See Also  
 [getFullYear Method (Date)](../../javascript/reference/getfullyear-method-date-javascript.md)   
 [getUTCFullYear Method (Date)](../../javascript/reference/getutcfullyear-method-date-javascript.md)   
 [setFullYear Method (Date)](../../javascript/reference/setfullyear-method-date-javascript.md)