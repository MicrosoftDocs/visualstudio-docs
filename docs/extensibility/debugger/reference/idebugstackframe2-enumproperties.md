---
description: "Creates an enumerator for properties associated with the stack frame, such as local variables."
title: IDebugStackFrame2::EnumProperties
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugStackFrame2::EnumProperties
helpviewer_keywords:
- IDebugStackFrame2::EnumProperties
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugStackFrame2::EnumProperties

Creates an enumerator for properties associated with the stack frame, such as local variables.

## Syntax

### [C#](#tab/csharp)
```csharp
int EnumProperties ( 
   enum_DEBUGPROP_INFO_FLAGS   dwFieldSpec,
   uint                        nRadix,
   ref Guid                    refiid,
   uint                        dwTimeout,
   out uint                    pcelt,
   out IEnumDebugPropertyInfo2 ppEnum
);
```
### [C++](#tab/cpp)
```cpp
HRESULT EnumProperties ( 
   DEBUGPROP_INFO_FLAGS      dwFieldSpec,
   UINT                      nRadix,
   REFIID                    refiid,
   DWORD                     dwTimeout,
   ULONG*                    pcelt,
   IEnumDebugPropertyInfo2** ppEnum
);
```
---

## Parameters
`dwFieldSpec`\
[in] A combination of flags from the [DEBUGPROP_INFO_FLAGS](../../../extensibility/debugger/reference/debugprop-info-flags.md) enumeration that specifies which fields in the enumerated [DEBUG_PROPERTY_INFO](../../../extensibility/debugger/reference/debug-property-info.md) structures are to be filled in.

`nRadix`\
[in] The radix to be used in formatting any numerical information.

`refiid`\
[in] A GUID of a filter used to select which [DEBUG_PROPERTY_INFO](../../../extensibility/debugger/reference/debug-property-info.md) structures are to be enumerated, such as `guidFilterLocals`.

`dwTimeout`\
[in] Maximum time, in milliseconds, to wait before returning from this method. Use `INFINITE` to wait indefinitely.

`pcelt`\
[out] Returns the number of properties enumerated. This is the same as calling the [GetCount](../../../extensibility/debugger/reference/ienumdebugpropertyinfo2-getcount.md) method.

`ppEnum`\
[out] Returns an [IEnumDebugPropertyInfo2](../../../extensibility/debugger/reference/ienumdebugpropertyinfo2.md) object containing a list of the desired properties.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 Because this method allows all selected properties to be retrieved with a single call, it is faster than sequentially calling the [GetDebugProperty](../../../extensibility/debugger/reference/idebugstackframe2-getdebugproperty.md) and [EnumChildren](../../../extensibility/debugger/reference/idebugproperty2-enumchildren.md) methods.

## See also
- [IDebugStackFrame2](../../../extensibility/debugger/reference/idebugstackframe2.md)
- [DEBUGPROP_INFO_FLAGS](../../../extensibility/debugger/reference/debugprop-info-flags.md)
- [IEnumDebugPropertyInfo2](../../../extensibility/debugger/reference/ienumdebugpropertyinfo2.md)
- [GetCount](../../../extensibility/debugger/reference/ienumdebugpropertyinfo2-getcount.md)
- [GetDebugProperty](../../../extensibility/debugger/reference/idebugstackframe2-getdebugproperty.md)
- [EnumChildren](../../../extensibility/debugger/reference/idebugproperty2-enumchildren.md)
