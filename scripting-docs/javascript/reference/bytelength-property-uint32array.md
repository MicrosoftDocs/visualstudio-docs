---
title: "byteLength Property (UInt32Array) | Microsoft Docs"
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
ms.assetid: 22c4fa81-4131-4f2c-9281-5087c4abb456
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# byteLength Property (UInt32Array)
Read-only. The length of this array from the start of its ArrayBuffer, in bytes, as fixed at construction time.  
  
## Syntax  
  
```javascript  
var arrayByteLength = uint32Array.byteLength;  
```  
  
## Example  
 The following example shows how to get the length of the array.  
  
```javascript  
var req = new XMLHttpRequest();  
    req.open('GET', "http://www.example.com");  
    req.responseType = "arraybuffer";  
    req.send();  
  
    req.onreadystatechange = function () {  
        if (req.readyState === 4) {  
            var buffer = req.response;  
            var dataView = new DataView(buffer);  
            var intArr = new Uint32Array(buffer.byteLength / 4);  
            alert(intArr.byteLength);  
        }  
    }  
  
```  
  
## Requirements  
 [!INCLUDE[jsv10](../../javascript/reference/includes/jsv10-md.md)]