---
title: "JsSerializedScriptLoadSourceCallback Typedef | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 9406c488-76ac-49e5-b305-39751f3412ea
caps.latest.revision: 3
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# JsSerializedScriptLoadSourceCallback Typedef
Called by the runtime to load the source code of the serialized script.     The caller must keep the script buffer valid until the `JsSerializedScriptUnloadCallback`.  
  
## Syntax  
  
```  
typedef bool (CALLBACK * JsSerializedScriptLoadSourceCallback)(  
  _In_ JsSourceContextsourceContext,  
  _Outptr_result_z_ const wchar_t** scriptBuffer  
);  
```  
  
#### Parameters  
 `sourceContext`  
 The context passed to `JsParseSerializedScriptWithCallback` or `JsRunSerializedScriptWithCallback`.  
  
 `scriptBuffer`  
 The script returned.  
  
## Remarks  
  
> [!WARNING]
## Requirements  
 **Header:** jsrt.h  
  
## See Also  
 [Reference (JavaScript Runtime)](../chakra-hosting/reference-javascript-runtime.md)