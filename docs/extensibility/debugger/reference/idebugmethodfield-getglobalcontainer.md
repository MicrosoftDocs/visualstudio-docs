---
description: "Gets the global container of the method."
title: IDebugMethodField::GetGlobalContainer
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugMethodField::GetGlobalContainer
helpviewer_keywords:
- IDebugMethodField::GetGlobalContainer method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugMethodField::GetGlobalContainer

Gets the global container of the method.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetGlobalContainer(
   out IDebugClassField ppClass
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetGlobalContainer(
   IDebugClassField** ppClass
);
```
---

## Parameters
`ppClass`\
[out] Returns an [IDebugClassField](../../../extensibility/debugger/reference/idebugclassfield.md) representing the module in which this method is defined.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## Remarks
 The returned [IDebugClassField](../../../extensibility/debugger/reference/idebugclassfield.md) object represents the entire module and is an artificial object, that is, the module itself does not have an actual class but it can be represented by an `IDebugClassField` object, allowing the various elements of the module to be enumerated and discovered.

## See also
- [IDebugMethodField](../../../extensibility/debugger/reference/idebugmethodfield.md)
- [IDebugClassField](../../../extensibility/debugger/reference/idebugclassfield.md)
