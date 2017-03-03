---
title: "Date Object (JavaScript) | Microsoft Docs"
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
  - "Date"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "Date object"
  - "dates, determining"
ms.assetid: ce2202bb-7ec9-4f5a-bf48-3a04feff283e
caps.latest.revision: 29
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Date Object (JavaScript)
Enables basic storage and retrieval of dates and times.  
  
## Syntax  
  
```  
  
      dateObj = new Date()  
dateObj = new Date(dateVal)  
dateObj = new Date(year, month, date[, hours[, minutes[, seconds[,ms]]]])   
```  
  
## Parameters  
 `dateObj`  
 Required. The variable name to which the `Date` object is assigned.  
  
 `dateVal`  
 Required. If a numeric value, `dateVal` represents the number of milliseconds in Universal Coordinated Time between the specified date and midnight January 1, 1970. If a string, `dateVal` is parsed according to the rules in [Date and Time Strings](../../javascript/date-and-time-strings-javascript.md). The `dateVal` argument can also be a VT_DATE value as returned from some ActiveX objects.  
  
 `year`  
 Required. The full year, for example, 1976 (and not 76).  
  
 `month`  
 Required. The month as an integer between 0 and 11 (January to December).  
  
 `date`  
 Required. The date as an integer between 1 and 31.  
  
 `hours`  
 Optional. Must be supplied if `minutes` is supplied. An integer from 0 to 23 (midnight to 11pm) that specifies the hour.  
  
 minutes  
 Optional. Must be supplied if `seconds` is supplied. An integer from 0 to 59 that specifies the minutes.  
  
 `seconds`  
 Optional. Must be supplied if `milliseconds` is supplied. An integer from 0 to 59 that specifies the seconds.  
  
 `ms`  
 Optional. An integer from 0 to 999 that specifies the milliseconds.  
  
## Remarks  
 A `Date` object contains a number representing a particular instant in time to within a millisecond. If the value of an argument is greater than its range or is a negative number, other stored values are modified accordingly. For example, if you specify 150 seconds, [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] redefines that number as two minutes and 30 seconds.  
  
 If the number is `NaN`, the object does not represent a specific instant of time. If you pass no parameters to the `Date` object, it is initialized to the current time (UTC). A value must be given to the object before you can use it.  
  
 The range of dates that can be represented in a `Date` object is approximately 285,616 years on either side of January 1, 1970.  
  
 See [Calculating Dates and Times (JavaScript)](../../javascript/calculating-dates-and-times-javascript.md) for more information about how to use the `Date` object and related methods.  
  
## Example  
 The following example illustrates the use of the `Date` object.  
  
```javascript  
var dateString = "Today's date is: ";  
  
var newDate = new Date();  
  
// Get the month, day, and year.  
dateString += (newDate.getMonth() + 1) + "/";  
dateString += newDate.getDate() + "/";  
dateString += newDate.getFullYear();  
  
document.write(dateString);  
  
// Output: Today's date is: <date>  
```  
  
## Requirements  
 The `Date object` was introduced in [!INCLUDE[jsv1text](../../javascript/reference/includes/jsv1text-md.md)]. Some members in the following lists were introduced in later versions. For more information, see [Version Information](../../javascript/reference/javascript-version-information.md) or the documentation for the individual members.  
  
## Properties  
 The following table lists properties of the `Date Object`.  
  
|Property|Description|  
|--------------|-----------------|  
|[constructor Property](../../javascript/reference/constructor-property-date.md)|Specifies the function that creates an object.|  
|[prototype Property](../../javascript/reference/prototype-property-date.md)|Returns a reference to the prototype for a class of objects.|  
  
## Functions  
 The following table lists functions of the `Date Object`.  
  
