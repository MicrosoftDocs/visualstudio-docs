---
description: "This interface enumerates DEBUG_REFERENCE_INFO structures."
title: IEnumDebugReferenceInfo2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IEnumDebugReferenceInfo2
helpviewer_keywords:
- IEnumDebugReferenceInfo2
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IEnumDebugReferenceInfo2

This interface enumerates [DEBUG_REFERENCE_INFO](../../../extensibility/debugger/reference/debug-reference-info.md) structures.

## Syntax

```
IEnumDebugReferenceInfo2 : IUnknown
```

## Notes for Implementers
 The debug engine (DE) implements this interface as part of its support for references to objects in memory. This interface must be implemented only if references are supported.

## Notes for Callers
 Visual Studio calls [EnumChildren](../../../extensibility/debugger/reference/idebugreference2-enumchildren.md) to obtain this interface.

## Methods in Vtable Order
 The following table shows the methods of `IEnumDebugReferenceInfo2`.

|Method|Description|
|------------|-----------------|
|[Next](../../../extensibility/debugger/reference/ienumdebugreferenceinfo2-next.md)|Retrieves a specified number of [DEBUG_REFERENCE_INFO](../../../extensibility/debugger/reference/debug-reference-info.md) structures in an enumeration sequence.|
|[Skip](../../../extensibility/debugger/reference/ienumdebugreferenceinfo2-skip.md)|Skips a specified number of [DEBUG_REFERENCE_INFO](../../../extensibility/debugger/reference/debug-reference-info.md) structures in the enumeration sequence.|
|[Reset](../../../extensibility/debugger/reference/ienumdebugreferenceinfo2-reset.md)|Resets an enumeration sequence to the beginning.|
|[Clone](../../../extensibility/debugger/reference/ienumdebugreferenceinfo2-clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|
|[GetCount](../../../extensibility/debugger/reference/ienumdebugreferenceinfo2-getcount.md)|Gets the number of [DEBUG_REFERENCE_INFO](../../../extensibility/debugger/reference/debug-reference-info.md) structures in an enumerator.|

## Remarks
 A reference is essentially a type and an address, whereas a property is a name, type, and address. A reference persists as long as the object referred to exists in memory. See [IDebugReference2](../../../extensibility/debugger/reference/idebugreference2.md) for more details.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [DEBUG_REFERENCE_INFO](../../../extensibility/debugger/reference/debug-reference-info.md)
- [IDebugReference2](../../../extensibility/debugger/reference/idebugreference2.md)
- [EnumChildren](../../../extensibility/debugger/reference/idebugreference2-enumchildren.md)
