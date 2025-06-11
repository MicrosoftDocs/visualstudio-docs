---
description: "Specifies what kind of information to retrieve for a particular machine."
title: MACHINE_INFO_FIELDS
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- MACHINE_INFO_FIELDS
helpviewer_keywords:
- MACHINE_INFO_FIELDS enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# MACHINE_INFO_FIELDS

Specifies what kind of information to retrieve for a particular machine.

## Syntax

### [C#](#tab/csharp)
```csharp
public enum enum_MACHINE_INFO_FIELDS { 
   MCIF_NAME  = 0x00000001,
   MCIF_FLAGS = 0x00000002,
   MCIF_ALL   = 0x00000003
};
```
### [C++](#tab/cpp)
```cpp
enum enum_MACHINE_INFO_FIELDS { 
   MCIF_NAME  = 0x00000001,
   MCIF_FLAGS = 0x00000002,
   MCIF_ALL   = 0x00000003
};
typedef DWORD MACHINE_INFO_FIELDS;
```
---

## Fields
 `MCIF_NAME`\
 Initialize/use the `bstrName` field in the structure.

 `MCIF_FLAGS`\
 Initialize/use the `Flags` field in the structure.

 `MIF_ALL`\
 Initialize/use all of the fields in the structure.

## Remarks
 These values are passed to the [GetMachineInfo](../../../extensibility/debugger/reference/idebugcoreserver2-getmachineinfo.md) method to indicate which members of the [MACHINE_INFO](../../../extensibility/debugger/reference/machine-info.md) structure are to be initialized.

 Also used in the `Fields` member of the `MACHINE_INFO` structure to indicate which fields are used and valid.

 These flags may be combined with a bitwise `OR`.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [MACHINE_INFO](../../../extensibility/debugger/reference/machine-info.md)
- [GetMachineInfo](../../../extensibility/debugger/reference/idebugcoreserver2-getmachineinfo.md)
