---
title: "IDebugSymbolProviderDirect::GetSymUnmanagedReader | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
helpviewer_keywords:
  - "GetSymUnmanagedReader"
  - "IDebugSymbolProviderDirect::GetSymUnmanagedReader"
ms.assetid: 147bacfa-f66c-43e0-8a72-e601058dc57f
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugSymbolProviderDirect::GetSymUnmanagedReader
Retrieves a symbol reader for unmanaged code.

## Syntax

```cpp
HRESULT GetSymUnmanagedReader (
   ULONG32    ulAppDomainID,
   GUID       guidModule,
   IUnknown** ppSymUnmanagedReader
);
```

```csharp
int GetSymUnmanagedReader (
   uint       ulAppDomainID,
   Guid       guidModule,
   out object ppSymUnmanagedReader
);
```

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