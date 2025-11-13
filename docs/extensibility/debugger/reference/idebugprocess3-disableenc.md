---
description: "This method explicitly disables Edit and Continue on this process (and all programs it contains)."
title: IDebugProcess3::DisableENC
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProcess3::DisableENC
helpviewer_keywords:
- IDebugProcess3::DisableENC
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProcess3::DisableENC

This method explicitly disables Edit and Continue on this process (and all programs it contains). A custom port supplier should always return `E_NOTIMPL`.

## Syntax

### [C#](#tab/csharp)
```csharp
   EncUnavailableReason reason
);
```
### [C++](#tab/cpp)
```cpp
HRESULT DisableENC(
   EncUnavailableReason reason
);
```
---

## Parameters
`reason`\
[in] A value from the [EncUnavailableReason](../../../extensibility/debugger/reference/encunavailablereason.md) enumeration.

## Return Value
 If successful, returns `S_OK`; otherwise, returns error code.

> [!NOTE]
> A custom port supplier should always return `E_NOTIMPL`.

## Remarks
 Once Edit and Continue is disabled for a process, it can be re-enabled only by restarting the process.

## See also
- [IDebugProcess3](../../../extensibility/debugger/reference/idebugprocess3.md)
- [EncUnavailableReason](../../../extensibility/debugger/reference/encunavailablereason.md)
