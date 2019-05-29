---
title: "IDebugObject2::GetICorDebugValue | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugObject2::GetICorDebugValue"
helpviewer_keywords:
  - "IDebugObject2::GetICorDebugValue method"
ms.assetid: bcd4355d-3fbe-483f-bb23-a44348323c6a
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugObject2::GetICorDebugValue
Gets a managed code object representing the value associated with this object.

## Syntax

```cpp
HRESULT GetICorDebugValue(
   IUnknown** ppUnk
);
```

```csharp
int GetICorDebugValue(
   out object ppUnk
);
```

## Parameters
`ppUnk`\
[out] `IUnknown` interface that represents this alias. This interface can be queried for the `ICorDebugValue` interface.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## Remarks
 The `ICorDebugValue` object is a Common Language Runtime interface that represents a value.

## See also
- [IDebugObject2](../../../extensibility/debugger/reference/idebugobject2.md)