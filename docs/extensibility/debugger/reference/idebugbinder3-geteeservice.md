---
description: "This method returns a requested service."
title: IDebugBinder3::GetEEService
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugBinder3::GetEEService
helpviewer_keywords:
- IDebugBinder3::GetEEService method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugBinder3::GetEEService

This method returns a requested service.

## Syntax

### [C#](#tab/csharp)
```csharp
Int GetEEService(
   Guid       vendor,
   Guid       language,
   Guid       iid,
   out object ppService
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetEEService(
   [in] GUID        vendor,
   [in] GUID        language,
   [in] GUID        iid,
   [out] IUnknown** ppService
);
```
---

## Parameters
`vendor`\
[in] `GUID` of a vendor (a null value is acceptable).

`language`\
[in] `GUID` of a language (a null value is acceptable).

`iid`\
[in] `IID` of the service to obtain.

`ppService`\
[out] An interface to the requested service.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 Pass the `IID` for the [IEEVisualizerServiceProvider](../../../extensibility/debugger/reference/ieevisualizerserviceprovider.md) interface (`IID_IEEVisualizerServiceProvider`) to see if the Type Visualizer service is available. If so, the expression evaluator can obtain the [IEEVisualizerService](../../../extensibility/debugger/reference/ieevisualizerservice.md) interface to support type visualizers. See [Visualizing and Viewing Data](../../../extensibility/debugger/visualizing-and-viewing-data.md) for details.

## See also
- [IDebugBinder3](../../../extensibility/debugger/reference/idebugbinder3.md)
- [IEEVisualizerServiceProvider](../../../extensibility/debugger/reference/ieevisualizerserviceprovider.md)
- [IEEVisualizerService](../../../extensibility/debugger/reference/ieevisualizerservice.md)
- [Visualizing and Viewing Data](../../../extensibility/debugger/visualizing-and-viewing-data.md)
