---
title: "IEEVisualizerService::GetCustomViewerCount | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IEEVisualizerService::GetCustomViewerCount"
helpviewer_keywords:
  - "IEEVisualizerService::GetCustomViewerCount method"
ms.assetid: f7b095c2-e538-4352-8cad-d4c6d4f6bdbc
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IEEVisualizerService::GetCustomViewerCount
This method gets the number of type visualizers available from this service.

## Syntax

```cpp
HRESULT GetCustomViewerCount(
   ULONG* pcelt
);
```

```csharp
int GetCustomViewerCount(
   out uint pcelt
);
```

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