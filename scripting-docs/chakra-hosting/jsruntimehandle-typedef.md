---
title: "JsRuntimeHandle Typedef | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: 69e59bfd-9b0e-4710-9aa8-fbd6844171bc
caps.latest.revision: 6
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# JsRuntimeHandle Typedef
A handle to a Chakra runtime.  
  
## Syntax  
  
```  
typedef void *JsRuntimeHandle;  
```  
  
## Remarks  
 Each Chakra runtime has its own independent execution engine, JIT compiler, and garbage collected heap. As such, each runtime is completely isolated from other runtimes.  
  
 Runtimes can be used on any thread, but only one thread can call into a runtime at any time.  
  
> [!WARNING]
>  A JsRuntimeHandle, unlike other object references in the Chakra hosting API, is not garbage collected since it contains the garbage collected heap itself. A runtime will continue to exist until JsDisposeRuntime is called.  
  
## Requirements  
 **Header:** jsrt.h  
  
## See Also  
 [Reference (JavaScript Runtime)](../chakra-hosting/reference-javascript-runtime.md)