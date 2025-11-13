---
description: "Enables a debug engine that uses DCOM to ask the Visual Studio UI to make sure that the firewall will not block remote debugging."
title: IDebugFirewallConfigurationCallback2
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugFirewallConfigurationCallback2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugFirewallConfigurationCallback2

Enables a debug engine that uses DCOM to ask the Visual Studio UI to make sure that the firewall will not block remote debugging.

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
