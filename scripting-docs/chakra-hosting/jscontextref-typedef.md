---
title: "JsContextRef Typedef | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: 8586bfcc-bb24-430d-a6f2-1a3b3e34ec2e
caps.latest.revision: 6
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# JsContextRef Typedef
A reference to a script context.  
  
## Syntax  
  
```  
typedef JsRef JsContextRef;  
```  
  
## Remarks  
 Each script context contains its own global object, distinct from the global object in other script contexts.  
  
 Many Chakra hosting APIs require an "active" script context, which can be set using `JsSetCurrentContext`. Chakra hosting APIs that require a current context to be set will note that explicitly in their documentation.  
  
## Requirements  
 **Header:** jsrt.h  
  
## See Also  
 [Reference (JavaScript Runtime)](../chakra-hosting/reference-javascript-runtime.md)