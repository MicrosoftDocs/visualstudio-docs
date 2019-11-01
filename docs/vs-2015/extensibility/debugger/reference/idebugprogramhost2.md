---
title: "IDebugProgramHost2 | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugProgramHost2"
helpviewer_keywords: 
  - "IDebugProgramHost2 interface"
ms.assetid: 2c37b3aa-97a9-4665-8709-edd917f18cb1
caps.latest.revision: 12
ms.author: gregvanl
manager: jillfra
---
# IDebugProgramHost2
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

This interface provides host (process) information about a program.  
  
## Syntax  
  
```  
IDebugProgramHost2 : IUnknown  
```  
  
## Notes for Implementers  
 The debug engine implements this interface on the same object as the [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md) interface to provide information about the hosting process. This is an optional interface.  
  
## Notes for Callers  
 Call [QueryInterface](https://msdn.microsoft.com/library/62fce95e-aafa-4187-b50b-e6611b74c3b3) on an `IDebugProgram2` interface to obtain this interface.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugProgramHost2`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetHostName](../../../extensibility/debugger/reference/idebugprogramhost2-gethostname.md)|Gets the title, friendly name, or file name of the hosting process of this program.|  
|[GetHostId](../../../extensibility/debugger/reference/idebugprogramhost2-gethostid.md)|Gets the process identifier of the hosting process of this program.|  
|[GetHostMachineName](../../../extensibility/debugger/reference/idebugprogramhost2-gethostmachinename.md)|Gets the name of the machine the hosting process of this program is running on.|  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)   
 [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)
