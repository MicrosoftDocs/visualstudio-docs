---
title: "IDebugFirewallConfigurationCallback2 | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
helpviewer_keywords:
  - "IDebugFirewallConfigurationCallback2 interface"
ms.assetid: 0827361c-b97c-4851-9898-ab6d88c81811
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# IDebugFirewallConfigurationCallback2
Enables a debug engine that uses DCOM to ask the [!INCLUDE[vsprvs](../../../code-quality/includes/vsprvs_md.md)] UI to make sure that the firewall will not block remote debugging.

## Syntax

```
IDebugFirewallConfigurationCallback2 : IUnknown
```

## Notes for Implementers
 Implemented by the port object of the session debug manager.

## Methods
 The following table shows the methods of `IDebugFirewallConfigurationCallback2`.

|Method|Description|
|------------|-----------------|
|[EnsureDCOMUnblocked](../../../extensibility/debugger/reference/idebugfirewallconfigurationcallback2-ensuredcomunblocked.md)|Requests that the firewall not block remote debugging.|

## Requirements
 Header: Msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll