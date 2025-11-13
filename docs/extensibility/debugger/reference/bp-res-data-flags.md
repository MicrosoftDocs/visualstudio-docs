---
description: "Specifies whether the data breakpoint is being emulated or implemented in hardware."
title: BP_RES_DATA_FLAGS
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- BP_RES_DATA_FLAGS
helpviewer_keywords:
- BP_RES_DATA_FLAGS enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# BP_RES_DATA_FLAGS

Specifies whether the data breakpoint is being emulated or implemented in hardware.

## Syntax

### [C#](#tab/csharp)
```csharp
public enum enum_BP_RES_DATA_FLAGS {
    BP_RES_DATA_EMULATED = 0x0001
};
```
### [C++](#tab/cpp)
```cpp
enum enum_BP_RES_DATA_FLAGS {
    BP_RES_DATA_EMULATED = 0x0001
};
typedef DWORD BP_RES_DATA_FLAGS;
```
---

## Fields
`BP_RES_DATA_EMULATED`\
Specifies that the data breakpoint is being emulated.

## Remarks
Used for the `dwFlags` member of the [BP_RESOLUTION_DATA](../../../extensibility/debugger/reference/bp-resolution-data.md) structure.

## Requirements
Header: msdbg.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [BP_RESOLUTION_DATA](../../../extensibility/debugger/reference/bp-resolution-data.md)
