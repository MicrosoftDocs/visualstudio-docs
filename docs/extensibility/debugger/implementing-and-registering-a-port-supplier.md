---
title: Implementing and Registering a Port Supplier
description: Learn how to implement and register a port supplier, which tracks and supplies ports, which manage processes.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- debugging [Debugging SDK], registering port suppliers
- port suppliers, registering
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Implement and register a port supplier

The role of a port supplier is to track and supply ports, which in turn manage processes. When a port needs to be created, the port supplier is instantiated using CoCreate with the port supplier's GUID (the session debug manager [SDM] will use the port supplier that the user selected or the port supplier specified by the project system). The SDM then calls [CanAddPort](../../extensibility/debugger/reference/idebugportsupplier2-canaddport.md) to see if any ports can be added. If a port can be added, a new port is requested by calling [AddPort](../../extensibility/debugger/reference/idebugportsupplier2-addport.md) and passing it an [IDebugPortRequest2](../../extensibility/debugger/reference/idebugportrequest2.md) that describes the port. `AddPort` returns a new port represented by an [IDebugPort2](../../extensibility/debugger/reference/idebugport2.md) interface.

## Discussion
 A port is created by a port supplier, which is associated with a machine or debug server. A server enumerates its port suppliers through the [EnumPortSuppliers](../../extensibility/debugger/reference/idebugcoreserver2-enumportsuppliers.md) method, and a port supplier enumerates its ports through the [EnumPorts](../../extensibility/debugger/reference/idebugportsupplier2-enumports.md) method.

 In addition to the typical COM registration, a port supplier must register itself with Visual Studio by placing its CLSID and name in specific registry locations. A Debugging SDK helper function called `SetMetric` handles this chore: it is called once for each item to be registered, thus:

```cpp
SetMetric(metrictypePortSupplier,
          <GUID of your port supplier>,
          metricCLSID,
          <CLSID of your port supplier>,
          false,
          NULL)
SetMetric(metrictypePortSupplier,
          <GUID of your port supplier>,
          metricName,
          <name of your port supplier>,
          false,
          NULL);
```

 A port supplier unregisters itself by calling `RemoveMetric` (another Debugging SDK helper function) once for each item that was registered, thus:

```cpp
RemoveMetric(metrictypePortSupplier,
             <GUID of your port supplier>,
             metricCLSID,
             NULL);
RemoveMetric(metrictypePortSupplier,
             <GUID of your port supplier>,
             metricName,
             NULL);
```

> [!NOTE]
> The [SDK helpers for debugging](../../extensibility/debugger/reference/sdk-helpers-for-debugging.md)`SetMetric` and `RemoveMetric` are static functions defined in *dbgmetric.h* and compiled into *ad2de.lib*. The `metrictypePortSupplier`, `metricCLSID`, and `metricName` helpers are also defined in *dbgmetric.h*.

 A port supplier can supply its name and GUID through the methods [GetPortSupplierName](../../extensibility/debugger/reference/idebugportsupplier2-getportsuppliername.md) and [GetPortSupplierId](../../extensibility/debugger/reference/idebugportsupplier2-getportsupplierid.md), respectively.

## Related content
- [Implement a port supplier](../../extensibility/debugger/implementing-a-port-supplier.md)
- [SDK helpers for debugging](../../extensibility/debugger/reference/sdk-helpers-for-debugging.md)
- [Port suppliers](../../extensibility/debugger/port-suppliers.md)
