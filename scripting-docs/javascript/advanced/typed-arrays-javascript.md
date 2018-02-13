---
title: "Typed Arrays (JavaScript) | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-javascript"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
ms.assetid: fa82c562-0ebf-4559-aecc-166e59f7fb64
caps.latest.revision: 14
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Typed Arrays (JavaScript)
You can use typed arrays to handle binary data from sources such as network protocols, binary file formats, and raw graphics buffers. Typed arrays can also be used to manage in-memory binary data with well-known byte layouts.  
  
## Example  
 The following code shows how to use an [ArrayBuffer Object](../../javascript/reference/arraybuffer-object.md) as the response of an [XMLHttpRequest](http://msdn.microsoft.com/library/ie/ms535874\(v=vs.85\).aspx). You can manipulate the bytes in the response by using the different methods of the [DataView Object](../../javascript/reference/dataview-object.md), or by copying the bytes into the appropriate typed array.  
  
> [!TIP]
>  For more information about using different response types with an `XmlHttpRequest`, see [XMLHttpRequest.responseType](http://msdn.microsoft.com/en-us/8d7738d1-4bfd-4cf1-8015-174def089556), [XMLHttpRequest enhancements](http://msdn.microsoft.com/en-us/be09137c-6546-441b-b953-dcbf72b77069), and [Downloading different types of content (Windows Store apps)](http://msdn.microsoft.com/en-us/c0006bbd-17f9-4c6a-af81-2acaf109111d).  
  
```JavaScript  
...  
<div id="xhrDiv"></div>  
...  
var name = "http://www.microsoft.com";  
var xhrDiv = document.getElementById("xhrDiv");  
  
var req = new XMLHttpRequest();  
req.open("GET", name, true);  
req.responseType = "arraybuffer";  
req.onreadystatechange = function () {  
if (req.readyState == req.DONE) {  
    var arrayResponse = req.response;  
    var dataView = new DataView(arrayResponse);  
    var ints = new Uint32Array(dataView.byteLength / 4);  
  
    xhrDiv.style.backgroundColor = "#00FF00";  
    xhrDiv.innerText = "Array is " + ints.length + "uints long";  
    }  
}  
req.send();  
```  
  
## ArrayBuffer  
 An [ArrayBuffer Object](../../javascript/reference/arraybuffer-object.md) represents a buffer of raw data that is used to store data for the different typed arrays. You cannot read from or write to an `ArrayBuffer`, but you can pass it to a typed array or [DataView Object](../../javascript/reference/dataview-object.md) to interpret the raw buffer. You can use an `ArrayBuffer` to store any kind of data (or mixed types of data).  
  
## DataView  
 You can use a [DataView Object](../../javascript/reference/dataview-object.md) to read and write the different kinds of binary data to any location in the `ArrayBuffer`.  
  
## Typed Arrays  
 The typed array types represent views of an [ArrayBuffer Object](../../javascript/reference/arraybuffer-object.md) that can be indexed and manipulated. All array types are of fixed length.  
  
||||  
|-|-|-|  
|Name|Size (in bytes)|Description|  
|[Int8Array Object](../../javascript/reference/int8array-object.md)|1|Eight-bit two's complement signed integer|  
|[Uint8Array Object](../../javascript/reference/uint8array-object.md)|1|Eight-bit unsigned integer|  
|[Int16Array Object](../../javascript/reference/int16array-object.md)|2|Sixteen-bit two's complement signed integer|  
|[Uint16Array Object](../../javascript/reference/uint16array-object.md)|2|Sixteen-bit unsigned integer|  
|[Int32Array Object](../../javascript/reference/int32array-object.md)|4|Thirty-two-bit two's complement signed integer|  
|[Uint32Array Object](../../javascript/reference/uint32array-object.md)|4|Thirty-two-bit unsigned integer|  
|[Float32Array Object](../../javascript/reference/float32array-object.md)|4|Thirty-two-bit IEEE floating point|  
|[Float64Array Object](../../javascript/reference/float64array-object.md)|8|Sixty-four-bit IEEE floating point|