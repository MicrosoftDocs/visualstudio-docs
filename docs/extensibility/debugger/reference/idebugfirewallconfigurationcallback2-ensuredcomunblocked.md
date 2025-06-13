---
description: "Requests that the firewall not block remote debugging."
title: IDebugFirewallConfigurationCallback2::EnsureDCOMUnblocked
titleSuffix: ""
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- EnsureDCOMUnblocked
- IDebugFirewallConfigurationCallback2::EnsureDCOMUnblocked
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugFirewallConfigurationCallback2::EnsureDCOMUnblocked

Requests that the firewall not block remote debugging.

## Syntax

### [C#](#tab/csharp)
```csharp
public int EnsureDCOMUnblocked();
```
### [C++](#tab/cpp)
```cpp
HRESULT EnsureDCOMUnblocked(
    Void
);
```
---

## Return Value

 If successful, returns `S_OK`; otherwise, returns an error code.

## See also

- [IDebugFirewallConfigurationCallback2](../../../extensibility/debugger/reference/idebugfirewallconfigurationcallback2.md)
