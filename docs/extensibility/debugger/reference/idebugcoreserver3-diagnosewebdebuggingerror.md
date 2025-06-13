---
description: "Attempts to determine why an auto-attach failed."
title: IDebugCoreServer3::DiagnoseWebDebuggingError
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugCoreServer3::DiagnoseWebDebuggingError
helpviewer_keywords:
- IDebugCoreServer3::DiagnoseWebDebuggingError
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugCoreServer3::DiagnoseWebDebuggingError

Attempts to determine why an auto-attach failed.

## Syntax

### [C#](#tab/csharp)
```csharp
int DiagnoseWebDebuggingError(
   string pszUrl
);
```
### [C++](#tab/cpp)
```cpp
HRESULT DiagnoseWebDebuggingError(
   LPCWSTR pszUrl
);
```
---

## Parameters
`pszUrl`\
[in] Not currently used; should always be set to a null value.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code. The following are other typical return codes:

|Code|Description|
|----------|-----------------|
|`S_WEBDBG_UNABLE_TO_DIAGNOSE`|Cannot determine why the remote server failed to start debugging.|
|`S_WEBDBG_DEBUG_VERB_BLOCKED`|Cannot debug on remote server, possibly due to insufficient permissions or because the DEBUG verb is not enabled.|
|`E_WEBDBG_DEBUG_VERB_BLOCKED`|The web server has been locked down and is blocking the DEBUG verb, which is required to enable debugging.|

## See also
- [IDebugCoreServer3](../../../extensibility/debugger/reference/idebugcoreserver3.md)
