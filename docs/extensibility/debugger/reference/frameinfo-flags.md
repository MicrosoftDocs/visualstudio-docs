---
description: "Specifies the information to retrieve about a stack frame object."
title: FRAMEINFO_FLAGS
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- FRAMEINFO_FLAGS
helpviewer_keywords:
- FRAMEINFO_FLAGS enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# FRAMEINFO_FLAGS

Specifies the information to retrieve about a stack frame object.

## Syntax

### [C#](#tab/csharp)
```csharp
public enum enum_FRAMEINFO_FLAGS {
    FIF_FUNCNAME              = 0x00000001,
    FIF_RETURNTYPE            = 0x00000002,
    FIF_ARGS                  = 0x00000004,
    FIF_LANGUAGE              = 0x00000008,
    FIF_MODULE                = 0x00000010,
    FIF_STACKRANGE            = 0x00000020,
    FIF_FRAME                 = 0x00000040,
    FIF_DEBUGINFO             = 0x00000080,
    FIF_STALECODE             = 0x00000100,
    FIF_ANNOTATEDFRAME        = 0x00000200,
    FIF_DEBUG_MODULEP         = 0x00000400,
    FIF_FUNCNAME_FORMAT       = 0x00001000,
    FIF_FUNCNAME_RETURNTYPE   = 0x00002000,
    FIF_FUNCNAME_ARGS         = 0x00004000,
    FIF_FUNCNAME_LANGUAGE     = 0x00008000,
    FIF_FUNCNAME_MODULE       = 0x00010000,
    FIF_FUNCNAME_LINES        = 0x00020000,
    FIF_FUNCNAME_OFFSET       = 0x00040000,
    FIF_FUNCNAME_ARGS_TYPES   = 0x00100000,
    FIF_FUNCNAME_ARGS_NAMES   = 0x00200000,
    FIF_FUNCNAME_ARGS_VALUES  = 0x00400000,
    FIF_FUNCNAME_ARGS_ALL     = 0x00700000,
    FIF_ARGS_TYPES            = 0x01000000,
    FIF_ARGS_NAMES            = 0x02000000,
    FIF_ARGS_VALUES           = 0x04000000,
    FIF_ARGS_ALL              = 0x07000000,
    FIF_ARGS_NOFORMAT         = 0x08000000,
    FIF_ARGS_NO_FUNC_EVAL     = 0x10000000,
    FIF_FILTER_NON_USER_CODE  = 0x20000000,
    FIF_ARGS_NO_TOSTRING      = 0x40000000,
    FIF_DESIGN_TIME_EXPR_EVAL = 0x80000000
};
```
### [C++](#tab/cpp)
```cpp
enum enum_FRAMEINFO_FLAGS {
    FIF_FUNCNAME              = 0x00000001,
    FIF_RETURNTYPE            = 0x00000002,
    FIF_ARGS                  = 0x00000004,
    FIF_LANGUAGE              = 0x00000008,
    FIF_MODULE                = 0x00000010,
    FIF_STACKRANGE            = 0x00000020,
    FIF_FRAME                 = 0x00000040,
    FIF_DEBUGINFO             = 0x00000080,
    FIF_STALECODE             = 0x00000100,
    FIF_ANNOTATEDFRAME        = 0x00000200,
    FIF_DEBUG_MODULEP         = 0x00000400,
    FIF_FUNCNAME_FORMAT       = 0x00001000,
    FIF_FUNCNAME_RETURNTYPE   = 0x00002000,
    FIF_FUNCNAME_ARGS         = 0x00004000,
    FIF_FUNCNAME_LANGUAGE     = 0x00008000,
    FIF_FUNCNAME_MODULE       = 0x00010000,
    FIF_FUNCNAME_LINES        = 0x00020000,
    FIF_FUNCNAME_OFFSET       = 0x00040000,
    FIF_FUNCNAME_ARGS_TYPES   = 0x00100000,
    FIF_FUNCNAME_ARGS_NAMES   = 0x00200000,
    FIF_FUNCNAME_ARGS_VALUES  = 0x00400000,
    FIF_FUNCNAME_ARGS_ALL     = 0x00700000,
    FIF_ARGS_TYPES            = 0x01000000,
    FIF_ARGS_NAMES            = 0x02000000,
    FIF_ARGS_VALUES           = 0x04000000,
    FIF_ARGS_ALL              = 0x07000000,
    FIF_ARGS_NOFORMAT         = 0x08000000,
    FIF_ARGS_NO_FUNC_EVAL     = 0x10000000,
    FIF_FILTER_NON_USER_CODE  = 0x20000000,
    FIF_ARGS_NO_TOSTRING      = 0x40000000,
    FIF_DESIGN_TIME_EXPR_EVAL = 0x80000000
};
typedef DWORD FRAMEINFO_FLAGS;
```
---

