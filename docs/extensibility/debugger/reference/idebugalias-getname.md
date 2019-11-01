---
title: "IDebugAlias::GetName | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugAlias::GetName"
helpviewer_keywords:
  - "IDebugAlias::GetName method"
ms.assetid: ac2d8891-56b5-40ef-9866-ed74f18bb043
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugAlias::GetName
Gets the name of this alias.

## Syntax

```cpp
HRESULT GetName(
   BSTR* pbstrName
);
```

```csharp
int GetName(
   out string pbstrName
);
```

## Parameters
`pbstrName`\
[out] Name of the alias.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## See also
- [IDebugAlias](../../../extensibility/debugger/reference/idebugalias.md)