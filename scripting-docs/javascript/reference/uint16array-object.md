---
title: "Uint16Array Object | Microsoft Docs"
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
ms.assetid: e684647d-04d0-41a9-9089-16612e18ec7d
caps.latest.revision: 15
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Uint16Array Object
A typed array of 16-bit unsigned integer values. The contents are initialized to 0. If the requested number of bytes could not be allocated an exception is raised.  
  
## Syntax  
  
```  
  
      uint16Array = new Uint16Array( length );  
uint16Array = new Uint16Array( array );  
uint16Array = new Uint16Array( buffer, byteOffset, length );  
```  
  
## Parameters  
 `uint16Array`  
 Required. The variable name to which the **Uint16Array** object is assigned.  
  
 `length`  
 Specifies the number of elements in the array.  
  
 `array`  
 The array (or typed array) that is contained in this array.. The contents are initialized to the contents of the given array or typed array, with each element converted to the Uint16 type.  
  
 `buffer`  
 The ArrayBuffer that the Uint16Array represents.  
  
 `byteOffset`  
 Optional. Specifies the offset in bytes from the start of the buffer at which the Uint16Array should begin.  
  
 `length`  
 The number of elements in the array.  
  
## Constants  
 The following table lists the constants of the `Uint16Array`object.  
  
|Constant|Description|  
|--------------|-----------------|  
|[BYTES_PER_ELEMENT Constant](../../javascript/reference/bytes-per-element-constant-uint16array.md)|The size in bytes of each element in the array.|  
  
## Properties  
 The following table lists the constants of the `Uint16Array`object.  
  
|Property|Description|  
|--------------|-----------------|  
|[buffer Property](../../javascript/reference/buffer-property-uint16array.md)|Read-only. Gets the ArrayBuffer that is referenced by this array.|  
|[byteLength Property](../../javascript/reference/bytelength-property-uint16array.md)|Read-only. The length of this array from the start of its ArrayBuffer, in bytes, as fixed at construction time.|  
|[byteOffset Property](../../javascript/reference/byteoffset-property-uint16array.md)|Read-only. The offset of this array from the start of its ArrayBuffer, in bytes, as fixed at construction time.|  
|[length Property](../../javascript/reference/length-property-uint16array.md)|The length of the array.|  
|||  
  
## Methods  
 The following table lists the methods of the `Uint16Array`object.  
  
|Method|Description|  
|------------|-----------------|  
|[set Method (Uint16Array)](../../javascript/reference/set-method-uint16array.md)|Sets a value or an array of values.|  
|[subarray Method (Uint16Array)](../../javascript/reference/subarray-method-uint16array.md)|Gets a new Uint16Array view of the ArrayBuffer store for this array.|  
  
## Example  
 The following example shows how to use a Uint16Array object to process the binary data acquired from an XmlHttpRequest:  
  
```javascript  
var req = new XMLHttpRequest();  
    req.open('GET', "http://www.example.com");  
    req.responseType = "arraybuffer";  
    req.send();  
  
    req.onreadystatechange = function () {  
        if (req.readyState === 4) {  
            var buffer = req.response;  
            var dataview = new DataView(buffer);  
            var ints = new Uint16Array(buffer.byteLength / 2);  
            for (var i = 0; i < ints.length; i++) {  
                ints[i] = dataview.getUint16(i * 2);  
            }  
        alert(ints[10]);  
        }  
    }  
  
```  
  
## Requirements  
 [!INCLUDE[jsv10](../../javascript/reference/includes/jsv10-md.md)]