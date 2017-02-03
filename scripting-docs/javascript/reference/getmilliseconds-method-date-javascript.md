---
title: "getMilliseconds Method (Date) (JavaScript) | Microsoft Docs"
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
  - "getMilliseconds"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "milliseconds"
  - "getMilliseconds method"
ms.assetid: 1b512146-1e8a-44a4-89da-6cc5338d15cb
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# getMilliseconds Method (Date) (JavaScript)
Gets the milliseconds of a Date, using local time.  
  
## Syntax  
  
```  
  
dateObj.getMilliseconds()   
```  
  
#### Parameters  
 The required `dateObj` reference is a `Date` object.  
  
## Return Value  
 Returns the milliseconds of a date. The value can range from 0-999. If a date has been constructed without specifying the milliseconds, the value returned is 0.  
  
## Remarks  
 To get the number of milliseconds in Universal Coordinated Time (UTC), use the `getUTCMilliseconds` method.  
  
## Example  
 The following example shows how to use the **getMilliseconds** method.  
  
```javascript  
var date = new Date("1/1/2001");  
document.write(date.getMilliseconds());  
document.write("<br/>");  
  
date.setMilliseconds(5);  
document.write(date.getMilliseconds());  
// Output:   
// 0  
// 5  
  
```  
  
## Requirements  
 [!INCLUDE[jsv3](../../javascript/reference/includes/jsv3-md.md)]  
  
 **Applies To**: [Date Object](../../javascript/reference/date-object-javascript.md)  
  
## See Also  
 [getUTCMilliseconds Method (Date)](../../javascript/reference/getutcmilliseconds-method-date-javascript.md)   
 [setMilliseconds Method (Date)](../../javascript/reference/setmilliseconds-method-date-javascript.md)   
 [setUTCMilliseconds Method (Date)](../../javascript/reference/setutcmilliseconds-method-date-javascript.md)