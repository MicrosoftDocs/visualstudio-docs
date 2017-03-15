---
title: "for...in Statement (JavaScript) | Microsoft Docs"
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
  - "iteration statements, for...in statement"
  - "loop structures, for...in statements"
ms.assetid: 1b51a0ce-89f7-4a69-88ed-017b47dc398f
caps.latest.revision: 20
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# for...in Statement (JavaScript)
Executes one or more statements for each property of an object, or each element of an array.  
  
## Syntax  
  
```  
for (variable in [object | array]) {  
    statements   
}  
```  
  
## Parameters  
 `variable`  
 Required. A variable that can be any property name of `object` or any element index of an `array`.  
  
 `object`, `array`  
 Optional. An object or array over which to iterate.  
  
 `statements`  
 Optional. One or more statements to be executed for each property of `object` or each element of `array`. Can be a compound statement.  
  
## Remarks  
 At the beginning of each iteration of a loop, the value of `variable` is the next property name of `object` or the next element index of `array`. You can then use `variable` in any of the statements inside the loop to reference the property of `object` or the element of `array`.  
  
 The properties of an object are not assigned in a determinate manner. You cannot specify a particular property by its index, only by the name of the property.  
  
 Iterating through an array is performed in element order, that is, 0, 1, 2.  
  
## Example  
 The following example illustrates the use of the `for...in` statement with an object used as an associative array.  
  
```JavaScript  
// Initialize object.  
a = {"a" : "Athens" , "b" : "Belgrade", "c" : "Cairo"}  
  
// Iterate over the properties.  
var s = ""  
for (var key in a) {  
    s += key + ": " + a[key];  
    s += "<br />";  
    }  
document.write (s);  
  
// Output:  
// a: Athens  
// b: Belgrade  
// c: Cairo  
```  
  
## Example  
 This example illustrates the use of the `for ... in` statement to iterate though an `Array` object that has expando properties.  
  
```JavaScript  
// Initialize the array.  
var arr = new Array("zero","one","two");  
  
// Add a few expando properties to the array.  
arr["orange"] = "fruit";  
arr["carrot"] = "vegetable";  
  
// Iterate over the properties and elements.  
var s = "";  
for (var key in arr) {  
    s += key + ": " + arr[key];  
    s += "<br />";  
}  
  
document.write (s);  
  
// Output:  
//   0: zero  
//   1: one  
//   2: two  
//   orange: fruit  
//   carrot: vegetable  
```  
  
> [!NOTE]
>  Use the `Enumerator` object to iterate over the members of a collection.  
  
## Requirements  
 [!INCLUDE[jsv5](../../javascript/reference/includes/jsv5-md.md)]  
  
## See Also  
 [for Statement](../../javascript/reference/for-statement-javascript.md)   
 [while Statement](../../javascript/reference/while-statement-javascript.md)