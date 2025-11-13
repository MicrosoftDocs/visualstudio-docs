---
description: "This structure is used to set the JustMyCode information for a module."
title: JMC_CODE_SPEC
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- JMC_CODE_SPEC
helpviewer_keywords:
- JMC_CODE_SPEC structure
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# JMC_CODE_SPEC

This structure is used to set the JustMyCode information for a module.

## Syntax

### [C#](#tab/csharp)
```csharp
public struct JMC_CODE_SPEC {
    public int    fIsUserCode;
    public string bstrModuleName;
};
```
### [C++](#tab/cpp)
```cpp
typedef struct _JMC_CODE_SPEC {
    BOOL fIsUserCode;
    BSTR bstrModuleName;
} JMC_CODE_SPEC;
```
---

## Members
`fIsUserCode`\
Non-zero (`TRUE`) if the module is to be considered user code; otherwise, zero (`FALSE`) if the module is to be treated as external code and not to be debugged.

`bstrModuleName`\
Name of the module in question.

## Remarks
This structure is passed as a list of such structures to the [SetJustMyCodeState](../../../extensibility/debugger/reference/idebugengine3-setjustmycodestate.md) method.

## Requirements
Header: msdbg.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Structures and Unions](../../../extensibility/debugger/reference/structures-and-unions.md)
- [SetJustMyCodeState](../../../extensibility/debugger/reference/idebugengine3-setjustmycodestate.md)
