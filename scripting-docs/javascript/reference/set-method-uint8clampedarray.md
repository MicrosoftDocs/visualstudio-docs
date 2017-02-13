---
title: "set Method (Uint8ClampedArray) | Microsoft Docs"
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
ms.assetid: 1298443d-5c4c-4329-9ad2-35e213dca157
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# set Method (Uint8ClampedArray)
Sets a value or an array of values.  
  
## Syntax  
  
```javascript  
uint8ClampedArray.set(index, value);  
uint8ClampedArray.set(array, offset);  
  
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
 If the input array is a typed array, the two arrays may use the same underlying [ArrayBuffer](../../javascript/reference/arraybuffer-object.md). In this situation, setting the values takes place as if all the data had first been copied into a temporary buffer that does not overlap either of the arrays, and then the data from the temporary buffer is copied into the current array.  
  
 If the offset plus the length of the given array is out of range for the current typed array, an exception is raised.  
  
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
            var intArr = new Uint8ClampedArray(buffer.byteLength);  
            intArr.set(0, 9);  
        }  
    }  
  
```  
  
## Requirements  
 [!INCLUDE[jsv11_winonly](../../javascript/reference/includes/jsv11-winonly-md.md)]  
  
## See Also  
 [ArrayBuffer Object](../../javascript/reference/arraybuffer-object.md)   
 [Uint8ClampedArray Object](../../javascript/reference/uint8clampedarray-object-javascript.md)