---
title: "Variables (JavaScript) | Microsoft Docs"
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
  - "coercion"
  - "case sensitivity, JavaScript variable name"
ms.assetid: 12a450e5-4818-4a09-9878-cd7c6cd2a248
caps.latest.revision: 20
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Variables (JavaScript)
In [!INCLUDE[javascript](../javascript/includes/javascript-md.md)], a variable contains a value, such as "hello" or 5. When you use the variable, you refer to the data it represents, for example `NumberOfDaysLeft = EndDate - TodaysDate`.  
  
 You use variables to store, retrieve, and manipulate values that appear in your code. Try to give your variables meaningful names to make it easy for other people to understand what your code does.  
  
## Declaring Variables  
 The first time a variable appears in your script is its declaration. The first mention of the variable sets it up in memory, so you can refer to it later on in your script. You should declare variables before using them. You do this using the `var` keyword.  
  
```JavaScript  
// A single declaration.  
var count;    
// Multiple declarations with a single var keyword.  
var count, amount, level;      
// Variable declaration and initialization in one statement.  
var count = 0, amount = 100;   
```  
  
 If you do not initialize your variable in the `var` statement, it automatically takes on the value `undefined`.  
  
## Naming Variables  
 [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] is a case-sensitive language. This means that a variable name such as **myCounter** is different from the variable name **MYCounter**. Variable names can be of any length. The rules for creating legal variable names are as follows:  
  
-   The first character must be an ASCII letter (either uppercase or lowercase), a letter that complies with Unicode variable naming conventions, or an underscore (_) character. Note that a number cannot be used as the first character.  
  
-   Subsequent characters must be letters, numbers, or underscores (_).  
  
-   The variable name must not be a [reserved word](../javascript/reference/javascript-reserved-words.md).  
  
 Here are some examples of valid variable names:  
  
```  
_pagecount   
Part9   
Number_Items   
```  
  
 Here are some examples of invalid variable names:  
  
```JavaScript  
// Cannot begin with a number.   
99Balloons     
// The ampersand (&) character is not a valid character for variable names.   
Alpha&Beta   
```  
  
 When you want to declare a variable and initialize it, but do not want to give it any particular value, assign it the value `null`. Here is an example.  
  
```JavaScript  
var bestAge = null;  
var muchTooOld = 3 * bestAge; // muchTooOld has the value 0.  
```  
  
 If you declare a variable without assigning a value to it, it has the value `undefined`. Here is an example.  
  
```JavaScript  
var currentCount;  
// finalCount has the value NaN because currentCount is undefined.  
var finalCount = 1 * currentCount;   
```  
  
 The `null` value behaves like the number 0, while `undefined` behaves like the special value `NaN` (Not a Number). If you compare a `null` value and an `undefined` value, they are equal.  
  
 You can declare a variable without using the `var` keyword in the declaration, and assign a value to it. This is an implicit declaration.  
  
```JavaScript  
// The variable noStringAtAll is declared implicitly.  
noStringAtAll = "";   
```  
  
 You cannot use a variable that has never been declared.  
  
```JavaScript  
// Error. Length and width do not yet exist.  
var area = length * width;   
```  
  
## Coercion  
 [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] is a loosely typed language, as opposed to strongly typed languages like C++. This means that JavaScript variables have no predetermined type. Instead, the type of a variable is the type of its value. This behavior allows you to treat a value as if it were of a different type.  
  
 In [!INCLUDE[javascript](../javascript/includes/javascript-md.md)], you can perform operations on values of different types without causing an exception. The [!INCLUDE[javascript](../javascript/includes/javascript-md.md)] interpreter implicitly converts, or *coerces*, one of the data types to that of the other, then performs the operation. The rules for coercion of string, number, and Boolean values are the following:  
  
-   If you add a number and a string, the number is coerced to a string.  
  
-   If you add a Boolean and a string, the Boolean is coerced to a string.  
  
-   If you add a number and a Boolean, the Boolean is coerced to a number.  
  
 In the following example, a number added to a string results in a string.  
  
```JavaScript  
var x = 2000;  
var y = "Hello";  
// The number is coerced to a string.  
x = x + y;  
document.write(x);   
  
// Output:  
// 2000Hello  
```  
  
 Strings are automatically converted to equivalent numbers for comparison purposes. To explicitly convert a string to an integer, use the [parseInt function](../javascript/reference/parseint-function-javascript.md). To explicitly convert a string to a number, use the [parseFloat function](../javascript/reference/parsefloat-function-javascript.md).