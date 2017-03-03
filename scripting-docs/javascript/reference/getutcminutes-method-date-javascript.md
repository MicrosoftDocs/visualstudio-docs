---
title: "getUTCMinutes Method (Date) (JavaScript) | Microsoft Docs"
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
  - "getUTCMinutes"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "minutes"
  - "UTC times, returning"
  - "getUTCMinutes method"
ms.assetid: b6d92543-b285-4e46-8f47-bba36e53fabd
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# getUTCMinutes Method (Date) (JavaScript)
Gets the minutes of a `Date` object using Universal Coordinated Time (UTC).  
  
## Syntax  
  
```  
  
dateObj.getUTCMinutes()   
```  
  
#### Parameters  
 The required `dateObj` reference is a `Date` object.  
  
## Return Value  
 Returns an integer between 0 and 59. Zero is returned the time is less than one minute after the hour. If a `Date` object was created without specifying the time, by default the UTC minute value is 0. However, in other time zones it may be different.  
  
## Remarks  
 To get the number of minutes stored using local time, use the `getMinutes` method.  
  
## Example  
 The following example illustrates the use of the `getUTCMinutes` method.  
  
```javascript  
var date = new Date("1/1/2001");  
document.write(date.getUTCMinutes());  
document.write("<br/>");  
  
date.setMinutes(5);  
document.write(date.getUTCMinutes());  
  
// Output:   
// 0  
// 5  
  
```  
  
## Requirements  
 [!INCLUDE[jsv3](../../javascript/reference/includes/jsv3-md.md)]  
  
 **Applies To**: [Date Object](../../javascript/reference/date-object-javascript.md)  
  
## See Also  
 [getMinutes Method (Date)](../../javascript/reference/getminutes-method-date-javascript.md)   
 [setMinutes Method (Date)](../../javascript/reference/setminutes-method-date-javascript.md)   
 [setUTCMinutes Method (Date)](../../javascript/reference/setutcminutes-method-date-javascript.md)