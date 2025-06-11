---
description: "A structure that describes an array of strings."
title: BSTR_ARRAY
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- BSTR_ARRAY
helpviewer_keywords:
- BSTR_ARRAY structure
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# BSTR_ARRAY

A structure that describes an array of strings.

## Syntax

### [C#](#tab/csharp)
```csharp
struct BSTR_ARRAY {
    DWORD    dwCount;
    string[] Members;
}
```
### [C++](#tab/cpp)
```cpp
typedef struct tagBSTR_ARRAY {
    DWORD dwCount;
    BSTR* Members;
} BSTR_ARRAY;
```
---

## Members
`dwCount`\
Number of strings in `Members` array.

`Members`\
Array of strings.

## Remarks
This structure is returned from the [EnumPersistedPorts](../../../extensibility/debugger/reference/idebugportsupplier3-enumpersistedports.md) method.

 [C++ only] Each individual string must be freed using `SysFreeString`, and the `Members` array must be freed with `CoTaskMemFree`.

## Requirements
Header: msdbg.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Structures and Unions](../../../extensibility/debugger/reference/structures-and-unions.md)
- [EnumPersistedPorts](../../../extensibility/debugger/reference/idebugportsupplier3-enumpersistedports.md)
