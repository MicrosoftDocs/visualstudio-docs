---
title: "Calculating Dates and Times (JavaScript) | Microsoft Docs"
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
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "date and time arithmetic [JavaScript]"
  - "JavaScript, date and time"
  - "date comparison [JavaScript]"
  - "date and time calculations [JavaScript]"
ms.assetid: ea976f78-d934-479b-9056-880390d8bddd
caps.latest.revision: 34
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Calculating Dates and Times (JavaScript)
You can use the [Date object](../javascript/reference/date-object-javascript.md) to perform common calendar and clock tasks, such as comparing dates and calculating elapsed time.  
  
## Setting a Date to the Current Date  
 When you create an instance of the [Date object](../javascript/reference/date-object-javascript.md) without specifying a date, it returns a value that represents the current date and time, including year, month, day, hour, minute, second, and millisecond. You can then read or modify this date and time.  
  
 The following example shows how to instantiate a date without using any parameters and display it in the format *mm-dd-yy*.  
  
```JavaScript  
var dt = new Date();  
  
// Display the month, day, and year. getMonth() returns a 0-based number.  
var month = dt.getMonth()+1;  
var day = dt.getDate();  
var year = dt.getFullYear();  
document.write(month + '-' + day + '-' + year);  
  
// Output: current month, day, year  
```  
  
## Setting a Specific Date  
 You can set a specific date by passing a date string to the constructor.  
  
```JavaScript  
var dt = new Date('8/24/2009');  
document.write(dt);  
  
// Output: Mon Aug 24 00:00:00 PDT 2009  
  
```  
  
> [!IMPORTANT]
>  The time zone displayed in the date string corresponds to the time zone set on the local machine.  
>   
>  [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] is flexible about the format of the string you use as the parameter. For example, you can input "8-24-2009", "August 24, 2009", or "24 Aug 2009".  
  
 You can also specify a time. The following example shows one way to specify a date and time in ISO format. The "Z" indicates UTC time.  
  
```JavaScript  
var dt = new Date('2010-06-09T15:20:00Z');  
document.write(dt);  
document.write("<br />");  
document.write(dt.toISOString());  
  
// Output:  
// Wed Jun 09 2010 08:20:00 GMT-0700 (Pacific Daylight Time)  
// 2010-06-09T15:20:00.000Z  
```  
  
 For more information on date formats such as ISO, see [Date and Time Strings](../javascript/date-and-time-strings-javascript.md).  
  
 The following example shows other ways to specify a time.  
  
```JavaScript  
var dtA = new Date('8/24/2009 14:52:10');  
  
// The parameters are year, month, day, hours, minutes, seconds.  
var dtB = new Date(2009, 7, 24, 14, 52, 10);  
document.write(dtA);  
document.write("<br/>");  
document.write(dtB);  
  
// Output:  
// Mon Aug 24 14:52:10 PDT 2009  
// Mon Aug 24 14:52:10 PDT 2009  
  
```  
  
## Adding and Subtracting Days, Months, and Years  
 You can use the getX and setX methods of the `Date` object to set specific dates and times.  
  
 The following example shows how you can set a date to the previous day. Note that if necessary the month and year values are also changed.  
  
```JavaScript  
var myDate = new Date("1/1/1990");  
var dayOfMonth = myDate.getDate();  
myDate.setDate(dayOfMonth - 1);  
  
document.write(myDate);  
  
// Output: Sun Dec 31 00:00:00 PST 1989  
```  
  
 The following example sets the date to the last day of the month by subtracting a day from the first day of the next month.  
  
> [!TIP]
>  The months of the year are numbered from 0 (January) to 11 (December). The days of the week are numbered from 0 (Sunday) to 6 (Saturday).  
  
```JavaScript  
var myDate = new Date("1/1/1990")  
myDate.setMonth(myDate.getMonth() + 1);  
  
myDate.setDate (myDate.getDate() - 1);  
  
document.write(myDate);  
  
// Output: Wed Jan 31 00:00:00 PST 1990  
  
```  
  
## Working with Days of the Week  
 The [getDay method](../javascript/reference/getday-method-date-javascript.md) gets the day of the week as a number between 0 (Sunday) and 6 (Saturday). (This is not the same as the [getDate method](../javascript/reference/getdate-method-date-javascript.md), which gets the day of the month as a number between 1 and 31).  
  
 The following example sets the date for Thanksgiving, which in the United States is the fourth Thursday in November. The script finds November 1 of the current year, then finds the first Thursday, and then adds three weeks.  
  
```JavaScript  
var myDate = new Date();  
myDate.setHours(0, 0, 0, 0);  
  
myDate.setYear(2013);  
  
// Determine November 1.  
myDate.setDate(1);  
myDate.setMonth(10);  
  
// Find Thursday.  
var thursday = 4;  
while(myDate.getDay() != thursday) {  
    myDate.setDate(myDate.getDate() + 1);  
}  
  
// Add 3 weeks.  
myDate.setDate(myDate.getDate() + 21);  
  
document.write(myDate);  
  
// Output: Thu Nov 28 00:00:00 <time zone> 2013  
  
```  
  
