---
title: "byteOffset Property (Uint8ClampedArray) | Microsoft Docs"
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
ms.assetid: bfc22cf4-00e3-4e2c-8419-032b179aa8da
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# byteOffset Property (Uint8ClampedArray)
Read-only. The offset of this array from the start of its [ArrayBuffer](../../javascript/reference/arraybuffer-object.md), in bytes, as fixed at construction time.  
  
## Syntax  
  
```javascript  
var arrayOffset = uint8ClampedArray.byteOffset;  
```  
  
## Example  
 The following example shows how to get the offset of the array.  
  
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
            alert(intArr.byteOffset);  
        }  
    }  
  
```  
  
## Requirements  
 [!INCLUDE[jsv11_winonly](../../javascript/reference/includes/jsv11-winonly-md.md)]  
  
## See Also  
 [ArrayBuffer Object](../../javascript/reference/arraybuffer-object.md)   
 [Uint8ClampedArray Object](../../javascript/reference/uint8clampedarray-object-javascript.md)