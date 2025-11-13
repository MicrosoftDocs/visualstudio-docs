---
description: "Gets the parent reference of a reference."
title: IDebugReference2::GetParent
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugReference2::GetParent
helpviewer_keywords:
- IDebugReference2::GetParent
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugReference2::GetParent

Gets the parent reference of a reference. Reserved for future use.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetParent ( 
   out IDebugReference2 ppParent
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetParent ( 
   IDebugReference2** ppParent
);
```
---

## Parameters
`ppParent`\
[out] Returns an [IDebugReference2](../../../extensibility/debugger/reference/idebugreference2.md) object that represents the parent of this property.

## Return Value
 Always returns `E_NOTIMPL`.

## See also
- [IDebugReference2](../../../extensibility/debugger/reference/idebugreference2.md)
