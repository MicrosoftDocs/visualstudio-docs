---
title: "format Property (Intl.DateTimeFormat) | Microsoft Docs"
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
  - "DHTML"
ms.assetid: 487930fe-a948-446f-902d-06bb0d7685d5
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# format Property (Intl.DateTimeFormat)
Returns a function that formats a locale-specific date by using the specified date/time formatter settings.  
  
## Syntax  
  
```  
dateTimeFormatObj.format  
```  
  
#### Parameters  
 `dateTimeFormatObj`  
 Required. The name of the `DateTimeFormat` object to use as a formatter.  
  
## Remarks  
 The function returned by the `format` property takes a single argument, `date`, and returns a string that represents the localized date by using the options specified in the `DateTimeFormat` object. The `date` parameter of the returned function must be a number, date string, or a `Date` object. If `date` is not provided, the function uses [Date.now](../../javascript/reference/date-now-function-javascript.md) as the default input value.  
  
## Example  
 The following example uses a `DateTimeFormat` object to localize the date "Dec 1, 2007" into German and reformat it.  
  
```javascript  
var dtFormat = new Intl.DateTimeFormat(["de"], {  
    year: "numeric",  
    month: "long",  
    day: "2-digit",  
    hour: "numeric"  
});  
  
if (console && console.log) {  
    console.log(dtFormat.format(new Date("Dec 1, 2007")));  
    // Returns 01. Dezember 2007 00:00  
}  
```  
  
## Requirements  
 [!INCLUDE[jsv11](../../javascript/reference/includes/jsv11-md.md)]  
  
## See Also  
 [Intl.DateTimeFormat Object](../../javascript/reference/intl-datetimeformat-object-javascript.md)