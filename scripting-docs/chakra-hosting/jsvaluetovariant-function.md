---
title: "JsValueToVariant Function | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
f1_keywords: 
  - "jsrt/JsValueToVariant"
helpviewer_keywords: 
  - "JsValueToVariant function"
ms.assetid: 070244be-a69d-4b78-971b-69c0579c03cf
caps.latest.revision: 12
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# JsValueToVariant Function
Initializes the passed in `VARIANT` as a projection of a JavaScript value.  
  
## Syntax  
  
```  
STDAPI_(JsErrorCode) JsValueToVariant(  
   _In_ JsValueRef object,  
   _Out_ VARIANT *variant  
);  
```  
  
#### Parameters  
 `object`  
 A JavaScript value to project as a `VARIANT`.  
  
 `variant`  
 A pointer to a `VARIANT` struct that will be initialized as a projection.  
  
## Return Value  
  
## Remarks  
 The projection `VARIANT` can be used by COM automation clients to call into the projected JavaScript object.  
  
 Requires an active script context.  
  
## Requirements  
 **Header:** jsrt.h  
  
## See Also  
 [Reference (JavaScript Runtime)](../chakra-hosting/reference-javascript-runtime.md)