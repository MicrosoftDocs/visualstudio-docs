---
title: "Float32Array Object | Microsoft Docs"
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
ms.assetid: 4b29456a-1488-4006-ae66-5bf4c05003b1
caps.latest.revision: 17
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Float32Array Object
A typed array of 32-bit float values. The contents are initialized to 0. If the requested number of bytes could not be allocated an exception is raised.  
  
## Syntax  
  
```  
  
      float32Array = new Float32Array( length );  
float32Array = new Float32Array( array );  
float32Array = new Float32Array( buffer, byteOffset, length);  
```  
  
## Parameters  
 `float32Array`  
 Required. The variable name to which the **Float32Array** object is assigned.  
  
 `length`  
 Specifies the number of elements in the array.  
  
 `array`  
 The array (or typed array) that is contained in this array. The contents are initialized to the contents of the given array or typed array, with each element converted to the Float32 type.  
  
 `buffer`  
 The ArrayBuffer that the Float32Array represents.  
  
 `byteOffset`  
 Optional. Specifies the offset in bytes from the start of the buffer at which the Float32Array should begin.  
  
 `length`  
 The number of elements in the array.  
  
## Constants  
 The following table lists the constants of the `Float32Array`object.  
  
|Constant|Description|  
|--------------|-----------------|  
|[BYTES_PER_ELEMENT Constant](../../javascript/reference/bytes-per-element-constant-float32array.md)|The size in bytes of each element in the array.|  
  
## Properties  
 The following table lists the constants of the `Float32Array`object.  
  
|Property|Description|  
|--------------|-----------------|  
|[buffer Property](../../javascript/reference/buffer-property-float32array.md)|Read-only. Gets the ArrayBuffer that is referenced by this array.|  
|[byteLength Property](../../javascript/reference/bytelength-property-float32array.md)|Read-only. The length of this array from the start of its ArrayBuffer, in bytes, as fixed at construction time.|  
|[byteOffset Property](../../javascript/reference/byteoffset-property-float32array.md)|Read-only. The offset of this array from the start of its ArrayBuffer, in bytes, as fixed at construction time.|  
|[length Property](../../javascript/reference/length-property-float32array.md)|The length of the array.|  
|||  
  
## Methods  
 The following table lists the methods of the `Float32Array`object.  
  
|Method|Description|  
|------------|-----------------|  
|[get Method](../../javascript/reference/get-method-float32array.md)|Omittable. Gets the element at the specified index.|  
|[set Method (Float32Array)](../../javascript/reference/set-method-float32array.md)|Sets a value or an array of values.|  
|[subarray Method (Float32Array)](../../javascript/reference/subarray-method-float32array.md)|Gets a new Float32Array view of the ArrayBuffer store for this array.|  
  
## Example  
 The following example shows how to use a Float32Array object to process the binary data acquired from an XmlHttpRequest:  
  
```JavaScript  
var req = new XMLHttpRequest();  
    req.open('GET', "http://www.example.com");  
    req.responseType = "arraybuffer";  
    req.send();  
  
    req.onreadystatechange = function () {  
        if (req.readyState === 4) {  
            var buffer = req.response;  
            var dataview = new DataView(buffer);  
            var ints = new Float32Array(buffer.byteLength / 4);  
            for (var i = 0; i < ints.length; i++) {  
                ints[i] = dataview.getFloat32(i * 4);  
            }  
        alert(ints[10]);  
        }  
    }  
  
```  
  
## Requirements  
 [!INCLUDE[jsv10](../../javascript/reference/includes/jsv10-md.md)]