---
title: "IDebugObject2::CreateAlias | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugObject2::CreateAlias"
helpviewer_keywords:
  - "IDebugObject2::CreateAlias method"
ms.assetid: 54a05920-5d13-4f67-962b-d1a7f013dff9
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugObject2::CreateAlias
Creates a unique ID or alias for this object or returns an existing alias.

## Syntax

```cpp
HRESULT CreateAlias(
   IDebugAlias** ppAlias
);
```

```csharp
int CreateAlias(
   out IDebugAlias ppAlias
);
```

## Parameters
`ppAlias`\
[out] The new (or existing) alias.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## Remarks
 An alias is a label that represents a particular object while the object is in memory.

## See also
- [IDebugObject2](../../../extensibility/debugger/reference/idebugobject2.md)
- [IDebugAlias](../../../extensibility/debugger/reference/idebugalias.md)