---
description: "Creates an enumerator for the interfaces implemented by this class."
title: IDebugClassField::EnumInterfacesImplemented | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugClassField::EnumInterfacesImplemented
helpviewer_keywords:
- IDebugClassField::EnumInterfacesImplemented method
ms.assetid: e5523e45-d350-491e-a92c-fe0ca97d2052
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugClassField::EnumInterfacesImplemented
Creates an enumerator for the interfaces implemented by this class.

## Syntax

```cpp
HRESULT EnumInterfacesImplemented( 
   IEnumDebugFields** ppEnum
);
```

```csharp
int EnumInterfacesImplemented(
   out IEnumDebugFields ppEnum
);
```

## Parameters
`ppEnum`\
[out] Returns an [IEnumDebugFields](../../../extensibility/debugger/reference/ienumdebugfields.md) object representing the list of interfaces implemented. Returns a null value if there are no interfaces.

## Return Value
 If successful, returns S_OK or returns S_FALSE if there are no interfaces implemented on this class. Otherwise, returns an error code.

## Remarks
 Each element of the enumeration is an [IDebugClassField](../../../extensibility/debugger/reference/idebugclassfield.md) object describing an interface. Note that unmanaged [!INCLUDE[vcprvc](../../../code-quality/includes/vcprvc_md.md)] code does not use interfaces as a discrete entity so this method always returns a null value for unmanaged [!INCLUDE[vcprvc](../../../code-quality/includes/vcprvc_md.md)] code.

## See also
- [IDebugClassField](../../../extensibility/debugger/reference/idebugclassfield.md)
- [IEnumDebugFields](../../../extensibility/debugger/reference/ienumdebugfields.md)
