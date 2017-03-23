---
title: "forEach Method (Array) (JavaScript) | Microsoft Docs"
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
  - "forEach method [JavaScript]"
  - "arrays [JavaScript], forEach method"
  - "callback function, forEach method [JavaScript]"
ms.assetid: bd188034-a62b-4cbd-99c8-46d70dd6823d
caps.latest.revision: 28
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# forEach Method (Array) (JavaScript)
Performs the specified action for each element in an array.  
  
## Syntax  
  
```  
  
array1.forEach(callbackfn[, thisArg])  
```  
  
#### Parameters  
  
|Parameter|Definition|  
|---------------|----------------|  
|`array1`|Required. An array object.|  
|`callbackfn`|Required. A function that accepts up to three arguments. `forEach` calls the `callbackfn` function one time for each element in the array.|  
|`thisArg`|Optional. An object to which the `this` keyword can refer in the `callbackfn` function. If `thisArg` is omitted, `undefined` is used as the `this` value.|  
  
## Exceptions  
 If the `callbackfn` argument is not a function object, a `TypeError` exception is thrown.  
  
## Remarks  
 The `forEach` method calls the `callbackfn` function one time for each element present in the array, in ascending index order. The callback function is not called for missing elements of the array.  
  
 In addition to array objects, the `forEach` method can be used by any object that has a `length` property and that has numerically indexed property names.  
  
## Callback Function Syntax  
 The syntax of the callback function is as follows:  
  
 `function callbackfn(value, index, array1)`  
  
 You can declare the callback function by using up to three parameters.  
  
 The callback function parameters are as follows.  
  
|Callback argument|Definition|  
|-----------------------|----------------|  
|`value`|The value of the array element.|  
|`index`|The numeric index of the array element.|  
|`array1`|The array object that contains the element.|  
  
## Modifying the Array Object  
 The `forEach` method does not directly modify the original array, but the callback function might modify it. The following table describes the results of modifying the array object after the `forEach` method starts.  
  
|Condition after `forEach` method starts|Element passed to callback function?|  
|---------------------------------------------|------------------------------------------|  
|Element is added beyond the original length of the array.|No.|  
|Element is added to fill in a missing element of the array.|Yes, if that index has not yet been passed to the callback function.|  
|Element is changed.|Yes, if that element has not yet been passed to the callback function.|  
|Element is deleted from the array.|No, unless that element has already been passed to the callback function.|  
  
## Example  
 The following example illustrates use of the `forEach` method.  
  
```JavaScript  
// Define the callback function.  
function ShowResults(value, index, ar) {  
    document.write("value: " + value);  
    document.write(" index: " + index);  
    document.write("<br />");  
}  
  
// Create an array.  
var letters = ['ab', 'cd', 'ef'];  
  
// Call the ShowResults callback function for each  
// array element.  
letters.forEach(ShowResults);  
  
// Output:  
//  value: ab index: 0   
//  value: cd index: 1   
//  value: ef index: 2   
```  
  
## Example  
 In the following example, the `callbackfn` argument includes the code of the callback function.  
  
```JavaScript  
// Create an array.  
var numbers = [10, 11, 12];  
  
// Call the addNumber callback function for each array element.  
var sum = 0;  
numbers.forEach(  
    function addNumber(value) { sum += value; }  
);  
  
document.write(sum);  
// Output: 33  
  
```  
  
## Example  
 The following example illustrates the use of the `thisArg` argument, which specifies an object that can be referred to with the `this` keyword.  
  
```JavaScript  
// Define the object that contains the callback function.  
var obj = {  
    showResults: function(value, index) {  
        // Call calcSquare by using the this value.  
        var squared = this.calcSquare(value);  
  
        document.write("value: " + value);  
        document.write(" index: " + index);  
        document.write(" squared: " + squared);  
        document.write("<br />");  
    },  
    calcSquare: function(x) { return x * x }  
};  
  
// Define an array.  
var numbers = [5, 6];  
  
// Call the showResults callback function for each array element.  
// The obj is the this value within the   
// callback function.  
numbers.forEach(obj.showResults, obj);  
  
// Embed the callback function in the forEach statement.  
// The obj argument is the this value within the obj object.  
// The output is the same as for the previous statement.  
numbers.forEach(function(value, index) { this.showResults(value, index) }, obj);  
  
// Output:  
//  value: 5 index: 0 squared: 25  
//  value: 6 index: 1 squared: 36  
//  value: 5 index: 0 squared: 25  
//  value: 6 index: 1 squared: 36  
```  
  
## Requirements  
 [!INCLUDE[jsv9](../../javascript/includes/jsv9-md.md)]  
  
## See Also  
 [filter Method (Array)](../../javascript/reference/filter-method-array-javascript.md)   
 [map Method (Array)](../../javascript/reference/map-method-array-javascript.md)   
 [some Method (Array)](../../javascript/reference/some-method-array-javascript.md)   
 [Array Object](../../javascript/reference/array-object-javascript.md)   
 [Using Arrays](../../javascript/advanced/using-arrays-javascript.md)   
 [Hilo JavaScript sample app (Windows Store)](http://hilojs.codeplex.com/SourceControl/latest)