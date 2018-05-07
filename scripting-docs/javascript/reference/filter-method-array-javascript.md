---
title: "filter Method (Array) (JavaScript) | Microsoft Docs"
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
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "arrays [JavaScript], filter method"
  - "filter method [JavaScript]"
ms.assetid: 1d260370-9e6e-43fc-870f-2d35850db7ee
caps.latest.revision: 32
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# filter Method (Array) (JavaScript)
Returns the elements of an array that meet the condition specified in a callback function.  
  
## Syntax  
  
```  
  
array1.filter(callbackfn[, thisArg])  
```  
  
#### Parameters  
  
|Parameter|Definition|  
|---------------|----------------|  
|`array1`|Required. An array object.|  
|`callbackfn`|Required. A function that accepts up to three arguments. The `filter` method calls the `callbackfn` function one time for each element in the array.|  
|`thisArg`|Optional. An object to which the `this` keyword can refer in the `callbackfn` function. If `thisArg` is omitted, `undefined` is used as the `this` value.|  
  
## Return Value  
 A new array that contains all the values for which the callback function returns `true`. If the callback function returns `false` for all elements of `array1`, the length of the new array is 0.  
  
## Exceptions  
 If the `callbackfn` argument is not a function object, a `TypeError` exception is thrown.  
  
## Remarks  
 The `filter` method calls the `callbackfn` function one time for each element in the array, in ascending index order. The callback function is not called for missing elements of the array.  
  
 In addition to array objects, the `filter` method can be used by any object that has a `length` property and that has numerically indexed property names.  
  
## Callback Function Syntax  
 The syntax of the callback function is as follows:  
  
 `function callbackfn(value, index, array1)`  
  
 You can declare the callback function by using up to three parameters.  
  
 The following table lists the callback function parameters.  
  
|Callback argument|Definition|  
|-----------------------|----------------|  
|`value`|The value of the array element.|  
|`index`|The numeric index of the array element.|  
|`array1`|The array object that contains the element.|  
  
## Modifying the Array Object  
 The `filter` method does not directly modify the original array, but the callback function might modify it. The following table describes the results of modifying the array object after the `filter` method starts.  
  
|Condition after the `filter` method starts|Element passed to callback function?|  
|------------------------------------------------|------------------------------------------|  
|Element is added beyond the original length of the array.|No.|  
|Element is added to fill in a missing element of the array.|Yes, if that index has not yet been passed to the callback function.|  
|Element is changed.|Yes, if that element has not yet been passed to the callback function.|  
|Element is deleted from the array.|No, unless that element has already been passed to the callback function.|  
  
## Example  
 The following example shows how to use the `filter` method.  
  
```JavaScript  
// Define a callback function.  
function CheckIfPrime(value, index, ar) {  
    high = Math.floor(Math.sqrt(value)) + 1;  
  
    for (var div = 2; div <= high; div++) {  
        if (value % div == 0) {  
            return false;  
        }  
    }   
    return true;  
}  
  
// Create the original array.  
var numbers = [31, 33, 35, 37, 39, 41, 43, 45, 47, 49, 51, 53];  
  
// Get the prime numbers that are in the original array.   
var primes = numbers.filter(CheckIfPrime);  
  
document.write(primes);  
// Output: 31,37,41,43,47,53  
```  
  
## Example  
 In the following example, the `callbackfn` argument includes the code of the callback function.  
  
```JavaScript  
// Create the original array.  
var arr = [5, "element", 10, "the", true];  
  
// Create an array that contains the string  
// values that are in the original array.  
var result = arr.filter(  
    function (value) {  
        return (typeof value === 'string');  
    }  
);  
  
document.write(result);  
// Output: element, the  
```  
  
## Example  
 The following example displays the names of properties that start with the letter "css" in the `window` DOM object.  
  
```JavaScript  
var filteredNames = Object.getOwnPropertyNames(window).filter(IsC);  
  
    for (i in filteredNames)  
        document.write(filteredNames[i] + "<br/>");  
  
// Check whether the string starts with "css".  
function IsC(value) {  
    var firstChar = value.substr(0, 3);  
    if (firstChar.toLowerCase() == "css")  
        return true;  
    else  
        return false;  
    }  
  
// Output:  
// CSSRule  
// CSSFontFaceRule  
// CSSImportRule  
// CSSMediaRule  
// CSSNamespaceRule  
// CSSPageRule  
// CSSRuleList  
// CSSStyleDeclaration  
// CSSStyleRule  
// CSSStyleSheet  
  
```  
  
## Example  
 The following example illustrates the use of the `thisArg` argument, which specifies an object to which the `this` keyword can refer.  
  
```JavaScript  
var checkNumericRange = function(value) {  
    if (typeof value !== 'number')  
        return false;  
    else   
        return value >= this.minimum && value <= this.maximum;  
}  
  
var numbers = [6, 12, "15", 16, "the", -12];  
  
// The obj argument enables use of the this value  
// within the callback function.  
var obj = { minimum: 10, maximum: 20 }  
  
var result = numbers.filter(checkNumericRange, obj);  
  
document.write(result);  
// Output: 12,16  
  
```  
  
## Example  
 The `filter` method can be applied to a string instead of an array. The following example shows how to do this.  
  
```JavaScript  
// Define a callback function that returns true  
// if the current array element follows a space  
// or is the first character.  
function CheckValue(value, index, ar) {  
    if (index == 0)  
        return true;  
    else  
        return ar[index - 1] === " ";  
}  
  
// Create a string.  
var sentence = "The quick brown fox jumps over the lazy dog.";   
  
// Create an array that contains all characters that follow a space.  
var subset = [].filter.call(sentence, CheckValue);   
  
// You can use this alternative syntax.  
//var subset = Array.prototype.filter.call(sentence, CheckValue);  
  
document.write(subset);  
// Output: T,q,b,f,j,o,t,l,d  
  
```  
  
## Requirements  
 [!INCLUDE[jsv9](../../javascript/includes/jsv9-md.md)]  
  
## See Also  
 [Array Object](../../javascript/reference/array-object-javascript.md)   
 [Using Arrays](../../javascript/advanced/using-arrays-javascript.md)   
 [map Method (Array)](../../javascript/reference/map-method-array-javascript.md)   
 [forEach Method (Array)](../../javascript/reference/foreach-method-array-javascript.md)