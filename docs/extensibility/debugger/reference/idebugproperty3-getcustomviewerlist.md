---
description: "Gets a list of custom viewers associated with this property."
title: IDebugProperty3::GetCustomViewerList
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProperty3::GetCustomViewerList
helpviewer_keywords:
- IDebugProperty3::GetCustomViewerList
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProperty3::GetCustomViewerList

Gets a list of custom viewers associated with this property.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetCustomViewerList(
    uint                  celtSkip,
    uint                  celtRequested,
    DEBUG_CUSTOM_VIEWER[] rgViewers,
    out uint              pceltFetched
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetCustomViewerList(
    ULONG                celtSkip,
    ULONG                celtRequested,
    DEBUG_CUSTOM_VIEWER* rgViewers,
    ULONG*               pceltFetched
);
```
---

## Parameters
`celtSkip`\
[in] The number of viewers to skip over.

`celtRequested`\
[in] The number of viewers to retrieve (also specifies the size of the `rgViewers` array).

`rgViewers`\
[in, out] Array of [DEBUG_CUSTOM_VIEWER](../../../extensibility/debugger/reference/debug-custom-viewer.md) structures to be filled in.

`pceltFetched`\
[out] The actual number of viewers returned.

## Return Value
If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
To support type visualizers, this method forwards the call to the [GetCustomViewerList](../../../extensibility/debugger/reference/ieevisualizerservice-getcustomviewerlist.md) method. If the expression evaluator also supports custom viewers for this property's type, this method can append the appropriate custom viewers to the list.

See [Type Visualizer and Custom Viewer](../../../extensibility/debugger/type-visualizer-and-custom-viewer.md) for details on the differences between type visualizers and custom viewers.

## Example
The following example shows how to implement this method for a **CProperty** object that exposes the [IDebugProperty3](../../../extensibility/debugger/reference/idebugproperty3.md) interface.

```cpp
STDMETHODIMP CProperty::GetCustomViewerList(ULONG celtSkip, ULONG celtRequested, DEBUG_CUSTOM_VIEWER* prgViewers, ULONG* pceltFetched)
{
    if (NULL == prgViewers)
    {
        return E_POINTER;
    }

    if (GetVisualizerService())
    {
        return m_pIEEVisualizerService->GetCustomViewerList(celtSkip, celtRequested, prgViewers, pceltFetched);
    }
    else
    {
        return E_NOTIMPL;
    }
}
```

## See also
- [IDebugProperty3](../../../extensibility/debugger/reference/idebugproperty3.md)
- [DEBUG_CUSTOM_VIEWER](../../../extensibility/debugger/reference/debug-custom-viewer.md)
- [GetCustomViewerList](../../../extensibility/debugger/reference/ieevisualizerservice-getcustomviewerlist.md)
- [Type Visualizer and Custom Viewer](../../../extensibility/debugger/type-visualizer-and-custom-viewer.md)
