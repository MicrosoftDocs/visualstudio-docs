---
description: "Gets the name and identifier of the debug engine (DE) running a program."
title: IDebugProgramNode2::GetEngineInfo
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgramNode2::GetEngineInfo
helpviewer_keywords:
- IDebugProgramNode2::GetEngineInfo
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProgramNode2::GetEngineInfo

Gets the name and identifier of the debug engine (DE) running a program.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetEngineInfo(
   out string pbstrEngine,
   out Guid pguidEngine
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetEngineInfo ( 
   BSTR* pbstrEngine,
   GUID* pguidEngine
);
```
---

## Parameters
`pbstrEngine`\
[out] Returns the name of the DE running the program (C++-specific: this can be a null pointer indicating that the caller is not interested in the name of the engine).

`pguidEngine`\
[out] Returns the globally unique identifier of the DE running the program (C++-specific: this can be a null pointer indicating that the caller is not interested in the GUID of the engine).

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugProgramNode2](../../../extensibility/debugger/reference/idebugprogramnode2.md)