## Calculating Elapsed Time  
 The [getTime method](../javascript/reference/gettime-method-date-javascript.md) returns the number of milliseconds that have elapsed since midnight on January 1, 1970. For any date before that date it returns a negative number.  
  
 You can use the [getTime method](../javascript/reference/gettime-method-date-javascript.md) to set a start and end time for calculating an elapsed time. It can be used for measuring small units, such as a few seconds, and large units, such as days.  
  
 The following example calculates elapsed time in seconds. The [getTime method](../javascript/reference/gettime-method-date-javascript.md) gets the number of milliseconds since the zero date.  
  
```JavaScript  
var startTime = new Date('1/1/1990');  
var startMsec = startTime.getMilliseconds();  
startTime.setTime(5000000);  
var elapsed = (startTime.getTime() - startMsec) / 1000;   
document.write(elapsed);  
  
// Output: 5000  
  
```  
  
 To work with more manageable units, you can divide the milliseconds provided by the [getTime method](../javascript/reference/gettime-method-date-javascript.md) by an appropriate number. For instance, to turn milliseconds into days, divide the number by 86,400,000 (1000 milliseconds x 60 seconds x 60 minutes x 24 hours).  
  
 The following example shows how much time has elapsed since the first day of the specified year. It uses  division operations to calculate elapsed time in days, hours, minutes, and seconds. It does not account for daylight savings time.  
  
```JavaScript  
// Set the unit values in milliseconds.  
var msecPerMinute = 1000 * 60;  
var msecPerHour = msecPerMinute * 60;  
var msecPerDay = msecPerHour * 24;  
  
// Set a date and get the milliseconds  
var date = new Date('6/15/1990');  
var dateMsec = date.getTime();  
  
// Set the date to January 1, at midnight, of the specified year.  
date.setMonth(0);  
date.setDate(1);  
date.setHours(0, 0, 0, 0);  
  
// Get the difference in milliseconds.  
var interval = dateMsec - date.getTime();  
  
// Calculate how many days the interval contains. Subtract that  
// many days from the interval to determine the remainder.  
var days = Math.floor(interval / msecPerDay );  
interval = interval - (days * msecPerDay );  
  
// Calculate the hours, minutes, and seconds.  
var hours = Math.floor(interval / msecPerHour );  
interval = interval - (hours * msecPerHour );  
  
var minutes = Math.floor(interval / msecPerMinute );  
interval = interval - (minutes * msecPerMinute );  
  
var seconds = Math.floor(interval / 1000 );  
  
// Display the result.  
document.write(days + " days, " + hours + " hours, " + minutes + " minutes, " + seconds + " seconds.");  
  
//Output: 164 days, 23 hours, 0 minutes, 0 seconds.  
```  
  
### Determining the User's Age  
 The following example takes the user's birthday and calculates the user's age in years. It subtracts the birth year from the current year, and then subtracts 1 if the birthday has not occurred yet in the current year.  
  
```JavaScript  
var birthday = new Date("8/1/1985");  
var today = new Date();  
var years = today.getFullYear() - birthday.getFullYear();  
  
// Reset birthday to the current year.  
birthday.setFullYear(today.getFullYear());  
  
// If the user's birthday has not occurred yet this year, subtract 1.  
if (today < birthday)  
{  
    years--;  
}  
document.write("You are " + years + " years old.");  
  
// Output: You are <number of years> years old.  
  
```  
  
## Comparing Dates  
 When you compare dates in [!INCLUDE[javascript](../javascript/includes/javascript-md.md)], you should keep in mind that the `==` operator returns `true` only if the dates on both sides of the operator refer to the same object. Therefore, if you have two separate `Date` objects set to the same date, `date1 == date2` returns `false`. In addition, a `Date` object set with only the date and not the time is initialized to midnight of that date. So if you compare one `Date` set without a specified time to `Date.now`, for example, you should be aware that the first `Date` is set to midnight and `Date.now` is not.  
  
 The following example checks whether the current date is the same, before, or after a specified date. To set the current date in `todayAtMidn`, the script creates a `Date` object for the current year, month, and day.  
  
```JavaScript  
// Get the current date at midnight.  
var now = new Date();   
var todayAtMidn = new Date(now.getFullYear(), now.getMonth(), now.getDate());  
  
// Set specificDate to a specified date at midnight.  
var specificDate = new Date("9/21/2009");  
  
// Compare the two dates by comparing the millisecond  
// representations.  
if (todayAtMidn.getTime() == specificDate.getTime())  
{  
    document.write("Same");  
}  
else  
{  
    document.write("Different");  
}  
  
//Output: Different  
```  
  
 By modifying the preceding example, we can check whether a provided date is within a particular range.  
  
```JavaScript  
// Get the current date at midnight.  
var now = new Date();  
var todayAtMidn = new Date(now.getFullYear(), now.getMonth(), now.getDate());  
  
// Set start/end dates to a specified date (ISO format).  
var startDate = new Date("2009-06-09T15:20:00Z");  
var endDate = new Date("2011-06-09T15:20:00Z");  
  
// Compare the two dates by comparing the millisecond  
// representations.  
if (todayAtMidn.getTime() > startDate.getTime() &&   
    todayAtMidn.getTime() < endDate.getTime()) {  
    document.write("Specified date is within this range.");  
}  
else {  
    document.write("Specified date is not in this range.");  
}  
  
// Output: Specified date is not in this range.  
```  
  
## See Also  
 [Date Object](../javascript/reference/date-object-javascript.md)