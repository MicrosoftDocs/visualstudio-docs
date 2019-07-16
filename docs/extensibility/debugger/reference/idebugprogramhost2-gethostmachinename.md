---
title: "IDebugProgramHost2::GetHostMachineName | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugProgramHost2::GetHostMachineName"
helpviewer_keywords:
  - "IDebugProgramHost2::GetHostMachineName"
ms.assetid: 4677ffe4-aa9b-4450-a63b-74cd3984d956
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugProgramHost2::GetHostMachineName
Gets the name of the machine that the process hosting this program is running on.

## Syntax

```cpp
HRESULT GetHostMachineName( 
   BSTR* pbstrHostMachineName
);
```

```csharp
int GetHostMachineName( 
   out string pbstrHostMachineName
);
```

## Parameters
`pbstrHostMachineName`\
[out] Returns the name of the machine.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugProgramHost2](../../../extensibility/debugger/reference/idebugprogramhost2.md)