---
title: "forEach Method (Map) (JavaScript) | Microsoft Docs"
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
ms.assetid: 9cdf0adc-77c7-4407-8ba7-ada0fb09e507
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# forEach Method (Map) (JavaScript)
Performs the specified action for each element in a map.  
  
## Syntax  
  
```JavaScript  
mapObj.forEach(callbackfn[, thisArg])  
```  
  
#### Parameters  
 `mapObj`  
 Required. A `Map` object.  
  
 `callbackfn`  
 Required. The function that `forEach` calls one time for each element in the map. `callbackfn` accepts up to three arguments. `forEach` calls the `callbackfn` function one time for each element in the map.  
  
 `thisArg`  
 Optional. An object that the `this` keyword can refer to in the `callbackfn` function. If `thisArg` is omitted, `undefined` is used as the `this` value.  
  
## Exceptions  
 If the `callbackfn` argument is not a function object, a `TypeError` exception is thrown.  
  
## Remarks  
 The syntax of the callback function is as follows:  
  
 `function callbackfn(value, key, mapObj)`  
  
 You can declare the callback function by using up to three parameters, as shown in the following table.  
  
|Callback argument|Definition|  
|-----------------------|----------------|  
|`value`|A value contained in the map.|  
|`key`|A key contained in the map.|  
|`mapObj`|The `Map` object to traverse.|  
  
## Example  
 The following example shows how to retrieve members of a `Map` using `forEach`.  
  
```JavaScript  
var m = new Map();  
m.set(1, "black");  
m.set(2, "red");  
m.set("colors", 2);  
m.set({x:1}, 3);  
  
m.forEach(function (value, key, mapObj) {  
    document.write(value.toString() + "<br />");  
});  
  
document.write("<br />");  
document.write(m.get(2));  
  
// Output:  
// black  
// red  
// 2  
// 3  
//  
// red  
  
```  
  
## Requirements  
 [!INCLUDE[jsv11](../../javascript/reference/includes/jsv11-md.md)]
