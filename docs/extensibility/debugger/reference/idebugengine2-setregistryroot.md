---
description: "Sets the registry root for the debug engine (DE)."
title: IDebugEngine2::SetRegistryRoot
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugEngine2::SetRegistryRoot
helpviewer_keywords:
- IDebugEngine2::SetRegistryRoot
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugEngine2::SetRegistryRoot

Sets the registry root for the debug engine (DE).

## Syntax

### [C#](#tab/csharp)
```csharp
int SetRegistryRoot( 
   string pszRegistryRoot
);
```
### [C++](#tab/cpp)
```cpp
HRESULT SetRegistryRoot( 
   LPCOLESTR pszRegistryRoot
);
```
---

## Parameters
`pszRegistryRoot`\
[in] The registry root to use.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 This method allows Visual Studio to specify an alternate registry root that the DE should use to obtain registry settings; for example, "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\8.0Exp".

## See also
- [IDebugEngine2](../../../extensibility/debugger/reference/idebugengine2.md)
