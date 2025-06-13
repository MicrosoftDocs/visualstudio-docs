---
description: "This method returns a list of type visualizers that this service knows about."
title: IEEVisualizerService::GetCustomViewerList
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IEEVisualizerService::GetCustomViewerList
helpviewer_keywords:
- IEEVisualizerService::GetCustomViewerList method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IEEVisualizerService::GetCustomViewerList

This method returns a list of type visualizers that this service knows about.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetCustomViewerList(
   uint                  celtSkip,
   uint                  celtRequested,
   DEBUG_CUSTOM_VIEWER[] rgViewers,
   out uint              pceltFetched
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetCustomViewerList(
   ULONG                celtSkip,
   ULONG                celtRequested,
   DEBUG_CUSTOM_VIEWER* rgViewers,
   ULONG*               pceltFetched
);
```
---

## Parameters
`celtSkip`\
[in] Number of visualizers to skip over.

`celRequested`\
[in] Number of visualizers to retrieve (also specifies size of the `rgViewers` array).

`rgViewers`\
[in, out] Array of [DEBUG_CUSTOM_VIEWER](../../../extensibility/debugger/reference/debug-custom-viewer.md) structures to be filled in.

`pceltFetched`\
[out] Number of visualizers actually retrieved.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
- [GetCustomViewerList](../../../extensibility/debugger/reference/idebugproperty3-getcustomviewerlist.md) passes the request to this method as part of its support for type visualizers. If the expression evaluator also supplies custom viewers for the same type, it can append appropriately filled-out [DEBUG_CUSTOM_VIEWER](../../../extensibility/debugger/reference/debug-custom-viewer.md) structures for those custom viewers to the list. Make sure that [GetCustomViewerCount](../../../extensibility/debugger/reference/idebugproperty3-getcustomviewercount.md) reflects those additional viewers.

 See [Type Visualizer and Custom Viewer](../../../extensibility/debugger/type-visualizer-and-custom-viewer.md) for details on the differences between visualizers and viewers.

## See also
- [IEEVisualizerService](../../../extensibility/debugger/reference/ieevisualizerservice.md)
- [DEBUG_CUSTOM_VIEWER](../../../extensibility/debugger/reference/debug-custom-viewer.md)
- [GetCustomViewerList](../../../extensibility/debugger/reference/idebugproperty3-getcustomviewerlist.md)
- [GetCustomViewerCount](../../../extensibility/debugger/reference/idebugproperty3-getcustomviewercount.md)
- [Type Visualizer and Custom Viewer](../../../extensibility/debugger/type-visualizer-and-custom-viewer.md)
