---
description: "Represents a customized UI for selecting the port."
title: IDebugPortPicker
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugPortPicker interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugPortPicker

Represents a customized UI for selecting the port.

## Syntax

```
IDebugPortPicker : IUnknown
```

## Notes for Implementers
 This interface is implemented by port suppliers. A port supplier defines their port picker by exposing it as a CLSID and pointing the `metricPortPickerCLSID` metric at the exposed CLSID.

## Methods
 The following table shows the methods of `IDebugPortPicker`.

|Method|Description|
|------------|-----------------|
|[DisplayPortPicker](../../../extensibility/debugger/reference/idebugportpicker-displayportpicker.md)|Displays the specified dialog box that allows the user to select a port.|
|[SetSite](../../../extensibility/debugger/reference/idebugportpicker-setsite.md)|Sets the service provider.|

## Requirements
 Header: Msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll
