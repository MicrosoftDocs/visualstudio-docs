---
description: "Represents the reasons that Edit and Continue is not available."
title: EncUnavailableReason
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- EncUnavailableReason
helpviewer_keywords:
- EncUnavailableReason enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# EncUnavailableReason

`This is for internal use only!` Represents the reasons that **Edit and Continue** is not available.

## Syntax

### [C#](#tab/csharp)
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
### [C++](#tab/cpp)
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
---

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
This enumeration is for internal use only by Visual Studio. The [GetENCAvailableState](../../../extensibility/debugger/reference/idebugprocess3-getencavailablestate.md) and [DisableENC](../../../extensibility/debugger/reference/idebugprocess3-disableenc.md) methods as implemented by a custom port supplier should always return `E_NOTIMPL`.

## Requirements
Header: msdbg.idl

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)

- [DisableENC](../../../extensibility/debugger/reference/idebugprocess3-disableenc.md)

- [GetENCAvailableState](../../../extensibility/debugger/reference/idebugprocess3-getencavailablestate.md)
