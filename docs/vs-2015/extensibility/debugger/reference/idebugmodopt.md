---
title: "IDebugModOpt | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "IDebugModOpt interface"
ms.assetid: ebd525e3-d140-4071-9d8c-41871de4125e
caps.latest.revision: 7
ms.author: gregvanl
manager: jillfra
---
# IDebugModOpt
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

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
