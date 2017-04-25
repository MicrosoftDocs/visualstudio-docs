---
title: "Date.now Function (JavaScript) | Microsoft Docs"
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
  - "now method"
ms.assetid: 41beda89-1a40-4fb1-88b0-38c090af739b
caps.latest.revision: 14
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Date.now Function (JavaScript)
Gets the current date and time.  
  
## Syntax  
  
```  
  
Date.now()  
```  
  
## Return Value  
 The number of milliseconds between midnight, January 1, 1970, and the current date and time.  
  
## Remarks  
 The [getTime method](../../javascript/reference/gettime-method-date-javascript.md) returns the number of milliseconds between January 1, 1970, and a specified date.  
  
 For information about how to calculate elapsed time and compare dates, see [Calculating Dates and Times (JavaScript)](../../javascript/calculating-dates-and-times-javascript.md).  
  
## Example  
 The following example illustrates the use of the `now` method.  
  
```JavaScript  
var start = Date.now();  
var response = prompt("What is your name?", "");  
var end = Date.now();  
var elapsed = (end - start) / 1000;  
document.write("You took " + elapsed + " seconds" + " to type: " + response);  
  
// Output:  
// You took <seconds> seconds to type: <name>  
```  
  
## Requirements  
 Not supported in installed versions earlier than Internet Explorer 9. However, it is supported in the following document modes: Quirks, Internet Explorer 6 standards, Internet Explorer 7 standards, Internet Explorer 8 standards, Internet Explorer 9 standards, Internet Explorer 10 standards. Also supported in [!INCLUDE[win8_appname_long](../../javascript/includes/win8-appname-long-md.md)] apps.  
  
## See Also  
 [getTime Method (Date)](../../javascript/reference/gettime-method-date-javascript.md)   
 [Date Object](../../javascript/reference/date-object-javascript.md)   
 [Calculating Dates and Times (JavaScript)](../../javascript/calculating-dates-and-times-javascript.md)   
 [JavaScript Methods](../../javascript/reference/javascript-methods.md)