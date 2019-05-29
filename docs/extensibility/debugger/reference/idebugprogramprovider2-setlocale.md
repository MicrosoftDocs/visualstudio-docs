---
title: "IDebugProgramProvider2::SetLocale | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugProgramProvider2::SetLocale"
helpviewer_keywords:
  - "IDebugProgramProvider2::SetLocale"
ms.assetid: b41d20a7-ba40-4c42-a450-16f413d6a04f
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugProgramProvider2::SetLocale
Establishes a locale to be used for any locale-specific resources.

## Syntax

```cpp
HRESULT SetLocale(
   WORD wLangID
);
```

```csharp
int SetLocale(
   ushort wLangID
);
```

## Parameters
`wLangID`\
[in] Language ID to establish. For example, 1033 for English.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugProgramProvider2](../../../extensibility/debugger/reference/idebugprogramprovider2.md)