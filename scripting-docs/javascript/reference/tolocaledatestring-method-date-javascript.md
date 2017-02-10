---
title: "toLocaleDateString Method (Date) (JavaScript) | Microsoft Docs"
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
  - "toLocaleDateString"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "toLocaleDateString method"
ms.assetid: 0b83715c-8ced-4bd7-8940-a8007d002d10
caps.latest.revision: 14
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# toLocaleDateString Method (Date) (JavaScript)
Returns a date as a string value that is appropriate to the host environment's current locale or the specified locale.  
  
## Syntax  
  
```  
  
dateObj.toLocaleDateString( [locales][, options])   
```  
  
#### Parameters  
 `dateObj`  
 Required. A `Date` object.  
  
 `locales`  
 Optional. An array of locale strings that contain one or more language or locale tags. If you include more than one locale string, list them in descending order of priority so that the first entry is the preferred locale. If you omit this parameter, the default locale of the JavaScript runtime is used.  
  
 `options`  
 Optional. An object that contains one or more properties that specify comparison options.  
  
## Remarks  
 Starting in Internet Explorer 11, `toLocaleDateString` uses `Intl.DateTimeFormat` internally to format the date, which adds support for the `locales` and `options` parameters. For more information about these parameters, see [Intl.DateTimeFormat](../../javascript/reference/intl-datetimeformat-object-javascript.md).  
  
> [!IMPORTANT]
>  The `locales` and `options` parameters are not supported in all document modes and browser versions. For more information, see the Requirements section.  
  
 When you use `toLocaleDateString` in Internet Explorer 10 standards document mode, earlier document modes, and quirks mode:  
  
-   it returns a string value that contains a date in the current time zone.  
  
-   The returned date is in the default format of the host environment's current locale.  
  
 If you omit the `locales` parameter, the return value of this method cannot be relied upon in scripting, because it will vary from computer to computer. In this scenario, use the method only to format displayed text – never as part of a computation.  
  
## Example  
 The following example shows how to use the `toLocaleDateString` method with a specified locale and comparison options.  
  
```javascript  
var date = new Date(Date.UTC(2013, 1, 1, 14, 0, 0));  
var options = { weekday: "long", year: "numeric", month: "short",  
    day: "numeric" };  
  
// Using I18N toLocaleString  
document.write(date.toLocaleDateString("en-US"));  
document.write(date.toLocaleDateString("ja-JP"));  
document.write(date.toLocaleDateString("ar-SA", options));  
document.write(date.toLocaleDateString("hi-IN", options));  
  
// Output:  
// ‎2‎/‎1‎/‎2013‎   
// ‎2013‎年‎2‎月‎1‎日‎  
// ‏الجمعة‏, ‏٢٠‏ ‏ربيع الأول‏, ‏١٤٣٤  
// ‎शुक्रवार‎, ‎01‎ ‎फरवरी‎ ‎2013  
  
```  
  
## Requirements  
 [!INCLUDE[jsv55](../../javascript/reference/includes/jsv55-md.md)]  
  
 `locales` and `options` parameters:  
  
 [!INCLUDE[jsv11](../../javascript/reference/includes/jsv11-md.md)]  
  
## See Also  
 [toDateString Method (Date)](../../javascript/reference/todatestring-method-date-javascript.md)   
 [toLocaleTimeString Method (Date)](../../javascript/reference/tolocaletimestring-method-date-javascript.md)