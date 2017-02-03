---
title: "BYTES_PER_ELEMENT Constant (Uint16Array) | Microsoft Docs"
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
ms.assetid: 4e5e8a70-f8b9-4e3c-b9f3-0d1249963c28
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# BYTES_PER_ELEMENT Constant (Uint16Array)
The size in bytes of each element in the array.  
  
## Syntax  
  
```javascript  
var arraySize = uint16Array.BYTES_PER_ELEMENT;  
```  
  
## Example  
 The following example shows how to get the size of the array elements.  
  
```javascript  
var req = new XMLHttpRequest();  
    req.open('GET', "http://www.example.com");  
    req.responseType = "arraybuffer";  
    req.send();  
  
    req.onreadystatechange = function () {  
        if (req.readyState === 4) {  
            var buffer = req.response;  
            var dataView = new DataView(buffer);  
            var intArr = new Uint16Array(buffer.byteLength / 2);  
            alert(intArr.BYTES_PER_ELEMENT);  
        }  
    }  
  
```  
  
## Requirements  
 [!INCLUDE[jsv10](../../javascript/reference/includes/jsv10-md.md)]