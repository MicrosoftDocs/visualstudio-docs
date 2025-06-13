---
description: "Retrieves a list of the children of the property."
title: IDebugProperty2::EnumChildren
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProperty2::EnumChildren
helpviewer_keywords:
- IDebugProperty2::EnumChildren
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProperty2::EnumChildren

Retrieves a list of the children of the property.

## Syntax

### [C#](#tab/csharp)
```csharp
int EnumChildren ( 
   enum_DEBUGPROP_INFO_FLAGS   dwFields,
   uint                        dwRadix,
   ref Guid                    guidFilter,
   uint                        dwAttribFilter,
   string                      pszNameFilter,
   uint                        dwTimeout,
   out IEnumDebugPropertyInfo2 ppEnum
);
```
### [C++](#tab/cpp)
```cpp
HRESULT EnumChildren ( 
   DEBUGPROP_INFO_FLAGS      dwFields,
   DWORD                     dwRadix,
   REFGUID                   guidFilter,
   DBG_ATTRIB_FLAGS          dwAttribFilter,
   LPCOLESTR                 pszNameFilter,
   DWORD                     dwTimeout,
   IEnumDebugPropertyInfo2** ppEnum
);
```
---

## Parameters
`dwFields`\
[in] A combination of flags from the [DEBUGPROP_INFO_FLAGS](../../../extensibility/debugger/reference/debugprop-info-flags.md) enumeration that specifies which fields in the enumerated [DEBUG_PROPERTY_INFO](../../../extensibility/debugger/reference/debug-property-info.md) structures are to be filled in.

`dwRadix`\
[in] Specifies the radix to be used in formatting any numerical information.

`guidFilter`\
[in] GUID of the filter used with the `dwAttribFilter` and `pszNameFilter` parameters to select which `DEBUG_PROPERTY_INFO` children are to be enumerated. For example, `guidFilterLocals` filters for local variables.

`dwAttribFilter`\
[in] A combination of flags from the [DBG_ATTRIB_FLAGS](../../../extensibility/debugger/reference/dbg-attrib-flags.md) enumeration that specifies what type of objects to enumerate, for example `DBG_ATTRIB_METHOD` for all methods that might be children of this property. Used in combination with the `guidFilter` and `pszNameFilter` parameters.

`pszNameFilter`\
[in] The name of the filter used with the `guidFilter` and `dwAttribFilter` parameters to select which `DEBUG_PROPERTY_INFO` children are to be enumerated. For example, setting this parameter to "MyX" filters for all children with the name "MyX."

`dwTimeout`\
[in] Specifies the maximum time, in milliseconds, to wait before returning from this method. Use `INFINITE` to wait indefinitely.

`ppEnum`\
[out] Returns an [IEnumDebugPropertyInfo2](../../../extensibility/debugger/reference/ienumdebugpropertyinfo2.md) object containing a list of the child properties.

## Return Value
 If successful, returns `S_OK`; otherwise returns error code.

## See also
- [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md)
- [DEBUGPROP_INFO_FLAGS](../../../extensibility/debugger/reference/debugprop-info-flags.md)
- [DBG_ATTRIB_FLAGS](../../../extensibility/debugger/reference/dbg-attrib-flags.md)
- [IEnumDebugPropertyInfo2](../../../extensibility/debugger/reference/ienumdebugpropertyinfo2.md)
