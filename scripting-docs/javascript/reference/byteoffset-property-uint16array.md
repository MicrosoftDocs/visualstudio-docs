---
title: "byteOffset Property (Uint16Array) | Microsoft Docs"
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
ms.assetid: f7a97ea9-5f1d-466d-82cd-79fd8ab95771
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# byteOffset Property (Uint16Array)
Read-only. The offset of this array from the start of its ArrayBuffer, in bytes, as fixed at construction time.  
  
## Syntax  
  
```JavaScript  
var arrayOffset = uint16Array.byteOffset;  
```  
  
## Example  
 The following example shows how to get the offset of the array.  
  
```JavaScript  
var req = new XMLHttpRequest();  
    req.open('GET', "http://www.example.com");  
    req.responseType = "arraybuffer";  
    req.send();  
  
    req.onreadystatechange = function () {  
        if (req.readyState === 4) {  
            var buffer = req.response;  
            var dataView = new DataView(buffer);  
            var intArr = new Uint16Array(buffer.byteLength / 2);  
            alert(intArr.byteOffset);  
        }  
    }  
  
```  
  
## Requirements  
 [!INCLUDE[jsv10](../../javascript/reference/includes/jsv10-md.md)]