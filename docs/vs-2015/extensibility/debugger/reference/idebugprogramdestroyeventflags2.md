---
title: "IDebugProgramDestroyEventFlags2 | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "IDebugProgramDestroyEventFlags2 interface"
ms.assetid: d384ff71-dc71-40b9-a871-801f8b6a3418
caps.latest.revision: 8
ms.author: gregvanl
manager: jillfra
---
# IDebugProgramDestroyEventFlags2
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Enables a debug engine to override the default behavior of the [!INCLUDE[vsprvs](../../../includes/vsprvs-md.md)] UI when you end a debug session.  
  
## Syntax  
  
```  
IDebugProgramDestroyEventFlags2 : IUnknown  
```  
  
## Notes for Implementers  
 This interface is implemented by debug engines. It is useful for hosts that might create and destroy multiple programs over the lifetime of a process.  
  
## Methods  
 The following table shows the methods of `IDebugProgramDestroyEventFlags2`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetFlags](../../../extensibility/debugger/reference/idebugprogramdestroyeventflags2-getflags.md)|Retrieves the program destroy flags.|  
  
## Remarks  
 The default behavior of the [!INCLUDE[vsprvs](../../../includes/vsprvs-md.md)] UI is to go back to design mode after all programs have sent a program destroy event. This interface enables a debug engine to change that behavior.  
  
## Requirements  
 Header: Msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll
