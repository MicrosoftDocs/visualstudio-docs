---
title: "IDebugAlias::GetICorDebugValue | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugAlias::GetICorDebugValue"
helpviewer_keywords:
  - "IDebugAlias::GetICorDebugValue method"
ms.assetid: b9eb39ee-84af-4ace-9cfe-236b3d48aff5
author: "gregvanl"
ms.author: "gregvanl"
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugAlias::GetICorDebugValue
Retrieves a managed code interface that represents the value associated with this alias.

## Syntax

```cpp
HRESULT GetICorDebugValue(
   IUnknown** ppUnk
);
```

```csharp
int GetICorDebugValue(
   out object ppUnk
);
```

## Parameters
 `ppUnk`\

 [out] `IUnknown` interface that represents the value associated with this alias. This interface can be queried for the `ICorDebugValue` interface.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## Remarks
 This method applies only to managed values (the `ICorDebugValue` is an interface available in the [!INCLUDE[dnprdnshort](../../../code-quality/includes/dnprdnshort_md.md)] and is defined in the [!INCLUDE[dnprdnshort](../../../code-quality/includes/dnprdnshort_md.md)] SDK in the cordebug.idl file).

## See also
- [IDebugAlias](../../../extensibility/debugger/reference/idebugalias.md)