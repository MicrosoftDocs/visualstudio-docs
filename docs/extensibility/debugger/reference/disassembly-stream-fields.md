---
description: "Specifies what information to retrieve about a disassembly field."
title: DISASSEMBLY_STREAM_FIELDS
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- DISASSEMBLY_STREAM_FIELDS
helpviewer_keywords:
- DISASSEMBLY_STREAM_FIELDS enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
ms.custom: sfi-ropc-nochange
dev_langs:
- CPP
- CSharp
---
# DISASSEMBLY_STREAM_FIELDS

Specifies what information to retrieve about a disassembly field.

## Syntax

### [C#](#tab/csharp)
```csharp
public enum enum_DISASSEMBLY_STREAM_FIELDS {
    DSF_ADDRESS          = 0x00000001,
    DSF_ADDRESSOFFSET    = 0x00000002,
    DSF_CODEBYTES        = 0x00000004,
    DSF_OPCODE           = 0x00000008,
    DSF_OPERANDS         = 0x00000010,
    DSF_SYMBOL           = 0x00000020,
    DSF_CODELOCATIONID   = 0x00000040,
    DSF_POSITION         = 0x00000080,
    DSF_DOCUMENTURL      = 0x00000100,
    DSF_BYTEOFFSET       = 0x00000200,
    DSF_FLAGS            = 0x00000400,
    DSF_OPERANDS_SYMBOLS = 0x00010000,
    DSF_ALL              = 0x000107ff
};
```
### [C++](#tab/cpp)
```cpp
enum enum_DISASSEMBLY_STREAM_FIELDS {
    DSF_ADDRESS          = 0x00000001,
    DSF_ADDRESSOFFSET    = 0x00000002,
    DSF_CODEBYTES        = 0x00000004,
    DSF_OPCODE           = 0x00000008,
    DSF_OPERANDS         = 0x00000010,
    DSF_SYMBOL           = 0x00000020,
    DSF_CODELOCATIONID   = 0x00000040,
    DSF_POSITION         = 0x00000080,
    DSF_DOCUMENTURL      = 0x00000100,
    DSF_BYTEOFFSET       = 0x00000200,
    DSF_FLAGS            = 0x00000400,
    DSF_OPERANDS_SYMBOLS = 0x00010000,
    DSF_ALL              = 0x000107ff
};
typedef DWORD DISASSEMBLY_STREAM_FIELDS;
```
---

## Fields
`DSF_ADDRESS`\
Initialize/use the `bstrAddress` field.

`DSF_ADDRESSOFFSET`\
Initialize/use the `bstrAddressOffset` field.

`DSF_CODEBYTES`\
Initialize/use the `bstrCodeBytes` field.

`DSF_OPCODE`\
Initialize/use the `bstrOpCode` field.

`DSF_OPERANDS`\
Initialize/use the `bstrOperands` field.

`DSF_SYMBOL`\
Initialize/use the `bstrSymbol` field.

`DSF_CODELOCATIONID`\
Initialize/use the `uCodeLocationId` field.

`DSF_POSITION`\
Initialize/use the `posBeg` and `posEnd` fields.

`DSF_DOCUMENTURL`\
Initialize/use the `bstrDocumentUrl` field.

`DSF_BYTEOFFSET`\
Initialize/use the `dwByteOffset` field.

`DSF_FLAGS`\
Initialize/use the `dwFlags` ([DISASSEMBLY_FLAGS](../../../extensibility/debugger/reference/disassembly-flags.md)) field.

`DSF_OPERANDS_SYMBOLS`\
Include symbol names in the `bstrOperands` field.

`DSF_ALL`\
Specifies all fields for the disassembly stream.

## Remarks
Passed as a parameter to the [Read](../../../extensibility/debugger/reference/idebugdisassemblystream2-read.md) method to indicate which fields of the [DisassemblyData](../../../extensibility/debugger/reference/disassemblydata.md) structure are to be initialized.

Used for the `dwFields` member of the `DisassemblyData` structure to indicate which fields are used and valid when the structure is returned.

These values may be combined with a bitwise `OR`.

## Requirements
Header: msdbg.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [DisassemblyData](../../../extensibility/debugger/reference/disassemblydata.md)
- [Read](../../../extensibility/debugger/reference/idebugdisassemblystream2-read.md)
- [DISASSEMBLY_FLAGS](../../../extensibility/debugger/reference/disassembly-flags.md)
