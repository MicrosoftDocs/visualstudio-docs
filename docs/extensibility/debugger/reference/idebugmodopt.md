---
title: "IDebugModOpt | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "IDebugModOpt interface"
ms.assetid: ebd525e3-d140-4071-9d8c-41871de4125e
caps.latest.revision: 6
author: "gregvanl"
ms.author: "gregvanl"
manager: ghogen
ms.workload: 
  - "vssdk"
---
# IDebugModOpt
Represents a debug optional modifier.  
  
## Syntax  
  
```  
IDebugModOpt : IUnknown  
```  
  
## Notes for Callers  
 Obtained from an [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) object that represents a class or method.  
  
## Methods  
 This interface implements the following method:  
  
|Method|Description|  
|------------|-----------------|  
|[GetModOpts](../../../extensibility/debugger/reference/idebugmodopt-getmodopts.md)|Retrieves a list of optional modifiers.|  
  
## Requirements  
 Header: Sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll