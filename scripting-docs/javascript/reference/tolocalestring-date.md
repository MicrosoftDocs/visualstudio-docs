---
title: "toLocaleString (Date) | Microsoft Docs"
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
ms.assetid: 3472d7bd-b255-4804-8407-c4a1e419a5a3
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# toLocaleString (Date)
Converts a date to a string by using the current or specified locale.  
  
## Syntax  
  
```  
  
dateObj.toLocaleString([locales][, options])   
```  
  
#### Parameters  
 `dateObj`  
 Required. The `Date` object to convert.  
  
 `locales`  
 Optional. An array of locale strings that contain one or more language or locale tags. If you include more than one locale string, list them in descending order of priority so that the first entry is the preferred locale. If you omit this parameter, the default locale of the JavaScript runtime is used.  
  
 `options`  
 Optional. An object that contains one or more properties that specify comparison options.  
  
## Remarks  
 Starting in Internet Explorer 11, `toLocaleString` uses `Intl.DateTimeFormat` internally to make comparisons, which adds support for the `locales` and `options` parameters. For more information about these parameters, see [Intl.DateTimeFormat](../../javascript/reference/intl-datetimeformat-object-javascript.md).  
  
> [!IMPORTANT]
>  The `locales` and `options` parameters are not supported in all document modes and browser versions. For more information, see the Requirements section.  
  
 When you use `toLocaleString` in Internet Explorer 10 standards document mode, earlier document modes, and quirks mode:  
  
-   It returns a `String` object that contains the date written in the current locale's long default format.  
  
-   For dates between 1601 and 1999 A.D., the date is formatted according to the user's Control Panel regional settings.  
  
> [!NOTE]
>  If you omit the `locales` parameter, use `toLocaleString` only to display results to a user; never use it to compute values within a script, because the returned result is machine-specific.  
  
## Example  
 The following example shows how to use the `toLocaleString` method.  
  
```javascript  
function toLocaleStrDemo(){     
   var d, s;                      //Declare variables.  
   d = new Date();                //Create Date object.  
   s = "Current setting is ";  
   s += d.toLocaleString();       //Convert to current locale.  
   return(s);                     //Return converted date  
}  
```  
  
## Example  
 The following example shows how to use the `toLocaleString` method with a specified locale and comparison options.  
  
```javascript  
var date = new Date(Date.UTC(2013, 1, 1, 14, 0, 0));  
var options = { weekday: "long", year: "numeric", month: "short",  
    day: "numeric" };  
  
// Using I18N toLocaleString  
document.write(date.toLocaleString("en-US"));  
document.write(date.toLocaleString("ja-JP"));  
document.write(date.toLocaleString("ar-SA", options));  
document.write(date.toLocaleString("hi-IN", options));  
  
// Output:  
// ‎2‎/‎1‎/‎2013‎ ‎6‎:‎00‎:‎00‎ ‎AM  
// ‎2013‎年‎2‎月‎1‎日‎ ‎6‎:‎00‎:‎00  
// ‏الجمعة‏, ‏٢٠‏ ‏ربيع الأول‏, ‏١٤٣٤  
// ‎शुक्रवार‎, ‎01‎ ‎फरवरी‎ ‎2013  
  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
 `locales` and `options` parameters:  
  
 [!INCLUDE[jsv11](../../javascript/reference/includes/jsv11-md.md)]  
  
## See Also  
 [toLocaleDateString Method (Date)](../../javascript/reference/tolocaledatestring-method-date-javascript.md)