---
title: "set Method (Float64Array) | Microsoft Docs"
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
ms.assetid: 694965e6-503d-4aaa-8340-63455e96ddf6
caps.latest.revision: 10
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# set Method (Float64Array)
Sets a value or an array of values.  
  
## Syntax  
  
```javascript  
float64Array.set(index, value);  
float64Array.set(array, offset);  
  
```  
  
## Parameters  
 `index`  
 The index of the location to set.  
  
 `value`  
 The value to set.  
  
 `array`  
 A typed or untyped array of values to set.  
  
 `offset`  
 The index in the current array at which the values are to be written.  
  
## Remarks  
 If the input array is a TypedArray, the two arrays may use the same underlying ArrayBuffer. In this situation, setting the values takes place as if all the data is first copied into a temporary buffer that does not overlap either of the arrays, and then the data from the temporary buffer is copied into the current array.  
  
 If the offset plus the length of the given array is out of range for the current TypedArray, an exception is raised.  
  
## Example  
 The following example shows how to set the first element of the array.  
  
```javascript  
var req = new XMLHttpRequest();  
    req.open('GET', "http://www.example.com");  
    req.responseType = "arraybuffer";  
    req.send();  
  
    req.onreadystatechange = function () {  
        if (req.readyState === 4) {  
            var buffer = req.response;  
            var dataView = new DataView(buffer);  
            var floatArr = new Float64Array(buffer.byteLength / 8);  
            floatArr.set(0, 9.1);  
        }  
    }  
  
```  
  
## Requirements  
 [!INCLUDE[jsv10](../../javascript/reference/includes/jsv10-md.md)]