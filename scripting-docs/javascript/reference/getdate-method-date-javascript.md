---
title: "getDate Method (Date) (JavaScript) | Microsoft Docs"
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
  - "getDate"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "Date object"
  - "dates, returning day of the month"
  - "getDate method"
ms.assetid: 67e7f07c-dd46-4b42-82d6-e53e4bd33703
caps.latest.revision: 20
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# getDate Method (Date) (JavaScript)
Gets the day-of-the-month, using local time.  
  
## Syntax  
  
```  
  
dateObj.getDate()   
```  
  
#### Parameters  
 The required `dateObj` reference is a `Date` object.  
  
## Return Value  
 An integer between 1 and 31 that represents the day-of-the-month.  
  
## Remarks  
 To get the day-of-the-month using Universal Coordinated Time (UTC), use the `getUTCDate` method.  
  
## Example  
 The following example illustrates the use of the `getDate` method.  
  
```JavaScript  
var date = new Date("Jan 01, 2001");  
var str = "Today's date is: ";  
   str += (date.getMonth() + 1) + "/";  
   str += date.getDate() + "/";  
   str += date.getFullYear();  
document.write(str);  
  
// Output: Today's date is: 1/1/2001  
  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
 **Applies To**: [Date Object](../../javascript/reference/date-object-javascript.md)  
  
## See Also  
 [getUTCDate Method (Date)](../../javascript/reference/getutcdate-method-date-javascript.md)   
 [setDate Method (Date)](../../javascript/reference/setdate-method-date-javascript.md)   
 [setUTCDate Method (Date)](../../javascript/reference/setutcdate-method-date-javascript.md)