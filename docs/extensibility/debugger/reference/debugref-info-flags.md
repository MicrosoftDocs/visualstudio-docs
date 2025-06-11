---
description: "Specifies what information to retrieve about a debug reference object."
title: DEBUGREF_INFO_FLAGS
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- DEBUGREF_INFO_FLAGS
helpviewer_keywords:
- DEBUGREF_INFO_FLAGS enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# DEBUGREF_INFO_FLAGS

Specifies what information to retrieve about a debug reference object.

## Syntax

### [C#](#tab/csharp)
```csharp
public enum enum_DEBUGREF_INFO_FLAGS {
    DEBUGREF_INFO_NAME             = 0x00000001,
    DEBUGREF_INFO_TYPE             = 0x00000002,
    DEBUGREF_INFO_VALUE            = 0x00000004,
    DEBUGREF_INFO_ATTRIB           = 0x00000008,
    DEBUGREF_INFO_REFTYPE          = 0x00000010,
    DEBUGREF_INFO_REF              = 0x00000020,
    DEBUGREF_INFO_VALUE_AUTOEXPAND = 0x00010000,
    DEBUGREF_INFO_NONE             = 0x00000000,
    DEBUGREF_INFO_ALL              = 0xffffffff
};
```
### [C++](#tab/cpp)
```cpp
enum enum_DEBUGREF_INFO_FLAGS {
    DEBUGREF_INFO_NAME             = 0x00000001,
    DEBUGREF_INFO_TYPE             = 0x00000002,
    DEBUGREF_INFO_VALUE            = 0x00000004,
    DEBUGREF_INFO_ATTRIB           = 0x00000008,
    DEBUGREF_INFO_REFTYPE          = 0x00000010,
    DEBUGREF_INFO_REF              = 0x00000020,
    DEBUGREF_INFO_VALUE_AUTOEXPAND = 0x00010000,
    DEBUGREF_INFO_NONE             = 0x00000000,
    DEBUGREF_INFO_ALL              = 0xffffffff
};
typedef DWORD DEBUGREF_INFO_FLAGS;
```
---

## Fields
`DEBUGREF_INFO_NAME`\
Initialize/use the `bstrName` field in the structure.

`DEBUGREF_INFO_TYPE`\
Initialize/use the `bstrType` field in the structure.

`DEBUGREF_INFO_VALUE`\
Initialize/use the `bstrValue` field in the structure.

`DEBUGREF_INFO_ATTRIB`\
Initialize/use the `dwAttrib` field in the structure.

`DEBUGREF_INFO_REFTYPE`\
Initialize/use the `dwRefType` field in the structure.

`DEBUGREF_INFO_REF`\
Initialize/use the `pReference` field in the structure.

`DEBUGREF_INFO_VALUE_AUTOEXPAND`\
The value field should contain the auto-expanded value, if available, for this type of object.

`DEBUGREF_INFO_NONE`\
Indicates that no flags are set.

`DEBUGREF_INFO_ALL`\
Indicates a mask of the flags.

## Remarks
These flags are passed to the [EnumChildren](../../../extensibility/debugger/reference/idebugreference2-enumchildren.md) and [GetReferenceInfo](../../../extensibility/debugger/reference/idebugreference2-getreferenceinfo.md) methods to indicate which fields of the [DEBUG_REFERENCE_INFO](../../../extensibility/debugger/reference/debug-reference-info.md) structure are to be initialized.

Used for the `dwFields` member of the `DEBUG_REFERENCE_INFO` structure to indicate which fields are used and valid when the structure is returned.

These values may be combined with a bitwise `OR`.

## Requirements
Header: msdbg.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [DEBUG_REFERENCE_INFO](../../../extensibility/debugger/reference/debug-reference-info.md)
- [EnumChildren](../../../extensibility/debugger/reference/idebugreference2-enumchildren.md)
- [GetReferenceInfo](../../../extensibility/debugger/reference/idebugreference2-getreferenceinfo.md)
