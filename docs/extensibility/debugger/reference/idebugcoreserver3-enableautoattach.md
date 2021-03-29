---
description: "Enables automatic attaching for the specified debug engines."
title: IDebugCoreServer3::EnableAutoAttach | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugCoreServer3::EnableAutoAttach
helpviewer_keywords:
- IDebugCoreServer3::EnableAutoAttach
ms.assetid: 06aa633b-263b-4e08-8844-9a52d5120b94
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugCoreServer3::EnableAutoAttach
Enables automatic attaching for the specified debug engines.

## Syntax

```cpp
HRESULT EnableAutoAttach(
   GUID*     rgguidSpecificEngines,
   DWORD     celtSpecificEngines,
   LPCOLESTR pszStartPageUrl,
   BSTR*     pbstrSessionId
);
```

```csharp
int EnableAutoAttach(
   Guid[]     rgguidSpecificEngines,
   uint       celtSpecificEngines,
   string     pszStartPageUrl,
   out string pbstrSessionId
);
```

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
