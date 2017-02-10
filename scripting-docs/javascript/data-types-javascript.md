---
title: "Data Types (JavaScript) | Microsoft Docs"
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
  - "Boolean data type, supported data types"
ms.assetid: c7a6bd3a-4b1c-4dbe-8505-106dbf483b41
caps.latest.revision: 35
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Data Types (JavaScript)
In [!INCLUDE[javascript](../javascript/includes/javascript-md.md)], there are three primary data types, two composite data types, and two special data types.  
  
## Primary Data Types  
 The primary (primitive) data types are:  
  
-   String  
  
-   Number  
  
-   Boolean  
  
## Composite Data Types  
 The composite (reference) data types are:  
  
-   Object  
  
-   Array  
  
## Special Data Types  
 The special data types are:  
  
-   Null  
  
-   Undefined  
  
## String Data Type  
 A string value is a chain of zero or more Unicode characters (letters, digits, and punctuation marks). You use the string data type to represent text in [!INCLUDE[javascript](../javascript/includes/javascript-md.md)]. You include string literals in your scripts by enclosing them in single or double quotation marks. Double quotation marks can be contained in strings surrounded by single quotation marks, and single quotation marks can be contained in strings surrounded by double quotation marks. The following are examples of strings:  
  
```javascript  
"Happy am I; from care I'm free!"  
'"Avast, ye lubbers!" roared the technician.'   
"45"  
'c'  
```  
  
 Notice that [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] does not have a type to represent a single character. To represent a single character in [!INCLUDE[javascript](../javascript/includes/javascript-md.md)], you create a string that consists of only one character. A string that contains zero characters ("") is an empty (zero-length) string.  
  
 [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] provides escape sequences that you can include in strings to create characters that you cannot type directly. For example, `\t` specifies a tab character. For more information, see [Special Characters](../javascript/advanced/special-characters-javascript.md).  
  
## Number Data Type  
 In [!INCLUDE[javascript](../javascript/includes/javascript-md.md)], there is no distinction between integer and floating-point values; a [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] number can be either (internally, [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] represents all numbers as floating-point values).  
  
