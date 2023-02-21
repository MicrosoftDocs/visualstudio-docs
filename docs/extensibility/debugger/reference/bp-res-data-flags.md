---
description: "Specifies whether the data breakpoint is being emulated or implemented in hardware."
title: BP_RES_DATA_FLAGS | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- BP_RES_DATA_FLAGS
helpviewer_keywords:
- BP_RES_DATA_FLAGS enumeration
ms.assetid: d97611e2-def6-45a9-ad7d-eedf2ad4c82b
author: maiak
ms.author: maiak
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# BP_RES_DATA_FLAGS

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
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
