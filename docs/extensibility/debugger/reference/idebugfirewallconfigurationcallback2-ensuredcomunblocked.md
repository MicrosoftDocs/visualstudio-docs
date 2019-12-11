---
title: "IDebugFirewallConfigurationCallback2::EnsureDCOMUnblocked | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
helpviewer_keywords:
  - "EnsureDCOMUnblocked"
  - "IDebugFirewallConfigurationCallback2::EnsureDCOMUnblocked"
ms.assetid: acf54d27-32a6-47e7-aba6-3cc0004edc7f
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugFirewallConfigurationCallback2::EnsureDCOMUnblocked
Requests that the firewall not block remote debugging.

## Syntax

```cpp
HRESULT EnsureDCOMUnblocked(
    Void
);
```

```csharp
public int EnsureDCOMUnblocked();
```

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugFirewallConfigurationCallback2](../../../extensibility/debugger/reference/idebugfirewallconfigurationcallback2.md)