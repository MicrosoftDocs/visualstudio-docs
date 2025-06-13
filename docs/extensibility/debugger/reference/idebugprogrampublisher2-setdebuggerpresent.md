---
description: "Tells the program publisher that a debugger is present and running."
title: IDebugProgramPublisher2::SetDebuggerPresent
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgramPublisher2::SetDebuggerPresent
helpviewer_keywords:
- IDebugProgramPublisher2::SetDebuggerPresent
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProgramPublisher2::SetDebuggerPresent

Tells the program publisher that a debugger is present and running.

## Syntax

### [C#](#tab/csharp)
```csharp
int SetDebuggerPresent(
   int fDebuggerPresent
);
```
### [C++](#tab/cpp)
```cpp
HRESULT SetDebuggerPresent(
   BOOL fDebuggerPresent
);
```
---

## Parameters
`fDebuggerPresent`\
[in] Non-zero (`TRUE`) if a debugger is present, zero (`FALSE`) if it is not.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The presence or absence of a debugger is reflected in the data returned from the [GetProviderProcessData](../../../extensibility/debugger/reference/idebugprogramprovider2-getproviderprocessdata.md) method: the value returned there is set or cleared by a prior call to the `SetDebuggerPresent` method.

## See also
- [IDebugProgramPublisher2](../../../extensibility/debugger/reference/idebugprogrampublisher2.md)
- [GetProviderProcessData](../../../extensibility/debugger/reference/idebugprogramprovider2-getproviderprocessdata.md)
