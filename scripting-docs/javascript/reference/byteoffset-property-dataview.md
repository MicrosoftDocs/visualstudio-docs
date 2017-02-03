---
title: "byteOffset Property (DataView) | Microsoft Docs"
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
ms.assetid: 3b3e68bc-1476-4a32-a18d-6efa375bce0f
caps.latest.revision: 6
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# byteOffset Property (DataView)
Read-only. The offset of this view from the start of its ArrayBuffer, in bytes, as fixed at construction time.  
  
## Syntax  
  
```javascript  
var arrayOffset = dataView.byteOffset;  
```  
  
## Example  
 The following example shows how to get the length of a DataView.  
  
```javascript  
var req = new XMLHttpRequest();  
    req.open('GET', "http://www.example.com");  
    req.responseType = "arraybuffer";  
    req.send();  
  
    req.onreadystatechange = function () {  
        if (req.readyState === 4) {  
            var buffer = req.response;  
            var dataView = new DataView(buffer);  
            alert(dataView.byteOffset)  
        }  
    }  
  
```  
  
## Requirements  
 [!INCLUDE[jsv10](../../javascript/reference/includes/jsv10-md.md)]