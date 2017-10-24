---
title: "some Method (Array) (JavaScript) | Microsoft Docs"
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
  - "arrays [JavaScript], some method"
  - "some method [JavaScript]"
ms.assetid: 7b6822f9-c406-4f4e-bfec-a93459745992
caps.latest.revision: 18
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# some Method (Array) (JavaScript)
Determines whether the specified callback function returns `true` for any element of an array.  
  
## Syntax  
  
```  
  
array1.some(callbackfn[, thisArg])  
```  
  
#### Parameters  
  
|Parameter|Definition|  
|---------------|----------------|  
|`array1`|Required. An array object.|  
|`callbackfn`|Required. A function that accepts up to three arguments. The `some` method calls the `callbackfn` function for each element in `array1` until the `callbackfn` returns `true`, or until the end of the array.|  
|`thisArg`|Optional. An object to which the `this` keyword can refer in the `callbackfn` function. If `thisArg` is omitted, `undefined` is used as the `this` value.|  
  
## Return Value  
 `true` if the `callbackfn` function returns `true` for any array element; otherwise, `false`.  
  
## Exceptions  
 If the `callbackfn` argument is not a function object, a `TypeError` exception is thrown.  
  
## Remarks  
 The `some` method calls the `callbackfn` function on each array element, in ascending index order, until the `callbackfn` function returns `true`. If an element that causes `callbackfn` to return `true` is found, the `some` method immediately returns `true`. If the callback does not return `true` on any element, the `some` method returns `false`.  
  
 The callback function is not called for missing elements of the array.  
  
 In addition to array objects, the `some` method can be used by any object that has a `length` property and that has numerically indexed property names.  
  
> [!NOTE]
>  You can use the [every Method (Array)](../../javascript/reference/every-method-array-javascript.md) to check whether the callback function returns `true` for all the elements of an array.  
  
## Callback Function Syntax  
 The syntax of the callback function is as follows:  
  
 `function callbackfn(value, index, array1)`  
  
 You can declare the callback function with up to three parameters.  
  
 The following table lists the callback function parameters.  
  
|Callback parameter|Definition|  
|------------------------|----------------|  
|`value`|The value of the array element.|  
|`index`|The numeric index of the array element.|  
|`array1`|The array object that contains the element.|  
  
## Modifying the Array Object  
 The array object can be modified by the callback function.  
  
 The following table describes the results of modifying the array object after the `some` method starts.  
  
|Condition after the `some` method starts|Element passed to callback function?|  
|----------------------------------------------|------------------------------------------|  
|Element is added beyond the original length of the array.|No.|  
|Element is added to fill in a missing element of the array.|Yes, if that index has not yet been passed to the callback function.|  
|Element is changed.|Yes, if that element has not yet been passed to the callback function.|  
|Element is deleted from the array.|No, unless that element has already been passed to the callback function.|  
  
## Example  
 The following example uses the `some` method to find out if any elements in an array are even.  
  
```JavaScript  
// The callback function.  
function CheckIfEven(value, index, ar) {  
    if (value % 2 == 0)  
        return true;  
}  
  
var numbers = [1, 15, 4, 10, 11, 22];  
  
var evens = numbers.some(CheckIfEven);  
document.write(evens);  
  
// Output:  
// true  
```  
  
## Example  
 The following example shows how to use the `thisArg` parameter, which specifies an object to which the `this` keyword can refer. It checks whether any of the numbers in an array are outside the range provided by an object passed  
  
```JavaScript  
// Create a function that returns true if the value is   
// outside the range.  
var isOutsideRange = function (value) {  
    return value < this.minimum || value > this.maximum;  
}  
  
// Create an array of numbers.  
var numbers = [6, 12, 16, 22, -12];  
  
// The range object is to be the 'this' object.  
var range = { minimum: 10, maximum: 20 };  
  
document.write(numbers.some(isOutsideRange, range));  
  
// Output: true  
  
```  
  
## Requirements  
 [!INCLUDE[jsv9](../../javascript/includes/jsv9-md.md)]  
  
## See Also  
 [every Method (Array)](../../javascript/reference/every-method-array-javascript.md)   
 [filter Method (Array)](../../javascript/reference/filter-method-array-javascript.md)   
 [map Method (Array)](../../javascript/reference/map-method-array-javascript.md)