### Integer Values  
 Integer values can be positive whole numbers, negative whole numbers, and 0. They can be represented in base 10 (decimal), base 16 (hexadecimal), and base 8 (octal). Most numbers in [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] are written in decimal.  
  
 You denote hexadecimal ("hex") integers by prefixing them with a leading "0x" (zero and x&#124;X). They can contain digits 0 through 9, and letters A through F (either uppercase or lowercase) only. The letters A through F are used to represent, as single digits, 10 through 15 in base 10. That is, 0xF is equivalent to 15, and 0x10 is equivalent to 16.  
  
 You denote octal integers by prefixing them with a leading "0" (zero). They can contain digits 0 through 7 only. A number that has a leading "0" and contains the digits "8" and/or "9" is interpreted as a decimal number.  
  
 Both hexadecimal and octal numbers can be negative, but they cannot have a decimal portion, and they cannot be written in scientific (exponential) notation.  
  
> [!NOTE]
>  Starting in [!INCLUDE[jsv9text](../javascript/includes/jsv9text-md.md)], the [parseInt function](../javascript/reference/parseint-function-javascript.md) does not treat a string that has a prefix of "0" as octal. When you are not using the `parseInt` function, however, strings with a prefix of "0" can still be interpreted as octal.  
  
### Floating-point Values  
 Floating-point values can be whole numbers with a decimal portion. Additionally, they can be expressed in scientific notation. That is, an uppercase or lowercase "e" is used to represent "ten to the power of". [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] represents numbers using the eight byte IEEE 754 floating-point standard for numerical representation. This means you can write numbers as large as 1.79769x10<sup>308</sup>, and as small as 5x10<sup>-324</sup>. A number that contains a decimal point and that has a single "0" before the decimal point is interpreted as a decimal floating-point number.  
  
 Notice that a number that begins with "0x" or "00" and contains a decimal point will generate an error. Here are some examples of [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] numbers.  
  
|Number|Description|Decimal Equivalent|  
|------------|-----------------|------------------------|  
|.0001, 0.0001, 1e-4, 1.0e-4|Four equivalent floating-point numbers.|0.0001|  
|3.45e2|A floating-point number.|345|  
|45|An integer.|45|  
|0378|An integer. Although this looks like an octal number (it begins with a zero), 8 is not a valid octal digit, so the number is treated as a decimal.|378|  
|0377|An octal integer. Notice that although it only appears to be one less than the number above, its actual value is quite different.|255|  
|0.0001|A floating point number. Even though this begins with a zero, it is not an octal number because it has a decimal point.|0.0001|  
|00.0001|This is an error. The two leading zeros mark the number as an octal, but octals are not allowed a decimal component.|N/A (compiler error)|  
|0Xff|A hexadecimal integer.|255|  
|0x37CF|A hexadecimal integer.|14287|  
|0x3e7|A hexadecimal integer. Notice that the 'e' is not treated as exponentiation.|999|  
|0x3.45e2|This is an error. Hexadecimal numbers cannot have decimal parts.|N/A (compiler error)|  
  
 Additionally, [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] contains numbers with special values. These are:  
  
-   NaN (not a number). This is used when a mathematical operation is performed on inappropriate data, such as strings or the undefined value  
  
-   Positive Infinity. This is used when a positive number is too large to represent in [!INCLUDE[javascript](../javascript/includes/javascript-md.md)]  
  
-   Negative Infinity. This is used when a negative number is too large to represent in [!INCLUDE[javascript](../javascript/includes/javascript-md.md)]  
  
-   Positive and Negative 0. [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] differentiates between positive and negative zero.  
  
## Boolean Data Type  
 Whereas the string and number data types can have a virtually unlimited number of different values, the Boolean data type can only have two. They are the literals `true` and `false`. A Boolean value is a truth-value: it specifies whether the condition is true or not.  
  
 Comparisons you make in your scripts always have a Boolean outcome. Consider the following line of [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] code.  
  
```javascript  
y = (x == 2000);  
```  
  
 Here, the value of the variable `x` is compared to the number 2000. If it is, the result of the comparison is the Boolean value **true**, which is assigned to the variable `y`. If `x` is not equal to 2000, then the result of the comparison is the Boolean value `false`.  
  
 Boolean values are especially useful in control structures. The following code combines a comparison that creates a Boolean value directly with a statement that uses it. Consider the following [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] code sample.  
  
```javascript  
if (x == 2000) {  
    z = z + 1;  
}  
else {  
    x = x + 1;  
}  
```  
  
 The `if/else` statement in [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] performs one action if a Boolean value is `true` (`z = z + 1`), and an alternate action if the Boolean value is `false` (`x = x + 1`).  
  
 You can use any expression as a comparative expression. Any expression that evaluates to 0, null, undefined, or an empty string is interpreted as `false`. An expression that evaluates to any other value is interpreted as `true`. For example, you could use an expression such as:  
  
```javascript  
// This may not do what you expect. See below!  
if (x = y + z)   
```  
  
 Note that the above line does not check whether `x` is equal to `y + z`, since only a single equal sign (the assignment operator) is used. Instead, the code above assigns the value of `y + z` to the variable `x`, and then checks whether the result of the entire expression (the value of `x`) is zero. To check whether `x` is equal to `y + z`, you need to use the following code.  
  
```javascript  
// This is different from the code above!  
if (x == y + z)   
```  
  
 For more information on comparisons, see [Controlling Program Flow](../javascript/controlling-program-flow-javascript.md).  
  
## The null Data Type  
 The `null` data type has only one value in [!INCLUDE[javascript](../javascript/includes/javascript-md.md)]: null. The `null` keyword cannot be used as the name of a function or variable.  
  
 A variable that contains `null` contains no valid Number, String, Boolean, Array, or Object. You can erase the contents of a variable (without deleting the variable) by assigning it the `null` value.  
  
 Notice that in [!INCLUDE[javascript](../javascript/includes/javascript-md.md)], `null` is not the same as 0 (as it is in C and C++). Also note that the `typeof` operator in [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] reports `null` values as being of type `Object`, not of type `null`. This potentially confusing behavior is for backwards compatibility.  
  
## The undefined Data Type  
 The `undefined` value is returned when you use an object property that does not exist, or a variable that has been declared, but has never had a value assigned to it.  
  
 you can check to see if a variable exists by comparing it to `undefined`, although you can check if its type is `undefined` by comparing the type of the variable to the string "undefined". The following example shows how to find out the variable `x` has been declared:  
  
```javascript  
  
var x;  
  
// This method works.  
if (x == undefined) {  
    document.write("comparing x to undefined <br/>");  
}  
.  
// This method doesn't work - you must check for the string "undefined".  
if (typeof(x) == undefined) {  
    document.write("comparing the type of x to undefined <br/>");  
}  
// This method does work.   
if (typeof(x) == "undefined") {  
    document.write("comparing the type of x to the string 'undefined'");  
}  
  
// Output:   
// comparing x to undefined   
// comparing the type of x to the string 'undefined'  
  
```  
  
 You can also compare the undefined value to `null`. This comparison is `true` if the property `someObject.prop` is `null` or if the property `someObject.prop` does not exist.  
  
```javascript  
someObject.prop == null;  
```  
  
 To find out whether an object property exists, you can use the **in** operator:  
  
```javascript  
if ("prop" in someObject)  
    // someObject has the property 'prop'  
```  
  
## See Also  
 [Objects and Arrays](../javascript/objects-and-arrays-javascript.md)   
 [typeof Operator](../javascript/reference/typeof-operator-decrementjavascript.md)