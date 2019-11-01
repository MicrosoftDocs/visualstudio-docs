---
title: "IDebugProgramEx2 | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugProgramEx2"
helpviewer_keywords: 
  - "IDebugProgramEx2 interface"
ms.assetid: 663359ed-635a-4539-addb-0cc52f19d1bd
caps.latest.revision: 19
ms.author: gregvanl
manager: jillfra
---
# IDebugProgramEx2
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

This interface lets the session debug manager (SDM) attach to a program and get the program node associated with a program.  
  
## Syntax  
  
```  
IDebugProgramEx2 : IUnknown  
```  
  
## Notes for Implementers  
 A custom port supplier implements this interface on the same object as the [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md) interface in order to let the SDM attach to a program while at the same time allowing the port supplier to track all sessions attached to the program. The custom port supplier can implement this interface if it chooses.  
  
## Notes for Callers  
 The SDM calls [QueryInterface](https://msdn.microsoft.com/library/62fce95e-aafa-4187-b50b-e6611b74c3b3) on an `IDebugProgram2` interface to obtain this interface to track sessions that have attached to programs.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugProgramEx2`.  
  
|Method|Description|  
|------------|-----------------|  
|[Attach](../../../extensibility/debugger/reference/idebugprogramex2-attach.md)|Attaches a program to a session.|  
|[GetProgramNode](../../../extensibility/debugger/reference/idebugprogramex2-getprogramnode.md)|Gets the program node associated with a program.|  
  
## Remarks  
 This interface is private between the SDM and the program.  
  
## Requirements  
 Header: Portpriv.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)   
 [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)
