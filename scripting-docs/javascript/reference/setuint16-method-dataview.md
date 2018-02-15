---
title: "setUint16 Method (DataView) | Microsoft Docs"
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
ms.assetid: bdf47cda-7fa5-4aaa-8aa2-8cf9a8d56cb3
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# setUint16 Method (DataView)
Sets the Uint16 value at the specified byte offset from the start of the view. There is no alignment constraint; multi-byte values may be set at any offset.  
  
## Syntax  
  
```  
dataView.setUint16(byteOffset, value, littleEndian);   
```  
  
## Parameters  
 `testInt`  
 Required. The Uint16 value that is returned from the method.  
  
 `value`  
 The value to set.  
  
 `byteOffset`  
 The place in the buffer at which the value should be retrieved.  
  
 `littleEndian`  
 Optional. If false or undefined, a big-endian value should be written, otherwise a little-endian value should be written.  
  
## Remarks  
 These methods raise an exception if they would write beyond the end of the view.  
  
## Example  
 The following example shows how to set the first Uint16 in the DataView.  
  
```JavaScript  
var req = new XMLHttpRequest();  
    req.open('GET', "http://www.example.com");  
    req.responseType = "arraybuffer";  
    req.send();  
  
    req.onreadystatechange = function () {  
        if (req.readyState === 4) {  
            var buffer = req.response;  
            var dataView = new DataView(buffer);  
            dataView.setUint16(0, 9);  
        }  
    }  
  
```  
  
## Requirements  
 [!INCLUDE[jsv10](../../javascript/reference/includes/jsv10-md.md)]