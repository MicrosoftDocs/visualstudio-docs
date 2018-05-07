---
title: "map Method (Array) (JavaScript) | Microsoft Docs"
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
  - "map method [JavaScript]"
  - "arrays [JavaScript], map method"
ms.assetid: 500dc4f8-d73d-4a28-a5b8-c9bd5674ea36
caps.latest.revision: 20
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# map Method (Array) (JavaScript)
Calls a defined callback function on each element of an array, and returns an array that contains the results.  
  
## Syntax  
  
```  
  
array1.map(callbackfn[, thisArg])  
```  
  
#### Parameters  
  
|Parameter|Definition|  
|---------------|----------------|  
|`array1`|Required. An array object.|  
|`callbackfn`|Required. A function that accepts up to three arguments. The `map` method calls the `callbackfn` function one time for each element in the array.|  
|`thisArg`|Optional. An object to which the `this` keyword can refer in the `callbackfn` function. If `thisArg` is omitted, `undefined` is used as the `this` value.|  
  
## Return Value  
 A new array in which each element is the callback function return value for the associated original array element.  
  
## Exceptions  
 If the `callbackfn` argument is not a function object, a `TypeError` exception is thrown.  
  
## Remarks  
 The `map` method calls the `callbackfn` function one time for each element in the array, in ascending index order. The callback function is not called for missing elements of the array.  
  
 In addition to array objects, the `map` method can be used by any object that has a `length` property and that has numerically indexed property names.  
  
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
 The array object can be modified by the callback function.  
  
 The following table describes the results of modifying the array object after the `map` method starts.  
  
|Condition after the `map` method starts|Element passed to callback function?|  
|---------------------------------------------|------------------------------------------|  
|Element is added beyond the original length of the array.|No.|  
|Element is added to fill in a missing element of the array.|Yes, if that index has not yet been passed to the callback function.|  
|Element is changed.|Yes, if that element has not yet been passed to the callback function.|  
|Element is deleted from the array.|No, unless that element has already been passed to the callback function.|  
  
## Example  
 The following example illustrates the use of the `map` method.  
  
```JavaScript  
// Define the callback function.  
function AreaOfCircle(radius) {  
    var area = Math.PI * (radius * radius);  
    return area.toFixed(0);  
}  
  
// Create an array.  
var radii = [10, 20, 30];  
  
// Get the areas from the radii.  
var areas = radii.map(AreaOfCircle);  
  
document.write(areas);  
  
// Output:  
// 314,1257,2827  
```  
  
## Example  
 The following example illustrates the use of the `thisArg` argument, which specifies an object to which the `this` keyword can refer.  
  
```JavaScript  
// Define an object that contains a divisor property and  
// a remainder function.  
var obj = {  
    divisor: 10,  
    remainder: function (value) {  
        return value % this.divisor;  
    }  
}  
  
// Create an array.  
var numbers = [6, 12, 25, 30];  
  
// Get the remainders.  
// The obj argument specifies the this value in the callback function.  
var result = numbers.map(obj.remainder, obj);  
document.write(result);  
  
// Output:  
// 6,2,5,0  
```  
  
## Example  
 In the following example, a built-in[!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] method is used as the callback function.  
  
```JavaScript  
// Apply Math.sqrt(value) to each element in an array.  
var numbers = [9, 16];  
var result = numbers.map(Math.sqrt);  
  
document.write(result);  
// Output: 3,4  
```  
  
## Example  
 The `map` method can be applied to a string. The following example illustrates this.  
  
```JavaScript  
// Define the callback function.  
function threeChars(value, index, str) {  
    // Create a string that contains the previous, current,  
    // and next character.  
    return str.substring(index - 1, index + 2);  
}  
  
// Create a string.  
var word = "Thursday";  
  
// Apply the map method to the string.  
// Each array element in the result contains a string that  
// has the previous, current, and next character.  
// The commented out statement shows an alternative syntax.  
var result = [].map.call(word, threeChars);  
// var result = Array.prototype.map.call(word, threeChars);  
  
document.write(result);  
  
// Output:  
// Th,Thu,hur,urs,rsd,sda,day,ay  
  
```  
  
## Requirements  
 [!INCLUDE[jsv9](../../javascript/includes/jsv9-md.md)]  
  
## See Also  
 [JavaScript Methods](../../javascript/reference/javascript-methods.md)   
 [Array Object](../../javascript/reference/array-object-javascript.md)   
 [Using Arrays](../../javascript/advanced/using-arrays-javascript.md)   
 [filter Method (Array)](../../javascript/reference/filter-method-array-javascript.md)   
 [forEach Method (Array)](../../javascript/reference/foreach-method-array-javascript.md)   
 [Hilo JavaScript sample app (Windows Store)](http://hilojs.codeplex.com/SourceControl/latest)