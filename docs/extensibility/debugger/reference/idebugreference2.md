---
description: "This interface represents a reference to a stack frame property or some other property."
title: IDebugReference2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugReference2
helpviewer_keywords:
- IDebugReference2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugReference2

This interface represents a reference to a stack frame property or some other property.

> [!NOTE]
> `IDebugReference2` is reserved for future use, and all its methods should return `E_NOTIMPL`.

## Syntax

```
IDebugReference2 : IUnknown
```

## Notes for Implementers
 The DE implements this interface to represent a reference to a particular kind of value. For example, the value could be a numerical value as a result of an expression evaluation, a memory context used for displaying memory, or a list of registers and their values.

## Notes for Callers
 Call [GetReference](../../../extensibility/debugger/reference/idebugproperty2-getreference.md) to obtain this interface. [GetParent](../../../extensibility/debugger/reference/idebugreference2-getparent.md) and [GetDerivedMostReference](../../../extensibility/debugger/reference/idebugreference2-getderivedmostreference.md) also return this interface.

## Methods in Vtable Order
 The following table shows the methods of `IDebugReference2`.

|Method|Description|
|------------|-----------------|
|[GetReferenceInfo](../../../extensibility/debugger/reference/idebugreference2-getreferenceinfo.md)|Gets the [DEBUG_REFERENCE_INFO](../../../extensibility/debugger/reference/debug-reference-info.md) structure that describes this reference.|
|[SetValueAsString](../../../extensibility/debugger/reference/idebugreference2-setvalueasstring.md)|Sets the value of this reference from a string.|
|[SetValueAsReference](../../../extensibility/debugger/reference/idebugreference2-setvalueasreference.md)|Sets the value of this reference from another reference.|
|[EnumChildren](../../../extensibility/debugger/reference/idebugreference2-enumchildren.md)|Enumerates the children of this reference.|
|[GetParent](../../../extensibility/debugger/reference/idebugreference2-getparent.md)|Gets the parent of this reference.|
|[GetDerivedMostReference](../../../extensibility/debugger/reference/idebugreference2-getderivedmostreference.md)|Gets the most-derived reference of this reference.|
|[GetMemoryBytes](../../../extensibility/debugger/reference/idebugreference2-getmemorybytes.md)|Gets the memory bytes to which this reference refers.|
|[GetMemoryContext](../../../extensibility/debugger/reference/idebugreference2-getmemorycontext.md)|Gets a memory context for this reference.|
|[GetSize](../../../extensibility/debugger/reference/idebugreference2-getsize.md)|Gets the size, in bytes, of this reference.|
|[SetReferenceType](../../../extensibility/debugger/reference/idebugreference2-setreferencetype.md)|Sets this reference type.|
|[Compare](../../../extensibility/debugger/reference/idebugreference2-compare.md)|Compares this reference with another.|

## Remarks

> [!NOTE]
> This use of "property" should not be confused with that meaning a member variable of a class, although an `IDebugReference2` can represent such an entity.

- [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md) represents a property, while `IDebugReference2` represents a reference to a property, typically a reference to an object in the program being debugged.

 The main difference between a property and a reference is that a property refers to a named instance of an object, while a reference refers to an unnamed instance. For example, a property may refer to an object in the program's heap by `"a.b"`. Another property may refer to the same object as `"c.d"`. The way of referring to this property requires that `"a.b"` or `"c.d"` be in scope. A reference to this same object is nameless; the object can be referred to as long as the memory for that object is valid.

 An `IDebugProperty2` interface can be thought of as a value with a name, a type, and an address. An `IDebugReference2`, on the other hand, can be thought of as a type and an address.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [DEBUG_REFERENCE_INFO](../../../extensibility/debugger/reference/debug-reference-info.md)
- [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md)
- [GetReference](../../../extensibility/debugger/reference/idebugproperty2-getreference.md)
