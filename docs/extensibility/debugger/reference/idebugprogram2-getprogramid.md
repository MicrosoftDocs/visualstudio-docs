---
description: "Gets a GUID for this program."
title: IDebugProgram2::GetProgramId
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgram2::GetProgramId
helpviewer_keywords:
- IDebugProgram2::GetProgramId
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProgram2::GetProgramId

Gets a GUID for this program.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetProgramId( 
   out Guid pguidProgramId
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetProgramId( 
   GUID* pguidProgramId
);
```
---

## Parameters
`pguidProgramId`\
[out] Returns the `GUID` for this program.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 A debug engine (DE) must return the program identifier originally passed to the [OnAttach](../../../extensibility/debugger/reference/idebugprogramnodeattach2-onattach.md) or [Attach](../../../extensibility/debugger/reference/idebugengine2-attach.md) methods. This allows identification of the program across debugger components.

## See also
- [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)
- [OnAttach](../../../extensibility/debugger/reference/idebugprogramnodeattach2-onattach.md)
- [Attach](../../../extensibility/debugger/reference/idebugengine2-attach.md)
