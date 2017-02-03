---
title: "setMilliseconds Method (Date) (JavaScript) | Microsoft Docs"
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
  - "setMilliseconds"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "milliseconds"
  - "setMilliseconds method"
ms.assetid: 6c398961-130e-4f60-802f-6c30e1ef4de4
caps.latest.revision: 13
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# setMilliseconds Method (Date) (JavaScript)
Sets the milliseconds value in the `Date` object using local time.  
  
## Syntax  
  
```  
  
dateObj.  
setMilliseconds(  
numMilli  
)   
```  
  
## Parameters  
 `dateObj`  
 Required. Any `Date` object.  
  
 `numMilli`  
 Required. A numeric value equal to the millisecond value.  
  
## Remarks  
 To set the milliseconds value using Universal Coordinated Time (UTC), use the `setUTCMilliseconds` method.  
  
 If the value of `numMilli` is greater than 999 or is a negative number, the stored number of seconds (and minutes, hours, and so forth if necessary) is incremented an appropriate amount.  
  
## Example  
 The following example illustrates the use of the `setMilliseconds` method.  
  
```javascript  
function SetMSecDemo(nmsec){  
   var d, s;                    // Declare variables.  
   d = new Date();              // Create Date object.  
   d.setMilliseconds(nmsec);    // Set milliseconds.  
   s = "Current setting is ";  
   s += d.toLocaleString();  
   s += " and " + d.getMilliseconds();  
   s += " milliseconds";  
   return(s);                   // Return new date setting.  
}  
```  
  
## Requirements  
 [!INCLUDE[jsv3](../../javascript/reference/includes/jsv3-md.md)]  
  
 **Applies To**: [Date Object](../../javascript/reference/date-object-javascript.md)  
  
## See Also  
 [getMilliseconds Method (Date)](../../javascript/reference/getmilliseconds-method-date-javascript.md)   
 [getUTCMilliseconds Method (Date)](../../javascript/reference/getutcmilliseconds-method-date-javascript.md)   
 [setUTCMilliseconds Method (Date)](../../javascript/reference/setutcmilliseconds-method-date-javascript.md)