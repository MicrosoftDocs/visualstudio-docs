---
title: "JsParseSerializedScript Function | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
f1_keywords: 
  - "jsrt/JsParseSerializedScript"
helpviewer_keywords: 
  - "JsParseSerializedScript function"
ms.assetid: 40d0c7c4-fd5b-46ed-9e65-38c2db2fc859
caps.latest.revision: 13
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# JsParseSerializedScript Function
Parses a serialized script and returns a function representing the script.  
  
## Syntax  
  
```  
STDAPI_(JsErrorCode) JsParseSerializedScript(  
   _In_z_ const wchar_t *script,  
   _In_ BYTE *buffer,  
   _In_ JsSourceContext sourceContext,  
   _In_z_ const wchar_t *sourceUrl,  
   _Out_ JsValueRef *result  
);  
```  
  
#### Parameters  
 `script`  
 The script to parse.  
  
 `buffer`  
 The serialized script.  
  
 `sourceContext`  
 A cookie identifying the script that can be used by debuggable script contexts.  
  
 `sourceUrl`  
 The location the script came from.  
  
 `result`  
 A function representing the script code.  
  
## Return Value  
 The code `JsNoError` if the operation succeeded, a failure code otherwise.  
  
## Remarks  
 Requires an active script context.  
  
 The buffer is not persisted in memory by the scripting engine, so your code must keep it alive for as long as it might be used to execute scripts.  
  
## Requirements  
 **Header:** jsrt.h  
  
## See Also  
 [Reference (JavaScript Runtime)](../chakra-hosting/reference-javascript-runtime.md)