---
description: "Establishes a locale to be used for any locale-specific resources."
title: IDebugProgramProvider2::SetLocale
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgramProvider2::SetLocale
helpviewer_keywords:
- IDebugProgramProvider2::SetLocale
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProgramProvider2::SetLocale

Establishes a locale to be used for any locale-specific resources.

## Syntax

### [C#](#tab/csharp)
```csharp
int SetLocale(
   ushort wLangID
);
```
### [C++](#tab/cpp)
```cpp
HRESULT SetLocale(
   WORD wLangID
);
```
---

## Parameters
`wLangID`\
[in] Language ID to establish. For example, 1033 for English.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugProgramProvider2](../../../extensibility/debugger/reference/idebugprogramprovider2.md)
