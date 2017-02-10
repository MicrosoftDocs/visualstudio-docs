---
title: "forEach Method (Set) (JavaScript) | Microsoft Docs"
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
ms.assetid: 813bff6e-6098-4260-ab6e-b0d2da6be94d
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# forEach Method (Set) (JavaScript)
Performs the specified action for each element in a set.  
  
## Syntax  
  
```javascript  
setObj.forEach(callbackfn[, thisArg])  
```  
  
#### Parameters  
 `setObj`  
 Required. A `Set` object.  
  
 `callbackfn`  
 Required. `callbackfn` accepts up to three arguments. The function that `forEach` calls one time for each element in the set.  
  
 `thisArg`  
 Optional. An object that the `this` keyword can refer to in the `callbackfn` function. If `thisArg` is omitted, `undefined` is used as the `this` value.  
  
## Exceptions  
 If the `callbackfn` argument is not a function object, a `TypeError` exception is thrown.  
  
## Remarks  
 The syntax of the callback function is as follows:  
  
 `function callbackfn(value, key, setObj)`  
  
 You can declare the callback function by using up to three parameters, as shown in the following table.  
  
|Callback argument|Definition|  
|-----------------------|----------------|  
|`value`|A value contained in the set.|  
|`key`|A value contained in the set. A set has no keys, so this value is the same as `value`.|  
|`setObj`|The `Set` object to traverse.|  
  
## Example  
 The following example shows how to use `forEach`. The `callbackfn` argument includes the code for the callback function.  
  
```javascript  
var s = new Set();  
  
s.add("scale");  
s.add(10);  
s.add("5");  
  
s.forEach(function(item, sameItem, s) {  
    document.write("Size of the set object is: " + s.size + "<br />");  
    document.write("Deleting item: " + item + "<br />");  
    s.delete(sameItem);  
});  
  
// Output:  
// Size of the set object is: 3  
// Deleting item: scale  
// Size of the set object is: 2  
// Deleting item: 10  
// Size of the set object is: 1  
// Deleting item: 5  
```  
  
## Example  
 The following example shows that you can also retrieve members from a set by passing only a single parameter to the callback function.  
  
```javascript  
var s = new Set();  
s.add("Thomas Jefferson");  
s.add(1776);  
s.add("founding father");  
  
s.forEach(function (item) {  
    document.write(item.toString() + ", ");  
});  
  
// Output:  
// Thomas Jefferson, 1776, founding father,  
  
```  
  
## Requirements  
 [!INCLUDE[jsv11](../../javascript/reference/includes/jsv11-md.md)]