---
title: "COMPUTER_INFO | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
helpviewer_keywords:
  - "COMPUTER_INFO structure"
ms.assetid: 943085b2-f165-462d-9a4e-2086f0cdfff4
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# COMPUTER_INFO
Describes the computer on which the debugger is running.

## Syntax

```cpp
typedef struct tagCOMPUTER_INFO
{
    WORD wProcessorArchitecture;
    WORD wSuiteMask;
    DWORD dwOperatingSystemVersion;
} COMPUTER_INFO;
```

```csharp
public struct COMPUTER_INFO
{
    public ushort wProcessorArchitecture;
    public ushort wSuiteMask;
    public uint dwOperatingSystemVersion;
}
```

## Members
`wProcessorArchitecture`\
Identifies the architecture of the microprocessor.

`wSuiteMask`\
Identifies the suite mask.

`dwOperatingSystemVersion`\
Operating system version number.

## Remarks
This structure is returned by the [GetComputerInfo](../../../extensibility/debugger/reference/idebugwindowscomputerport2-getcomputerinfo.md) method.

## Requirements
Header: Msdbg.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Structures and Unions](../../../extensibility/debugger/reference/structures-and-unions.md)
- [GetComputerInfo](../../../extensibility/debugger/reference/idebugwindowscomputerport2-getcomputerinfo.md)
