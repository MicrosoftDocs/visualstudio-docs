---
description: "This method gets a new object for the visualizer."
title: IEEVisualizerDataProvider::GetNewObjectForVisualizer
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IEEVisualizerDataProvider::GetNewObjectForVisualizer
helpviewer_keywords:
- IEEVisualizerDataProvider::GetNewObjectForVisualizer method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IEEVisualizerDataProvider::GetNewObjectForVisualizer

This method gets a new object for the visualizer. This method will always create a new object from the existing object.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetNewObjectForVisualizer(
   out IDebugObject ppObject
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetNewObjectForVisualizer(
   IDebugObject** ppObject
);
```
---

## Parameters
`ppObject`\
[out] The new object.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 `This method` re-evaluates the object it currently represents and returns the result as a new object. The existing object will be updated as a result of the evaluation.

## See also
- [IEEVisualizerDataProvider](../../../extensibility/debugger/reference/ieevisualizerdataprovider.md)
- [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md)
