---
description: "This method changes the object that the visualizer represents."
title: IEEVisualizerDataProvider::SetObjectForVisualizer
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IEEVisualizerDataProvider::SetObjectForVisualizer
helpviewer_keywords:
- IEEVisualizerDataProvider::SetObjectForVisualizer method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IEEVisualizerDataProvider::SetObjectForVisualizer

This method changes the object that the visualizer represents.

## Syntax

### [C#](#tab/csharp)
```csharp
int SetObjectForVisualizer(
   IDebugObject     pNewObject,
   out string       error,
   out IDebugObject pException
);
```
### [C++](#tab/cpp)
```cpp
HRESULT SetObjectForVisualizer(
   IDebugObject*  pNewObject,
   BSTR*          error,
   IDebugObject** pException
);
```
---

## Parameters
`pNewObject`\
[in] The object to set.

`error`\
[out] If there was an error setting the object, this string holds the error message.

`pException`\
[out] If there was an error, this object holds the exception information.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 It is up to the implementer to determine how error information is returned. However, it is possible that some callers may only look to see if an exception object was returned to know there was an error, so this method should always return an exception object if there was an error. The error string should also be supplied in case the caller wants to make use of it.

## See also
- [IEEVisualizerDataProvider](../../../extensibility/debugger/reference/ieevisualizerdataprovider.md)
- [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md)
