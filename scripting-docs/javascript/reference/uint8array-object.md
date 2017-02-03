---
title: "Uint8Array Object | Microsoft Docs"
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
ms.assetid: ae78b3ee-b660-4625-ac7b-d414a0842c87
caps.latest.revision: 15
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Uint8Array Object
A typed array of 8-bit unsigned integer values. The contents are initialized to 0. If the requested number of bytes could not be allocated an exception is raised.  
  
## Syntax  
  
```  
  
      uint8Array = new Uint8Array( length );  
uint8Array = new Uint8Array( array );  
uint8Array = new Uint8Array( buffer, byteOffset, length);  
```  
  
## Parameters  
 `uint8Array`  
 Required. The variable name to which the **Uint8Array** object is assigned.  
  
 `length`  
 Specifies the number of elements in the array.  
  
 `array`  
 The array (or typed array) that is contained in this array. The contents are initialized to the contents of the given array or typed array, with each element converted to the Uint8 type.  
  
 `buffer`  
 The ArrayBuffer that the Uint8Array represents.  
  
 `byteOffset`  
 Optional. Specifies the offset in bytes from the start of the buffer at which the Uint8Array should begin.  
  
 `length`  
 The number of elements in the array.  
  
## Constants  
 The following table lists the constants of the `Uint8Array`object.  
  
|Constant|Description|  
|--------------|-----------------|  
|[BYTES_PER_ELEMENT Constant](../../javascript/reference/bytes-per-element-constant-uint8array.md)|The size in bytes of each element in the array.|  
  
## Properties  
 The following table lists the constants of the `Uint8Array`object.  
  
|Property|Description|  
|--------------|-----------------|  
|[buffer Property](../../javascript/reference/buffer-property-uint8array.md)|Read-only. Gets the ArrayBuffer that is referenced by this array.|  
|[byteLength Property](../../javascript/reference/bytelength-property-uint8array.md)|Read-only. The length of this array from the start of its ArrayBuffer, in bytes, as fixed at construction time.|  
|[byteOffset Property](../../javascript/reference/byteoffset-property-uint8array.md)|Read-only. The offset of this array from the start of its ArrayBuffer, in bytes, as fixed at construction time.|  
|[length Property](../../javascript/reference/length-property-uint8array.md)|The length of the array.|  
|||  
  
## Methods  
 The following table lists the methods of the `Uint8Array`object.  
  
|Method|Description|  
|------------|-----------------|  
|[set Method (Uint8Array)](../../javascript/reference/set-method-uint8array.md)|Sets a value or an array of values.|  
|[subarray Method (Uint8Array)](../../javascript/reference/subarray-method-uint8array.md)|Gets a new Uint8Array view of the ArrayBuffer store for this array.|  
  
## Example  
 The following example shows how to use a Uint8Array object to process the binary data acquired from an XmlHttpRequest:  
  
```javascript  
var req = new XMLHttpRequest();  
    req.open('GET', "http://www.example.com");  
    req.responseType = "arraybuffer";  
    req.send();  
  
    req.onreadystatechange = function () {  
        if (req.readyState === 4) {  
            var buffer = req.response;  
            var dataview = new DataView(buffer);  
            var ints = new Uint8Array(buffer.byteLength);  
            for (var i = 0; i < ints.length; i++) {  
                ints[i] = dataview.getUint8(i);  
            }  
        alert(ints[10]);  
        }  
    }  
  
```  
  
## Requirements  
 [!INCLUDE[jsv10](../../javascript/reference/includes/jsv10-md.md)]