---
title: "getUTCDay Method (Date) (JavaScript) | Microsoft Docs"
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
  - "getUTCDay"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "Date object"
  - "dates, UTC"
  - "UTC dates, returning"
  - "getUTCDay method"
ms.assetid: 2fceb5b0-6f77-4919-82c3-0877fd55bacb
caps.latest.revision: 14
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# getUTCDay Method (Date) (JavaScript)
Gets the day of the week using Universal Coordinated Time (UTC).  
  
## Syntax  
  
```  
  
dateObj.getUTCDay()   
```  
  
#### Parameters  
 The required `dateObj` reference is a `Date` object.  
  
## Return Value  
 Returns an integer between 0 (Sunday) and 6 (Saturday) that represents the day of the week.  
  
## Remarks  
 To get the day of the week using local time, use the `getDate` method.  
  
## Example  
 The following example shows how to use the `getUTCDay` method.  
  
```javascript  
var date = new Date("2/6/2001");  
var day = date.getUTCDay();  
document.write(day);  
  
// Output: 2  
  
```  
  
## Requirements  
 [!INCLUDE[jsv3](../../javascript/reference/includes/jsv3-md.md)]  
  
 **Applies To**: [Date Object](../../javascript/reference/date-object-javascript.md)  
  
## See Also  
 [getDay Method (Date)](../../javascript/reference/getday-method-date-javascript.md)