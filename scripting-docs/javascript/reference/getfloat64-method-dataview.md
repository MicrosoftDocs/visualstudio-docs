---
title: "getFloat64 Method (DataView) | Microsoft Docs"
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
ms.assetid: 347adeb6-b24c-4e7d-8b6b-8e36aacdcae1
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# getFloat64 Method (DataView)
Gets the Float64 value at the specified byte offset from the start of the view. There is no alignment constraint; multi-byte values may be fetched from any offset.  
  
## Syntax  
  
```  
var testFloat = dataView.getFloat64(byteOffset, littleEndian);   
```  
  
## Parameters  
 `testFloat`  
 Required. The Float64 value that is returned from the method.  
  
 `byteOffset`  
 The place in the buffer at which the value should be retrieved.  
  
 `littleEndian`  
 Optional. If false or undefined, a big-endian value should be read, otherwise a little-endian value should be read.  
  
## Remarks  
 These methods raise an exception if they would read beyond the end of the view.  
  
## Example  
 The following example shows how to get the first Float64 in the DataView.  
  
```JavaScript  
var req = new XMLHttpRequest();  
    req.open('GET', "http://www.example.com");  
    req.responseType = "arraybuffer";  
    req.send();  
  
    req.onreadystatechange = function () {  
        if (req.readyState === 4) {  
            var buffer = req.response;  
            var dataView = new DataView(buffer);  
            alert(dataView.getFloat64(0));  
        }  
    }  
  
```  
  
## Requirements  
 [!INCLUDE[jsv10](../../javascript/reference/includes/jsv10-md.md)]