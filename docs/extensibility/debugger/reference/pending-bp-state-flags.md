---
description: "Specifies the pending breakpoint state flags."
title: PENDING_BP_STATE_FLAGS
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- PENDING_BP_STATE_FLAGS
helpviewer_keywords:
- PENDING_BP_STATE_FLAGS enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# PENDING_BP_STATE_FLAGS

Specifies the pending breakpoint state flags.

## Syntax

### [C#](#tab/csharp)
```csharp
public enum enum_PENDING_BP_STATE_FLAGS { 
   PBPSF_NONE        = 0x0000,
   PBPSF_VIRTUALIZED = 0x0001
};
```
### [C++](#tab/cpp)
```cpp
enum enum_PENDING_BP_STATE_FLAGS { 
   PBPSF_NONE        = 0x0000,
   PBPSF_VIRTUALIZED = 0x0001
};
typedef DWORD PENDING_BP_STATE_FLAGS;
```
---

## Fields
 `PBPSF_NONE`
 Placeholder.

 `PBPSF_VIRTUALIZED`
 Specifies a virtualized pending breakpoint, one that is to be bound every time new code is loaded.

## Remarks
 Used for the `flags` member of the [PENDING_BP_STATE_INFO](../../../extensibility/debugger/reference/pending-bp-state-info.md) structure.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [PENDING_BP_STATE_INFO](../../../extensibility/debugger/reference/pending-bp-state-info.md)