## Fields
`FIF_FUNCNAME`\
Initialize/use the `m_bstrFuncName` field.

`FIF_RETURNTYPE`\
Initialize/use the `m_bstrReturnType` field.

`FIF_ARGS`\
Initialize/use the `m_bstrArgs` field.

`FIF_LANGUAGE`\
Initialize/use the `m_bstrLanguage` field.

`FIF_MODULE`\
Initialize/use the `m_bstrModule` field.

`FIF_STACKRANGE`\
Initialize/use the `m_addrMin` and `m_addrMax` (stack range) fields.

`FIF_FRAME`\
Initialize/use the `m_pFrame` field.

`FIF_DEBUGINFO`\
Initialize/use the `m_fHasDebugInfo` field.

`FIF_STALECODE`\
Initialize/use the `m_fStaleCode` field.

`FIF_ANNOTATEDFRAME`\
Initialize/use the `m_fAnnotatedFrame` field.

`FIF_DEBUG_MODULEP`\
Initialize/use the `m_pModule` field.

`FIF_FUNCNAME_FORMAT`\
Formats the function name. The result is returned in the `m_bstrFunName` field and no other fields are filled out.

`FIF_FUNCNAME_RETURNTYPE`\
Adds the return type to the `m_bstrFuncName` field.

`FIF_FUNCNAME_ARGS`\
Adds the arguments to the `m_bstrFuncName` field.

`FIF_FUNCNAME_LANGUAGE`\
Adds the language to the `m_bstrFuncName` field.

`FIF_FUNCNAME_MODULE`\
Adds the module name to the `m_bstrFuncName` field.

`FIF_FUNCNAME_LINES`\
Adds the number of lines to the `m_bstrFuncName` field.

`FIF_FUNCNAME_OFFSET`\
Adds to the `m_bstrFuncName` field the offset in bytes from the start of the line if `FIF_FUNCNAME_LINES` is specified. If `FIF_FUNCNAME_LINES` is not specified, or if line numbers are not available, adds the offset in bytes from the start of the function.

`FIF_FUNCNAME_ARGS_TYPES`\
Adds the type of each function argument to the `m_bstrFuncName` field.

`FIF_FUNCNAME_ARGS_NAMES`\
Adds the name of each function argument to the `m_bstrFuncName` field.

`FIF_FUNCNAME_ARGS_VALUES`\
Adds the value of each function argument to the `m_bstrFuncName` field.

`FIF_FUNCNAME_ARGS_ALL`\
Adds the type, name, and value of all arguments to the `m_bstrFuncName` field.

`FIF_ARGS_TYPES`\
The argument types are retrieved and formatted.

`FIF_ARGS_NAMES`\
The argument names are retrieved and formatted.

`FIF_ARGS_VALUES`\
The argument values are retrieved and formatted.

`FIF_ARGS_ALL`\
Retrieve and format the type, name, and value of all arguments.

`FIF_ARGS_NOFORMAT`\
Specifies that the arguments are not be formatted (for example, do not add opening and closing parentheses around the argument list nor add a separator between arguments).

`FIF_ARGS_NO_FUNC_EVAL`\
Specifies that function (property) evaluation should not be used when retrieving argument values.

`FIF_FILTER_NON_USER_CODE`\
The debug engine is to filter non-user code frames so they are not included.

`FIF_ARGS_NO_TOSTRING`\
Do not allow `ToString()` function evaluation or formatting when returning function arguments.

`FIF_DESIGN_TIME_EXPR_EVAL`\
Frame information should be gotten from the hosted app-domain rather than the hosting process.

## Remarks
These flags are passed to the [EnumFrameInfo](../../../extensibility/debugger/reference/idebugthread2-enumframeinfo.md) and [GetInfo](../../../extensibility/debugger/reference/idebugstackframe2-getinfo.md) methods to indicate which fields are to be initialized in the [FRAMEINFO](../../../extensibility/debugger/reference/frameinfo.md) structure or structures.

These flags are also used to indicate which fields of the [FRAMEINFO](../../../extensibility/debugger/reference/frameinfo.md) structure are used and valid when the structure is returned. These values may be combined with a bitwise `OR`.

## Requirements
Header: msdbg.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [FRAMEINFO](../../../extensibility/debugger/reference/frameinfo.md)
- [EnumFrameInfo](../../../extensibility/debugger/reference/idebugthread2-enumframeinfo.md)
- [GetInfo](../../../extensibility/debugger/reference/idebugstackframe2-getinfo.md)
