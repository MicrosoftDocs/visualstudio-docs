---
title: "EncUnavailableReason | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "EncUnavailableReason"
helpviewer_keywords:
  - "EncUnavailableReason enumeration"
ms.assetid: c10aa4c0-d7e0-4de1-b8ff-7e050985eb12
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# EncUnavailableReason
`This is for internal use only!` Represents the reasons that **Edit and Continue** is not available.

## Syntax

```cpp
enum tagEncUnavailableReason {
    ENCUN_NONE,
    ENCUN_INTEROP,
    ENCUN_SQLCLR,
    ENCUN_MINIDUMP,
    ENCUN_EMBEDDED,
    ENCUN_ATTACH,
    ENCUN_WIN64
};
typedef enum tagEncUnavailableReason EncUnavailableReason;
```

```csharp
public enum EncUnavailableReason {
    ENCUN_NONE,
    ENCUN_INTEROP,
    ENCUN_SQLCLR,
    ENCUN_MINIDUMP,
    ENCUN_EMBEDDED,
    ENCUN_ATTACH,
    ENCUN_WIN64
};
```

## Fields
`ENCUN_NONE`\
No specific reason why Edit and Continue is not available.

`ENCUN_INTEROP`\
Edit and Continue is not available during an InterOp call.

`ENCUN_SQLCLR`\
Edit and Continue is not available during an SQL procedure call that uses the Common Language Runtime (CLR).

`ENCUN_MINIDUMP`\
Edit and Continue is not available while processing a mini-dump.

`ENCUN_EMBEDDED`\
Edit and Continue is not available when processing embedded code.

`ENCUN_ATTACH`\
Edit and Continue is not available because the session was attached to, not launched by, the debugger.

`ENCUN_WIN64`\
Edit and Continue is not available while processing 64-bit Windows code.

## Remarks
This enumeration is for internal use only by [!INCLUDE[vsprvs](../../../code-quality/includes/vsprvs_md.md)]. The [GetENCAvailableState](../../../extensibility/debugger/reference/idebugprocess3-getencavailablestate.md) and [DisableENC](../../../extensibility/debugger/reference/idebugprocess3-disableenc.md) methods as implemented by a custom port supplier should always return `E_NOTIMPL`.

## Requirements
Header: msdbg.idl

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)

- [DisableENC](../../../extensibility/debugger/reference/idebugprocess3-disableenc.md)

- [GetENCAvailableState](../../../extensibility/debugger/reference/idebugprocess3-getencavailablestate.md)