|Functions|Description|  
|---------------|-----------------|  
|[Date.now Function](../../javascript/reference/date-now-function-javascript.md)|Returns the number of milliseconds between January 1, 1970, and the current date and time.|  
|[Date.parse Function](../../javascript/reference/date-parse-function-javascript.md)|Parses a string containing a date, and returns the number of milliseconds between that date and midnight, January 1, 1970.|  
|[Date.UTC Function](../../javascript/reference/date-utc-function-javascript.md)|Returns the number of milliseconds between midnight, January 1, 1970 Universal Coordinated Time (UTC) (or GMT) and the supplied date.|  
  
<a name="js56jsobjdatemeth"></a>   
## Methods  
 The following table lists methods of the `Date Object`.  
  
|Method|Description|  
|------------|-----------------|  
|[getDate Method](../../javascript/reference/getdate-method-date-javascript.md)|Returns the day-of-the-month value using local time.|  
|[getDay Method](../../javascript/reference/getday-method-date-javascript.md)|Returns the day-of-the-week value using local time.|  
|[getFullYear Method](../../javascript/reference/getfullyear-method-date-javascript.md)|Returns the year value using local time.|  
|[getHours Method](../../javascript/reference/gethours-method-date-javascript.md)|Returns the hours value using local time.|  
|[getMilliseconds Method](../../javascript/reference/getmilliseconds-method-date-javascript.md)|Returns the milliseconds value using local time.|  
|[getMinutes Method](../../javascript/reference/getminutes-method-date-javascript.md)|Returns the minutes value using local time.|  
|[getMonth Method](../../javascript/reference/getmonth-method-date-javascript.md)|Returns the month value using local time.|  
|[getSeconds Method](../../javascript/reference/getseconds-method-date-javascript.md)|Returns seconds value using local time.|  
|[getTime Method](../../javascript/reference/gettime-method-date-javascript.md)|Returns the time value in a `Date` Object as the number of milliseconds since midnight January 1, 1970.|  
|[getTimezoneOffset Method](../../javascript/reference/gettimezoneoffset-method-date-javascript.md)|Returns the difference in minutes between the time on the host computer and Universal Coordinated Time (UTC).|  
|[getUTCDate Method](../../javascript/reference/getutcdate-method-date-javascript.md)|Returns the day-of-the-month value using UTC.|  
|[getUTCDay Method](../../javascript/reference/getutcday-method-date-javascript.md)|Returns the day-of-the-week value using UTC.|  
|[getUTCFullYear Method](../../javascript/reference/getutcfullyear-method-date-javascript.md)|Returns the year value using UTC.|  
|[getUTCHours Method](../../javascript/reference/getutchours-method-date-javascript.md)|Returns the hours value using UTC.|  
|[getUTCMilliseconds Method](../../javascript/reference/getutcmilliseconds-method-date-javascript.md)|Returns the milliseconds value using UTC.|  
|[getUTCMinutes Method](../../javascript/reference/getutcminutes-method-date-javascript.md)|Returns the minutes value using UTC.|  
|[getUTCMonth Method](../../javascript/reference/getutcmonth-method-date-javascript.md)|Returns the month value using UTC.|  
|[getUTCSeconds Method](../../javascript/reference/getutcseconds-method-date-javascript.md)|Returns the seconds value using UTC.|  
|[getVarDate Method](../../javascript/reference/getvardate-method-date-javascript.md)|Returns the VT_DATE value in a `Date` object.|  
|[getYear Method](../../javascript/reference/getyear-method-date-javascript.md)|Returns the year value .|  
|[hasOwnProperty Method](../../javascript/reference/hasownproperty-method-object-javascript.md)|Returns a Boolean value that indicates whether an object has a property with the specified name.|  
|[isPrototypeOf Method](../../javascript/reference/isprototypeof-method-object-javascript.md)|Returns a Boolean value that indicates whether an object exists in another object's prototype chain.|  
|[propertyIsEnumerable Method](../../javascript/reference/propertyisenumerable-method-object-javascript.md)|Returns a Boolean value that indicates whether a specified property is part of an object and whether it is enumerable.|  
|[setDate Method](../../javascript/reference/setdate-method-date-javascript.md)|Sets the numeric day of the month using local time.|  
|[setFullYear Method](../../javascript/reference/setfullyear-method-date-javascript.md)|Sets the year value using local time.|  
|[setHours Method](../../javascript/reference/sethours-method-date-javascript.md)|Sets the hours value using local time.|  
|[setMilliseconds Method](../../javascript/reference/setmilliseconds-method-date-javascript.md)|Sets the milliseconds value using local time.|  
|[setMinutes Method](../../javascript/reference/setminutes-method-date-javascript.md)|Sets the minutes value using local time.|  
|[setMonth Method](../../javascript/reference/setmonth-method-date-javascript.md)|Sets the month value using local time.|  
|[setSeconds Method](../../javascript/reference/setseconds-method-date-javascript.md)|Sets the seconds value using local time.|  
|[setTime Method](../../javascript/reference/settime-method-date-javascript.md)|Sets the date and time value in the `Date` object.|  
|[setUTCDate Method](../../javascript/reference/setutcdate-method-date-javascript.md)|Sets the numeric day of the month using UTC.|  
|[setUTCFullYear Method](../../javascript/reference/setutcfullyear-method-date-javascript.md)|Sets the year value using UTC.|  
|[setUTCHours Method](../../javascript/reference/setutchours-method-date-javascript.md)|Sets the hours value using UTC.|  
|[setUTCMilliseconds Method](../../javascript/reference/setutcmilliseconds-method-date-javascript.md)|Sets the milliseconds value using UTC.|  
|[setUTCMinutes Method](../../javascript/reference/setutcminutes-method-date-javascript.md)|Sets the minutes value using UTC.|  
|[setUTCMonth Method](../../javascript/reference/setutcmonth-method-date-javascript.md)|Sets the month value using UTC.|  
|[setUTCSeconds Method](../../javascript/reference/setutcseconds-method-date-javascript.md)|Sets the seconds value using UTC.|  
|[setYear Method](../../javascript/reference/setyear-method-date-javascript.md)|Sets the year value using local time.|  
|[toDateString Method](../../javascript/reference/todatestring-method-date-javascript.md)|Returns a date as a string value.|  
|[toGMTString Method](../../javascript/reference/togmtstring-method-date-javascript.md)|Returns a date converted to a string using Greenwich Mean Time (GMT).|  
|[toISOString Method](../../javascript/reference/toisostring-method-date-javascript.md)|Returns a date as a string value in ISO format.|  
|[toJSON Method](../../javascript/reference/tojson-method-date-javascript.md)|Used to transform data of an object type before the JSON serialization.|  
|[toLocaleDateString Method](../../javascript/reference/tolocaledatestring-method-date-javascript.md)|Returns a date as a string value appropriate to the host environment's current locale.|  
|[toLocaleString Method](../../javascript/reference/tolocalestring-date.md)|Returns an object converted to a string using the current locale.|  
|[toLocaleTimeString Method](../../javascript/reference/tolocaletimestring-method-date-javascript.md)|Returns a time as a string value appropriate to the host environment's current locale.|  
|[toString Method](../../javascript/reference/tostring-method-date.md)|Returns a string representation of an object.|  
|[toTimeString Method](../../javascript/reference/totimestring-method-date-javascript.md)|Returns a time as a string value.|  
|[toUTCString Method](../../javascript/reference/toutcstring-method-date-javascript.md)|Returns a date converted to a string using UTC.|  
|[valueOf Method](../../javascript/reference/valueof-method-date.md)|Returns the primitive value of the specified object.|  
  
## See Also  
 [Calculating Dates and Times (JavaScript)](../../javascript/calculating-dates-and-times-javascript.md)   
 [Date and Time Strings](../../javascript/date-and-time-strings-javascript.md)