---
description: "Gets the number of custom viewers that might be available for this property."
title: IDebugProperty3::GetCustomViewerCount
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProperty3::GetCustomViewerCount
helpviewer_keywords:
- IDebugProperty3::GetCustomViewerCount
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProperty3::GetCustomViewerCount

Gets the number of custom viewers that might be available for this property.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetCustomViewerCount(
    out uint pcelt
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetCustomViewerCount(
    ULONG* pcelt
);
```
---

## Parameters
`pcelt`\
[out] The number of custom viewers available for this property.

## Return Value
If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
In order to support type visualizers, this method forwards the call to the [GetCustomViewerCount](../../../extensibility/debugger/reference/ieevisualizerservice-getcustomviewercount.md) method. If the expression evaluator also supports custom viewers for this property's type, this method adds the number of custom viewers to the returned value.

For detailed information about the differences between type visualizers and custom viewers, see [Type Visualizer and Custom Viewer](../../../extensibility/debugger/type-visualizer-and-custom-viewer.md).

## Example
The following example shows how to implement this method for a **CProperty** object that exposes the [IDebugProperty3](../../../extensibility/debugger/reference/idebugproperty3.md) interface.

```cpp
STDMETHODIMP CProperty::GetCustomViewerCount(ULONG* pcelt)
{
    if (pcelt == NULL)
    {
        return E_POINTER;
    }

    if (GetVisualizerService())
    {
        return m_pIEEVisualizerService->GetCustomViewerCount(pcelt);
    }
    else
    {
        return E_NOTIMPL;
    }
}
```

## See also
- [IDebugProperty3](../../../extensibility/debugger/reference/idebugproperty3.md)
- [GetCustomViewerCount](../../../extensibility/debugger/reference/ieevisualizerservice-getcustomviewercount.md)
- [Type Visualizer and Custom Viewer](../../../extensibility/debugger/type-visualizer-and-custom-viewer.md)
