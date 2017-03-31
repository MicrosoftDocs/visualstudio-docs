---
title: "toLocaleTimeString Method (Date) (JavaScript) | Microsoft Docs"
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
  - "toLocaleTimeString"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "toLocaleTimeString method"
ms.assetid: 8ad75bf5-864c-4a2a-be90-220e87dce172
caps.latest.revision: 15
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# toLocaleTimeString Method (Date) (JavaScript)
Returns a time as a string value that is appropriate to the host environment's current locale or a specified locale.  
  
## Syntax  
  
```  
  
dateObj.toLocaleTimeString([locales][, options])  
```  
  
#### Parameters  
 `dateObj`  
 Required. A `Date` object.  
  
 `locales`  
 Optional. An array of locale strings that contain one or more language or locale tags. If you include more than one locale string, list them in descending order of priority so that the first entry is the preferred locale. If you omit this parameter, the default locale of the JavaScript runtime is used.  
  
 `options`  
 Optional. An object that contains one or more properties that specify comparison options.  
  
## Remarks  
 Starting in Internet Explorer 11, `toLocaleTimeString` uses `Intl.DateTimeFormat` internally to format the time, which adds support for the `locales` and `options` parameters. For more information about these parameters, see [Intl.DateTimeFormat](../../javascript/reference/intl-datetimeformat-object-javascript.md).  
  
> [!IMPORTANT]
>  The `locales` and `options` parameters are not supported in all document modes and browser versions. For more information, see the Requirements section.  
  
 When you use `toLocaleTimeString` in Internet Explorer 10 standards document mode, earlier document modes, and quirks mode:  
  
-   It returns a string value that contains a time in the current time zone.  
  
-   The returned time is in the default format of the host environment's current locale.  
  
 If you omit the `locales` parameter, the return value of this method cannot be relied upon in scripting, because it will vary from computer to computer. In this scenario, use the method only to format displayed text – never as part of a computation.  
  
## Example  
 The following example shows how to use the `toLocaleTimeString` method with a specified locale and comparison options.  
  
```JavaScript  
var date = new Date(Date.UTC(2013, 1, 1, 14, 0, 0));  
var options = { weekday: "long", year: "numeric", month: "short",  
    day: "numeric" };  
  
// Using I18N toLocaleString  
document.write(date.toLocaleTimeString("en-US"));  
document.write(date.toLocaleTimeString("ja-JP"));  
document.write(date.toLocaleTimeString("ar-SA", options));  
document.write(date.toLocaleTimeString("hi-IN", options));  
  
// Output:  
// ‎‎6‎:‎00‎:‎00‎ ‎AM ‎   
// 6‎:‎00‎:‎00‎  
// ‏الجمعة‏, ‏٢٠‏ ‏ربيع الأول‏, ‏١٤٣٤ ٠٦‎:‎٠٠‎:‎٠٠‎ ‎ص  
// ‎शुक्रवार‎, ‎01‎ ‎फरवरी‎ ‎2013 06:00:00  
  
```  
  
## Requirements  
 [!INCLUDE[jsv55](../../javascript/reference/includes/jsv55-md.md)]  
  
 `locales` and `options` parameters:  
  
 [!INCLUDE[jsv11](../../javascript/reference/includes/jsv11-md.md)]  
  
## See Also  
 [toTimeString Method (Date)](../../javascript/reference/totimestring-method-date-javascript.md)   
 [toLocaleDateString Method (Date)](../../javascript/reference/tolocaledatestring-method-date-javascript.md)