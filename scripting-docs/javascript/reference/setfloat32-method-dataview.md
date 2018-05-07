---
title: "setFloat32 Method (DataView) | Microsoft Docs"
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
ms.assetid: b3f68048-c817-48d2-bc17-945e3bcc94d7
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# setFloat32 Method (DataView)
Sets the Float32 value at the specified byte offset from the start of the view. There is no alignment constraint; multi-byte values may be set at any offset.  
  
## Syntax  
  
```  
dataView.setFloat32 (byteOffset, value, littleEndian);   
```  
  
## Parameters  
 `byteOffset`  
 The place in the buffer at which the value should be retrieved.  
  
 `value`  
 The value to set.  
  
 `littleEndian`  
 Optional. If false or undefined, a big-endian value should be written, otherwise a little-endian value should be written.  
  
## Remarks  
 These methods raise an exception if they would write beyond the end of the view.  
  
## Example  
 The following example shows how to set the first Float32 in the DataView.  
  
```JavaScript  
var req = new XMLHttpRequest();  
    req.open('GET', "http://www.example.com");  
    req.responseType = "arraybuffer";  
    req.send();  
  
    req.onreadystatechange = function () {  
        if (req.readyState === 4) {  
            var buffer = req.response;  
            var dataView = new DataView(buffer);  
            dataView.setFloat32(0, 9.1);  
        }  
    }  
  
```  
  
## Requirements  
 [!INCLUDE[jsv10](../../javascript/reference/includes/jsv10-md.md)]