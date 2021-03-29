---
description: "Provides locale support for a port supplier."
title: IDebugPortSupplierLocale2 | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugPortSupplierLocale2 interface
ms.assetid: 910e7220-da2a-4339-9fff-9fb1bad3c28c
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.workload:
- vssdk
---
# IDebugPortSupplierLocale2
Provides locale support for a port supplier.

## Syntax

```
IDebugPortSupplierLocale2 : IUnknown
```

## Notes for Implementers
 A custom port supplier implements this interface to set the locale.

## Methods
 The following table shows the methods of **IDebugPortSupplierLocale2**.

|Method|Description|
|------------|-----------------|
|[SetLocale](../../../extensibility/debugger/reference/idebugportsupplierlocale2-setlocale.md)|Sets the locale for the port supplier.|

## Requirements
 Header: Portpriv.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [IDebugPortSupplier2](../../../extensibility/debugger/reference/idebugportsupplier2.md)
- [IDebugPortSupplier3](../../../extensibility/debugger/reference/idebugportsupplier3.md)
