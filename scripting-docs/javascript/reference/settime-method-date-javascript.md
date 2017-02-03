---
title: "setTime Method (Date) (JavaScript) | Microsoft Docs"
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
  - "setTime"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "SetTime method"
  - "time method"
ms.assetid: 86584748-7219-495b-bf56-e27f5782778c
caps.latest.revision: 10
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# setTime Method (Date) (JavaScript)
Sets the date and time value in the `Date` object.  
  
## Syntax  
  
```  
  
dateObj.setTime(milliseconds)   
```  
  
## Parameters  
 `dateObj`  
 Required. Any `Date` object.  
  
 *milliseconds*  
 Required. A numeric value representing the number of elapsed milliseconds since midnight, January 1, 1970 GMT.  
  
## Remarks  
 If *milliseconds* is negative, it indicates a date before 1970. The range of available dates is approximately 285,616 years from either side of 1970.  
  
 Setting the date and time with the `setTime` method is independent of the time zone.  
  
## Example  
 The following example illustrates the use of the `setTime` method.  
  
```javascript  
function SetTimeTest(newtime){  
   var d, s;                  //Declare variables.  
   d = new Date();            //Create Date object.  
   d.setTime(newtime);        //Set time.  
   s = "Current setting is ";  
   s += d.toUTCString();  
   return(s);                 //Return new setting.  
}  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
 **Applies To**: [Date Object](../../javascript/reference/date-object-javascript.md)  
  
## See Also  
 [getTime Method (Date)](../../javascript/reference/gettime-method-date-javascript.md)