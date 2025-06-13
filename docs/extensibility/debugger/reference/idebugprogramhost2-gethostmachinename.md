---
description: "Gets the name of the machine that the process hosting this program is running on."
title: IDebugProgramHost2::GetHostMachineName
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgramHost2::GetHostMachineName
helpviewer_keywords:
- IDebugProgramHost2::GetHostMachineName
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProgramHost2::GetHostMachineName

Gets the name of the machine that the process hosting this program is running on.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetHostMachineName( 
   out string pbstrHostMachineName
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetHostMachineName( 
   BSTR* pbstrHostMachineName
);
```
---

## Parameters
`pbstrHostMachineName`\
[out] Returns the name of the machine.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugProgramHost2](../../../extensibility/debugger/reference/idebugprogramhost2.md)
