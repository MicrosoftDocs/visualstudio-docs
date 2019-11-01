---
title: "IEEVisualizerDataProvider::CanSetObjectForVisualizer | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IEEVisualizerDataProvider::CanSetObjectForVisualizer"
helpviewer_keywords:
  - "IEEVisualizerDataProvider::CanSetObjectForVisualizer method"
ms.assetid: 70fd3c6f-2f82-43a3-993b-c1dc8aa080bf
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IEEVisualizerDataProvider::CanSetObjectForVisualizer
This method determines whether the visualizer can have the data object it represents updated.

## Syntax

```cpp
HRESULT CanSetObjectForVisualizer(
   BOOL* b
);
```

```csharp
int CanSetObjectForVisualizer(
   out int b
);
```

## Parameters
`b`\
[out] Nonzero (`TRUE`) if the object on the visualizer can be updated, zero (`FALSE`) if it cannot.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 An object might not be changeable if it is bound to read-only memory, for example.

## See also
- [IEEVisualizerDataProvider](../../../extensibility/debugger/reference/ieevisualizerdataprovider.md)