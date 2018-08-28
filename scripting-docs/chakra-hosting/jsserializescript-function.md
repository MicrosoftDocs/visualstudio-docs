---
title: "JsSerializeScript Function | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
f1_keywords: 
  - "jsrt/JsSerializeScript"
helpviewer_keywords: 
  - "JsSerializeScript function"
ms.assetid: ca42c194-e1c1-407d-b542-b9d494e3ac4e
caps.latest.revision: 12
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# JsSerializeScript Function
Serializes a parsed script to a buffer than can be reused.  
  
## Syntax  
  
```  
STDAPI_(JsErrorCode) JsSerializeScript(  
   _In_z_ const wchar_t *script,  
   _Out_writes_to_opt_(*bufferSize,  
   *bufferSize) BYTE *buffer,  
   _Inout_ unsigned long *bufferSize  
);  
```  
  
#### Parameters  
 `script`  
 The script to serialize.  
  
 `buffer`  
 The buffer to put the serialized script into. Can be null.  
  
 `bufferSize`  
 On entry, the size of the buffer, in bytes; on exit, the size of the buffer, in bytes, required to hold the serialized script.  
  
## Return Value  
 The code `JsNoError` if the operation succeeded, a failure code otherwise.  
  
## Remarks  
 `JsSerializeScript` parses a script and then stores the parsed form of the script in a runtime-independent format. The serialized script then can be deserialized in any runtime without requiring the script to be re-parsed.  
  
 Requires an active script context.  
  
## Requirements  
 **Header:** jsrt.h  
  
## See Also  
 [Reference (JavaScript Runtime)](../chakra-hosting/reference-javascript-runtime.md)