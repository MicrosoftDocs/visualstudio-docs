---
description: "This method gets the current Edit and Continue state of the process."
title: IDebugProcess3::GetENCAvailableState
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProcess3::GetENCAvailableState
helpviewer_keywords:
- IDebugProcess3::GetENCAvailableState
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProcess3::GetENCAvailableState

This method gets the current Edit and Continue state of the process. A custom port supplier should always return `E_NOTIMPL`.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetENCAvailableState(
   EncUnavailableReason[] pReason
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetENCAvailableState(
   EncUnavailableReason* pReason
);
```
---

## Parameters
`pReason`\
[out] A value from the [EncUnavailableReason](../../../extensibility/debugger/reference/encunavailablereason.md) enumeration.

## Return Value
 If successful, returns `S_OK`; otherwise, returns error code.

> [!NOTE]
> A custom port supplier should always return `E_NOTIMPL`.

## Remarks
 This state can be affected by [DisableENC](../../../extensibility/debugger/reference/idebugprocess3-disableenc.md).

## See also
- [IDebugProcess3](../../../extensibility/debugger/reference/idebugprocess3.md)
- [DisableENC](../../../extensibility/debugger/reference/idebugprocess3-disableenc.md)
- [EncUnavailableReason](../../../extensibility/debugger/reference/encunavailablereason.md)
