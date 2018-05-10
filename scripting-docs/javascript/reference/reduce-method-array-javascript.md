---
title: "reduce Method (Array) (JavaScript) | Microsoft Docs"
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
  - "callback function, reduce method [JavaScript]"
  - "arrays [JavaScript], reduce method"
  - "reduce method [JavaScript]"
ms.assetid: 48d069e0-e083-494f-86d5-d459d2377dc5
caps.latest.revision: 21
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# reduce Method (Array) (JavaScript)
Calls the specified callback function for all the elements in an array. The return value of the callback function is the accumulated result, and is provided as an argument in the next call to the callback function.  
  
## Syntax  
  
```  
  
array1.reduce(callbackfn[, initialValue])  
```  
  
#### Parameters  
  
|Parameter|Definition|  
|---------------|----------------|  
|`array1`|Required. An array object.|  
|`callbackfn`|Required. A function that accepts up to four arguments. The `reduce` method calls the `callbackfn` function one time for each element in the array.|  
|`initialValue`|Optional. If `initialValue` is specified, it is used as the initial value to start the accumulation. The first call to the `callbackfn` function provides this value as an argument instead of an array value.|  
  
## Return Value  
 The accumulated result from the last call to the callback function.  
  
## Exceptions  
 A `TypeError` exception is thrown when either of the following conditions is true:  
  
-   The `callbackfn` argument is not a function object.  
  
-   The array contains no elements and `initialValue` is not provided.  
  
## Remarks  
 If an `initialValue` is provided, the `reduce` method calls the `callbackfn` function one time for each element present in the array, in ascending index order. If an `initialValue` is not provided, the `reduce` method calls the `callbackfn` function on each element, starting with the second element.  
  
 The return value of the callback function is provided as the `accumulator` argument on the next call to the callback function. The return value of the last call to the callback function is the return value of the `reduce` method.  
  
 The callback function is not called for missing elements of the array.  
  
> [!NOTE]
>  The [reduceRight Method (Array)](../../javascript/reference/reduceright-method-array-javascript.md) processes the elements in descending index order.  
  
## Callback Function Syntax  
 The syntax of the callback function is as follows:  
  
 `function callbackfn(accumulator, currentValue, currentIndex, array1)`  
  
 You can declare the callback function by using up to four parameters.  
  
 The following table lists the callback function parameters.  
  
|Callback argument|Definition|  
|-----------------------|----------------|  
|`accumulator`|The value from the previous call to the callback function. If an `initialValue` is provided to the `reduce` method, the `accumulator` is `initialValue` the first time the function is called.|  
|`currentValue`|The value of the current array element.|  
|`currentIndex`|The numeric index of the current array element.|  
|`array1`|The array object that contains the element.|  
  
## First Call to the Callback Function  
 The first time the callback function is called, the values provided as arguments depend on whether the `reduce` method has an `initialValue` argument.  
  
 If an `initialValue` is provided to the reduce method:  
  
-   The `accumulator` argument is `initialValue`.  
  
-   The `currentValue` argument is the value of the first element present in the array.  
  
 If an `initialValue` is not provided:  
  
-   The `accumulator` argument is the value of the first element present in the array.  
  
-   The `currentValue` argument is the value of the second element present in the array.  
  
## Modifying the Array Object  
 The array object can be modified by the callback function.  
  
 The following table describes the results of modifying the array object after the `reduce` method starts.  
  
|Condition after the `reduce` method starts|Element passed to callback function?|  
|------------------------------------------------|------------------------------------------|  
|Element is added beyond the original length of the array.|No.|  
|Element is added to fill in a missing element of the array.|Yes, if that index has not yet been passed to the callback function.|  
|Element is changed.|Yes, if that element has not yet been passed to the callback function.|  
|Element is deleted from the array.|No, unless that element has already been passed to the callback function.|  
  
## Example  
 The following example concatenates array values into a string, separating the values with "::". Because no initial value is provided to the `reduce` method, the first call to the callback function has "abc" as the `accumulator` argument and "def" as the `currentValue` argument.  
  
```JavaScript  
// Define the callback function.  
function appendCurrent (accumulator, currentValue) {  
    return accumulator + "::" + currentValue;  
    }  
  
// Create an array.  
var elements = ["abc", "def", 123, 456];  
  
// Call the reduce method, which calls the callback function  
// for each array element.  
var result = elements.reduce(appendCurrent);  
  
document.write(result);  
  
// Output:  
//  abc::def::123::456  
  
```  
  
## Example  
 The following example adds the values of an array after they have been rounded. The `reduce` method is called with an initial value of 0.  
  
```JavaScript  
// Define the callback function.  
function addRounded (accumulator, currentValue) {  
    return accumulator + Math.round(currentValue);  
    }  
  
// Create an array.  
var numbers = [10.9, 15.4, 0.5];  
  
// Call the reduce method, starting with an initial value of 0.  
var result = numbers.reduce(addRounded, 0);  
  
document.write (result);  
// Output: 27  
```  
  
## Example  
 The following example adds the values in an array. The `currentIndex` and `array1` parameters are used in the callback function.  
  
```JavaScript  
function addDigitValue(accumulator, currentDigit, currentIndex, array) {  
    var exponent = (array.length - 1) - currentIndex;  
    var digitValue = currentDigit * Math.pow(10, exponent);  
    return accumulator + digitValue;  
    }  
  
var digits = [4, 1, 2, 5];  
  
// Determine an integer that is computed from values in the array.  
var result = digits.reduce(addDigitValue, 0);  
  
document.write (result);  
// Output: 4125  
```  
  
## Example  
 The following example gets an array that contains only those values that are between 1 and 10 in another array. The initial value provided to the `reduce` method is an empty array.  
  
```JavaScript  
function Process(accumulatedArray, currentValue) {  
    // If currentValue is between 1 and 10,   
    // append currentValue to the array.  
    var nextArray;  
    if (currentValue >= 1 && currentValue <= 10)  
        nextArray = accumulatedArray.concat(currentValue);  
    else  
        nextArray = accumulatedArray;  
  
    // If this is not the last call by the reduce method,  
    // the returned array is accumulatedArray on the next call.  
    // If this is the last call by the reduce method, the  
    // returned array is the return value of the reduce method.  
    return nextArray;  
}  
  
// Create an array.  
var numbers = [20, 1, -5, 6, 50, 3];  
  
// Call the reduce method, starting with an initial empty array.  
var emptyArray = new Array();  
var resultArray = numbers.reduce(Process, emptyArray);  
  
document.write("result array=" + resultArray);  
  
// Output:  
// result array=1,6,3  
```  
  
## Requirements  
 [!INCLUDE[jsv9](../../javascript/includes/jsv9-md.md)]  
  
## See Also  
 [reduceRight Method (Array)](../../javascript/reference/reduceright-method-array-javascript.md)
