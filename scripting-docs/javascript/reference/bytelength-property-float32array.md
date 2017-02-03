---
title: "byteLength Property (Float32Array) | Microsoft Docs"
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
ms.assetid: ea55beb2-e79f-4706-bcc9-6fdbf89e0fe9
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# byteLength Property (Float32Array)
Read-only. The length of this array from the start of its ArrayBuffer, in bytes, as fixed at construction time.  
  
## Syntax  
  
```javascript  
var arrayByteLength = float32Array.byteLength;  
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
            var floatArr = new Float32Array(buffer.byteLength) / 4);  
            alert(floatArr.byteLength);  
        }  
    }  
  
```  
  
## Requirements  
 [!INCLUDE[jsv10](../../javascript/reference/includes/jsv10-md.md)]