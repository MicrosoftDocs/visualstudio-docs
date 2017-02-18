---
title: "Date.parse Function (JavaScript) | Microsoft Docs"
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
  - "parse"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "parse function [JavaScript]"
  - "Date.parse function [JavaScript]"
ms.assetid: ed737e50-6398-4462-8779-2af3c03f8325
caps.latest.revision: 19
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Date.parse Function (JavaScript)
Parses a string containing a date, and returns the number of milliseconds between that date and midnight, January 1, 1970.  
  
## Syntax  
  
```  
Date.parse(dateVal)   
```  
  
## Remarks  
 The required `dateVal` argument is either a string containing a date or a VT_DATE value retrieved from an ActiveX object or other object. For information about date strings that the `Date.parse` function can parse. see [Date and Time Strings](../../javascript/date-and-time-strings-javascript.md).  
  
 The `Date.parse` function returns an integer value representing the number of milliseconds between midnight, January 1, 1970 and the date supplied in `dateVal`.  
  
## Example  
 The following example illustrates the use of the `Date.parse` function.  
  
```javascript  
var dateString = "November 1, 1997 10:15 AM";  
var mSec = Date.parse(dateString);  
document.write(mSec);  
// Output: 878404500000  
```  
  
## Example  
 The following example returns the difference between the date provided and 1/1/1970.  
  
```javascript  
var minMilli = 1000 * 60;  
var hrMilli = minMilli * 60;  
var dyMilli = hrMilli * 24;  
  
var testDate = new Date("June 1, 1990");  
var ms = Date.parse(testDate);  
var days = Math.round(ms / dyMilli);  
  
var dateStr = "";  
dateStr += "There are " + days + " days ";  
dateStr += "between 01/01/1970 and " + testDate;  
document.write(dateStr);  
  
// Output: There are 7456 days between 01/01/1970 and Fri Jun 1 00:00:00 PDT 1990  
  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
## See Also  
 [getDate Method (Date)](../../javascript/reference/getdate-method-date-javascript.md)