---
description: "This method gets the number of type visualizers available from this service."
title: IEEVisualizerService::GetCustomViewerCount
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IEEVisualizerService::GetCustomViewerCount
helpviewer_keywords:
- IEEVisualizerService::GetCustomViewerCount method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IEEVisualizerService::GetCustomViewerCount

This method gets the number of type visualizers available from this service.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetCustomViewerCount(
   out uint pcelt
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetCustomViewerCount(
   ULONG* pcelt
);
```
---

## Parameters
`pcelt`\
[out] Returns the number of type visualizers available.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
- [GetCustomViewerCount](../../../extensibility/debugger/reference/idebugproperty3-getcustomviewercount.md) passes the request to this method in its support for type visualizers.

## See also
- [IEEVisualizerService](../../../extensibility/debugger/reference/ieevisualizerservice.md)
- [GetCustomViewerCount](../../../extensibility/debugger/reference/idebugproperty3-getcustomviewercount.md)
