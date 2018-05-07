---
title: "setUint8 Method (DataView) | Microsoft Docs"
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
ms.assetid: b294262b-3f4b-4183-a292-5a6982cbdd27
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# setUint8 Method (DataView)
Stores a Uint8 value at the specified byte offset from the start of the view.  
  
## Syntax  
  
```  
dataView.setUint8(byteOffset, value);   
```  
  
## Parameters  
 `byteOffset`  
 The place in the buffer at which the value should be set.  
  
 `value`  
 The value to set.  
  
## Remarks  
 These methods raise an exception if they would write beyond the end of the view.  
  
## Example  
 The following example shows how to set the first Uint8 in the DataView.  
  
```JavaScript  
var req = new XMLHttpRequest();  
    req.open('GET', "http://www.example.com");  
    req.responseType = "arraybuffer";  
    req.send();  
  
    req.onreadystatechange = function () {  
        if (req.readyState === 4) {  
            var buffer = req.response;  
            var dataView = new DataView(buffer);  
            dataView.setUint8(0, 9);  
        }  
    }  
  
```  
  
## Requirements  
 [!INCLUDE[jsv10](../../javascript/reference/includes/jsv10-md.md)]