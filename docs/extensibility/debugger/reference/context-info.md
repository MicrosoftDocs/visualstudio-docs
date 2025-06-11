---
description: "This structure describes a memory context or code context."
title: CONTEXT_INFO
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- CONTEXT_INFO
helpviewer_keywords:
- CONTEXT_INFO structure
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# CONTEXT_INFO

This structure describes a memory context or code context.

## Syntax

### [C#](#tab/csharp)
```csharp
public struct CONTEXT_INFO {
    public uint          dwFields;
    public string        bstrModuleUrl;
    public string        bstrFunction;
    public TEXT_POSITION posFunctionOffset;
    public string        bstrAddress;
    public string        bstrAddressOffset;
    public string        bstrAddressAbsolute;
};
```
### [C++](#tab/cpp)
```cpp
typedef struct _tagCONTEXT_INFO {
    CONTEXT_INFO_FIELDS dwFields;
    BSTR                bstrModuleUrl;
    BSTR                bstrFunction;
    TEXT_POSITION       posFunctionOffset;
    BSTR                bstrAddress;
    BSTR                bstrAddressOffset;
    BSTR                bstrAddressAbsolute;
} CONTEXT_INFO;
```
---

## Members
`dwFields`\
A combination of flags from he [CONTEXT_INFO_FIELDS](../../../extensibility/debugger/reference/context-info-fields.md) enumeration that specifies which fields are filled out<strong>.</strong>

`bstrModuleUrl`\
The name of the module where the context is located.

`bstrFunction`\
The function name where the context is located.

`posFunctionOffset`\
A [TEXT_POSITION](../../../extensibility/debugger/reference/text-position.md) structure that identifies the line and column offset of the function associated with the code context.

`bstrAddress`\
The address in code where the given context is located.

`bstrAddressOffset`\
The offset of the address in code where the given context is located.

`bstrAddressAbsolute`\
The absolute address in memory where the given context is located.

## Remarks
This structure is returned from a call to the [GetInfo](../../../extensibility/debugger/reference/idebugmemorycontext2-getinfo.md) method.

A typical use for this structure is in support of a **Memory** debug window.

## Requirements
Header: msdbg.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Structures and Unions](../../../extensibility/debugger/reference/structures-and-unions.md)
- [GetInfo](../../../extensibility/debugger/reference/idebugmemorycontext2-getinfo.md)
- [CONTEXT_INFO_FIELDS](../../../extensibility/debugger/reference/context-info-fields.md)
- [TEXT_POSITION](../../../extensibility/debugger/reference/text-position.md)
