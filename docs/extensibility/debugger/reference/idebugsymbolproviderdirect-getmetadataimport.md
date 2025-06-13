---
description: "Retrieves the metadata import information."
title: IDebugSymbolProviderDirect::GetMetaDataImport
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- GetMetaDataImport
- IDebugSymbolProviderDirect::GetMetaDataImport
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugSymbolProviderDirect::GetMetaDataImport

Retrieves the metadata import information.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetMetaDataImport (
    Guid       guid,
    uint       appID,
    out object ppImport
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetMetaDataImport (
    GUID*      guid,
    DWORD      appID,
    IUnknown** ppImport
);
```
---

## Parameters
`guid`\
[in] Unique identifier for the module.

`appID`\
[in] Identifier for the application domain.

`ppImport`\
[out] Returns an object that contains the metadata import information.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugSymbolProviderDirect](../../../extensibility/debugger/reference/idebugsymbolproviderdirect.md)
