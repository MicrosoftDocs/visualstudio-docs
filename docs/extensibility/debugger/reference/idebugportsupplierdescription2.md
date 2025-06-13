---
description: "Enables the Visual Studio UI to display text inside the Transport Information section of the Attach to Process dialog box."
title: IDebugPortSupplierDescription2
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugPortSupplierDescription2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugPortSupplierDescription2

Enables the Visual Studio UI to display text inside the **Transport Information** section of the **Attach to Process** dialog box.

## Syntax

```
IDebugPortSupplierDescription2 : IUnknown
```

## Notes for Implementers
 This interface is implemented by port suppliers.

## Methods
 The following table shows the methods of `IDebugPortSupplierDescription2`.

|Method|Description|
|------------|-----------------|
|[GetDescription](../../../extensibility/debugger/reference/idebugportsupplierdescription2-getdescription.md)|Retrieves the description and description metadata for the port supplier.|

## Requirements
 Header: Msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll
