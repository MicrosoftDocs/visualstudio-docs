---
description: "Retrieves a symbol reader for unmanaged code."
title: IDebugSymbolProviderDirect::GetSymUnmanagedReader | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- GetSymUnmanagedReader
- IDebugSymbolProviderDirect::GetSymUnmanagedReader
ms.assetid: 147bacfa-f66c-43e0-8a72-e601058dc57f
author: maiak
ms.author: maiak
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugSymbolProviderDirect::GetSymUnmanagedReader

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
Retrieves a symbol reader for unmanaged code.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetSymUnmanagedReader (
   uint       ulAppDomainID,
   Guid       guidModule,
   out object ppSymUnmanagedReader
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetSymUnmanagedReader (
   ULONG32    ulAppDomainID,
   GUID       guidModule,
   IUnknown** ppSymUnmanagedReader
);
```
---

## Parameters
`ulAppDomainID`\
[in] Identifier of the application domain.

`guidModule`\
[in] Unique identifier of the module.

`ppSymUnmanagedReader`\
[out] Returns an object that represents the symbol reader for unmanaged code.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugSymbolProviderDirect](../../../extensibility/debugger/reference/idebugsymbolproviderdirect.md)
