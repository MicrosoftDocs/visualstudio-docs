---
description: "Allows querying for information about the target computer."
title: IDebugWindowsComputerPort2
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugWindowsComputerPort2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugWindowsComputerPort2

Allows querying for information about the target computer.

## Syntax

```
IDebugWindowsComputerPort2 : IUnknown
```

## Notes for Implementers
 This interface is implemented by port objects of the session debug manager.

## Methods
 The following table shows the methods of `IDebugWindowsComputerPort2`.

|Method|Description|
|------------|-----------------|
|[GetComputerInfo](../../../extensibility/debugger/reference/idebugwindowscomputerport2-getcomputerinfo.md)|Retrieves information about the computer on which the debugger in running.|

## Requirements
 Header: Msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll
