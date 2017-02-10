---
title: "getUint16 Method (DataView) | Microsoft Docs"
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
ms.assetid: 3c0d9ad8-30b0-42a3-b0fe-aa805398c396
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# getUint16 Method (DataView)
Gets the Uint16 value at the specified byte offset from the start of the view. There is no alignment constraint; multi-byte values may be fetched from any offset.  
  
## Syntax  
  
```  
var testInt = dataView.getUint16(byteOffset, littleEndian);   
```  
  
## Parameters  
 `testInt`  
 Required. The Uint16 value that is returned from the method.  
  
 `byteOffset`  
 The place in the buffer at which the value should be retrieved.  
  
 `littleEndian`  
 Optional. If false or undefined, a big-endian value should be read, otherwise a little-endian value should be read.  
  
## Remarks  
 These methods raise an exception if they would read beyond the end of the view.  
  
## Example  
 The following example shows how to get the first Uint16 in the DataView.  
  
```javascript  
var req = new XMLHttpRequest();  
    req.open('GET', "http://www.example.com");  
    req.responseType = "arraybuffer";  
    req.send();  
  
    req.onreadystatechange = function () {  
        if (req.readyState === 4) {  
            var buffer = req.response;  
            var dataView = new DataView(buffer);  
            alert(dataView.getUint16(0));  
        }  
    }  
  
```  
  
## Requirements  
 [!INCLUDE[jsv10](../../javascript/reference/includes/jsv10-md.md)]