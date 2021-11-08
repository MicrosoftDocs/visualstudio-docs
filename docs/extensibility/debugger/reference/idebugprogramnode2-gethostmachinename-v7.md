---
title: IDebugProgramNode2::GetHostMachineName_V7 | Microsoft Docs
description: "This is old, deprecated method to get the host machine name used prior to Visual Studio 2005."
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgramNode2::GetHostMachineName
helpviewer_keywords:
- IDebugProgramNode2::GetHostMachineName_V7
- IDebugProgramNode2::GetHostMachineNameIDebugProgramNode2::GetHostMachineName
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugProgramNode2::GetHostMachineName_V7

> [!Note]
> DEPRECATED. DO NOT USE.

## Syntax

```cpp
HRESULT GetHostMachineName_V7 (
   BSTR* pbstrHostMachineName
);
```

```csharp
int GetHostMachineName_V7 (
   out string pbstrHostMachineName
);
```

## Parameters

`pbstrHostMachineName`\
[out] Returns the name of the machine in which the program is running.

## Return Value

An implementation should always return `E_NOTIMPL`.

## Remarks

> [!WARNING]
> As of Visual Studio 2005, this method is no longer used and should always return `E_NOTIMPL`.

## See also

- [IDebugProgramNode2](../../../extensibility/debugger/reference/idebugprogramnode2.md)
