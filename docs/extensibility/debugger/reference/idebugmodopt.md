---
title: "IDebugModOpt | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
helpviewer_keywords:
  - "IDebugModOpt interface"
ms.assetid: ebd525e3-d140-4071-9d8c-41871de4125e
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# IDebugModOpt
Represents a debug optional modifier.

## Syntax

```
IDebugModOpt : IUnknown
```

## Notes for Callers
 Obtained from an [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) object that represents a class or method.

## Methods
 This interface implements the following method:

|Method|Description|
|------------|-----------------|
|[GetModOpts](../../../extensibility/debugger/reference/idebugmodopt-getmodopts.md)|Retrieves a list of optional modifiers.|

## Requirements
 Header: Sh.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll