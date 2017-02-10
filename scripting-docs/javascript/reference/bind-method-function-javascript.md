---
title: "bind Method (Function) (JavaScript) | Microsoft Docs"
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
helpviewer_keywords: 
  - "parameters [JavaScript], bind method"
  - "arguments [JavaScript], bind method"
  - "bind method [JavaScript]"
  - "this keyword [JavaScript], bind method"
ms.assetid: 28946f47-b758-48cf-b508-610a0f2f6e19
caps.latest.revision: 21
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# bind Method (Function) (JavaScript)
For a given function, creates a bound function that has the same body as the original function. In the bound function, the `this` object resolves to the passed in object. The bound function has the specified initial parameters.  
  
## Syntax  
  
```  
  
function.bind(thisArg[,arg1[,arg2[,argN]]])  
```  
  
#### Parameters  
 `function`  
 Required. A function object.  
  
 `thisArg`  
 Required. An object to which the `this` keyword can refer inside the new function.  
  
 `arg1`[,`arg2`[,`argN`]]]  
 Optional. A list of arguments to be passed to the new function.  
  
## Return Value  
 A new function that is the same as the `function` function, except for the `thisArg` object and the initial arguments.  
  
## Exceptions  
 If the specified `function` is not a function, a `TypeError` exception is thrown.  
  
## Example  
 The following code shows how to use the `bind` method.  
  
```javascript  
// Define the original function.  
var checkNumericRange = function (value) {  
    if (typeof value !== 'number')  
        return false;  
    else  
        return value >= this.minimum && value <= this.maximum;  
}  
  
// The range object will become the this value in the callback function.  
var range = { minimum: 10, maximum: 20 };  
  
// Bind the checkNumericRange function.  
var boundCheckNumericRange = checkNumericRange.bind(range);  
  
// Use the new function to check whether 12 is in the numeric range.  
var result = boundCheckNumericRange (12);  
document.write(result);  
  
// Output: true  
```  
  
## Example  
 In the following example, the `thisArg` object is different from the object that contains the original method.  
  
```javascript  
// Create an object that contains the original function.  
var originalObject = {  
    minimum: 50,  
    maximum: 100,  
    checkNumericRange: function (value) {  
        if (typeof value !== 'number')  
            return false;  
        else  
            return value >= this.minimum && value <= this.maximum;  
    }  
}  
  
// Check whether 10 is in the numeric range.  
var result = originalObject.checkNumericRange(10);  
document.write(result + " ");  
// Output: false  
  
// The range object supplies the range for the bound function.  
var range = { minimum: 10, maximum: 20 };  
  
// Create a new version of the checkNumericRange function that uses range.  
var boundObjectWithRange = originalObject.checkNumericRange.bind(range);  
  
// Check whether 10 is in the numeric range.  
var result = boundObjectWithRange(10);  
document.write(result);  
// Output: true  
```  
  
## Example  
 The following code shows how to use the `arg1[,arg2[,argN]]]` arguments. The bound function uses the parameters specified in the `bind` method as the first and second parameters. Any parameters specified when the bound function is called are used as the third, fourth (and so on) parameters.  
  
```javascript  
// Define the original function with four parameters.  
var displayArgs = function (val1, val2, val3, val4) {  
    document.write(val1 + " " + val2 + " " + val3 + " " + val4);  
}  
  
var emptyObject = {};  
  
// Create a new function that uses the 12 and "a" parameters  
// as the first and second parameters.  
var displayArgs2 = displayArgs.bind(emptyObject, 12, "a");  
  
// Call the new function. The "b" and "c" parameters are used  
// as the third and fourth parameters.  
displayArgs2("b", "c");  
// Output: 12 a b c   
```  
  
## Requirements  
 [!INCLUDE[jsv9](../../javascript/includes/jsv9-md.md)]  
  
## See Also  
 [Function Object](../../javascript/reference/function-object-javascript.md)   
 [filter Method (Array)](../../javascript/reference/filter-method-array-javascript.md)   
 [Using the bind method](../../javascript/advanced/using-the-bind-method-javascript.md)   
 [Hilo JavaScript sample app (Windows Store)](http://hilojs.codeplex.com/SourceControl/latest)