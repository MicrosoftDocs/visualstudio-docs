---
description: "This interface is used to represent and obtain information from a server on a machine on the network."
title: IDebugCoreServer2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugCoreServer2
helpviewer_keywords:
- IDebugCoreServer2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugCoreServer2

This interface is used to represent and obtain information from a server on a machine on the network.

## Syntax

```
IDebugCoreServer2 : IUknown
```

## Notes for Implementers
 Visual Studio implements this interface to represent a server. Each instance of Visual Studio creates an instance of this interface.

## Notes for Callers
 A custom port supplier receives this interface in a call to [Event](../../../extensibility/debugger/reference/idebugportevents2-event.md).

 A debug engine can obtain this interface indirectly through a call to [GetServer](../../../extensibility/debugger/reference/idebugdefaultport2-getserver.md) (which returns [IDebugCoreServer3](../../../extensibility/debugger/reference/idebugcoreserver3.md), an interface that is derived from `IDebugCoreServer2`).

## Methods in Vtable Order
 The following table shows the methods of `IDebugCoreServer2`.

|Method|Description|
|------------|-----------------|
|[GetMachineInfo](../../../extensibility/debugger/reference/idebugcoreserver2-getmachineinfo.md)|Gets the name and attributes of a machine.|
|[GetMachineName](../../../extensibility/debugger/reference/idebugcoreserver2-getmachinename.md)|Gets the name of a machine.|
|[GetPortSupplier](../../../extensibility/debugger/reference/idebugcoreserver2-getportsupplier.md)|Gets a port supplier that exists on a machine.|
|[GetPort](../../../extensibility/debugger/reference/idebugcoreserver2-getport.md)|Gets a port that already exists on a machine.|
|[EnumPorts](../../../extensibility/debugger/reference/idebugcoreserver2-enumports.md)|Creates an enumerator for all the ports on a machine.|
|[EnumPortSuppliers](../../../extensibility/debugger/reference/idebugcoreserver2-enumportsuppliers.md)|Creates an enumerator for all the port suppliers on a machine.|
|[GetMachineUtilities_V7](../../../extensibility/debugger/reference/idebugcoreserver2-getmachineutilities-v7.md)|Gets the machine utilities for a machine.|

## Remarks
 This interface is also used by Visual Studio to browse processes running on machines on the network.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [IDebugPort2](../../../extensibility/debugger/reference/idebugport2.md)
- [Event](../../../extensibility/debugger/reference/idebugportevents2-event.md)
- [GetServer](../../../extensibility/debugger/reference/idebugdefaultport2-getserver.md)
- [IDebugCoreServer3](../../../extensibility/debugger/reference/idebugcoreserver3.md)
