---
title: "Float64Array Object | Microsoft Docs"
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
ms.assetid: 74c945dc-56ae-458c-b0aa-782f240e9b6c
caps.latest.revision: 18
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Float64Array Object
A typed array of 64-bit float values. The contents are initialized to 0. If the requested number of bytes could not be allocated an exception is raised.  
  
## Syntax  
  
```  
  
      float64Array = new Float64Array( length );  
float64Array = new Float64Array( array );  
float64Array = new Float64Array( buffer, byteOffset, length);  
```  
  
## Parameters  
 `float64Array`  
 Required. The variable name to which the **Float64Array** object is assigned.  
  
 `length`  
 Specifies the number of elements in the array.  
  
 `array`  
 The array (or typed array) that is contained in this array.. The contents are initialized to the contents of the given array or typed array, with each element converted to the Float64 type.  
  
 `buffer`  
 The ArrayBuffer that the Float64Array represents.  
  
 `byteOffset`  
 Optional. Specifies the offset in bytes from the start of the buffer at which the Float64Array should begin.  
  
 `length`  
 The number of elements in the array.  
  
## Constants  
 The following table lists the constants of the `Float64Array`object.  
  
|Constant|Description|  
|--------------|-----------------|  
|[BYTES_PER_ELEMENT Constant](../../javascript/reference/bytes-per-element-constant-float64array.md)|The size in bytes of each element in the array.|  
  
## Properties  
 The following table lists the constants of the `Float64Array`object.  
  
|Property|Description|  
|--------------|-----------------|  
|[buffer Property](../../javascript/reference/bytelength-property-float64array.md)|Read-only. Gets the ArrayBuffer that is referenced by this array.|  
|[byteLength Property](../../javascript/reference/bytelength-property-float64array.md)|Read-only. The length of this array from the start of its ArrayBuffer, in bytes, as fixed at construction time.|  
|[byteOffset Property](../../javascript/reference/length-property-float64array.md)|Read-only. The offset of this array from the start of its ArrayBuffer, in bytes, as fixed at construction time.|  
|[length Property](../../javascript/reference/length-property-float64array.md)|The length of the array.|  
  
## Methods  
 The following table lists the methods of the `Float64Array`object.  
  
|Method|Description|  
|------------|-----------------|  
|[get Method](../../javascript/reference/get-method-float64array.md)|Omittable. Gets the element at the specified index.|  
|[set Method (Float64Array)](../../javascript/reference/set-method-float64array.md)|Sets a value or an array of values.|  
|[subarray Method (Float64Array)](../../javascript/reference/subarray-method-float64array.md)|Gets a new Float64Array view of the ArrayBuffer store for this array.|  
  
## Example  
 The following example shows how to use a Float64Array object to process the binary data acquired from an XmlHttpRequest:  
  
```javascript  
var req = new XMLHttpRequest();  
    req.open('GET', "http://www.example.com");  
    req.responseType = "arraybuffer";  
    req.send();  
  
    req.onreadystatechange = function () {  
        if (req.readyState === 4) {  
            var buffer = req.response;  
            var dataview = new DataView(buffer);  
            var ints = new Float64Array(buffer.byteLength / 8);  
            for (var i = 0; i < ints.length; i++) {  
                ints[i] = dataview.getFloat64(i * 8);  
            }  
        alert(ints[10]);  
        }  
    }  
  
```  
  
## Requirements  
 [!INCLUDE[jsv10](../../javascript/reference/includes/jsv10-md.md)]