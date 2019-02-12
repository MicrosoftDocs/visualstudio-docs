---
title: "IDebugProgram2::GetProcess | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugProgram2::GetProcess"
helpviewer_keywords: 
  - "IDebugProgram2::GetProcess"
ms.assetid: 1d602485-ebaf-451c-9165-f2e226f20a90
caps.latest.revision: 14
ms.author: gregvanl
manager: jillfra
---
# IDebugProgram2::GetProcess
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Get the process that this program is running in.  
  
## Syntax  
  
```cpp  
HRESULT GetProcess(  
   IDebugProcess2** ppProcess  
);  
```  
  
```csharp  
int GetProcess(  
   out IDebugProcess2 ppProcess  
);  
```  
  
#### Parameters  
 `ppProcess`  
 [out] Returns the [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md) interface that represents the process.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 Unless a debug engine (DE) implements the [IDebugEngineLaunch2](../../../extensibility/debugger/reference/idebugenginelaunch2.md) interface, the DE's implementation of this method should always return `E_NOTIMPL` because a DE cannot determine which process it is running in and therefore cannot satisfy an implementation of this method.  
  
 Implementing the `IDebugEngineLaunch2` interface means that the DE must know how to create a process; therefore, the DE's implementation of the [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md) interface is able to know what process it is running in.  
  
## See Also  
 [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)   
 [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md)   
 [IDebugEngineLaunch2](../../../extensibility/debugger/reference/idebugenginelaunch2.md)
