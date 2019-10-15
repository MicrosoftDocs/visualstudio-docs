---
title: "IDebugProgramDestroyEvent2::GetExitCode | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugProgramDestroyEvent2::GetExitCode"
helpviewer_keywords:
  - "IDebugProgramDestroyEvent2::GetExitCode"
ms.assetid: 7f540cf6-e2d1-42b0-913e-a26d654b7659
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugProgramDestroyEvent2::GetExitCode
Gets the program's exit code.

## Syntax

```cpp
HRESULT GetExitCode( 
   DWORD* pdwExit
);
```

```csharp
int GetExitCode( 
   out uint pdwExit
);
```

## Parameters
`pdwExit`\
[out] Returns the program's exit code.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugProgramDestroyEvent2](../../../extensibility/debugger/reference/idebugprogramdestroyevent2.md)