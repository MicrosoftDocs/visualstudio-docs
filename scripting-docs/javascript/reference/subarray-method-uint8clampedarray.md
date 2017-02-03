---
title: "subarray Method (Uint8ClampedArray) | Microsoft Docs"
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
ms.assetid: 309ed9e8-5805-47ab-b3ed-501cae1323dd
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# subarray Method (Uint8ClampedArray)
Gets a new [Uint8ClampedArray](../../javascript/reference/uint8array-object.md) view of the [ArrayBuffer](../../javascript/reference/arraybuffer-object.md) store for this array, specifying the first and last members of the subarray.  
  
## Syntax  
  
```javascript  
var newUint8ClampedArray = uint8ClampedArray.subarray(begin, end);  
```  
  
## Parameters  
 `newUint8ClampedArray`  
 Required. The subarray returned by this method.  
  
 `begin`  
 Optional. The index of the beginning of the array.  
  
 `end`  
 Optional. The index of the end of the array. This is non-inclusive.  
  
## Remarks  
 If either `begin` or `end` is negative, it refers to an index from the end of the array, as opposed to from the beginning. If `end` is unspecified, the subarray contains all elements from `begin` to the end of the typed array. The range specified by the `begin` and `end` values is clamped to the valid index range for the current array. If the computed length of the new typed array would be negative, it is clamped to zero. The returned array has the same type as the array on which this method is invoked.  
  
## Example  
 The following example shows how to get a subarray that is two elements long, starting with the first element of the array.  
  
```javascript  
var req = new XMLHttpRequest();  
    req.open('GET', "http://www.example.com");  
    req.responseType = "arraybuffer";  
    req.send();  
  
    req.onreadystatechange = function () {  
        if (req.readyState === 4) {  
            var buffer = req.response;  
            var intArr = new Uint8ClampedArray(buffer.byteLength);  
            var subArr = intArr.subarray(0, 2);  
        }  
    }  
  
```  
  
## Requirements  
 [!INCLUDE[jsv11_winonly](../../javascript/reference/includes/jsv11-winonly-md.md)]  
  
## See Also  
 [Uint8Array Object](../../javascript/reference/uint8array-object.md)   
 [ArrayBuffer Object](../../javascript/reference/arraybuffer-object.md)   
 [Uint8ClampedArray Object](../../javascript/reference/uint8clampedarray-object-javascript.md)