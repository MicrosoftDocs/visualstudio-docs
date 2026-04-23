---
title: Implementing a Port Supplier
description: Learn about implementing a port supplier, which is necessary when debugging to a non-DCOM machine or when a new device requires support.
ms.date: 11/04/2016
ms.topic: concept-article
helpviewer_keywords:
- debugging [Debugging SDK], implementing port suppliers
- port suppliers, implementing
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Implement a port supplier

A port supplier supplies ports on request to the session debug manager (SDM). A port supplier must be implemented when debugging to a non-DCOM machine or when a new device requires support. For example, to provide debugging to a cell phone, you might set up a port supplier that provides ports, which connect to the cell phone (perhaps by way of IR or a cell connection) and enumerates the processes and programs running on the phone.

 For debugging programs on Windows-based machines (including remote debugging), Visual Studio provides port suppliers for native and Common Language Runtime (CLR) processes, so there is no need to set up your own port supplier in those cases.

## In this section

[Implement and register a port supplier](../../extensibility/debugger/implementing-and-registering-a-port-supplier.md) discusses how the SDM interacts with the port supplier and its ports.

 [Required port supplier interfaces](../../extensibility/debugger/required-port-supplier-interfaces.md) documents the interfaces you must implement to get a port supplier.

## Related content
- [Debugger concepts](../../extensibility/debugger/debugger-concepts.md) describes the main debugging architectural concepts.

- [Visual Studio debugger extensibility](../../extensibility/debugger/visual-studio-debugger-extensibility.md)
