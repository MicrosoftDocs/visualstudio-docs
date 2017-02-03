---
title: "Uint8ClampedArray Object (JavaScript) | Microsoft Docs"
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
ms.assetid: 0c5537f7-00b4-487a-8fba-ef032e67e7bd
caps.latest.revision: 6
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Uint8ClampedArray Object (JavaScript)
A typed array of 8-bit unsigned integers with values clamped to the range 0-255. The contents are initialized to 0. If the requested number of bytes cannot be allocated, an exception is thrown.  
  
## Syntax  
  
```  
  
      uint8ClampedArray = new Uint8ClampedArray( length );  
uint8ClampedArray = new Uint8ClampedArray( array );  
uint8ClampedArray = new Uint8ClampedArray( buffer, byteOffset, length);  
```  
  
## Parameters  
 `uint8ClampedArray`  
 Required. The variable name to which the `Uint8ClampedArray` object is assigned.  
  
 `length`  
 Optional. The number of elements in the array.  
  
 `array`  
 Optional. The array (or typed array) that this array contains. The contents are initialized to the contents of the given array or typed array, with each element converted to the `Uint8` type.  
  
 `buffer`  
 Optional. The [ArrayBuffer](../../javascript/reference/arraybuffer-object.md) that the `Uint8ClampedArray` represents.  
  
 `byteOffset`  
 Optional. The offset, in bytes, from the start of the buffer at which the `Uint8ClampedArray` should begin.  
  
 `length`  
 Optional. The number of elements in the array.  
  
## Remarks  
 Values stored in a `Uint8ClampedArray` object are between 0 and 255. If you set a negative value for an array member, 0 is set for the value. If you set a value that is larger than 255, 255 is set as the value.  
  
 Values in a `Uint8ClampedArray` object are rounded to the nearest event value, which is called banker's rounding.  
  
## Constants  
 The following table lists the constants of the `Uint8ClampedArray` object.  
  
|Constant|Description|  
|--------------|-----------------|  
|[BYTES_PER_ELEMENT Constant](../../javascript/reference/bytes-per-element-constant-uint8clampedarray.md)|The size, in bytes, of each element in the array.|  
  
## Properties  
 The following table lists the constants of the `Uint8ClampedArray` object.  
  
|Property|Description|  
|--------------|-----------------|  
|[buffer Property](../../javascript/reference/buffer-property-uint8clampedarray.md)|Read-only. Gets the [ArrayBuffer](../../javascript/reference/arraybuffer-object.md) that is referenced by this array.|  
|[byteLength Property](../../javascript/reference/bytelength-property-uint8clampedarray.md)|Read-only. The length of this array from the start of its [ArrayBuffer](../../javascript/reference/arraybuffer-object.md), in bytes, as fixed at construction time.|  
|[byteOffset Property](../../javascript/reference/byteoffset-property-uint8clampedarray.md)|Read-only. The offset of this array from the start of its [ArrayBuffer](../../javascript/reference/arraybuffer-object.md), in bytes, as fixed at construction time.|  
|[length Property](../../javascript/reference/length-property-uint8clampedarray.md)|The length of the array.|  
  
## Methods  
 The following table lists the methods of the `Uint8ClampedArray` object.  
  
|Method|Description|  
|------------|-----------------|  
|[set Method](../../javascript/reference/set-method-uint8clampedarray.md)|Sets a value or an array of values.|  
|[subarray Method](../../javascript/reference/subarray-method-uint8clampedarray.md)|Gets a new `Uint8ClampedArray` view of the [ArrayBuffer](../../javascript/reference/arraybuffer-object.md) store for this array, specifying the first and last elements of the subarray.|  
  
## Example  
 The following example shows how to use a `Uint8ClampedArray` object to process the binary data acquired from an `XmlHttpRequest`:  
  
```javascript  
var req = new XMLHttpRequest();  
    req.open('GET', "http://www.example.com");  
    req.responseType = "arraybuffer";  
    req.send();  
  
    req.onreadystatechange = function () {  
        if (req.readyState === 4) {  
            var buffer = req.response;  
            var dataview = new DataView(buffer);  
            var ints = new Uint8ClampedArray(buffer.byteLength);  
            for (var i = 0; i < ints.length; i++) {  
                ints[i] = dataview.getUint8(i);  
            }  
        alert(ints[10]);  
        }  
    }  
  
```  
  
## Example  
 The following example shows how values are restricted in a `Uint8ClampedArray`.  
  
```javascript  
var ints = new Uint8ClampedArray(2);  
ints[0] = -1;  // 0 will be assigned.  
ints[1] = 256; // 255 will be assigned.  
  
```  
  
## Example  
 The following example shows how values are rounded in a `Uint8ClampedArray`.  
  
```  
var ints = new Uint8ClampedArray(4);  
ints[0] = 11.3; // 11 will be assigned (same as Int8Array).  
ints[1] = 11.8; // 11 will be assigned (same as Int8Array).  
ints[2] = 10.5; // 10 will be assigned (rounded to the nearest   
                // even value).  
ints[3] = 11.5; // 12 will be assigned (rounded to the nearest   
                // even value).  
  
```  
  
## Requirements  
 [!INCLUDE[jsv11_winonly](../../javascript/reference/includes/jsv11-winonly-md.md)]  
  
## See Also  
 [Uint8Array Object](../../javascript/reference/uint8array-object.md)   
 [ArrayBuffer Object](../../javascript/reference/arraybuffer-object.md)