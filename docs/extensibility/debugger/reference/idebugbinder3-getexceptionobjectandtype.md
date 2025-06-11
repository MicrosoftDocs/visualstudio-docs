---
description: "This method retrieves the exception associated with an object, if any."
title: IDebugBinder3::GetExceptionObjectAndType
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugBinder3::GetExceptionObjectAndType
helpviewer_keywords:
- IDebugBinder3::GetExceptionObjectAndType method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugBinder3::GetExceptionObjectAndType

This method retrieves the exception associated with an object, if any.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetExceptionObjectAndType(
   out IDebugObject ppException,
   out IDebugField  ppField
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetExceptionObjectAndType(
   IDebugObject** ppException,
   IDebugField**  ppField
);
```
---

## Parameters
`ppException`\
[out] Returns the object representing the exception.

`ppField`\
[out] Returns the object representing a specific field that may have caused the exception (this may be a null value).

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

> [!NOTE]
> To verify whether there is an exception, check the value returned by `ppException`: if it is a null value, then no exception is associated with this object.

## See also
- [IDebugBinder3](../../../extensibility/debugger/reference/idebugbinder3.md)
