---
title: "IDebugProgramPublisher2::SetDebuggerPresent | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugProgramPublisher2::SetDebuggerPresent"
helpviewer_keywords:
  - "IDebugProgramPublisher2::SetDebuggerPresent"
ms.assetid: c88c3ff4-3632-4199-b5de-83c6d21bcf75
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugProgramPublisher2::SetDebuggerPresent
Tells the program publisher that a debugger is present and running.

## Syntax

```cpp
HRESULT SetDebuggerPresent(
   BOOL fDebuggerPresent
);
```

```csharp
int SetDebuggerPresent(
   int fDebuggerPresent
);
```

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