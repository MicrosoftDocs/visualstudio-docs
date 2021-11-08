---
description: "Specifies the breakpoint condition style for pending and bound breakpoints."
title: BP_COND_STYLE | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- BP_COND_STYLE
helpviewer_keywords:
- BP_COND_STYLE enumeration
ms.assetid: a93b1412-f447-48a1-af9d-38f3dbb3092f
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# BP_COND_STYLE
Specifies the breakpoint condition style for pending and bound breakpoints.

## Syntax

```cpp
enum enum_BP_COND_STYLE {
    BP_COND_NONE         = 0x0000,
    BP_COND_WHEN_TRUE    = 0x0001,
    BP_COND_WHEN_CHANGED = 0x0002
};
typedef DWORD BP_COND_STYLE;
```

```csharp
public enum enum_BP_COND_STYLE {
    BP_COND_NONE         = 0x0000,
    BP_COND_WHEN_TRUE    = 0x0001,
    BP_COND_WHEN_CHANGED = 0x0002
};
```

## Fields
`BP_COND_NONE`\
Fires the breakpoint when the breakpoint's position is reached. No breakpoint condition specified.

`BP_COND_WHEN_TRUE`\
Fires the breakpoint only when the conditional expression associated with the breakpoint evaluates to `true`.

`BP_COND_WHEN_CHANGED`\
Fires the breakpoint only when the value of the conditional expression associated with the breakpoint has changed from its previous evaluation.

## Remarks
Used for the `styleCondition` member of the [BP_CONDITION](../../../extensibility/debugger/reference/bp-condition.md) structure.

## Requirements
Header: msdbg.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [BP_CONDITION](../../../extensibility/debugger/reference/bp-condition.md)
