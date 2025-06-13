---
description: "Enables automatic attaching for the specified debug engines."
title: IDebugCoreServer3::EnableAutoAttach
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugCoreServer3::EnableAutoAttach
helpviewer_keywords:
- IDebugCoreServer3::EnableAutoAttach
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugCoreServer3::EnableAutoAttach

Enables automatic attaching for the specified debug engines.

## Syntax

### [C#](#tab/csharp)
```csharp
int EnableAutoAttach(
   Guid[]     rgguidSpecificEngines,
   uint       celtSpecificEngines,
   string     pszStartPageUrl,
   out string pbstrSessionId
);
```
### [C++](#tab/cpp)
```cpp
HRESULT EnableAutoAttach(
   GUID*     rgguidSpecificEngines,
   DWORD     celtSpecificEngines,
   LPCOLESTR pszStartPageUrl,
   BSTR*     pbstrSessionId
);
```
---

## Parameters
`rgguidSpecificEngines`\
[in] Array of GUIDs for each debug engine to mark as auto-attaching.

`celtSpecificEngines`\
[in] The number of engines specified in `rgguidSpecificEngines`.

`pszStartPageUrl`\
[in] The starting URL to use when auto-attaching.

`pbstrSessionID`\
[out] ID of the session that was auto-attached.

## Return Value
 If successful, returns `S_OK`; otherwise returns error code. One error code is `E_AUTO_ATTACH_NOT_REGISTERED`, which indicates that the auto-attach class factory has not been registered.

## Remarks
 When a program associated with the specified URL is started, the specified debug engines are automatically started and attached.

## See also
- [IDebugCoreServer3](../../../extensibility/debugger/reference/idebugcoreserver3.md)
