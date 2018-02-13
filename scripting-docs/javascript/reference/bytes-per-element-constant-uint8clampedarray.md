---
title: "BYTES_PER_ELEMENT Constant (Uint8ClampedArray) | Microsoft Docs"
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
ms.assetid: f9fb2a10-9faf-4534-9183-dad2984e74ff
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# BYTES_PER_ELEMENT Constant (Uint8ClampedArray)
The size, in bytes, of each element in the array.  
  
## Syntax  
  
```JavaScript  
var arraySize = uint8ClampedArray.BYTES_PER_ELEMENT;  
```  
  
## Example  
 The following example shows how to get the size of the array elements.  
  
```JavaScript  
var req = new XMLHttpRequest();  
    req.open('GET', "http://www.example.com");  
    req.responseType = "arraybuffer";  
    req.send();  
  
    req.onreadystatechange = function () {  
        if (req.readyState === 4) {  
            var buffer = req.response;  
            var dataView = new DataView(buffer);  
            var intArr = new Uint8ClampedArray(buffer.byteLength);  
            alert(intArr.BYTES_PER_ELEMENT);  
        }  
    }  
  
```  
  
## Requirements  
 [!INCLUDE[jsv11_winonly](../../javascript/reference/includes/jsv11-winonly-md.md)]  
  
## See Also  
 [Uint8ClampedArray Object](../../javascript/reference/uint8clampedarray-object-javascript.md)