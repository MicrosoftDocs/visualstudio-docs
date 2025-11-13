---
description: "This method makes a program available for debug engines (DEs) and the session debug manager."
title: IDebugProgramPublisher2::PublishProgram
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgramPublisher2::PublishProgram
helpviewer_keywords:
- IDebugProgramPublisher2::PublishProgram
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProgramPublisher2::PublishProgram

This method makes a program available for debug engines (DEs) and the session debug manager.

## Syntax

### [C#](#tab/csharp)
```csharp
int PublishProgram(
   CONST_GUID_ARRAY Engines,
   string           szFriendlyName,
   object           pDebuggeeInterface
);
```
### [C++](#tab/cpp)
```cpp
HRESULT PublishProgram(
   CONST_GUID_ARRAY Engines,
   LPCOLESTR        szFriendlyName,
   IUnknown*        pDebuggeeInterface
);
```
---

## Parameters
`Engines`\
[in] An array of GUIDs for DEs that can launch or attach to this program.

`szFriendlyName`\
[in] Friendly name for the program (this appears in menus or dialogs presented to the user).

`pDebuggeeInterface`\
[in] `IUnknown` interface for the program (this value is used as a cookie to uniquely identify the program; this same value is used to "unpublish" the program)

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 To make a program no longer available for debugging, call [UnpublishProgram](../../../extensibility/debugger/reference/idebugprogrampublisher2-unpublishprogram.md).

## See also
- [IDebugProgramPublisher2](../../../extensibility/debugger/reference/idebugprogrampublisher2.md)
- [UnpublishProgram](../../../extensibility/debugger/reference/idebugprogrampublisher2-unpublishprogram.md)
