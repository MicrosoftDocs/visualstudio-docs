---
description: "Extends the IDebugCodeContext2 interface to enable the retrieval of module and process interfaces."
title: IDebugCodeContext3 | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugCodeContext3 interface
ms.assetid: 524eb882-0ad5-4bfb-95eb-eb3abb3d0237
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugCodeContext3
Extends the [IDebugCodeContext2](../../../extensibility/debugger/reference/idebugcodecontext2.md) interface to enable the retrieval of module and process interfaces.

## Syntax

```
IDebugCodeContext3 : IDebugCodeContext2
```

## Notes for Implementers
 Implemented by debug engines and consumed by the [!INCLUDE[vsprvs](../../../code-quality/includes/vsprvs_md.md)] Debug package.

## Methods
 In addition to the methods on the `IDebugCodeContext2` interface, this interface implements the following methods:

|Method|Description|
|------------|-----------------|
|[GetModule](../../../extensibility/debugger/reference/idebugcodecontext3-getmodule.md)|Retrieves a reference to the interface of the debug module.|
|[GetProcess](../../../extensibility/debugger/reference/idebugcodecontext3-getprocess.md)|Retrieves a reference to the interface of the debug process.|

## Remarks
 This is an optional interface which generally does not have to be implemented.

## Requirements
 Header: Msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll
