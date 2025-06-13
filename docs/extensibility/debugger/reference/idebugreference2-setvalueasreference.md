---
description: "Sets the value of a reference from another reference."
title: IDebugReference2::SetValueAsReference
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugReference2::SetValueAsReference
helpviewer_keywords:
- IDebugReference2::SetValueAsReference
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugReference2::SetValueAsReference

Sets the value of a reference from another reference. Reserved for future use.

## Syntax

```cpp
HRESULT SetValueAsReference ( 
   IDebugReference2** rgpArgs,
   DWORD              dwArgCount,
   IDebugReference2*  pValue,
   DWORD              dwTimeout
);
```

```cpp
int SetValueAsReference ( 
   IDebugReference2[] rgpArgs,
   uint               dwArgCount,
   IDebugReference2   pValue,
   uint               dwTimeout
);
```

## Parameters
`rgpArgs`\
[in] An array of [IDebugReference2](../../../extensibility/debugger/reference/idebugreference2.md) objects used to determine how to set the reference value.

`dwArgCount`\
[in] The number of references in the array.

`pValue`\
[in] An [IDebugReference2](../../../extensibility/debugger/reference/idebugreference2.md) object from which to set the property value.

`dwTimeout`\
[in] Maximum time, in milliseconds, to wait before returning from this method. Use `INFINITE` to wait indefinitely.

## Return Value
 Always returns `E_NOTIMPL`.

## See also
- [IDebugReference2](../../../extensibility/debugger/reference/idebugreference2.md)
