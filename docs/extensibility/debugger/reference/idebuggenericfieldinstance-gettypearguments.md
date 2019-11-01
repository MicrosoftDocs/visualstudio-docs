---
title: "IDebugGenericFieldInstance::GetTypeArguments | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
helpviewer_keywords:
  - "GetTypeArguments"
  - "IDebugGenericFieldInstance::GetTypeArguments"
ms.assetid: 6e7e0f95-181a-4805-adb3-c2407de0ab93
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugGenericFieldInstance::GetTypeArguments
Retrieves the type parameter arguments for this instance.

## Syntax

```cpp
HRESULT GetTypeArguments(
   ULONG32       cArgs,
   IDebugField** ppArgs,
   ULONG32*      pcArgs
);
```

```csharp
int GetTypeArguments(
   uint              cArgs,
   out IDebugField[] ppArgs,
   ref uint          pcArgs
);
```

## Parameters
`cArgs`\
[in] Number of type parameters.

`ppArgs`\
[out] Returns an array of type parameters.

`pcArgs`\
[in, out] Number of members in the `ppArgs` array.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugGenericFieldInstance](../../../extensibility/debugger/reference/idebuggenericfieldinstance.md)