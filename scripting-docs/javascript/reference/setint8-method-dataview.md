---
title: "setInt8 Method (DataView) | Microsoft Docs"
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
ms.assetid: 0a0e1450-e0c4-4778-8706-4d332442d882
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# setInt8 Method (DataView)
Stores an Int8 value at the specified byte offset from the start of the view.  
  
## Syntax  
  
```  
dataView.setInt8(byteOffset, value);   
```  
  
## Parameters  
 `byteOffset`  
 The place in the buffer at which the value should be set.  
  
 `value`  
 The value to set.  
  
## Remarks  
 These methods raise an exception if they would write beyond the end of the view.  
  
## Example  
 The following example shows how to set the first Int8 in the DataView.  
  
```javascript  
var req = new XMLHttpRequest();  
    req.open('GET', "http://www.example.com");  
    req.responseType = "arraybuffer";  
    req.send();  
  
    req.onreadystatechange = function () {  
        if (req.readyState === 4) {  
            var buffer = req.response;  
            var dataView = new DataView(buffer);  
            dataView.setInt8(0, 9);  
        }  
    }  
  
```  
  
## Requirements  
 [!INCLUDE[jsv10](../../javascript/reference/includes/jsv10-md.md)]