---
title: "DataView Object | Microsoft Docs"
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
ms.assetid: 250ec067-7505-4ee0-82ab-bfd3c2820afa
caps.latest.revision: 10
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# DataView Object
You can use a DataView object to read and write the different kinds of binary data to any location in the ArrayBuffer.  
  
## Syntax  
  
```  
  
dataView = new DataView(buffer, byteOffset, byteLength);  
```  
  
## Parameters  
 `dataView`  
 Required. The variable name to which the **DataView** object is assigned.  
  
 `buffer`  
 The ArrayBuffer that the DataView represents.  
  
 `byteOffset`  
 Optional. Specifies the offset in bytes from the start of the buffer at which the DataView should begin.  
  
 `byteLength`  
 Optional. Specifies the length (in bytes) of the section of the buffer that the DataView should represent.  
  
## Remarks  
 If both byteOffset and byteLength are omitted, the DataView spans the entire ArrayBuffer range. If the byteLength is omitted, the DataView extends from the given byteOffset until the end of the ArrayBuffer. If the given byteOffset and byteLength references an area beyond the end of the ArrayBuffer, an exception is raised.  
  
## Properties  
 The following table lists the properties of the `DataView` object.  
  
|Property|Description|  
|--------------|-----------------|  
|[buffer Property](../../javascript/reference/buffer-property-dataview.md)|Read-only. Gets the ArrayBuffer that is referenced by this view.|  
|[byteLength Property](../../javascript/reference/bytelength-property-dataview.md)|Read-only. The length of this view from the start of its ArrayBuffer, in bytes, as fixed at construction time.|  
|[byteOffset Property](../../javascript/reference/byteoffset-property-dataview.md)|Read-only. The offset of this view from the start of its ArrayBuffer, in bytes, as fixed at construction time.|  
  
## Methods  
 The following table lists the methods of the `DataView`object.  
  
|Method|Description|  
|------------|-----------------|  
|[getInt8 Method](../../javascript/reference/getint8-method-dataview.md)|Gets the Int8 value at the specified byte offset from the start of the view.|  
|[getUint8 Method (DataView)](../../javascript/reference/getuint8-method-dataview.md)|Gets the Uint8 value at the specified byte offset from the start of the view.|  
|[getInt16 Method (DataView)](../../javascript/reference/getint16-method-dataview.md)|Gets the Int16 value at the specified byte offset from the start of the view.|  
|[getUint16 Method (DataView)](../../javascript/reference/getuint16-method-dataview.md)|Gets the Uint16 value at the specified byte offset from the start of the view.|  
|[getInt32 Method (DataView)](../../javascript/reference/getint32-method-dataview.md)|Gets the Int32 value at the specified byte offset from the start of the view.|  
|[getUint32 Method (DataView)](../../javascript/reference/getuint32-method-dataview.md)|Gets the Uint32 value at the specified byte offset from the start of the view.|  
|[getFloat32 Method (DataView)](../../javascript/reference/getfloat32-method-dataview.md)|Gets the Float32 value at the specified byte offset from the start of the view.|  
|[getFloat64 Method (DataView)](../../javascript/reference/getfloat64-method-dataview.md)|Gets the Float64 value at the specified byte offset from the start of the view.|  
|[setInt8 Method (DataView)](../../javascript/reference/setint8-method-dataview.md)|Stores a Int8 value at the specified byte offset from the start of the view.|  
|[setUint8 Method (DataView)](../../javascript/reference/setuint8-method-dataview.md)|Stores a Uint8 value at the specified byte offset from the start of the view.|  
|[setInt16 Method (DataView)](../../javascript/reference/setint16-method-dataview.md)|Stores a Int16 value at the specified byte offset from the start of the view.|  
|[setUint16 Method (DataView)](../../javascript/reference/setuint16-method-dataview.md)|Stores a Uint16 value at the specified byte offset from the start of the view.|  
|[setInt32 Method (DataView)](../../javascript/reference/setint32-method-dataview.md)|Stores a Int32 value at the specified byte offset from the start of the view.|  
|[setUint32 Method (DataView)](../../javascript/reference/setuint32-method-dataview.md)|Stores a Uint32 value at the specified byte offset from the start of the view.|  
|[setFloat32 Method (DataView)](../../javascript/reference/setfloat32-method-dataview.md)|Stores a Float32 value at the specified byte offset from the start of the view.|  
|[setFloat64 Method (DataView)](../../javascript/reference/setfloat64-method-dataview.md)|Stores a Float64 value at the specified byte offset from the start of the view.|  
  
## Example  
 The following example shows how to use a DataView object to process the binary data acquired from an XmlHttpRequest:  
  
```JavaScript  
var req = new XMLHttpRequest();  
    req.open('GET', "http://www.example.com");  
    req.responseType = "arraybuffer";  
    req.send();  
  
    req.onreadystatechange = function () {  
        if (req.readyState === 4) {  
            var buffer = req.response;  
            var dataView = new DataView(buffer);  
            var ints = new Int32Array(dataView.byteLength / 4);  
            for (var i = 0; i < ints.length; i++) {  
                ints[i] = dataview.getInt32(i * 4);  
            }  
        alert(ints[10]);  
        }  
    }  
  
```  
  
## Requirements  
 [!INCLUDE[jsv10](../../javascript/reference/includes/jsv10-md.md)]