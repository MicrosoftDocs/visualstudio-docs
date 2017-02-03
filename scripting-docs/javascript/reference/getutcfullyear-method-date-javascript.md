---
title: "getUTCFullYear Method (Date) (JavaScript) | Microsoft Docs"
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
  - "getUTCFullYear"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "getUTCFullYear method"
  - "Date object"
  - "UTCFullYear method"
  - "dates, UTC"
  - "UTC dates, returning"
  - "Full Year method"
  - "UTC dates, getting"
ms.assetid: f11e5363-ef8a-48dd-9d56-4ee7290c7c48
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# getUTCFullYear Method (Date) (JavaScript)
Gets the year using Universal Coordinated Time (UTC).  
  
## Syntax  
  
```  
  
dateObj.getUTCFullYear()   
```  
  
#### Parameters  
 The required `dateObj` reference is a `Date` object.  
  
## Return Value  
 Returns the year as a four-digit number. Years specified as two digits in the `Date` constructor or in `setFullYear` are assumed to be in the twentieth century, so given "5/14/12", `getUTCFullYear` returns "1912".  
  
## Remarks  
 To get the year using local time, use the `getFullYear` method.  
  
## Example  
 The following example shows how to use the `getUTCFullYear` method.  
  
```javascript  
var date = new Date("1/9/36");  
document.write(date.getUTCFullYear());  
  
// Output: 1936  
```  
  
## Requirements  
 [!INCLUDE[jsv3](../../javascript/reference/includes/jsv3-md.md)]  
  
 **Applies To**: [Date Object](../../javascript/reference/date-object-javascript.md)  
  
## See Also  
 [getFullYear Method (Date)](../../javascript/reference/getfullyear-method-date-javascript.md)   
 [setFullYear Method (Date)](../../javascript/reference/setfullyear-method-date-javascript.md)   
 [setUTCFullYear Method (Date)](../../javascript/reference/setutcfullyear-method-date-javascript.md)