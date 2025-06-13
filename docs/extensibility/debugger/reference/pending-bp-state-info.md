---
description: "Contains information about the state of a breakpoint that is ready to bind to a code location."
title: PENDING_BP_STATE_INFO
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- PENDING_BP_STATE_INFO
helpviewer_keywords:
- PENDING_BP_STATE_INFO structure
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# PENDING_BP_STATE_INFO

Contains information about the state of a breakpoint that is ready to bind to a code location.

## Syntax

### [C#](#tab/csharp)
```csharp
public struct PENDING_BP_STATE_INFO { 
   public uint state;
   public uint flags;
};
```
### [C++](#tab/cpp)
```cpp
typedef struct _tagPENDING_BP_STATE_INFO { 
   PENDING_BP_STATE       state;
   PENDING_BP_STATE_FLAGS flags;
} PENDING_BP_STATE_INFO;
```
---

## Members
 `state`\
 A value from the [PENDING_BP_STATE](../../../extensibility/debugger/reference/pending-bp-state.md) enumeration that specifies the state of the pending breakpoint.

 `flags`\
 A combination of flags from the [PENDING_BP_STATE_FLAGS](../../../extensibility/debugger/reference/pending-bp-state-flags.md) enumeration that specifies whether the breakpoint is virtualized.

## Remarks
 This structure is passed to the [GetState](../../../extensibility/debugger/reference/idebugpendingbreakpoint2-getstate.md) method where it is filled in.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Structures and Unions](../../../extensibility/debugger/reference/structures-and-unions.md)
- [GetState](../../../extensibility/debugger/reference/idebugpendingbreakpoint2-getstate.md)
- [PENDING_BP_STATE](../../../extensibility/debugger/reference/pending-bp-state.md)
- [PENDING_BP_STATE_FLAGS](../../../extensibility/debugger/reference/pending-bp-state-flags.md)
