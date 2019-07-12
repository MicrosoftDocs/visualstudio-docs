---
title: "IDebugProcess3::DisableENC | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugProcess3::DisableENC"
helpviewer_keywords:
  - "IDebugProcess3::DisableENC"
ms.assetid: cffdbdac-4d76-4aeb-aa55-5d0410db99f1
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugProcess3::DisableENC
This method explicitly disables Edit and Continue on this process (and all programs it contains). A custom port supplier should always return `E_NOTIMPL`.

## Syntax

```cpp
HRESULT DisableENC(
   EncUnavailableReason reason
);
```

```csharp
   EncUnavailableReason reason
);
```

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