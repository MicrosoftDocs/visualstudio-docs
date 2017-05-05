---
title: "ArrayBuffer Object | Microsoft Docs"
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
ms.assetid: 9fda1261-f450-493b-b3db-ecfa9ca93cd7
caps.latest.revision: 17
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# ArrayBuffer Object
Represents a raw buffer of binary data, which is used to store data for the different typed arrays. `ArrayBuffers` cannot be read from or written to directly, but can be passed to a typed array or [DataView Object](../../javascript/reference/dataview-object.md) to interpret the raw buffer as needed.  
  
 For more information about typed arrays, see [Typed Arrays](../../javascript/advanced/typed-arrays-javascript.md).  
  
## Syntax  
  
```JavaScript  
  
arrayBuffer = new ArrayBuffer(length);  
```  
  
## Parameters  
 `arrayBuffer`  
 Required. The variable name to which the `ArrayBuffer` object is assigned.  
  
 `length`  
 The length of the buffer. The contents of the ArrayBuffer are initialized to 0. If the requested number of bytes could not be allocated an exception is raised.  
  
## Properties  
 The following table lists the properties of the `ArrayBuffer` object.  
  
|Property|Description|  
|--------------|-----------------|  
|[byteLength Property](../../javascript/reference/bytelength-property-arraybuffer.md)|Read-only. The length of the ArrayBuffer (in bytes).|  
  
## Functions  
 The following table lists the functions of the `ArrayBuffer` object.  
  
|Property|Description|  
|--------------|-----------------|  
|[ArrayBuffer.isView Function](../../javascript/reference/arraybuffer-isview-function-arraybuffer.md)|Determines whether an object provides a view of the buffer.|  
  
## Methods  
 The following table lists the methods of the `ArrayBuffer` object.  
  
|Property|Description|  
|--------------|-----------------|  
|[slice Method](../../javascript/reference/slice-method-arraybuffer.md)|Returns a section of an `ArrayBuffer`.|  
  
## Example  
 The following example shows how to use an ArrayBuffer object to process the binary data acquired from an [XMLHttpRequest](http://msdn.microsoft.com/library/ie/ms535874\(v=vs.85\).aspx). You can use a [DataView Object](../../javascript/reference/dataview-object.md) to get the individual values.  
  
```JavaScript  
var req = new XMLHttpRequest();  
    req.open('GET', "http://www.example.com");  
    req.responseType = "arraybuffer";  
    req.send();  
  
    req.onreadystatechange = function () {  
        if (req.readyState === 4) {  
            var buffer = req.response;  
            var dataview = new DataView(buffer);  
            var ints = new Int32Array(buffer.byteLength / 4);  
            for (var i = 0; i < ints.length; i++) {  
                ints[i] = dataview.getInt32(i * 4);  
            }  
        alert(ints[10]);  
        }  
    }  
  
```  
  
## Remarks  
 For more information about using `XmlHttpRequest`, see [XMLHttpRequest enhancements](http://msdn.microsoft.com/en-us/be09137c-6546-441b-b953-dcbf72b77069).  
  
## Requirements  
 [!INCLUDE[jsv10](../../javascript/reference/includes/jsv10-md.md)]