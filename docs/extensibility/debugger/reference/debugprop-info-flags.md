---
description: "Specifies what information to retrieve about a debug property object."
title: DEBUGPROP_INFO_FLAGS
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- DEBUGPROP_INFO_FLAGS
helpviewer_keywords:
- DBGPROP_INFO_FLAGS enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# DEBUGPROP_INFO_FLAGS

Specifies what information to retrieve about a debug property object.

## Syntax

### [C#](#tab/csharp)
```csharp
public enum enum_DEBUGPROP_INFO_FLAGS {
    DEBUGPROP_INFO_FULLNAME          = 0x00000001,
    DEBUGPROP_INFO_NAME              = 0x00000002,
    DEBUGPROP_INFO_TYPE              = 0x00000004,
    DEBUGPROP_INFO_VALUE             = 0x00000008,
    DEBUGPROP_INFO_ATTRIB            = 0x00000010,
    DEBUGPROP_INFO_PROP              = 0x00000020,
    DEBUGPROP_INFO_VALUE_AUTOEXPAND  = 0x00010000,
    DEBUGPROP_INFO_VALUE_NOFUNCEVAL  = 0x00020000,
    DEBUGPROP_INFO_VALUE_RAW         = 0x00040000,
    DEBUGPROP_INFO_VALUE_NO_TOSTRING = 0x00080000
    DEBUGPROP_INFO_NONE              = 0x00000000,
    DEBUGPROP_INFO_STANDARD          = DEBUGPROP_INFO_ATTRIB |
                                        DEBUGPROP_INFO_NAME |
                                        DEBUGPROP_INFO_TYPE |
                                        DEBUGPROP_INFO_VALUE,
    DEBUGPROP_INFO_ALL               = 0xffffffff
};
```
### [C++](#tab/cpp)
```cpp
enum enum_DEBUGPROP_INFO_FLAGS {
    DEBUGPROP_INFO_FULLNAME          = 0x00000001,
    DEBUGPROP_INFO_NAME              = 0x00000002,
    DEBUGPROP_INFO_TYPE              = 0x00000004,
    DEBUGPROP_INFO_VALUE             = 0x00000008,
    DEBUGPROP_INFO_ATTRIB            = 0x00000010,
    DEBUGPROP_INFO_PROP              = 0x00000020,
    DEBUGPROP_INFO_VALUE_AUTOEXPAND  = 0x00010000,
    DEBUGPROP_INFO_VALUE_NOFUNCEVAL  = 0x00020000,
    DEBUGPROP_INFO_VALUE_RAW         = 0x00040000,
    DEBUGPROP_INFO_VALUE_NO_TOSTRING = 0x00080000
    DEBUGPROP_INFO_NONE              = 0x00000000,
    DEBUGPROP_INFO_STANDARD          = DEBUGPROP_INFO_ATTRIB |
                                        DEBUGPROP_INFO_NAME |
                                        DEBUGPROP_INFO_TYPE |
                                        DEBUGPROP_INFO_VALUE,
    DEBUGPROP_INFO_ALL               = 0xffffffff
};
typedef DWORD DEBUGPROP_INFO_FLAGS;
```
---

## Fields
`DEBUGPROP_INFO_FULLNAME`\
Initialize/use the `bstrFullName` field.

`DEBUGPROP_INFO_NAME`\
Initialize/use the `bstrName` field.

`DEBUGPROP_INFO_TYPE`\
Initialize/use the `bstrType` field.

`DEBUGPROP_INFO_VALUE`\
Initialize/use the `bstrValue` field.

`DEBUGPROP_INFO_ATTRIB`\
Initialize/use the `dwAttrib` field.

`DEBUGPROP_INFO_PROP`\
Initialize/use the `pProperty` field that contains an [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md) interface.

`DEBUGPROP_INFO_VALUE_AUTOEXPAND`\
Specifies that the value field should contain the auto-expanded value, if available, for this type of object.

`DEBUGPROP_INFO_VALUE_NOFUNCEVAL`\
Deprecated.

`DEBUGPROP_INFO_VALUE_RAW`\
Do not return any beautified values or members (that is, do not format the values).

`DEBUGPROP_INFO_VALUE_NO_TOSTRING`\
Do not return any special synthesized values (for example, do not call `ToString()` on an object to produce a value).

`DEBUGPROP_INFO_NONE`\
Specifies that no flags are set.

`DEBUGPROP_INFO_STANDARD`\
Initialize/use the `dwAttrib`, `bstrName`, `bstrType`, and `bstrValue` fields.

`DEBUGPROP_INFO_All`\
Indicates a mask of all flags.

## Remarks
These values are passed to the [GetPropertyInfo](../../../extensibility/debugger/reference/idebugproperty2-getpropertyinfo.md), [EnumChildren](../../../extensibility/debugger/reference/idebugproperty2-enumchildren.md), and [EnumProperties](../../../extensibility/debugger/reference/idebugstackframe2-enumproperties.md) methods to indicate which fields are to be initialized the [DEBUG_PROPERTY_INFO](../../../extensibility/debugger/reference/debug-property-info.md) structure.

These values are also used for the `dwFields` member of the `DEBUG_PROPERTY_INFO` structure to indicate which fields of the structure are used and valid when the structure is returned.

These values may be combined with a bitwise `OR`.

## Requirements
Header: msdbg.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md)
- [GetPropertyInfo](../../../extensibility/debugger/reference/idebugproperty2-getpropertyinfo.md)
- [EnumChildren](../../../extensibility/debugger/reference/idebugproperty2-enumchildren.md)
- [EnumProperties](../../../extensibility/debugger/reference/idebugstackframe2-enumproperties.md)
- [DEBUG_PROPERTY_INFO](../../../extensibility/debugger/reference/debug-property-info.md)
