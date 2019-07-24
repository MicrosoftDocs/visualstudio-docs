---
title: "IEnumDebugPrograms2 | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IEnumDebugPrograms2"
helpviewer_keywords: 
  - "IEnumDebugPrograms2"
ms.assetid: 7fbb8fb7-db64-4546-a364-dc668430c8af
caps.latest.revision: 12
ms.author: gregvanl
manager: jillfra
---
# IEnumDebugPrograms2
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

This interface enumerates the programs running in the current debug session.  
  
## Syntax  
  
```  
IEnumDebugPrograms2 : IUnknown  
```  
  
## Notes for Implementers  
 The debug engine (DE) implements this interface to provide a list of programs being debugged by the DE.  
  
## Notes for Callers  
 Visual Studio calls [EnumPrograms](../../../extensibility/debugger/reference/idebugprocess2-enumprograms.md) to obtain this interface. [EnumPrograms](../../../extensibility/debugger/reference/idebugengine2-enumprograms.md) is not used by Visual Studio.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IEnumDebugPrograms2`.  
  
|Method|Description|  
|------------|-----------------|  
|[Next](../../../extensibility/debugger/reference/ienumdebugprograms2-next.md)|Retrieves a specified number of programs in an enumeration sequence.|  
|[Skip](../../../extensibility/debugger/reference/ienumdebugprograms2-skip.md)|Skips a specified number of programs in an enumeration sequence.|  
|[Reset](../../../extensibility/debugger/reference/ienumdebugprograms2-reset.md)|Resets an enumeration sequence to the beginning.|  
|[Clone](../../../extensibility/debugger/reference/ienumdebugprograms2-clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|  
|[GetCount](../../../extensibility/debugger/reference/ienumdebugprograms2-getcount.md)|Gets the number of programs in an enumerator.|  
  
## Remarks  
 Visual Studio uses this interface to:  
  
- Populate the **Modules** window (by calling [EnumPrograms](../../../extensibility/debugger/reference/idebugprocess2-enumprograms.md) and then calling [EnumModules](../../../extensibility/debugger/reference/idebugprogram2-enummodules.md) on each program).  
  
- Populate the **Attach to Process** list (by calling `IDebugProcess2::EnumPrograms` and then calling [QueryInterface](https://msdn.microsoft.com/library/62fce95e-aafa-4187-b50b-e6611b74c3b3) on each [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md) interface to obtain an [IDebugEngineProgram2](../../../extensibility/debugger/reference/idebugengineprogram2.md) interface).  
  
- Generate a list of DEs that can debug each program in the process (using [GetEngineInfo](../../../extensibility/debugger/reference/idebugprogram2-getengineinfo.md)).  
  
- Apply Edit and Continue (ENC) updates to each program (by calling IDebugProcess2::EnumPrograms and then calling [GetENCUpdate](../../../extensibility/debugger/reference/idebugprogram2-getencupdate.md)).  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)   
 [EnumPrograms](../../../extensibility/debugger/reference/idebugengine2-enumprograms.md)   
 [EnumPrograms](../../../extensibility/debugger/reference/idebugprocess2-enumprograms.md)
