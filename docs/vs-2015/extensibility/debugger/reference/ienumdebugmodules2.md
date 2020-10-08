---
title: "IEnumDebugModules2 | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IEnumDebugModules2"
helpviewer_keywords: 
  - "IEnumDebugModules2"
ms.assetid: 4fe28074-a960-41ad-b74d-b57f04c0c0ad
caps.latest.revision: 12
ms.author: gregvanl
manager: jillfra
---
# IEnumDebugModules2
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

This interface enumerates a list of modules.  
  
## Syntax  
  
```  
IEnumDebugModules2 : IUnknown  
```  
  
## Notes for Implementers  
 The debug engine (DE) implements this interface to represent a list of modules loaded for a program.  
  
## Notes for Callers  
 Visual Studio calls [EnumModules](../../../extensibility/debugger/reference/idebugprogram2-enummodules.md) to obtain this interface.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IEnumDebugModules2`.  
  
|Method|Description|  
|------------|-----------------|  
|[Next](../../../extensibility/debugger/reference/ienumdebugmodules2-next.md)|Retrieves a specified number of modules in an enumeration sequence.|  
|[Skip](../../../extensibility/debugger/reference/ienumdebugmodules2-skip.md)|Skips a specified number of modules in an enumeration sequence.|  
|[Reset](../../../extensibility/debugger/reference/ienumdebugmodules2-reset.md)|Resets an enumeration sequence to the beginning.|  
|[Clone](../../../extensibility/debugger/reference/ienumdebugmodules2-clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|  
|[GetCount](../../../extensibility/debugger/reference/ienumdebugmodules2-getcount.md)|Gets the number of modules.|  
  
## Remarks  
 Visual Studio uses this interface primarily to update the **Modules** window.  
  
 For the purposes of debugging in Visual Studio, a program is a logical sequence of code instructions that can cross module boundaries, hence the need for a list of modules for a single [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md) interface. The first module in the list typically contains the initial entry point for the associated program.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)   
 [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)   
 [EnumModules](../../../extensibility/debugger/reference/idebugprogram2-enummodules.md)
