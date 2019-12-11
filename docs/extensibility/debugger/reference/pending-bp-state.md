---
title: "PENDING_BP_STATE | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "PENDING_BP_STATE"
helpviewer_keywords:
  - "PENDING_BP_STATE enumeration"
ms.assetid: ac04ad72-fa92-4a15-ade2-0d0bbbadfc7f
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# PENDING_BP_STATE
Specifies the state of a pending breakpoint (a breakpoint that has not yet been bound).

## Syntax

```cpp
enum enum_PENDING_BP_STATE { 
   PBPS_NONE     = 0x0000,
   PBPS_DELETED  = 0x0001,
   PBPS_DISABLED = 0x0002,
   PBPS_ENABLED  = 0x0003
};
typedef DWORD PENDING_BP_STATE;
```

```csharp
public enum enum_PENDING_BP_STATE { 
   PBPS_NONE     = 0x0000,
   PBPS_DELETED  = 0x0001,
   PBPS_DISABLED = 0x0002,
   PBPS_ENABLED  = 0x0003
};
```

## Fields
 `PBPS_NONE`\
 Placeholder for zero. This value is never returned.

 `PBPS_DELETED`\
 Indicates that the pending breakpoint has been deleted.

 `PBPS_DISABLED`\
 Indicates that the pending breakpoint is disabled.

 `PBPS_ENABLED`\
 Indicates that the pending breakpoint is enabled.

## Remarks
 Use as the `state` member of the [PENDING_BP_STATE_INFO](../../../extensibility/debugger/reference/pending-bp-state-info.md) structure.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [PENDING_BP_STATE_INFO](../../../extensibility/debugger/reference/pending-bp-state-info.md)