---
description: "This method tells the debug engine about the JustMyCode state information."
title: IDebugEngine3::SetJustMyCodeState
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugEngine3::SetJustMyCodeState
helpviewer_keywords:
- IDebugEngine3::SetJustMyCodeState
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugEngine3::SetJustMyCodeState

This method tells the debug engine about the JustMyCode state information.

## Syntax

### [C#](#tab/csharp)
```csharp
int SetJustMyCodeState(
   int             fUpdate,
   uint            dwModules,
   JMC_CODE_SPEC[] rgJMCSpec
);
```
### [C++](#tab/cpp)
```cpp
HRESULT SetJustMyCodeState(
   BOOL           fUpdate,
   DWORD          dwModules,
   JMC_CODE_SPEC* rgJMCSpec
);
```
---

## Parameters
`fUpdate`\
[in] Nonzero (`TRUE`) to update current information, zero (`FALSE`) to reset all information (ignoring anything previously set).

`dwModules`\
[in] Number of information structures in `rgJMCSpec.`

`rgJMCSpec`\
[in] Array of [JMC_CODE_SPEC](../../../extensibility/debugger/reference/jmc-code-spec.md) structures to use.

## Return Value
 If successful, returns `S_OK`; otherwise, returns error code.

## Remarks
 JustMyCode is the concept of debugging only the code that belongs to a user and ignoring all intermediate code such as system code—even if source code is available for that system code.

## See also
- [IDebugEngine3](../../../extensibility/debugger/reference/idebugengine3.md)
- [JMC_CODE_SPEC](../../../extensibility/debugger/reference/jmc-code-spec.md)
