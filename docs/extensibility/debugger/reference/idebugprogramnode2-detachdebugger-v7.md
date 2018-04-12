---
title: "IDebugProgramNode2::DetachDebugger_V7 | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.technology: 
  - "vs-ide-sdk"
ms.topic: "conceptual"
f1_keywords: 
  - "IDebugProgramNode2::DetachDebugger"
helpviewer_keywords: 
  - "IDebugProgramNode2::DetachDebugger"
  - "IDebugProgramNode2::DetachDebugger_V7"
author: "gregvanl"
ms.author: "gregvanl"
manager: douge
ms.workload: 
  - "vssdk"
---
# IDebugProgramNode2::DetachDebugger_V7

> [!Note]
> DEPRECATED. DO NOT USE.

## Syntax

```cpp
HRESULT DetachDebugger_V7 (
   void 
);
```

```csharp
int DetachDebugger_V7 ();
```

## Return Value

An implementation should always return `E_NOTIMPL`.

## Remarks

> [!WARNING]
> As of Visual Studio 2005, this method is no longer used and should always return `E_NOTIMPL`.

This method is called when the debugger unexpectedly quits. When this method is called, the DE should resume the program as though the user detached from it. No more debug events should be sent. The program should be in a state where it is attachable from another instance of the debugger.

## See Also

[IDebugProgramNode2](../../../extensibility/debugger/reference/idebugprogramnode2.md)