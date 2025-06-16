---
title: IDebugProgramNode2::DetachDebugger_V7
description: "This method is an old, deprecated form of the detach method used prior to Visual Studio 2005."
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgramNode2::DetachDebugger
helpviewer_keywords:
- IDebugProgramNode2::DetachDebugger
- IDebugProgramNode2::DetachDebugger_V7
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProgramNode2::DetachDebugger_V7

> [!Note]
> DEPRECATED. DO NOT USE.

## Syntax

### [C#](#tab/csharp)
```csharp
int DetachDebugger_V7 ();
```
### [C++](#tab/cpp)
```cpp
HRESULT DetachDebugger_V7 (
   void 
);
```
---

## Return Value

An implementation should always return `E_NOTIMPL`.

## Remarks

> [!WARNING]
> As of Visual Studio 2005, this method is no longer used and should always return `E_NOTIMPL`.

This method is called when the debugger unexpectedly quits. When this method is called, the DE should resume the program as though the user detached from it. No more debug events should be sent. The program should be in a state where it is attachable from another instance of the debugger.

## See also

- [IDebugProgramNode2](../../../extensibility/debugger/reference/idebugprogramnode2.md)
