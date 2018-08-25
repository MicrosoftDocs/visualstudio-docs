---
title: "JsParseSerializedScriptWithCallback Function | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 0a93ecfb-4b82-4a85-b24c-6816db2332ea
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# JsParseSerializedScriptWithCallback Function
Parses a serialized script and returns a function representing the script.     Provides the ability to lazy load the script source only if/when it is needed.  
  
## Syntax  
  
```  
STDAPI_(JsErrorCode) JsParseSerializedScriptWithCallback(  
  _In_ JsSerializedScriptLoadSourceCallback scriptLoadCallback,  
  _In_ JsSerializedScriptUnloadCallback scriptUnloadCallback,  
  _In_ BYTE *buffer,  
  _In_ JsSourceContext sourceContext,  
  _In_z_ const wchar_t *sourceUrl,  
  _Out_ JsValueRef * result  
);  
  
```  
  
#### Parameters  
 `scriptLoadCallback`  
 Callback called when the source code of the script needs to be loaded.  
  
 `scriptUnloadCallback`  
 Callback called when the serialized script and source code are no longer needed.  
  
 `buffer`  
 The serialized script.  
  
 `sourceContext`  
 A cookie identifying the script that can be used by debuggable script contexts.     This context will passed into scriptLoadCallback and scriptUnloadCallback.  
  
 `sourceUrl`  
 The location the script came from.  
  
 `result`  
 A function representing the script code.  
  
## Return Value  
 The code `JsNoError` if the operation succeeded, a failure code otherwise.  
  
## Remarks  
  
> [!NOTE]
>  This API is not yet available for Store apps.  
  
 Requires an active script context.  
  
 The runtime will hold on to the buffer until all instances of any functions created from     the buffer are garbage collected.  It will then call scriptUnloadCallback to inform the     caller that it is safe to release.  
  
## Requirements  
 **Header:** jsrt.h  
  
## See Also  
 [Reference (JavaScript Runtime)](../chakra-hosting/reference-javascript-runtime.md)