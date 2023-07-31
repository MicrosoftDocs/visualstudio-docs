---
description: "Retrieves information on whether the module represents user code or not."
title: IDebugModule3::IsUserCode | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugModule3::IsUserCode
helpviewer_keywords:
- IDebugModule3::IsUserCode
ms.assetid: 77022946-bb8b-4114-aa81-614df6e54b13
author: maiak
ms.author: maiak
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugModule3::IsUserCode

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
Retrieves information on whether the module represents user code or not.

## Syntax

### [C#](#tab/csharp)
```csharp
int IsUserCode(
   out int pfUser
);
```
### [C++](#tab/cpp)
```cpp
HRESULT IsUserCode(
   BOOL* pfUser
);
```
---

## Parameters
`pfUser`\
[out] Nonzero (`TRUE`) if module represents user code, zero (`FALSE`) if it does not.

## Return Value
 If successful, returns `S_OK`; otherwise, returns error code.

## See also
- [IDebugModule3](../../../extensibility/debugger/reference/idebugmodule3.md)
