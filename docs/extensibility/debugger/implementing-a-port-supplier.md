---
title: Implementing a Port Supplier | Microsoft Docs
description: Learn about implementing a port supplier, which is necessary when debugging to a non-DCOM machine or when a new device requires support.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- debugging [Debugging SDK], implementing port suppliers
- port suppliers, implementing
ms.assetid: 6b8579df-58df-4c7f-8112-6015993e8765
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
---
# Implement a port supplier
A port supplier supplies ports on request to the session debug manager (SDM). A port supplier must be implemented when debugging to a non-DCOM machine or when a new device requires support. For example, to provide debugging to a cell phone, you might set up a port supplier that provides ports, which connect to the cell phone (perhaps by way of IR or a cell connection) and enumerates the processes and programs running on the phone.

 For debugging programs on Windows-based machines (including remote debugging), Visual Studio provides port suppliers for native and Common Language Runtime (CLR) processes, so there is no need to set up your own port supplier in those cases.

## In this section
 [Implement and register a port supplier](../../extensibility/debugger/implementing-and-registering-a-port-supplier.md)
 Discusses how the SDM interacts with the port supplier and its ports.

 [Required port supplier interfaces](../../extensibility/debugger/required-port-supplier-interfaces.md)
 Documents the interfaces you must implement to get a port supplier.

## Related sections
 [Debugger concepts](../../extensibility/debugger/debugger-concepts.md)
 Describes the main debugging architectural concepts.

## See also
 [Visual Studio debugger extensibility](../../extensibility/debugger/visual-studio-debugger-extensibility.md)
