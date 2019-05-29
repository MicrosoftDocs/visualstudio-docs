---
title: "IEEVisualizerDataProvider::SetObjectForVisualizer | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IEEVisualizerDataProvider::SetObjectForVisualizer"
helpviewer_keywords:
  - "IEEVisualizerDataProvider::SetObjectForVisualizer method"
ms.assetid: 40dad2be-57ff-4f74-9d82-c48039c125c4
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IEEVisualizerDataProvider::SetObjectForVisualizer
This method changes the object that the visualizer represents.

## Syntax

```cpp
HRESULT SetObjectForVisualizer(
   IDebugObject*  pNewObject,
   BSTR*          error,
   IDebugObject** pException
);
```

```csharp
int SetObjectForVisualizer(
   IDebugObject     pNewObject,
   out string       error,
   out IDebugObject pException
);
```

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