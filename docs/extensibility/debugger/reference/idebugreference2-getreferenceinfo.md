---
description: "Gets the DEBUG_REFERENCE_INFO structure that describes a reference."
title: IDebugReference2::GetReferenceInfo
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugReference2::GetReferenceInfo
helpviewer_keywords:
- IDebugReference2::GetReferenceInfo
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugReference2::GetReferenceInfo

Gets the [DEBUG_REFERENCE_INFO](../../../extensibility/debugger/reference/debug-reference-info.md) structure that describes a reference. Reserved for future use.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetReferenceInfo ( 
   enum_DEBUGREF_INFO_FLAGS  dwFields,
   uint                      nRadix,
   uint                      dwTimeout,
   IDebugReference2[]        rgpArgs,
   uint                      dwArgCount,
   DEBUG_REFERENCE_INFO[]    pReferenceInfo
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetReferenceInfo ( 
   DEBUGREF_INFO_FLAGS   dwFields,
   DWORD                 nRadix,
   DWORD                 dwTimeout,
   IDebugReference2**    rgpArgs,
   DWORD                 dwArgCount,
   DEBUG_REFERENCE_INFO* pReferenceInfo
);
```
---

## Parameters
`dwFields`\
[in] A combination of flags from the [DEBUGREF_INFO_FLAGS](../../../extensibility/debugger/reference/debugref-info-flags.md) enumeration that determine the fields to be filled out in the [DEBUG_REFERENCE_INFO](../../../extensibility/debugger/reference/debug-reference-info.md) structure.

`nRadix`\
[in] The radix to be used in formatting any numerical information.

`dwTimeout`\
[in] Maximum time, in milliseconds, to wait before returning from this method. Use `INFINITE` to wait indefinitely.

`rgpArgs`\
[in] An array of [IDebugReference2](../../../extensibility/debugger/reference/idebugreference2.md) objects. Reserved for future use; set to a null value.

`dwArgCount`\
[in] The number of reference arguments in the `rgpArgs` array. Reserved for future use; set to 0.

`pReferenceInfo`\
[out] A [DEBUG_REFERENCE_INFO](../../../extensibility/debugger/reference/debug-reference-info.md) structure that is filled in with a description of the property.

## Return Value
 Always returns `E_NOTIMPL`.

## See also
- [IDebugReference2](../../../extensibility/debugger/reference/idebugreference2.md)
- [DEBUGREF_INFO_FLAGS](../../../extensibility/debugger/reference/debugref-info-flags.md)
- [DEBUG_REFERENCE_INFO](../../../extensibility/debugger/reference/debug-reference-info.md)
