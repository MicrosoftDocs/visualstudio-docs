---
title: "JsGetTypedArrayInfo Function | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 992bc4e9-3d06-4ad2-8b6b-88a437360f81
caps.latest.revision: 3
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# JsGetTypedArrayInfo Function
Obtains frequently used properties of a typed array.  
  
## Syntax  
  
```  
STDAPI_(JsErrorCode) JsGetTypedArrayInfo(  
  _In_ JsValueRef typedArray,  
  _Out_opt_ JsTypedArrayType *arrayType,  
  _Out_opt_ JsValueRef *arrayBuffer,  
  _Out_opt_ unsigned int *byteOffset,  
  _Out_opt_ unsigned int *byteLength  
);  
  
```  
  
#### Parameters  
 `typedArray`  
 The typed array instance.  
  
 `arrayType`  
 The type of the array.  
  
 `arrayBuffer`  
 The `ArrayBuffer` backstore of the array.  
  
 `byteOffset`  
 The offset in bytes from the start of arrayBuffer referenced by the array.  
  
 `byteLength`  
 The number of bytes in the array.  
  
## Return Value  
 The code `JsNoError` if the operation succeeded, a failure code otherwise.  
  
## Remarks  
 Requires an active script context.  
  
## Requirements  
 **Header:** jsrt.h  
  
## See Also  
 [Reference (JavaScript Runtime)](../chakra-hosting/reference-javascript-runtime.md)