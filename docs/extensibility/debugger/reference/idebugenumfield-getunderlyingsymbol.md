---
description: "This method returns an IDebugField that represents the name of the enumeration."
title: IDebugEnumField::GetUnderlyingSymbol | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugEnumField::GetUnderlyingSymbol
helpviewer_keywords:
- IDebugEnumField::GetUnderlyingSymbol method
ms.assetid: c3b8a117-6708-4cfd-8ffc-5f007d706bc5
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugEnumField::GetUnderlyingSymbol
This method returns an [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) that represents the name of the enumeration.

## Syntax

```cpp
HRESULT GetUnderlyingSymbol(
   IDebugField** ppField
);
```

```csharp
int GetUnderlyingSymbol(
   out IDebugField ppField
);
```

## Parameters
`ppField`\
[out] Returns the [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) describing the name of this enumeration.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The name of the enumeration also contains the type of the enumeration, which is bound to a memory location by using [Bind](../../../extensibility/debugger/reference/idebugbinder-bind.md).

## See also
- [IDebugEnumField](../../../extensibility/debugger/reference/idebugenumfield.md)
- [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)
- [Bind](../../../extensibility/debugger/reference/idebugbinder-bind.md)
