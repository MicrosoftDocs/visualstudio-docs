---
description: "Determines whether the object represents user data."
title: IDebugObject2::IsUserData | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugObject2::IsUserData
helpviewer_keywords:
- IDebugObject2::IsUserData method
ms.assetid: 6ffa0d0e-f742-496d-acc7-db74c248bc45
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugObject2::IsUserData
Determines whether the object represents user data.

## Syntax

```cpp
HRESULT IsUserData(
   BOOL* pfUser
);
```

```csharp
int IsUserData(
   out int pfUser
);
```

## Parameters
`pfUser`\
[out] Returns nonzero (`TRUE`) if the object represents user data; zero (`FALSE`) if it does not.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## Remarks
 User data is any object that is part of a module designated as JustMyCode (a user-configurable option that marks a module as user code and therefore visible in a stack trace).

## See also
- [IDebugObject2](../../../extensibility/debugger/reference/idebugobject2.md)
