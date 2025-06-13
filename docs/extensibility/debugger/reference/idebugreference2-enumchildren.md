---
description: "Get a list of selected children of a reference."
title: IDebugReference2::EnumChildren
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugReference2::EnumChildren
helpviewer_keywords:
- IDebugReference2::EnumChildren
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugReference2::EnumChildren

Get a list of selected children of a reference. Reserved for future use.

## Syntax

### [C#](#tab/csharp)
```csharp
int EnumChildren ( 
   enum_DEBUGREF_INFO_FLAGS     dwFields,
   uint                         dwRadix,
   enum_DBG_ATTRIB_FLAGS        dwAttribFilter,
   string                       pszNameFilter,
   uint                         dwTimeout,
   out IEnumDebugReferenceInfo2 ppEnum
);
```
### [C++](#tab/cpp)
```cpp
HRESULT EnumChildren ( 
   DEBUGREF_INFO_FLAGS        dwFields,
   DWORD                      dwRadix,
   DBG_ATTRIB_FLAGS           dwAttribFilter,
   LPCOLESTR                  pszNameFilter,
   DWORD                      dwTimeout,
   IEnumDebugReferenceInfo2** ppEnum
);
```
---

## Parameters
`dwFields`\
[in] A combination of flags from the [DEBUGREF_INFO_FLAGS](../../../extensibility/debugger/reference/debugref-info-flags.md) enumeration that specifies which fields in the enumerated [DEBUG_REFERENCE_INFO](../../../extensibility/debugger/reference/debug-reference-info.md) structures are to be filled in.

`dwRadix`\
[in] The radix to be used in formatting any numerical information.

`dwAttribFilter`\
[in] A combination of flags from the [DBG_ATTRIB_FLAGS](../../../extensibility/debugger/reference/dbg-attrib-flags.md) enumeration that is used as a filter in combination with the `pszNameFilter` parameter to select which structures are to be enumerated.

`pszNameFilter`\
[in] A string specifying a filter, such as "MyX", used in combination with the `dwAttribFilter` parameter to select the structures to be enumerated.

`dwTimeout`\
[in] Maximum time, in milliseconds, to wait before returning from this method. Use `INFINITE` to wait indefinitely.

`ppEnum`\
[out] Returns an [IEnumDebugReferenceInfo2](../../../extensibility/debugger/reference/ienumdebugreferenceinfo2.md) object that contains a list of the requested child properties.

## Return Value
 Always returns `E_NOTIMPL`.

## See also
- [IDebugReference2](../../../extensibility/debugger/reference/idebugreference2.md)
- [DEBUGREF_INFO_FLAGS](../../../extensibility/debugger/reference/debugref-info-flags.md)
- [DBG_ATTRIB_FLAGS](../../../extensibility/debugger/reference/dbg-attrib-flags.md)
- [IEnumDebugReferenceInfo2](../../../extensibility/debugger/reference/ienumdebugreferenceinfo2.md)
