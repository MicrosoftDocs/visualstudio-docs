---
description: "This method gets the container of a field."
title: IDebugField::GetContainer
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugField::GetContainer
helpviewer_keywords:
- IDebugField::GetContainer method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugField::GetContainer

This method gets the container of a field.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetContainer(
   out IDebugContainerField ppContainerField
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetContainer( 
   IDebugContainerField** ppContainerField
);
```
---

## Parameters
`ppContainerField`\
[out] Returns the container as represented by the [IDebugContainerField](../../../extensibility/debugger/reference/idebugcontainerfield.md) interface.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 If this field does not have a container, the returned `ppContainerField` will be a null value.

## See also
- [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)
- [IDebugContainerField](../../../extensibility/debugger/reference/idebugcontainerfield.md)
