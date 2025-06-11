---
description: "Retrieves information about the modules in the symbol group."
title: IDebugSymbolProviderDirect::GetCurrentModulesInfo
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugSymbolProviderDirect::GetCurrentModulesInfo
- GetCurrentModulesInfo
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugSymbolProviderDirect::GetCurrentModulesInfo

Retrieves information about the modules in the symbol group.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetCurrentModulesInfo(
   uint       pCount,
   Guid       ppGuids,
   uint       pADIds,
   uint       pCurrentState,
   out object ppCDModItfs
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetCurrentModulesInfo(
   unsigned long * pCount,
   GUID *          ppGuids,
   DWORD *         pADIds,
   DWORD *         pCurrentState,
   IUnknown **     ppCDModItfs
);
```
---

## Parameters
`pCount`\
[in] Number of modules in the `ppGuids` array.

`ppGuids`\
[in] Array that contains the unique identifiers for the modules.

`pADIds`\
[in] Identifiers for the application domains.

`pCurrentState`\
[in] Current state of the symbol group.

`ppCDModItfs`\
[out] Returns an object that contains the modules in the symbol group.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugSymbolProviderDirect](../../../extensibility/debugger/reference/idebugsymbolproviderdirect.md)
