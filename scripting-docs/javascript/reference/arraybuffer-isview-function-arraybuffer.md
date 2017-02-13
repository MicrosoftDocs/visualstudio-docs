---
title: "ArrayBuffer.isView Function (ArrayBuffer) | Microsoft Docs"
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
ms.assetid: 1887324f-892b-4fcd-ad33-748ba9517a06
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# ArrayBuffer.isView Function (ArrayBuffer)
Determines whether an object provides a view of the buffer.  
  
## Syntax  
  
```javascript  
ArrayBuffer.isView(object)  
```  
  
#### Parameters  
 `object`  
 Required. The object to test.  
  
## Return Value  
 `true` if either of the following is true:  
  
-   `object` is a `DataView` object.  
  
-   `object` is a typed array.  
  
 Otherwise, the method returns `false`.  
  
## Remarks  
  
## Example  
 The following example illustrates the use of the `isView` function to test a typed array and a `DataView` object.  
  
```javascript  
var uint = new UInt8ClampedArray(10);  
  
if(console && console.log) {  
    console.log( ArrayBuffer.isView(uint) ); // Outputs true  
{  
var dataView = new DataView(uint.buffer);  
  
if(console && console.log) {  
    console.log( ArrayBuffer.isView(dataView) ); // Outputs true.  
}  
```  
  
## Requirements  
 [!INCLUDE[jsv11_winonly](../../javascript/reference/includes/jsv11-winonly-md.md)]  
  
## See Also  
 [Uint8ClampedArray Object](../../javascript/reference/uint8clampedarray-object-javascript.md)