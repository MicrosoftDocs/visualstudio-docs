---
title: "IDebugEngine3::SetAllExceptions | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugEngine3::SetAllExceptions"
helpviewer_keywords:
  - "IDebugEngine3::SetAllExceptions"
ms.assetid: 8f03a6ac-a854-42f7-933c-a2df1b351975
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugEngine3::SetAllExceptions
This method sets the state of all outstanding exceptions.

## Syntax

```cpp
HRESULT SetAllExceptions(
   EXCEPTION_STATE dwState
);
```

```csharp
int SetAllExceptions(
   enum_EXCEPTION_STATE dwState
);
```

## Parameters
`dwState`\
[in] One of the [EXCEPTION_STATE](../../../extensibility/debugger/reference/exception-state.md) values.

## Return Value
 If successful, returns `S_OK`; otherwise, returns error code.

## See also
- [IDebugEngine3](../../../extensibility/debugger/reference/idebugengine3.md)
- [EXCEPTION_STATE](../../../extensibility/debugger/reference/exception-state.md)