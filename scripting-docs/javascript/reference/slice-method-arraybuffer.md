---
title: "slice Method (ArrayBuffer) | Microsoft Docs"
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
ms.assetid: 2dcc51ff-f444-4d51-80ba-3bcd845ba0ae
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# slice Method (ArrayBuffer)
Returns a section of an [ArrayBuffer](../../javascript/reference/arraybuffer-object.md).  
  
## Syntax  
  
```  
arrayBufferObj.slice(start, [end])   
```  
  
## Parameters  
 `arrayBufferObj`  
 Required. The [ArrayBuffer](../../javascript/reference/arraybuffer-object.md) object the section will be copied from.  
  
 `start`  
 Required. The byte index of the beginning of the section to be copied.  
  
 `end`  
 Optional. The byte index of the end of the section to be copied.  
  
## Remarks  
 The `slice` method returns an [ArrayBuffer](../../javascript/reference/arraybuffer-object.md) object that contains the specified portion of `arrayBufferObj`.  
  
 The `slice` method copies up to, but not including, the byte indicated by `end`. If `start` or `end` is negative, the specified index is treated as `length` + `start` or `end`, respectively, where `length` is the length of the [ArrayBuffer](../../javascript/reference/arraybuffer-object.md). If `end` is omitted, extraction continues to the end of `arrayBufferObj`. If `end` occurs before `start`, no bytes are copied to the new [ArrayBuffer](../../javascript/reference/arraybuffer-object.md).  
  
## Example  
 The following examples show how to use the `slice` method.  
  
```JavaScript  
var req = new XMLHttpRequest();  
    req.open('GET', "http://www.example.com");  
    req.responseType = "arraybuffer";  
    req.send();  
  
    req.onreadystatechange = function () {  
        if (req.readyState === 4) {  
            var buffer1 = req.response;  
            var buffer2 = buffer1.slice(40, 48);  
            var dataview = new DataView(buffer2);  
            var ints = new Int32Array(buffer2.byteLength / 4);  
            for (var i = 0; i < ints.length; i++) {  
                ints[i] = dataview.getInt32(i * 4);  
            }  
        alert(ints[1]);  
        }  
    }  
```  
  
## Requirements  
 [!INCLUDE[jsv11_winonly](../../javascript/reference/includes/jsv11-winonly-md.md)]  
  
## See Also  
 [ArrayBuffer Object](../../javascript/reference/arraybuffer-object.md)