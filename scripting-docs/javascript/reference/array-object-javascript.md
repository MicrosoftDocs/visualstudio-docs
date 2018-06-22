---
title: "Array Object (JavaScript) | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.technology: 
  - "devlang-javascript"
ms.tgt_pltfrm: ""
ms.topic: "language-reference"
f1_keywords: 
  - "Array"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "Array object"
  - "constructor property"
ms.assetid: 08e5f552-0797-4b48-8164-609582fc18c9
caps.latest.revision: 27
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Array Object (JavaScript)

Provides support for creation of arrays of any data type.  
  
## Syntax  
  
```
arrayObj = new Array()  
arrayObj = new Array([size])  
arrayObj = new Array([element0[, element1[, ...[, elementN]]]])  
```  
  
## Parameters  
 `arrayObj`  
 Required. The variable name to which the `Array` object is assigned.  
  
 `size`  
 Optional. The size of the array. As arrays are zero-based, created elements will have indexes from zero to `size` -1.  
  
 `element0,...,elementN`  
 Optional. The elements to place in the array. This creates an array with *n* + 1 elements, and a `length` of *n* + 1. Using this syntax, you must supply more than one element.  
  
## Remarks  
 After an array is created, you can access the individual elements of the array by using [ ] notation. Note that arrays in [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] are zero-based.  
  
```JavaScript  
var my_array = new Array();  
for (i = 0; i < 10; i++) {  
    my_array[i] = i;  
}  
x = my_array[4];  
document.write(x);  
  
// Output: 4  
```  
  
 You can pass an unsigned 32-bit integer to the `Array` constructor to specify the size of the array. If the value is negative or not an integer, a run-time error occurs. If you run the following code, you should see this error in the Console.  
  
```JavaScript  
var arr = new Array(10);  
document.write(arr.length);  
  
// Output: 10  
  
// Don't do this  
var arr = new Array(-1);  
arr = new Array(1.50);   
```  
  
 If a single value is passed to the `Array` constructor, and it is not a number, the `length` property is set to 1, and the value of the only element becomes the single, passed-in argument.  
  
```npl  
var arr = new Array("one");  
document.write(arr.length);  
document.write("<br/>");  
document.write(arr[0]);  
  
// Output:  
1  
one  
  
```  
  
 JavaScript arrays are sparse arrays, which means that not all the elements in an array may contain data. In JavaScript, only the elements that actually contain data exist in the array. This reduces the amount of memory used by the array.  
  
## Requirements  
 [!INCLUDE[jsv2](../../javascript/reference/includes/jsv2-md.md)]  
  
 Some members in the following lists were introduced in later versions. For more information, see [Version Information](../../javascript/reference/javascript-version-information.md) or the documentation for the individual members.  
  
## Properties  
 The following table lists the properties of the `Array` object.  
  
|Property|Description|  
|--------------|-----------------|  
|[constructor Property](../../javascript/reference/constructor-property-array.md)|Specifies the function that creates an array.|  
|[length Property (Array)](../../javascript/reference/length-property-array-javascript.md)|Returns an integer value that is one higher than the highest element defined in an array.|  
|[prototype Property](../../javascript/reference/prototype-property-array.md)|Returns a reference to the prototype for an array.|  
  
## Functions  
 The following table describes the functions of the `Array` object.  
  
|Function|Description|  
|--------------|-----------------|  
|[Array.from Function](../../javascript/reference/array-from-function-array-javascript.md)|Returns an array from an array-like or iterable object.|  
|[Array.isArray Function](../../javascript/reference/array-isarray-function-javascript.md)|Returns a Boolean value that indicates whether an object is an array.|  
|[Array.of Function](../../javascript/reference/array-of-function-array-javascript.md)|Returns an array from the passed in arguments.|  
  
<a name="js56jsobjarraymeth"></a>   
## Methods  
 The following table lists the methods of the `Array` object.  
  
