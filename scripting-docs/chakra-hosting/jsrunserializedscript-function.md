---
title: "JsRunSerializedScript Function | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
f1_keywords: 
  - "jsrt/JsRunSerializedScript"
helpviewer_keywords: 
  - "JsRunSerializedScript function"
ms.assetid: 3fd3f6f1-eb3e-4751-92a5-c93b1035f3b2
caps.latest.revision: 13
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# JsRunSerializedScript Function
Runs a serialized script.  
  
## Syntax  
  
```  
STDAPI_(JsErrorCode) JsRunSerializedScript(  
   _In_z_ const wchar_t *script,  
   _In_ BYTE *buffer,  
   _In_ JsSourceContext sourceContext,  
   _In_z_ const wchar_t *sourceUrl,  
   _Out_ JsValueRef *result  
);  
```  
  
#### Parameters  
 `script`  
 The source code of the serialized script.  
  
 `buffer`  
 The serialized script.  
  
 `sourceContext`  
 A cookie identifying the script that can be used by debuggable script contexts.  
  
 `sourceUrl`  
 The location the script came from.  
  
 `result`  
 The result of running the script, if any. This parameter can be null.  
  
## Return Value  
 The code `JsNoError` if the operation succeeded, a failure code otherwise.  
  
## Remarks  
 Requires an active script context.  
  
 The buffer is not persisted in memory by the scripting engine, so your code must keep it alive for as long as it might be used to execute scripts.  
  
## Requirements  
 **Header:** jsrt.h  
  
## See Also  
 [Reference (JavaScript Runtime)](../chakra-hosting/reference-javascript-runtime.md)