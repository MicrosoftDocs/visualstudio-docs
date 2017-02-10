---
title: "Intrinsic Objects (JavaScript) | Microsoft Docs"
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
helpviewer_keywords: 
  - "built-in objects [JavaScript]"
  - "intrinsic objects [JavaScript]"
ms.assetid: 6520c634-a7d1-4a05-8c1b-2e79f449d2e4
caps.latest.revision: 19
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Intrinsic Objects (JavaScript)
[!INCLUDE[javascript](../javascript/includes/javascript-md.md)] provides intrinsic (or "built-in") objects. They are the `Array`, `Boolean`, `Date`, `Error`, `Function`, **Global**, **JSON**, **Math**, **Number**, `Object`, `RegExp`, and `String` objects. The intrinsic objects have associated methods, functions, properties, and constants that are described in detail in the [language reference](../javascript/reference/javascript-reference.md).  
  
## Array Object  
 The subscripts of an array can be thought of as properties of an object, and are referred to by their numeric index. Note that named properties added to an array cannot be indexed by number; they are separate from the array elements.  
  
 To create a new array, use the **new** operator and the **Array()** [constructor](../javascript/reference/constructor-property-object-javascript.md), as in the following example.  
  
```javascript  
var theMonths = new Array(12);  
theMonths[0] = "Jan";  
theMonths[1] = "Feb";  
theMonths[2] = "Mar";  
theMonths[3] = "Apr";  
theMonths[4] = "May";  
theMonths[5] = "Jun";  
theMonths[6] = "Jul";  
theMonths[7] = "Aug";  
theMonths[8] = "Sep";  
theMonths[9] = "Oct";  
theMonths[10] = "Nov";  
theMonths[11] = "Dec";  
```  
  
 When you create an array using the `Array` keyword, [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] includes a **length** property, which records the number of entries. If you do not specify a number, the length is set to 0, and the array has no entries. If you specify a number, the length is set to that number. If you specify more than one parameter, the parameters are used as entries in the array. In addition, the number of parameters is assigned to the length property, as in the following example, which is equivalent to the preceding example.  
  
```javascript  
var theMonths = new Array("Jan", "Feb", "Mar", "Apr", "May", "Jun",   
"Jul", "Aug", "Sep", "Oct", "Nov", "Dec");  
```  
  
 [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] automatically changes the value of **length** when you add elements to an array that you created with the `Array` keyword. Array indices in [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] always start at 0, not 1, so the length property is always one greater than the largest index in the array.  
  
## String Object  
 In [!INCLUDE[javascript](../javascript/includes/javascript-md.md)], you can treat strings (and numbers) as if they were objects. The [string Object](../javascript/reference/string-object-javascript.md) has certain built-in methods, which you can use with your strings. One of these is the [substring Method](../javascript/reference/substring-method-string-javascript.md), which returns part of the string. It takes two numbers as its arguments.  
  
```javascript  
var aString = "0123456789";  
  
// This code sets aChunk to "456".  
var aChunk = aString.substring(4, 7);  
  
// This code sets anotherChunk to "456", using  
// the lower value index as the starting index.  
var anotherChunk = aString.substring(7, 4);  
  
// This code sets the firstLetter variable to "J"  
// by using the array in the preceding array creation example.  
firstLetter = theMonths[5].substring(0,1);  
```  
  
 Another property of the `String` object is the **length** property. This property contains the number of characters in the string (0 for an empty string). This a numeric value, and can be used directly in calculations.  
  
```javascript  
var howLong = "Hello World".length  // Sets the howLong variable to 11.  
```  
  
## Math Object  
 The **Math** object has a number of predefined constants and functions. The constants are specific numbers. One of these specific numbers is the value of pi (approximately 3.14159...). This is the **Math.PI** constant, shown in the following example.  
  
```javascript  
var radius = 5;  
var circleArea = Math.PI * radius * radius;  
```  
  
 One of the built-in functions of the **Math** object is the exponentiation method, or `Math.pow`, which raises a number to a specified power. The following example uses both pi and exponentiation to calculate the volume of a sphere.  
  
```javascript  
var volume = (4/3)*(Math.PI*Math.pow(radius,3));  
```  
  
## Date Object  
 The `Date` object can be used to represent arbitrary dates and times, to get the current system date, and to calculate differences between dates. It has several properties and methods, all predefined. In general, the `Date` object provides the day of the week; the month, day, and year; and the time in hours, minutes, and seconds. This information is based on the number of milliseconds since January 1, 1970, 00:00:00.000 GMT, which is Greenwich Mean Time (the preferred term is UTC, or "Universal Coordinated Time," which refers to signals issued by the World Time Standard). [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] can handle dates that are in the approximate range 250,000 B.C. to 255,000 A.D.  
  
 To create a new `Date` object, use the **new** operator, as shown in the following example.  
  
```javascript  
var toDay = new Date();    
var thisYear = toDay.getFullYear();  
var thisMonth = theMonths[toDay.getMonth()];  
var thisDay = thisMonth  + " " + toDay.getDate() + ", " + thisYear;  
```  
  
## Number Object  
 In addition to the special numeric constants (`PI`, for example) that are available in the **Math** object, several other constants are available in [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] through the **Number** object.  
  
|Constant|Description|  
|--------------|-----------------|  
|Number.MAX_VALUE|Largest possible number, about 1.79E+308; can be positive or negative. (Value varies slightly from system to system.)|  
|Number.MIN_VALUE|Smallest possible number, about 5.00E-324; can be positive or negative. (Value varies slightly from system to system.)|  
|Number.NaN|Special nonnumeric value, "not a number."|  
|Number.POSITIVE_INFINITY|Any positive value larger than the largest positive number (Number.MAX_VALUE) is automatically converted to this value; represented as infinity.|  
|Number.NEGATIVE_INFINITY|Any value more negative than the largest negative number (-Number.MAX_VALUE) is automatically converted to this value; represented as -infinity.|  
  
 **Number.NaN** is a special constant that is defined as "not a number." An attempt to parse a string that cannot be parsed as a number returns **Number.NaN**. `NaN` compares unequal to any number and to itself. To test for a `NaN` result, do not compare against **Number.NaN**; use the **isNaN()** function instead.  
  
## JSON Object  
 JSON is a lightweight data-interchange format based on a subset of the object literal notation of the JavaScript language.  
  
 The JSON object provides two functions to convert to and from JSON text format. The [JSON.stringify](../javascript/reference/json-stringify-function-javascript.md) function serializes objects and arrays into JSON text. The [JSON.parse](../javascript/reference/json-parse-function-javascript.md) function de-serializes JSON text to produce in-memory objects. For more information, see [An Introduction to JavaScript Object Notation (JSON) in JavaScript and .NET](http://go.microsoft.com/fwlink/?LinkId=124098).  
  
## See Also  
 [JavaScript Objects](../javascript/reference/javascript-objects.md)