|Method|Description|  
|------------|-----------------|  
|[concat Method (Array)](../../javascript/reference/concat-method-array-javascript.md)|Returns a new array consisting of a combination of two arrays.|  
|[entries Method](../../javascript/reference/entries-method-array-javascript.md)|Returns an iterator that contains the key/value pairs of the array.|  
|[every Method](../../javascript/reference/every-method-array-javascript.md)|Checks whether a defined callback function returns `true` for all elements in an array.|  
|[fill Method](../../javascript/reference/fill-method-array-javascript.md)|Populates an array with a specified value.|  
|[filter Method](../../javascript/reference/filter-method-array-javascript.md)|Calls a defined callback function on each element of an array, and returns an array of values for which the callback function returns `true`.|  
|[findIndex Method](../../javascript/reference/findindex-method-array-javascript.md)|Returns an index value for the first array element that meets test criteria specified in a callback function.|  
|[forEach Method](../../javascript/reference/foreach-method-array-javascript.md)|Calls a defined callback function for each element in an array.|  
|[hasOwnProperty Method](../../javascript/reference/hasownproperty-method-object-javascript.md)|Returns a Boolean value that indicates whether an object has a property with the specified name.|  
|[indexOf Method (Array)](../../javascript/reference/indexof-method-array-javascript.md)|Returns the index of the first occurrence of a value in an array.|  
|[isPrototypeOf Method](../../javascript/reference/isprototypeof-method-object-javascript.md)|Returns a Boolean value that indicates whether an object exists in another object's prototype chain.|  
|[join Method](../../javascript/reference/join-method-array-javascript.md)|Returns a `String` object consisting of all the elements of an array concatenated together.|  
|[keys Method](../../javascript/reference/keys-method-array-javascript.md)|Returns an iterator that contains the index values of the array.|  
|[lastIndexOf Method (Array)](../../javascript/reference/lastindexof-method-array-javascript.md)|Returns the index of the last occurrence of a specified value in an array.|  
|[map Method](../../javascript/reference/map-method-array-javascript.md)|Calls a defined callback function on each element of an array, and returns an array that contains the results.|  
|[pop Method](../../javascript/reference/pop-method-array-javascript.md)|Removes the last element from an array and returns it.|  
|[propertyIsEnumerable Method](../../javascript/reference/propertyisenumerable-method-object-javascript.md)|Returns a Boolean value that indicates whether a specified property is part of an object and whether it is enumerable.|  
|[push Method](../../javascript/reference/push-method-array-javascript.md)|Appends new elements to an array, and returns the new length of the array.|  
|[reduce Method](../../javascript/reference/reduce-method-array-javascript.md)|Accumulates a single result by calling a defined callback function for all elements in an array. The return value of the callback function is the accumulated result, and is provided as an argument in the next call to the callback function.|  
|[reduceRight Method](../../javascript/reference/reduceright-method-array-javascript.md)|Accumulates a single result by calling a defined callback function for all elements in an array, in descending order. The return value of the callback function is the accumulated result, and is provided as an argument in the next call to the callback function.|  
|[reverse Method](../../javascript/reference/reverse-method-javascript.md)|Returns an `Array` object with the elements reversed.|  
|[shift Method](../../javascript/reference/shift-method-array-javascript.md)|Removes the first element from an array and returns it.|  
|[slice Method (Array)](../../javascript/reference/slice-method-array-javascript.md)|Returns a section of an array.|  
|[some Method](../../javascript/reference/some-method-array-javascript.md)|Checks whether a defined callback function returns `true` for any element of an array.|  
|[sort Method](../../javascript/reference/sort-method-array-javascript.md)|Returns an `Array` object with the elements sorted.|  
|[splice Method](../../javascript/reference/splice-method-array-javascript.md)|Removes elements from an array and, if necessary, inserts new elements in their place, returning the deleted elements.|  
|[toLocaleString Method](../../javascript/reference/tolocalestring-method-object-javascript.md)|Returns a string using the current locale.|  
|[toString Method](../../javascript/reference/tostring-method-array.md)|Returns a string representation of an array.|  
|[unshift Method](../../javascript/reference/unshift-method-array-javascript.md)|Inserts new elements at the start of an array.|  
|[valueOf Method](../../javascript/reference/valueof-method-array.md)|Gets a reference to the array.|  
|[values Method](../../javascript/reference/values-method-array-javascript.md)|Returns an iterator that contains the values of the array.|  
  
## See Also  
 [Scrolling, panning, and zooming sample app](http://code.msdn.microsoft.com/ie/Scrolling-panning-and-6834aaf9)