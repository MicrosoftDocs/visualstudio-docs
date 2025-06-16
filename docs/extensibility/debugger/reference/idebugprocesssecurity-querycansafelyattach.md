---
description: "This method allows the port supplier to display a warning before the user attaches to an unsafe process."
title: IDebugProcessSecurity::QueryCanSafelyAttach
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugProcessSecurity::QueryCanSafelyAttach
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProcessSecurity::QueryCanSafelyAttach

This method allows the port supplier to display a warning before the user attaches to an unsafe process.

## Syntax

### [C#](#tab/csharp)
```csharp
int QueryCanSafelyAttach();
```
### [C++](#tab/cpp)
```cpp
HRESULT QueryCanSafelyAttach();
```
---

## Return Value
 The return values are as follows:

- `S_OK`: Attaching to process is safe and no warning dialog box is shown.

- `S_FALSE`: Attaching could be a security problem and a dialog box with a warning is shown.

- `FAILURE`: Attaching to process fails.

## See also
- [IDebugProcessSecurity](../../../extensibility/debugger/reference/idebugprocesssecurity.md)
