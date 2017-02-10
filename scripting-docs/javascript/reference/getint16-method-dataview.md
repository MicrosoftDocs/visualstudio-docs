---
title: "getInt16 Method (DataView) | Microsoft Docs"
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
ms.assetid: d364cbe0-48a6-4350-a6ca-9f563d7ae571
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# getInt16 Method (DataView)
Gets the Int16 value at the specified byte offset from the start of the view. There is no alignment constraint; multi-byte values may be fetched from any offset.  
  
## Syntax  
  
```  
var testInt = dataView.getInt16(byteOffset, littleEndian);   
```  
  
## Parameters  
 `testInt`  
 Required. The Int16 value that is returned from the method.  
  
 `byteOffset`  
 The place in the buffer at which the value should be retrieved.  
  
 `littleEndian`  
 Optional. If false or undefined, a big-endian value should be read, otherwise a little-endian value should be read.  
  
## Remarks  
 These methods raise an exception if they would read beyond the end of the view.  
  
## Example  
 The following example shows how to get the first Int16 in the DataView.  
  
```javascript  
var req = new XMLHttpRequest();  
    req.open('GET', "http://www.example.com");  
    req.responseType = "arraybuffer";  
    req.send();  
  
    req.onreadystatechange = function () {  
        if (req.readyState === 4) {  
            var buffer = req.response;  
            var dataView = new DataView(buffer);  
            alert(dataView.getInt16(0));  
        }  
    }  
  
```  
  
## Requirements  
 [!INCLUDE[jsv10](../../javascript/reference/includes/jsv10-md.md)]