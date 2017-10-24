---
title: "getUTCDate Method (Date) (JavaScript) | Microsoft Docs"
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
  - "getUTCDate"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "Date object"
  - "dates, UTC"
  - "UTC dates, returning"
  - "getUTCDate method"
ms.assetid: 9e4c763f-c94c-44c9-9684-cb632d75b62e
caps.latest.revision: 13
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# getUTCDate Method (Date) (JavaScript)
Gets the day-of-the-month, using Universal Coordinated Time (UTC).  
  
## Syntax  
  
```  
  
dateObj.getUTCDate()   
```  
  
#### Parameters  
 The required `dateObj` reference is a `Date` object.  
  
## Return Value  
 Returns an integer between 1 and 31 that represents the day-of-the-month.  
  
## Remarks  
 To get the day of the month using local time, use the `getDate` method.  
  
## Example  
 The following example shows how to use the `getUTCDate` method.  
  
```JavaScript  
var date = new Date("1/23/2001");  
document.write(date.getUTCDate());  
  
// Output: 23  
  
```  
  
## Requirements  
 [!INCLUDE[jsv3](../../javascript/reference/includes/jsv3-md.md)]  
  
 **Applies To**: [Date Object](../../javascript/reference/date-object-javascript.md)  
  
## See Also  
 [getDate Method (Date)](../../javascript/reference/getdate-method-date-javascript.md)   
 [setDate Method (Date)](../../javascript/reference/setdate-method-date-javascript.md)   
 [setUTCDate Method (Date)](../../javascript/reference/setutcdate-method-date-javascript.md)