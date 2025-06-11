---
description: "This method determines whether the visualizer can have the data object it represents updated."
title: IEEVisualizerDataProvider::CanSetObjectForVisualizer
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IEEVisualizerDataProvider::CanSetObjectForVisualizer
helpviewer_keywords:
- IEEVisualizerDataProvider::CanSetObjectForVisualizer method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IEEVisualizerDataProvider::CanSetObjectForVisualizer

This method determines whether the visualizer can have the data object it represents updated.

## Syntax

### [C#](#tab/csharp)
```csharp
int CanSetObjectForVisualizer(
   out int b
);
```
### [C++](#tab/cpp)
```cpp
HRESULT CanSetObjectForVisualizer(
   BOOL* b
);
```
---

## Parameters
`b`\
[out] Nonzero (`TRUE`) if the object on the visualizer can be updated, zero (`FALSE`) if it cannot.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 An object might not be changeable if it is bound to read-only memory, for example.

## See also
- [IEEVisualizerDataProvider](../../../extensibility/debugger/reference/ieevisualizerdataprovider.md)
