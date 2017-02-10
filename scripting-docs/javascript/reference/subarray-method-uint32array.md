---
title: "subarray Method (Uint32Array) | Microsoft Docs"
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
ms.assetid: 4c183208-12ec-4051-bf0f-a4f7c112cea1
caps.latest.revision: 13
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# subarray Method (Uint32Array)
Gets a new Uint32Array view of the [ArrayBuffer Object](../../javascript/reference/arraybuffer-object.md) store for this array, specifying the first and last members of the subarray.  
  
## Syntax  
  
```javascript  
var newUint32Array = uint32Array.subarray(begin, end);  
```  
  
## Parameters  
 `newUint32Array`  
 The subarray returned by this method.  
  
 `begin`  
 The index of the beginning of the array.  
  
 `end`  
 The index of the end of the array. This is non-inclusive.  
  
## Remarks  
 If either `begin` or `end` is negative, it refers to an index from the end of the array, as opposed to from the beginning. If `end` is unspecified, the subarray contains all elements from `begin` to the end of the typed array. The range specified by the `begin` and `end` values is clamped to the valid index range for the current array. If the computed length of the new typed array would be negative, it is clamped to zero. The returned array is of the same type as the array on which this method is invoked.  
  
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
            var intArr = new Uint32Array(buffer.byteLength / 4);  
            var subArr = intArr.subarray(0, 2);  
        }  
    }  
  
```  
  
## Requirements  
 [!INCLUDE[jsv10](../../javascript/reference/includes/jsv10-md.md)]