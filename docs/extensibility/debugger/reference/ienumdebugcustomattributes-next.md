---
title: "IEnumDebugCustomAttributes::Next | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IEnumCustomAttributes::Next"
helpviewer_keywords:
  - "IEnumDebugCustomAttributes::Next"
ms.assetid: e36f856b-2619-42d1-b73e-4f2390fc22bd
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IEnumDebugCustomAttributes::Next
Retrieves a specified number of custom attributes in an enumeration sequence.

## Syntax

```cpp
HRESULT Next ( 
   ULONG      celt,
   CODE_PATH* rgelt,
   ULONG*     pceltFetched
);
```

```csharp
int Next(
   uint                        celt,
   out IDebugCustomAttribute[] rgelt,
   ref uint                    pceltFetched
);
```

## Parameters
`celt`\
[in] The number of elements to retrieve. Also specifies the maximum size of the `rgelt` array.

`rgelt`\
[out] An array of [IDebugCustomAttribute](../../../extensibility/debugger/reference/idebugcustomattribute.md) objects to be filled in.

`pceltFetched`\
[out] Returns the number of elements actually returned in `rgelt`.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if fewer than the requested number of elements could be returned; otherwise, returns an error code.

## See also
- [IEnumDebugCustomAttributes](../../../extensibility/debugger/reference/ienumdebugcustomattributes.md)
- [IDebugCustomAttribute](../../../extensibility/debugger/reference/idebugcustomattribute.md)