---
description: "Retrieves a friendly name for the server."
title: IDebugCoreServer3::GetServerFriendlyName
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugCoreServer3::GetServerFriendlyName
helpviewer_keywords:
- IDebugCoreServer3::GetServerFriendlyName
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugCoreServer3::GetServerFriendlyName

Retrieves a friendly name for the server.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetServerFriendlyName(
   out string pbstrName
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetServerFriendlyName(
   BSTR* pbstrName
);
```
---

## Parameters
`pbstrName`\
[out] Returns a friendly name for the server.

> [!NOTE]
> The caller is responsible for freeing the string.

## Return Value
 If successful, returns `S_OK`; otherwise, returns error code.

## Remarks
 For user-launched servers, the name returned by this method is the full name of the server. For auto-launched servers, the name is that of the machine the server is running on.

 For a machine-oriented name, call the [GetServerName](../../../extensibility/debugger/reference/idebugcoreserver3-getservername.md) method.

## See also
- [IDebugCoreServer3](../../../extensibility/debugger/reference/idebugcoreserver3.md)
- [GetServerName](../../../extensibility/debugger/reference/idebugcoreserver3-getservername.md)
