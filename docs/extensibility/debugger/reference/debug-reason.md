---
description: "Specifies why the process was launched for debugging."
title: DEBUG_REASON | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- DEBUG_REASON
helpviewer_keywords:
- DEBUG_REASON enumeration
ms.assetid: ad2ee898-8648-4671-9078-d32873862346
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# DEBUG_REASON
Specifies why the process was launched for debugging.

## Syntax

```cpp
enum enum_DEBUG_REASON {
    DEBUG_REASON_ERROR         = 0,
    DEBUG_REASON_USER_LAUNCHED = 1,
    DEBUG_REASON_USER_ATTACHED = 2,
    DEBUG_REASON_AUTO_ATTACHED = 3,
    DEBUG_REASON_CAUSALITY     = 4
};
typedef DWORD DEBUG_REASON;
```

```csharp
public enum enum_DEBUG_REASON {
    DEBUG_REASON_ERROR         = 0,
    DEBUG_REASON_USER_LAUNCHED = 1,
    DEBUG_REASON_USER_ATTACHED = 2,
    DEBUG_REASON_AUTO_ATTACHED = 3,
    DEBUG_REASON_CAUSALITY     = 4
};
```

## Fields
`DEBUG_REASON_ERROR`\
A non-specific error occurred (this is used as a default condition when none of the other reasons fit).

`DEBUG_REASON_USER_LAUNCHED`\
The process was launched at the user's request.

`DEBUG_REASON_USER_ATTACHED`\
The already-running process was attached to by the user.

`DEBUG_REASON_AUTO_ATTACHED`\
The process was automatically attached to when it was launched.

`DEBUG_REASON_CAUSALITY`\
The process was launched due to a *Just-In-Time* (JIT) debugging event.

## Remarks
Returned from the [GetDebugReason](../../../extensibility/debugger/reference/idebugprocess3-getdebugreason.md) method.

## Requirements
Header: msdbg.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [GetDebugReason](../../../extensibility/debugger/reference/idebugprocess3-getdebugreason.md)
