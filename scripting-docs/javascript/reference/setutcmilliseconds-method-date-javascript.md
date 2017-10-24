---
title: "setUTCMilliseconds Method (Date) (JavaScript) | Microsoft Docs"
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
  - "setUTCMilliseconds"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "milliseconds"
  - "dates, UTC"
  - "UTC times, setting"
  - "setUTCMilliseconds method"
ms.assetid: ed8e4486-d4b2-4b73-836b-dd1d3bb991a0
caps.latest.revision: 13
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# setUTCMilliseconds Method (Date) (JavaScript)
Sets the milliseconds value in the `Date` object using Universal Coordinated Time (UTC).  
  
## Syntax  
  
```  
  
dateObj.setUTCMilliseconds(numMilli)   
```  
  
## Parameters  
 `dateObj`  
 Required. Any `Date` object.  
  
 `numMilli`  
 Required. A numeric value equal to the millisecond value.  
  
## Remarks  
 To set the milliseconds using local time, use the `setMilliseconds` method.  
  
 If the value of `numMilli` is greater than 999, or is a negative number, the stored number of seconds (and minutes, hours, and so forth, if necessary) is incremented an appropriate amount.  
  
## Example  
 The following example illustrates the use of the `setUTCMilliseconds` method.  
  
```JavaScript  
function SetUTCMSecDemo(nmsec){     
// Create Date object.  
   var d = new Date();             
// Set UTC milliseconds.  
   d.setUTCMilliseconds(nmsec);    
  
   var s = "Current setting is ";  
   s += d.toUTCString();  
   s += " and " + d.getUTCMilliseconds();  
   s += " milliseconds"  
   return(s);  
}  
```  
  
## Requirements  
 [!INCLUDE[jsv3](../../javascript/reference/includes/jsv3-md.md)]  
  
 **Applies To**: [Date Object](../../javascript/reference/date-object-javascript.md)  
  
## See Also  
 [getMilliseconds Method (Date)](../../javascript/reference/getmilliseconds-method-date-javascript.md)   
 [getUTCMilliseconds Method (Date)](../../javascript/reference/getutcmilliseconds-method-date-javascript.md)   
 [setMilliseconds Method (Date)](../../javascript/reference/setmilliseconds-method-date-javascript.md)