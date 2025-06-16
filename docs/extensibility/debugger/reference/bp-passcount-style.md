---
description: "Specifies the condition associated with the breakpoint pass count that causes the breakpoint to fire."
title: BP_PASSCOUNT_STYLE
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- BP_PASSCOUNT_STYLE
helpviewer_keywords:
- BP_PASSCOUNT_STYLE structure
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# BP_PASSCOUNT_STYLE

Specifies the condition associated with the breakpoint pass count that causes the breakpoint to fire.

## Syntax

### [C#](#tab/csharp)
```csharp
public enum enum_BP_PASSCOUNT_STYLE {
    BP_PASSCOUNT_NONE             = 0x0000,
    BP_PASSCOUNT_EQUAL            = 0x0001,
    BP_PASSCOUNT_EQUAL_OR_GREATER = 0x0002,
    BP_PASSCOUNT_MOD              = 0x0003
};
```
### [C++](#tab/cpp)
```cpp
enum enum_BP_PASSCOUNT_STYLE {
    BP_PASSCOUNT_NONE             = 0x0000,
    BP_PASSCOUNT_EQUAL            = 0x0001,
    BP_PASSCOUNT_EQUAL_OR_GREATER = 0x0002,
    BP_PASSCOUNT_MOD              = 0x0003
};
typedef DWORD BP_PASSCOUNT_STYLE;
```
---

## Fields
`BP_PASSCOUNT_NONE`\
Specifies no breakpoint pass count style.

`BP_PASSCOUNT_EQUAL`\
Sets the breakpoint pass count style to equal. The breakpoint fires when the number of times the breakpoint is hit equals the pass count.

`BP_PASSCOUNT_EQUAL_OR_GREATER`\
Sets the breakpoint pass count style to equal or greater. The breakpoint fires when the number of times the breakpoint is hit is equal to or greater than the pass count.

`BP_PASSCOUNT_MOD`\
Specifies a modulo pass count. For example, if the pass count is of the type `BP_PASSCOUNT_MOD` and the pass count value is 4, the breakpoint fires every time the hit count is a multiple of 4.

## Remarks
Used for the `stylePassCount` member of the [BP_PASSCOUNT](../../../extensibility/debugger/reference/bp-passcount.md) structure that is in turn a member of the [BP_REQUEST_INFO](../../../extensibility/debugger/reference/bp-request-info.md) and [BP_REQUEST_INFO2](../../../extensibility/debugger/reference/bp-request-info2.md) structures.

## Requirements
Header: msdbg.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [BP_PASSCOUNT](../../../extensibility/debugger/reference/bp-passcount.md)
- [BP_REQUEST_INFO](../../../extensibility/debugger/reference/bp-request-info.md)
- [BP_REQUEST_INFO2](../../../extensibility/debugger/reference/bp-request-info2.md)
