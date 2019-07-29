---
title: "BSTR_ARRAY | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "BSTR_ARRAY"
helpviewer_keywords:
  - "BSTR_ARRAY structure"
ms.assetid: 48da37f7-a237-48a9-9ff9-389c1a00862c
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# BSTR_ARRAY
A structure that describes an array of strings.

## Syntax

```cpp
typedef struct tagBSTR_ARRAY {
    DWORD dwCount;
    BSTR* Members;
} BSTR_ARRAY;
```

```csharp
struct BSTR_ARRAY {
    DWORD    dwCount;
    string[] Members;
}
```

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
