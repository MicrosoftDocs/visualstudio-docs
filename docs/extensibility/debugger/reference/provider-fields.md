---
description: "Specifies properties associated with a program provider."
title: PROVIDER_FIELDS | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- PROVIDER_FIELDS
helpviewer_keywords:
- PROVIDER_FIELDS enumeration
ms.assetid: 39631545-2b0e-45b4-978b-d63656484b02
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# PROVIDER_FIELDS
Specifies properties associated with a program provider.

## Syntax

```cpp
enum enum_PROVIDER_FIELDS {
   PFIELD_PROGRAM_NODES       = 0x01,
   PFIELD_IS_DEBUGGER_PRESENT = 0x02
};
typedef DWORD PROVIDER_FIELDS;
```

```csharp
public enum enum_PROVIDER_FIELDS {
   PFIELD_PROGRAM_NODES       = 0x01,
   PFIELD_IS_DEBUGGER_PRESENT = 0x02
};
```

## Fields
 `PFIELD_PROGRAM_NODES`\
 The `ProgramNodes` field is valid.

 `PFIELD_IS_DEBUGGER_PRESENT`\
 The `fIsDebuggerPresent` field is valid.

## Remarks
 These values are returned in the `Fields` member of the [PROVIDER_PROCESS_DATA](../../../extensibility/debugger/reference/provider-process-data.md) structure to indicate which fields of the structure were explicitly filled in.

 These values can be combined with a bitwise `OR`.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [PROVIDER_PROCESS_DATA](../../../extensibility/debugger/reference/provider-process-data.md)
