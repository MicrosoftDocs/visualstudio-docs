---
description: "Determines whether the object represents user data."
title: IDebugObject2::IsUserData
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugObject2::IsUserData
helpviewer_keywords:
- IDebugObject2::IsUserData method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugObject2::IsUserData

Determines whether the object represents user data.

## Syntax

### [C#](#tab/csharp)
```csharp
int IsUserData(
   out int pfUser
);
```
### [C++](#tab/cpp)
```cpp
HRESULT IsUserData(
   BOOL* pfUser
);
```
---

## Parameters
`pfUser`\
[out] Returns nonzero (`TRUE`) if the object represents user data; zero (`FALSE`) if it does not.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## Remarks
 User data is any object that is part of a module designated as JustMyCode (a user-configurable option that marks a module as user code and therefore visible in a stack trace).

## See also
- [IDebugObject2](../../../extensibility/debugger/reference/idebugobject2.md)
