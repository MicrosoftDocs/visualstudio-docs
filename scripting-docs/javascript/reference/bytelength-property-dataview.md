---
title: "byteLength Property (DataView) | Microsoft Docs"
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
ms.assetid: 6274285f-b673-48f6-a1e7-89ff7ee348b5
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# byteLength Property (DataView)
Read-only. The length of this view from the start of its ArrayBuffer, in bytes, as fixed at construction time.  
  
## Syntax  
  
```javascript  
var byteLength = dataView.byteLength;  
```  
  
## Example  
 The following example shows how get the length of a DataView from an XMLHttpRequest.  
  
```javascript  
var req = new XMLHttpRequest();  
    req.open('GET', "http://www.example.com");  
    req.responseType = "arraybuffer";  
    req.send();  
  
    req.onreadystatechange = function () {  
        if (req.readyState === 4) {  
            var buffer = req.response;  
            var dataView = new DataView(buffer);  
            alert(dataView.byteLength);  
        }  
    }  
  
```  
  
## Requirements  
 [!INCLUDE[jsv10](../../javascript/reference/includes/jsv10-md.md)]