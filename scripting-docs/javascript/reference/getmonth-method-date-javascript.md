---
title: "getMonth Method (Date) (JavaScript) | Microsoft Docs"
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
  - "getMonth"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "Date object"
  - "dates, month value"
  - "Month method"
  - "GetMonth method"
ms.assetid: c20dd8ba-1d78-42f1-8717-ed3dfd2362dd
caps.latest.revision: 14
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# getMonth Method (Date) (JavaScript)
Gets the month, using local time.  
  
## Syntax  
  
```  
  
dateObj.getMonth()   
```  
  
#### Parameters  
 The required `dateObj` reference is a `Date` object.  
  
## Return Value  
 The `getMonth` method returns an integer between 0 (January) and 11 (December). For a `Date` constructed with "Jan 5, 1996", `getMonth` returns 0.  
  
## Remarks  
 To get the month value using Universal Coordinated Time (UTC), use the `getUTCMonth` method.  
  
## Example  
 The following example shows how to use the `getMonth` method.  
  
```JavaScript  
var date = new Date("1/1/2001");  
document.write(date.getMonth());  
  
// Output: 0  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
 **Applies To**: [Date Object](../../javascript/reference/date-object-javascript.md)  
  
## See Also  
 [getUTCMonth Method (Date)](../../javascript/reference/getutcmonth-method-date-javascript.md)   
 [setMonth Method (Date)](../../javascript/reference/setmonth-method-date-javascript.md)   
 [setUTCMonth Method (Date)](../../javascript/reference/setutcmonth-method-date-javascript.md)