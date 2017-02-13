---
title: "Date and Time Strings (JavaScript) | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-javascript"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "JavaScript"
  - "DHTML"
ms.assetid: ba0798c5-3574-4434-89f4-3d90be276001
caps.latest.revision: 47
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Date and Time Strings (JavaScript)
You can use a number of techniques to specify and format JavaScript date and time strings.  
  
## Formatting Dates using Intl.DateTimeFormat  
 Internet Explorer 11 introduces support for the [Intl.DateTimeFormat Object](../javascript/reference/intl-datetimeformat-object-javascript.md), which is part of the [ECMAScript Internationalization API Specification](http://www.ecma-international.org/ecma-402/1.0/). To format dates, you can use this object directly or you can use the updated implementation of [toLocaleDateString Method (Date)](../javascript/reference/tolocaledatestring-method-date-javascript.md) and [toLocaleTimeString Method (Date)](../javascript/reference/tolocaletimestring-method-date-javascript.md). These methods of [Date Object](../javascript/reference/date-object-javascript.md) use `Intl.DateTimeFormat` internally to support new optional parameters for the locale and other formatting options.  
  
 The following example shows how to use `toLocaleDateString` and `toLocaleTimeString` to format dates and times. The first parameter passed to these methods is a locale value, such as "en-us". The second parameter, where present, specifies formatting options, such as the long form for the weekday.  
  
```javascript  
var date = new Date(Date.UTC(2013, 1, 1, 14, 0, 0));  
var options = {  
    weekday: "long", year: "numeric", month: "short",  
    day: "numeric", hour: "2-digit", minute: "2-digit"  
};  
  
document.write(date.toLocaleDateString("en-US"));  
document.write(date.toLocaleTimeString("en-us", options));  
document.write(date.toLocaleDateString("ja-JP"));  
document.write(date.toLocaleTimeString("ja-JP", options));  
  
// Output:  
// ‎2‎/‎1‎/‎2013  
// ‎Friday‎, ‎Feb‎ ‎1‎, ‎2013‎ ‎06‎:‎00‎ ‎AM  
// ‎2013‎年‎2‎月‎1‎日‎  
// ‎2013‎年‎2‎月‎1‎日 ‎金曜日‎ ‎06‎:‎00  
```  
  
 For a complete list of formatting options, see [Intl.DateTimeFormat Object](../javascript/reference/intl-datetimeformat-object-javascript.md).  
  
## Formatting Dates  
 Before Internet Explorer 11, JavaScript did not have specific methods to format dates and times. To provide your own date formatting for previous browser versions, use the [getDay Method (Date)](../javascript/reference/getday-method-date-javascript.md), [getDate Method (Date)](../javascript/reference/getdate-method-date-javascript.md), [getMonth Method (Date)](../javascript/reference/getmonth-method-date-javascript.md), and [getFullYear Method (Date)](../javascript/reference/getfullyear-method-date-javascript.md) methods. (The [getYear Method (Date)](../javascript/reference/getyear-method-date-javascript.md) is obsolete and should not be used.)  
  
```javascript  
var myDate = new Date("February 3, 2001");  
var myDate = new Date("February 3 2001");  
document.write((myDate.getMonth() + 1) + "-" + myDate.getDate() + "-" + myDate.getFullYear());  
document.write("<br/>");  
document.write((myDate.getMonth() + 1) + "/" + myDate.getDate() + "/" + myDate.getFullYear());  
  
//Output:  
// 2-3-2001  
// 2/3/2001  
```  
  
 You can provide your own time formatting by using the [getHours Method (Date)](../javascript/reference/gethours-method-date-javascript.md), [getMinutes Method (Date)](../javascript/reference/getminutes-method-date-javascript.md), [getSeconds Method (Date)](../javascript/reference/getseconds-method-date-javascript.md), and [getMilliseconds Method (Date)](../javascript/reference/getmilliseconds-method-date-javascript.md) methods.  
  
```javascript  
myDate = new Date();  
myDate.setHours(10, 30, 53, 400);  
  
document.write(myDate.getHours() + ":" + myDate.getMinutes() + ":" + myDate.getSeconds() +   
":" + myDate.getMilliseconds());  
  
// Output:   
// 10:30:53:400  
```  
  
## Converting Strings to Dates  
 You can specify strings to construct `Date` objects either with `Date(dateStr)` or with `Date.parse(dateStr)`. JavaScript uses the following rules to parse date strings:  
  
-   It first tries to parse a date string by using the [ISO Date Format](#ISO).  
  
    > [!NOTE]
    >  JavaScript uses a simplified version of the ISO 8601 extended format.  
  
-   If the date string is not in ISO format, JavaScript tries to parse the date by using other [Other Date Formats](#OtherDateFormats).  
  
<a name="ISO"></a>   
## ISO Date Format  
 The ISO format is a simplification of the ISO 8601 extended format. The format is as follows:  
  
 `YYYY-MM-DDTHH:mm:ss.sssZ`  
  
> [!IMPORTANT]
>  ISO Date Format is not supported in Internet Explorer 8 standards mode and Quirks mode.  
  
 The following table describes the parts of this format.  
  
|Symbol|Description|Values|  
|------------|-----------------|------------|  
|`-`, `:`, `.`, `T`|Characters actually in the string. `T` specifies the start of a time.||  
|`YYYY`|Year. An extended year can be used instead of a 4-digit year. For more information, see [Extended Years](../javascript/date-and-time-strings-javascript.md#bkmk_extend) later in this topic.||  
|`MM`|Month|01 to 12|  
|`DD`|Day of the month|01 to 31|  
|`HH`|Hours|00 to 24|  
|`mm`|Minutes|00 to 59|  
|`ss`|Seconds. The seconds and milliseconds are optional if a time is specified.|00 to 59|  
|`sss`|Milliseconds|00 to 999|  
|`Z`|The value in this position can be one of the following. If the value is omitted, UTC time is used.<br /><br /> -   `Z` indicates UTC time.<br />-   `+hh:mm` indicates that the input time is the specified offset after UTC time.<br />-   `-hh:mm` indicates that the input time is the absolute value of the specified offset before UTC time.||  
  
 The string can include the date only, as in the following formats: `YYYY`, `YYYY-MM`, `YYYY-MM-DD`.  
  
 The ISO format does not support time zone names. You can use the `Z` position to specify an offset from UTC time. If you do not include a value in the `Z` position, UTC time is used.  
  
 You can specify midnight by using 00:00, or by using 24:00 on the previous day. The following two strings specify the same time: 2010-05-25T00:00 and 2010-05-24T24:00.  
  
 To return a date in ISO format, you can use the [toISOString Method (Date)](../javascript/reference/toisostring-method-date-javascript.md).  
  
<a name="bkmk_extend"></a>   
### Extended Years  
 An *extended year* has 6 digits instead of 4 digits, and is prefixed with a plus or minus sign. An example of an extended year is `+002010`, which is equivalent to `2010`. You can use an extended year to represent years before the year 0 or after 9999.  
  
 If you use the 6-digit format, a plus or minus sign must be present. When you use the 4-digit format, the sign must be absent. Therefore, `0000` and `+000000` are accepted, but `000000` and `-0001` cause an error. The extended year 0 is considered positive and therefore prefixed with a plus sign.  
  
 The [toISOString Method (Date)](../javascript/reference/toisostring-method-date-javascript.md) always uses the extended year format for years that are before 0 and after 9999.  
  
> [!NOTE]
>  [!INCLUDE[jsv9](../javascript/includes/jsv9-md.md)]  
  
<a name="OtherDateFormats"></a>   
## Other Date Formats  
 If a date string is not in the ISO format, [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] uses the following rules to parse it.  
  
 Short dates  
  
-   The format must follow the month/day/year order, for example "06/08/2010".  
  
-   Either "/" or "-" can be used as a separator.  
  
 Long dates  
  
-   The year, month, and day can be in any order. "June 8 2010" and "2010 June 8" are both valid.  
  
-   The year can have two or four digits. If the year has only two digits, it must be at least 70.  
  
-   Month and day names must have at least two characters. Two character names that are not unique are resolved to the last matching name. For example, "Ju" specifies July, not June.  
  
-   A day of the week is ignored if it is inconsistent with the rest of the supplied date. For example, "Tuesday November 9 1996" resolves to "Friday November 9 1996" because Friday is the correct day of the week for that date.  
  
 Times  
  
-   Hours, minutes, and seconds are separated by colons. However, some of the parts can be omitted. The following are valid: "10:", "10:11", and "10:11:12".  
  
-   If PM is specified and the specified hour is at least 13, NaN is returned. For example, "23:15 PM" returns NaN.  
  
 General  
  
-   A string that contains an invalid date returns NaN. For example, a string that contains two years or two months returns NaN.  
  
-   [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] supports all standard time zones, and Universal Coordinated Time (UTC) and Greenwich Mean Time (GMT). (The ISO format does not support time zones.)  
  
-   Text enclosed in parentheses is treated as a comment. The parentheses can be nested.  
  
-   Commas and spaces are treated as delimiters. Multiple delimiters are permitted.  
  
## Example  
 The following code displays the results of parsing different date and time strings.  
  
```  
document.writeln((new Date("2010")).toUTCString());   
  
document.writeln((new Date("2010-06")).toUTCString());  
  
document.writeln((new Date("2010-06-09")).toUTCString());  
  
 // Specifies Z, which indicates UTC time.  
document.writeln((new Date("2010-06-09T15:20:00Z")).toUTCString());  
  
 // Specifies -07:00 offset, which is equivalent to Pacific Daylight time.  
document.writeln((new Date("2010-06-09T15:20:00-07:00")).toGMTString());  
  
// Specifies a non-ISO Long date.  
document.writeln((new Date("June 9, 2010")).toUTCString());  
  
// Specifies a non-ISO Long date.  
document.writeln((new Date("2010 June 9")).toUTCString());  
  
// Specifies a non-ISO Short date and time.  
document.writeln((new Date("6/9/2010 3:20 pm")).toUTCString());  
  
// Output:  
// Fri, 1 Jan 2010 00:00:00 UTC  
// Tue, 1 Jun 2010 00:00:00 UTC  
// Wed, 9 Jun 2010 00:00:00 UTC  
// Wed, 9 Jun 2010 15:20:00 UTC  
// Wed, 9 Jun 2010 22:20:00 UTC  
// Wed, 9 Jun 2010 07:00:00 UTC  
// Wed, 9 Jun 2010 07:00:00 UTC  
// Wed, 9 Jun 2010 22:20:00 UTC  
```  
  
 Where local times are specified, the result will vary depending on the time zone.  
  
> [!IMPORTANT]
>  ISO Date Format is not supported in Internet Explorer 8 standards mode and Quirks mode.  
  
## See Also  
 [Date Object](../javascript/reference/date-object-javascript.md)   
 [Date.parse Function](../javascript/reference/date-parse-function-javascript.md)