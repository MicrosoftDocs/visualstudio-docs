---
title: "Intl.DateTimeFormat Object (JavaScript) | Microsoft Docs"
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
  - "DateTimeFormat"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
ms.assetid: cc555ac2-f31c-4239-a612-b84c08e3a37f
caps.latest.revision: 14
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Intl.DateTimeFormat Object (JavaScript)
Provides locale-specific date and time formatting.  
  
## Syntax  
  
```  
dateTimeFormatObj = new Intl.DateTimeFormat([locales][, options])  
```  
  
#### Parameters  
 `dateTimeFormatObj`  
 Required. The variable name to assign the `DateTimeFormat` object to.  
  
 `locales`  
 Optional. An array of locale strings that contain one or more language or locale tags. If you include more than one locale string, list them in descending order of priority so that the first entry is the preferred locale. If you omit this parameter, the default locale of the JavaScript runtime is used. See the Remarks section for more information.  
  
 `options`  
 Optional. An object that contains one or more properties that specify formatting options for the date and time. See the Remarks section for details.  
  
## Remarks  
 The `locales` parameter must conform to [BCP 47](http://tools.ietf.org/html/rfc5646) language or locale tags such as "en-US" and "zh-CN". The tag may include language, region, country, and variant. For examples of language tags, see [Appendix A](http://tools.ietf.org/html/rfc5646#appendix-A) of BCP 47. For `DateTimeFormat`, you may add the **-u** subtag in the locale string to include one or both of the following Unicode extensions:  
  
-   -nu to specify a numbering system extension: *language*-*region*-u-nu-*numberingsystem*  
  
     where *numberingsystem* may be one of the following: arab, arabext, bali, beng, deva, fullwide, gujr, guru, hanidec, khmr, knda, laoo, latn, limb, mylm, mong, mymr, orya, tamldec, telu, thai, tibt.  
  
-   –ca to specify a calendar: *language*-*region*-u-ca-*calendar*  
  
     where *calendar* may be one of the following: buddhist, chinese, gregory, islamic, islamicc, japanese.  
  
 The `options` parameter may include the following properties:  
  
|Property|Description|Possible values|Default value|  
|--------------|-----------------|---------------------|-------------------|  
|`localeMatcher`|Specifies the locale-matching algorithm to use.|"lookup","best fit"|"best fit"|  
|`formatMatcher`|Specifies the format-matching algorithm to use.|"basic", "best fit"|"best fit"|  
|`hour12`|Specifies whether to use a 12-hour format for hours.|`true` (for 12-hour format), `false` (for 24-hour format)||  
|`timeZone`|Specifies the time zone. At minimum, "UTC" is always supported.|A timezone value such as "UTC".|"UTC"|  
|`weekday`|Specifies formatting of the weekday.|"narrow", "short", "long".|undefined|  
|`era`|Specifies formatting of the era.|"narrow", "short", "long"|undefined|  
|`year`|Specifies formatting of the year.|"2-digit", "numeric"|undefined or "numeric"|  
|`month`|Specifies formatting of the month.|"2-digit", "numeric", "narrow", "short", "long"|undefined or "numeric"|  
|`day`|Specifies formatting of the day.|"2-digit", "numeric"|undefined or "numeric"|  
|`hour`|Specifies formatting of the hour.|"2-digit", "numeric"|undefined|  
|`minute`|Specifies formatting of the minute.|"2-digit", "numeric"|undefined|  
|`second`|Specifies formatting of the second.|"2-digit", "numeric"|undefined|  
|`timeZoneName`|Specifies formatting of the time zone. This property is not currently supported.|"short", "long".|This property is not currently supported.|  
  
 The default values for `weekday`, `era`, `year`, `month`, `day`, `hour`, `minute`, and `second` are `undefined`. If you don't set these properties, "numeric" formatting is used for `year`, `month`, and `day`.  
  
 Each locale must support, at minimum, the following formats:  
  
-   weekday, year, month, day, hour, minute, second  
  
-   weekday, year, month, day  
  
-   year, month, day  
  
-   year, month  
  
-   month, day  
  
-   hour, minute, second  
  
-   hour, minute  
  
## Properties  
 The following table lists the properties of the `DateTimeFormat` object.  
  
|||  
|-|-|  
|Property|Description|  
|[constructor](../../javascript/reference/constructor-property-intl-datetimeformat.md)|Specifies the function that creates a date/time formatter object.|  
|[format](../../javascript/reference/format-property-intl-datetimeformat.md)|Returns a function that formats a locale-specific date by using the date/time formatter settings.|  
|[prototype](../../javascript/reference/prototype-property-intl-datetimeformat.md)|Returns a reference to the prototype for a date/time formatter.|  
  
## Methods  
 The following table lists the methods of the `DateTimeFormat` object.  
  
|||  
|-|-|  
|Method|Description|  
|[resolvedOptions](../../javascript/reference/resolvedoptions-method-intl-datetimeformat.md)|Returns an object that contains the properties and values of the date/time formatter object.|  
  
## Example  
 The following example shows the result of passing a date object to `DateTimeFormat` using different locales.  
  
```JavaScript  
var date = new Date(Date.UTC(2013, 1, 1, 14, 0, 0));  
var options = { weekday: "long", year: "numeric", month: "short",  
    day: "numeric" };  
  
if (console && console.log) {  
    console.log(new Intl.DateTimeFormat("en-US").format(date));  
    // Returns ‎2‎/‎1‎/‎2013  
    console.log(new Intl.DateTimeFormat("ja-JP").format(date));  
    // Returns ‎2013‎年‎2‎月‎1‎日  
    console.log(new Intl.DateTimeFormat("ar-SA", options).format(date));  
    // Returns ‏الجمعة‏, ‏٢٠‏ ‏ربيع الأول‏, ‏١٤٣٤  
    console.log(new Intl.DateTimeFormat("hi-IN", options).format(date));  
    // Returns ‎शुक्रवार‎, ‎01‎ ‎फरवरी‎ ‎2013  
}  
```  
  
## Example  
 The following example creates a `DateTimeFormat` object that specifies the current weekday in long format using the Arabic (Saudi Arabia) locale, the Islamic calendar, and the Latin numbering system.  
  
```JavaScript  
var dtf = new Intl.DateTimeFormat(["ar-SA-u-ca-islamic-nu-latn"], {  
    weekday: "long",  
    year: "numeric",  
    day: "numeric",  
    month: "long"  
});   
  
If (console && console.log) {  
    console.log(dtf.format(new Date()));  
    // Returns ‏الجمعة‏, ‏19‏ ‏رمضان‏, ‏1434  
}  
```  
  
## Requirements  
 [!INCLUDE[jsv11](../../javascript/reference/includes/jsv11-md.md)]  
  
## See Also  
 [toLocaleString (Date)](../../javascript/reference/tolocalestring-date.md)   
 [toLocaleDateString Method (Date)](../../javascript/reference/tolocaledatestring-method-date-javascript.md)   
 [toLocaleTimeString Method (Date)](../../javascript/reference/tolocaletimestring-method-date-javascript.md)   
 [Intl.Collator Object](../../javascript/reference/intl-collator-object-javascript.md)   
 [Intl.NumberFormat Object](../../javascript/reference/intl-numberformat-object-javascript.md)