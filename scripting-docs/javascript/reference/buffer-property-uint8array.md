---
title: "buffer Property (Uint8Array) | Microsoft Docs"
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
ms.assetid: bb10f4db-d9a0-4f94-9497-a8719c94a717
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# buffer Property (Uint8Array)
Read-only. Gets the ArrayBuffer that is referenced by this array.  
  
## Syntax  
  
```javascript  
var arrayBuffer = uint8Array.buffer;  
```  
  
## Example  
 The following example shows how to get the ArrayBuffer of the array.  
  
```javascript  
var req = new XMLHttpRequest();  
    req.open('GET', "http://www.example.com");  
    req.responseType = "arraybuffer";  
    req.send();  
  
    req.onreadystatechange = function () {  
        if (req.readyState === 4) {  
            var buffer = req.response;  
            var dataView = new DataView(buffer);  
            var intArr = new Uint8Array(buffer.byteLength);  
            alert(intArr.buffer.byteLength);  
        }  
    }  
  
```  
  
## Requirements  
 [!INCLUDE[jsv10](../../javascript/reference/includes/jsv10-md.md)]