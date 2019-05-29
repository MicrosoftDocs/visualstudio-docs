---
title: "IDebugReference2::GetParent | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugReference2::GetParent"
helpviewer_keywords:
  - "IDebugReference2::GetParent"
ms.assetid: e3061665-ad3e-4c1b-b33f-82755fa21be3
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugReference2::GetParent
Gets the parent reference of a reference. Reserved for future use.

## Syntax

```cpp
HRESULT GetParent ( 
   IDebugReference2** ppParent
);
```

```csharp
int GetParent ( 
   out IDebugReference2 ppParent
);
```

## Parameters
`ppParent`\
[out] Returns an [IDebugReference2](../../../extensibility/debugger/reference/idebugreference2.md) object that represents the parent of this property.

## Return Value
 Always returns `E_NOTIMPL`.

## See also
- [IDebugReference2](../../../extensibility/debugger/reference/idebugreference2.md)