---
title: "IDebugSymbolProviderDirect::GetCurrentModulesInfo | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
helpviewer_keywords:
  - "IDebugSymbolProviderDirect::GetCurrentModulesInfo"
  - "GetCurrentModulesInfo"
ms.assetid: b3b45ed2-ea4e-4389-b78a-11fc9796a6c1
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugSymbolProviderDirect::GetCurrentModulesInfo
Retrieves information about the modules in the symbol group.

## Syntax

```cpp
HRESULT GetCurrentModulesInfo(
   unsigned long * pCount,
   GUID *          ppGuids,
   DWORD *         pADIds,
   DWORD *         pCurrentState,
   IUnknown **     ppCDModItfs
);
```

```csharp
int GetCurrentModulesInfo(
   uint       pCount,
   Guid       ppGuids,
   uint       pADIds,
   uint       pCurrentState,
   out object ppCDModItfs
);
```

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