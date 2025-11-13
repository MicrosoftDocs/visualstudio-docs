---
description: "This method gets the object that this visualizer represents."
title: IEEVisualizerDataProvider::GetObjectForVisualizer
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IEEVisualizerDataProvider::GetObjectForVisualizer
helpviewer_keywords:
- IEEVisualizerDataProvider::GetObjectForVisualizer method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IEEVisualizerDataProvider::GetObjectForVisualizer

This method gets the object that this visualizer represents.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetObjectForVisualizer(
   out IDebugObject ppObject
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetObjectForVisualizer(
   IDebugObject** ppObject
);
```
---

## Parameters
`ppObject`\
[out] The object being represented by this visualizer

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 `GetObjectForVisualizer` is allowed to return a cached version of the object. If the caller wants to make sure that the object is up to date, then it will call [GetNewObjectForVisualizer](../../../extensibility/debugger/reference/ieevisualizerdataprovider-getnewobjectforvisualizer.md).

## See also
- [IEEVisualizerDataProvider](../../../extensibility/debugger/reference/ieevisualizerdataprovider.md)
- [GetNewObjectForVisualizer](../../../extensibility/debugger/reference/ieevisualizerdataprovider-getnewobjectforvisualizer.md)
- [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md)
