---
title: "toISOString Method (Date) (JavaScript) | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-javascript"
ms.tgt_pltfrm: ""
ms.topic: "language-reference"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "toISOString method [JavaScript]"
ms.assetid: 58577d8f-3ae8-4887-8687-26233ea79ff6
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# toISOString Method (Date) (JavaScript)
Returns a date as a string value in ISO format.  
  
## Syntax  
  
```JavaScript  
  
objDate.toISOString()  
```  
  
## Return Value  
 A string representation of the date in International Organization for Standardization (ISO) format.  
  
## Exceptions  
 If `objDate` does not contain a valid date, a `RangeError` exception is thrown.  
  
## Remarks  
 The ISO format is a simplification of the ISO 8601 format. For more information, see [Date and Time Strings](../../javascript/date-and-time-strings-javascript.md).  
  
 The time zone is always UTC, denoted by the suffix Z in the output.  
  
## Example  
 The following example illustrates the use of the `toISOString` method.  
  
```JavaScript  
var dt = new Date("30 July 2010 15:05 UTC");  
document.write(dt.toISOString());  
document.write("<br />");  
document.write(dt.toUTCString());  
  
// Output:  
//  2010-07-30T15:05:00.000Z  
//  Fri, 30 Jul 2010 15:05:00 UTC  
  
```  
  
## Requirements  
 [!INCLUDE[jsv9](../../javascript/includes/jsv9-md.md)]  
  
## See Also  
 [Date Object](../../javascript/reference/date-object-javascript.md)   
 [Date and Time Strings](../../javascript/date-and-time-strings-javascript.md)