---
description: "Creates an enumerator for the fields of the container."
title: IDebugContainerField::EnumFields
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugContainerField::EnumFields
helpviewer_keywords:
- IDebugContainerField::EnumFields method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugContainerField::EnumFields

Creates an enumerator for the fields of the container.

## Syntax

### [C#](#tab/csharp)
```csharp
int EnumFields(
   enum_ FIELD_KIND      dwKindFilter,
   enum_ FIELD_MODIFIERS dwModifiersFilter,
   string                pszNameFilter,
   NAME_MATCH            nameMatch,
   out IEnumDebugFields  ppEnum
);
```
### [C++](#tab/cpp)
```cpp
HRESULT EnumFields( 
   FIELD_KIND         dwKindFilter,
   FIELD_MODIFIERS    dwModifiersFilter,
   LPCOLESTR          pszNameFilter,
   NAME_MATCH         nameMatch,
   IEnumDebugFields** ppEnum
);
```
---

## Parameters
`dwKindFilter`\
[in] A combination of [FIELD_KIND](../../../extensibility/debugger/reference/field-kind.md) constants that select the fields to be enumerated. Field kinds can describe storage types, such as class or primitive, or specific information, such as local, parameter, or "this" pointer.

`dwModifiersFilter`\
[in] A combination of [FIELD_MODIFIERS](../../../extensibility/debugger/reference/field-modifiers.md) constants that select the fields to be enumerated. Field modifiers can be access permissions, such as public or private, or storage information, such as virtual, static, or final.

`pszNameFilter`\
[in] The name of the field to be enumerated. This can be a null value if all fields are to be returned.

`nameMatch`\
[in] A value from the [NAME_MATCH](../../../extensibility/debugger/reference/name-match.md) enumeration that controls whether searching is case-sensitive or not.

`ppEnum`\
[out] Returns an [IEnumDebugFields](../../../extensibility/debugger/reference/ienumdebugfields.md) object representing the list of fields. Returns a null value if there are no fields.

## Return Value
 If successful, returns S_OK or S_FALSE if there are no fields. Otherwise, returns an error code.

## Remarks
 The `dwKindFilter`, `dwModifiersFilter`, and `pszNameFilter` parameters can be combined, for example, to select all public virtual methods named "MyMethod".

## See also
- [IDebugContainerField](../../../extensibility/debugger/reference/idebugcontainerfield.md)
- [IEnumDebugFields](../../../extensibility/debugger/reference/ienumdebugfields.md)
- [FIELD_KIND](../../../extensibility/debugger/reference/field-kind.md)
- [FIELD_MODIFIERS](../../../extensibility/debugger/reference/field-modifiers.md)
- [NAME_MATCH](../../../extensibility/debugger/reference/name-match.md)
