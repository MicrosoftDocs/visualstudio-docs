---
title: "IDebugBinder::GetFunctionObject | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugBinder::GetFunctionObject"
helpviewer_keywords:
  - "IDebugBinder::GetFunctionObject method"
ms.assetid: 8fb789df-8f30-420d-8ca5-bb496a6738f1
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugBinder::GetFunctionObject
This method gets an [IDebugFunctionObject](../../../extensibility/debugger/reference/idebugfunctionobject.md) object used to create function parameters.

## Syntax

```cpp
HRESULT GetFunctionObject( 
   IDebugFunctionObject **ppFunction
);
```

```csharp
int GetFunctionObject(
   out IDebugFunctionObject ppFunction
);
```

## Parameters
`ppFunction`\
[out] Returns the [IDebugFunctionObject](../../../extensibility/debugger/reference/idebugfunctionobject.md) interface that is used to create function parameters.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## See also
- [IDebugBinder](../../../extensibility/debugger/reference/idebugbinder.md)
- [IDebugFunctionObject](../../../extensibility/debugger/reference/idebugfunctionobject.md)