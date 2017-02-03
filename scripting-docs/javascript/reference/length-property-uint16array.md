---
title: "length Property (UInt16Array) | Microsoft Docs"
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
ms.assetid: dca1cbf3-3c40-4d33-b83d-4195c66ceb05
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# length Property (UInt16Array)
The length of the array.  
  
## Syntax  
  
```javascript  
var arrayLength = uint16Array.length;  
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
            var intArr = new Uint16Array(buffer.byteLength / 2);  
            alert(intArr.length);  
        }  
    }  
  
```  
  
## Requirements  
 [!INCLUDE[jsv10](../../javascript/reference/includes/jsv10-md.md)]