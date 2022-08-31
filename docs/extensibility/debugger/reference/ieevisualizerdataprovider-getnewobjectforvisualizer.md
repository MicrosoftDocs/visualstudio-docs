---
description: "This method gets a new object for the visualizer."
title: IEEVisualizerDataProvider::GetNewObjectForVisualizer | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IEEVisualizerDataProvider::GetNewObjectForVisualizer
helpviewer_keywords:
- IEEVisualizerDataProvider::GetNewObjectForVisualizer method
ms.assetid: a898d549-4898-4fde-aad1-e8bb89129652
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IEEVisualizerDataProvider::GetNewObjectForVisualizer

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
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
