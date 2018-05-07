---
title: "byteOffset Property (Int16Array) | Microsoft Docs"
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
ms.assetid: 3d61e936-7681-42b6-a22e-4c877cb062a5
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# byteOffset Property (Int16Array)
Read-only. The offset of this array from the start of its ArrayBuffer, in bytes, as fixed at construction time.  
  
## Syntax  
  
```JavaScript  
var arrayOffset = int16Array.byteOffset;  
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
            var intArr = new Int16Array(buffer.byteLength / 2);  
            alert(intArr.byteOffset);  
        }  
    }  
  
```  
  
## Requirements  
 [!INCLUDE[jsv10](../../javascript/reference/includes/jsv10-md.md)]