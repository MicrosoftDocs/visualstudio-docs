---
description: "This method determines whether the Edit and Continue status of this object or of the parent container is out of date."
title: IDebugObject2::IsEncOutdated
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugObject2::IsEncOutdated
helpviewer_keywords:
- IDebugObject2::IsEncOutdated method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugObject2::IsEncOutdated

This method determines whether the Edit and Continue status of this object or of the parent container is out of date. A custom expression evaluator does not implement this method and always returns `E_NOTIMPL`.

## Syntax

### [C#](#tab/csharp)
```csharp
int IsEncOutdated(
   out int pfEncOutdated
);
```
### [C++](#tab/cpp)
```cpp
HRESULT IsEncOutdated(
   BOOL* pfEncOutdated
);
```
---

## Parameters
`pfEncOutdated`\
[out] Nonzero (`TRUE`) if the Edit and Continue state is out of date, zero (`FALSE`) if it is not.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

> [!NOTE]
> A custom expression evaluator should always return `E_NOTIMPL`.

## See also
- [IDebugObject2](../../../extensibility/debugger/reference/idebugobject2.md)
