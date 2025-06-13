---
description: "Retrieves information about the symbol group of which the symbol provider is a member."
title: IDebugSymbolProviderDirect::GetCurrentModulesState
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- GetCurrentModulesState
- IDebugSymbolProviderDirect::GetCurrentModulesState
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugSymbolProviderDirect::GetCurrentModulesState

Retrieves information about the symbol group of which the symbol provider is a member.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetCurrentModulesState(
    out uint pState,
    out uint count
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetCurrentModulesState(
    DWORD*          pState,
    unsigned long * count
);
```
---

## Parameters
`pState`\
[out] The state of the symbol provider group.

`count`\
[out] Number of modules in the group.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The state is changed whenever a module is added to, or removed from, the symbol group. Therefore, this method can be used to detect if a symbol group has been modified.

## See also
- [IDebugSymbolProviderDirect](../../../extensibility/debugger/reference/idebugsymbolproviderdirect.md)
