---
description: "Informs a debug engine (DE) that the program specified has been atypically terminated and that the DE should clean up all references to the program and send a program destroy event."
title: IDebugEngine2::DestroyProgram
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugEngine2::DestroyProgram
helpviewer_keywords:
- IDebugEngine2::DestroyProgram
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugEngine2::DestroyProgram

Informs a debug engine (DE) that the program specified has been atypically terminated and that the DE should clean up all references to the program and send a program destroy event.

## Syntax

```cpp
HRESULT DestroyProgram( 
   IDebugProgram2* pProgram
);
```

```cpp
int DestroyProgram( 
   IDebugProgram2 pProgram
);
```

## Parameters
`pProgram`\
[in] An [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md) object that represents the program that has been atypically terminated.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 After this method is called, the DE subsequently sends an [IDebugProgramDestroyEvent2](../../../extensibility/debugger/reference/idebugprogramdestroyevent2.md) event back to the session debug manager (SDM).

 This method is not implemented (returns `E_NOTIMPL`) if the DE runs in the same process as the program being debugged. This method is implemented only if the DE runs in the same process as the SDM.

## See also
- [IDebugEngine2](../../../extensibility/debugger/reference/idebugengine2.md)
- [IDebugProgramDestroyEvent2](../../../extensibility/debugger/reference/idebugprogramdestroyevent2.md)
- [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)
