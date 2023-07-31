---
description: "Makes a program unavailable to be debugged."
title: IDebugProgramPublisher2::UnpublishProgram | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgramPublisher2::UnpublishProgram
helpviewer_keywords:
- IDebugProgramPublisher2::UnpublishProgram
ms.assetid: 627e7d38-b2ac-4873-9a40-37ff7f47cd1d
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
# IDebugProgramPublisher2::UnpublishProgram

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
Makes a program unavailable to be debugged.

## Syntax

### [C#](#tab/csharp)
```csharp
int UnpublishProgram(
   object pDebuggeeInterface
);
```
### [C++](#tab/cpp)
```cpp
HRESULT UnpublishProgram(
   IUnknown* pDebuggeeInterface
);
```
---

## Parameters
`pDebuggeeInterface`\
[in] An `IUnknown` interface to the program. This is the same value supplied to the [PublishProgram](../../../extensibility/debugger/reference/idebugprogrampublisher2-publishprogram.md) method and uniquely identifies the program being removed (that is, it's used as a cookie).

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 To make a program available to the debug engines and session debug manager, use the [PublishProgram](../../../extensibility/debugger/reference/idebugprogrampublisher2-publishprogram.md) method.

## See also
- [IDebugProgramPublisher2](../../../extensibility/debugger/reference/idebugprogrampublisher2.md)
- [PublishProgram](../../../extensibility/debugger/reference/idebugprogrampublisher2-publishprogram.md)
