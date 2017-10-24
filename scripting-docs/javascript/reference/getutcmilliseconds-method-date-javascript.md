---
title: "getUTCMilliseconds Method (Date) (JavaScript) | Microsoft Docs"
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
  - "getUTCMilliseconds"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "milliseconds"
  - "UTC times, returning"
  - "getUTCMilliseconds method"
ms.assetid: 7491d387-7b6a-40df-89e5-55c64795ef70
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# getUTCMilliseconds Method (Date) (JavaScript)
Gets the milliseconds of a `Date` object using Universal Coordinated Time (UTC).  
  
## Syntax  
  
```  
  
dateObj.getUTCMilliseconds()   
```  
  
#### Parameters  
 The required `dateObj` reference is a `Date` object.  
  
## Return Value  
 Returns a millisecond value that can range from 0-999.  
  
## Remarks  
 To get the number of milliseconds in local time, use the `getMilliseconds` method.  
  
## Example  
 The following example illustrates the use of the `getUTCMilliseconds` method.  
  
```JavaScript  
var date = new Date("1/1/2001");  
document.write(date.getUTCMilliseconds());  
document.write("<br/>");  
  
date.setMilliseconds(34);  
document.writedate.getUTCMilliseconds());  
  
// Output:  
// 0   
// 34   
```  
  
## Requirements  
 [!INCLUDE[jsv3](../../javascript/reference/includes/jsv3-md.md)]  
  
 **Applies To**: [Date Object](../../javascript/reference/date-object-javascript.md)  
  
## See Also  
 [getMilliseconds Method (Date)](../../javascript/reference/getmilliseconds-method-date-javascript.md)   
 [setMilliseconds Method (Date)](../../javascript/reference/setmilliseconds-method-date-javascript.md)   
 [setUTCMilliseconds Method (Date)](../../javascript/reference/setutcmilliseconds-method-date-javascript.md)