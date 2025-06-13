---
description: "Specifies the flags for disassembly."
title: DISASSEMBLY_FLAGS
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- DISASSEMBLY_FLAGS
helpviewer_keywords:
- DISASSEMBLY_FLAGS enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# DISASSEMBLY_FLAGS

Specifies the flags for disassembly.

## Syntax

### [C#](#tab/csharp)
```csharp
public enum enum_DISASSEMBLY_FLAGS {
    DF_DOCUMENTCHANGE     = 0x00000001,
    DF_DISABLED           = 0x00000002,
    DF_INSTRUCTION_ACTIVE = 0x00000004,
    DF_DATA               = 0x00000008,
    DF_HASSOURCE          = 0x00000010,
    DF_DOCUMENT_CHECKSUM  = 0x00000020
};
```
### [C++](#tab/cpp)
```cpp
enum enum_DISASSEMBLY_FLAGS {
    DF_DOCUMENTCHANGE     = 0x00000001,
    DF_DISABLED           = 0x00000002,
    DF_INSTRUCTION_ACTIVE = 0x00000004,
    DF_DATA               = 0x00000008,
    DF_HASSOURCE          = 0x00000010,
    DF_DOCUMENT_CHECKSUM  = 0x00000020
};
typedef DWORD DISASSEMBLY_FLAGS;
```
---

## Fields
`DF_DOCUMENTCHANGE`\
Indicates that this instruction is in a different document than the previous one.

`DF_DISABLED`\
Indicates that this instruction will not be executed.

`DF_INSTRUCTION_ACTIVE`\
Indicates that this instruction is one of the next instructions to be executed (there may be more than one).

`DF_DATA`\
Indicates that this instruction is really data (not code).

`DF_HASSOURCE`\
Indicates that this instruction has source. Some instructions, such as profiling or garbage collection code, have no corresponding source.

`DF_DOCUMENT_CHECKSUM`\
Indicates that `bstrDocumentUrl` field contains checksum data after the document URL. See the Remarks section for the [DisassemblyData](../../../extensibility/debugger/reference/disassemblydata.md) structure for how the checksum data is stored.

## Remarks
Used as the `dwFlags` member of the [DisassemblyData](../../../extensibility/debugger/reference/disassemblydata.md) structure.

These flags may be combined with a bitwise `OR`.

## Requirements
Header: msdbg.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [DisassemblyData](../../../extensibility/debugger/reference/disassemblydata.md)
