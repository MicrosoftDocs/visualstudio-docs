---
title: IDebugProperty3
description: "This interface provides support for retrieving an arbitrarily long string associated with the property, associating a unique ID with the property, retrieving a list of custom viewers for the property, setting the value of a property with the ability to report any resulting errors."
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProperty3
helpviewer_keywords:
- IDebugProperty3 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugProperty3

This interface provides support for:

- Retrieving an arbitrarily long string associated with the property.

- Associating a unique ID with the property.

- Retrieving a list of custom viewers for the property.

- Setting the value of a property with the ability to report any resulting errors

## Syntax

```
IDebugProperty3 : IDebugProperty2
```

## Notes for Implementers
 The debug engine (DE) implements this interface on the same object that implements [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md) to provide support for long strings, property IDs, and custom viewers.

## Notes for Callers
 Call [QueryInterface](/cpp/atl/queryinterface) on an `IDebugProperty2` interface to obtain this interface.

## Methods in Vtable Order
 In addition to the methods inherited from `IDebugProperty2`, the `IDebugProperty3` interface exposes the following methods.

|Method|Description|
|------------|-----------------|
|[GetStringCharLength](../../../extensibility/debugger/reference/idebugproperty3-getstringcharlength.md)|Returns the length of the string associated with the property.|
|[GetStringChars](../../../extensibility/debugger/reference/idebugproperty3-getstringchars.md)|Returns the string in a user-supplied buffer.|
|[CreateObjectID](../../../extensibility/debugger/reference/idebugproperty3-createobjectid.md)|Creates a unique ID for this property.|
|[DestroyObjectID](../../../extensibility/debugger/reference/idebugproperty3-destroyobjectid.md)|Destroys the unique ID for this property.|
|[GetCustomViewerCount](../../../extensibility/debugger/reference/idebugproperty3-getcustomviewercount.md)|Returns the number of custom viewers that this property can be viewed with.|
|[GetCustomViewerList](../../../extensibility/debugger/reference/idebugproperty3-getcustomviewerlist.md)|Returns the list of custom viewers that this property can be viewed with.|
|[SetValueAsStringWithError](../../../extensibility/debugger/reference/idebugproperty3-setvalueasstringwitherror.md)|Sets the value of this property, returning an error message if anything went wrong.|

## Remarks
- [SetValueAsStringWithError](../../../extensibility/debugger/reference/idebugproperty3-setvalueasstringwitherror.md) is the preferred way for the session debug manager (SDM) to set a property's value.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md)
- [IDebugCustomViewer](../../../extensibility/debugger/reference/idebugcustomviewer.md)
