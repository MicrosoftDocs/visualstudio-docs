---
description: "This method creates a visualizer service."
title: IEEVisualizerServiceProvider::CreateVisualizerService
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IEEVisualizerServiceProvider::CreateVisualizerService
helpviewer_keywords:
- IEEVisualizerServiceProvider::CreateVisualizerService method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IEEVisualizerServiceProvider::CreateVisualizerService

This method creates a visualizer service.

## Syntax

### [C#](#tab/csharp)
```csharp
int CreateVisualizerService(
   IDebugBinder binder,
   IDebugSymbolProvider      pSymProv,
   IDebugAddress             pAddress,
   IEEVisualizerDataProvider dataProvider,
   out IEEVisualizerService  ppService
);
```
### [C++](#tab/cpp)
```cpp
HRESULT CreateVisualizerService(
   IDebugBinder*              binder,
   IDebugSymbolProvider*      pSymProv,
   IDebugAddress*             pAddress,
   IEEVisualizerDataProvider* dataProvider,
   IEEVisualizerService**     ppService
);
```
---

## Parameters
`binder`\
[in] The [IDebugBinder](../../../extensibility/debugger/reference/idebugbinder.md) object passed to [EvaluateSync](../../../extensibility/debugger/reference/idebugparsedexpression-evaluatesync.md).

`pSymProv`\
[in] The [IDebugSymbolProvider](../../../extensibility/debugger/reference/idebugsymbolprovider.md) object passed to `IDebugParsedExpression::EvaluateSync`.

`pAddress`\
[in] The [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md) object passed to `IDebugParsedExression::EvaluateSync`.

`dataProvider`\
[in] An object implementing the [IEEVisualizerDataProvider](../../../extensibility/debugger/reference/ieevisualizerdataprovider.md) interface (supplied by the expression evaluator).

`ppService`\
[out] The created service.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The `binder`, `pSymProv`, and `pAddress` parameters were all passed to the `IDebugParsedExpression::EvaluateSync` method. `CreateVisualizerService` is to be called only from `IDebugParsedExpression::EvaluateSync` as part of an expression evaluator's support for type visualizers.

## See also
- [IEEVisualizerServiceProvider](../../../extensibility/debugger/reference/ieevisualizerserviceprovider.md)
- [EvaluateSync](../../../extensibility/debugger/reference/idebugparsedexpression-evaluatesync.md)
- [IDebugBinder](../../../extensibility/debugger/reference/idebugbinder.md)
- [IDebugSymbolProvider](../../../extensibility/debugger/reference/idebugsymbolprovider.md)
- [IEEVisualizerDataProvider](../../../extensibility/debugger/reference/ieevisualizerdataprovider.md)
