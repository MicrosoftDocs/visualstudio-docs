---
description: "Creates an enumerator for the parameters of the method."
title: IDebugMethodField::EnumParameters | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugMethodField::EnumParameters
helpviewer_keywords:
- IDebugMethodField::EnumParameters method
ms.assetid: d77b1197-deb6-4144-8d1b-8b09949ccfac
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugMethodField::EnumParameters
Creates an enumerator for the parameters of the method.

## Syntax

```cpp
HRESULT EnumParameters( 
   IEnumDebugFields** ppParams
);
```

```csharp
int EnumParameters(
   out IEnumDebugFields ppParams
);
```

## Parameters
`ppParams`\
[out] Returns an [IEnumDebugFields](../../../extensibility/debugger/reference/ienumdebugfields.md) object representing the list of parameters to the method; otherwise, returns a null value if there are no parameters.

## Return Value
 If successful, returns S_OK or returns S_FALSE if there are no parameters. Otherwise, returns an error code.

## Remarks
 Each element is an [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) object representing different types of parameters. Call the [GetKind](../../../extensibility/debugger/reference/idebugfield-getkind.md) method on each object to determine exactly what kind of parameter the object represents.

 A parameter includes both its variable name and its type. The first parameter to a class method is typically the "this" pointer.

 If only the types of the parameters is needed, call the [EnumArguments](../../../extensibility/debugger/reference/idebugmethodfield-enumarguments.md) method.

## See also
- [IDebugMethodField](../../../extensibility/debugger/reference/idebugmethodfield.md)
- [IEnumDebugFields](../../../extensibility/debugger/reference/ienumdebugfields.md)
- [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)
- [EnumArguments](../../../extensibility/debugger/reference/idebugmethodfield-enumarguments.md)
