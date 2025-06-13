---
description: "Retrieves the identifier for the application domain."
title: IDebugAlias2::GetAppDomainId
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- GetAppDomainId
- IDebugAlias2::GetAppDomainId
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugAlias2::GetAppDomainId

Retrieves the identifier for the application domain.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetAppDomainId (
   out uint pappDomainId
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetAppDomainId (
   ULONG32* pappDomainId
);
```
---

## Parameters
`pappDomainId`\
[out] Returns the application domain identifier.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The application domain identifier changes whenever the application is restarted and a new application domain is created.

## See also
- [IDebugAlias2](../../../extensibility/debugger/reference/idebugalias2.md)
