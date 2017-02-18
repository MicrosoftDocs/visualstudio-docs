---
title: "getFullYear Method (Date) (JavaScript) | Microsoft Docs"
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
  - "getFullYear"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "dates, returning year"
  - "Date object"
  - "getFullYear method"
ms.assetid: f9ec1262-02e9-4791-90b5-48f33b1dc4bc
caps.latest.revision: 15
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# getFullYear Method (Date) (JavaScript)
Gets the year, using local time.  
  
## Syntax  
  
```  
  
dateObj.getFullYear()   
```  
  
#### Parameters  
 The required `dateObj` reference is a `Date` object.  
  
## Return Value  
 The year as a four-digit number. For example, the year 1976 is returned as 1976. Years specified as two digits in the `Date` constructor or in `setFullYear` are assumed to be in the twentieth century, so given "5/14/12", `getFullYear` returns "1912".  
  
## Remarks  
 To get the year using Universal Coordinated Time (UTC), use the `getUTCFullYear` method.  
  
## Example  
 The following example illustrates the use of the **getFullYear** method.  
  
```javascript  
var date = new Date("1/1/01");  
document.write(date.getFullYear());  
  
// Output: 1901  
  
```  
  
## Requirements  
 [!INCLUDE[jsv3](../../javascript/reference/includes/jsv3-md.md)]  
  
 **Applies To**: [Date Object](../../javascript/reference/date-object-javascript.md)  
  
## See Also  
 [getUTCFullYear Method (Date)](../../javascript/reference/getutcfullyear-method-date-javascript.md)   
 [setFullYear Method (Date)](../../javascript/reference/setfullyear-method-date-javascript.md)   
 [setUTCFullYear Method (Date)](../../javascript/reference/setutcfullyear-method-date-javascript.md)