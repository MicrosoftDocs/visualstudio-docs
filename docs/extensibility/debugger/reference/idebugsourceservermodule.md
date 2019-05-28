---
title: "IDebugSourceServerModule | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
helpviewer_keywords:
  - "IDebugSourceServerModule interface"
ms.assetid: 38213060-451d-46e6-8b4a-efc123e01a2c
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# IDebugSourceServerModule
Represents the source server information that is contained in a PDB file.

## Syntax

```
IDebugSourceServerModule : IUnknown
```

## Notes for Implementers
 This interface is implemented by debugger engines and consumed by the debugger UI.

## Methods
 The following table shows the methods of `IDebugSourceServerModule`.

|Method|Description|
|------------|-----------------|
|[GetSourceServerData](../../../extensibility/debugger/reference/idebugsourceservermodule-getsourceserverdata.md)|Retrieves an array of source server information.|

## Requirements
 Header: Msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll