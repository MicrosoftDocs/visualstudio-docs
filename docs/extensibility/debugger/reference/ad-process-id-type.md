---
description: "Specifies how to interpret a process ID in the AD_PROCESS_ID structure."
title: AD_PROCESS_ID_TYPE
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- AD_PROCESS_ID_TYPE
helpviewer_keywords:
- AD_PROCESS_ID_TYPE enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# AD_PROCESS_ID_TYPE

Specifies how to interpret a process ID in the [AD_PROCESS_ID](../../../extensibility/debugger/reference/ad-process-id.md) structure.

## Syntax

### [C#](#tab/csharp)
```csharp
public enum enum_AD_PROCESS_ID {
    AD_PROCESS_ID_SYSTEM = 0,
    AD_PROCESS_ID_GUID   = 1
};
```
### [C++](#tab/cpp)
```cpp
enum enum_AD_PROCESS_ID {
    AD_PROCESS_ID_SYSTEM = 0,
    AD_PROCESS_ID_GUID   = 1
};
typedef DWORD AD_PROCESS_ID_TYPE;
```
---

## Fields
`AD_PROCESS_ID_SYSTEM`\
Process ID is a system identifier. Use the `ProcessId.dwProcessId` field of the [AD_PROCESS_ID](../../../extensibility/debugger/reference/ad-process-id.md) structure.

`AD_PROCESS_ID_GUID`\
Process ID is a GUID. Use the `ProcessId.guidProcessId` field of the `AD_PROCESS_ID` structure.

## Remarks
Used for the `ProcessIdType` member of the [AD_PROCESS_ID](../../../extensibility/debugger/reference/ad-process-id.md) structure to identify the type of process ID that is contained in the structure. Determines how to interpret the `ProcessId` union in the structure.

## Requirements
Header: msdbg.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [AD_PROCESS_ID](../../../extensibility/debugger/reference/ad-process-id.md)
