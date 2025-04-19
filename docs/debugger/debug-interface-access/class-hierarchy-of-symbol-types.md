---
title: Class Hierarchy of Symbol Types
description: Review a list of symbol types in the class hierarchy of the Visual Studio Debug Interface Access SDK.
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "symbols [DIA SDK], class hierarchies"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# Class Hierarchy of Symbol Types

The following table describes the symbol types in the class hierarchy.

## Symbol Types

|Symbol type|Description|
|-----------------|-----------------|
|[user-defined type (UDT)](../../debugger/debug-interface-access/udt.md)|Symbol used to represent each class, structure, and union.|
|[Enum (Debug Interface Access SDK)](../../debugger/debug-interface-access/enum-debug-interface-access-sdk.md)|Symbol for enumerated types.|
|[PointerType](../../debugger/debug-interface-access/pointertype.md)|Symbol for pointer types.|
|[ArrayType](../../debugger/debug-interface-access/arraytype.md)|Symbol for array types.|
|[BaseType](../../debugger/debug-interface-access/basetype.md)|Symbol for base types|
|[Typedef (Debug Interface Access SDK)](../../debugger/debug-interface-access/typedef-debug-interface-access-sdk.md)|Symbol that introduces names for other types.|
|[BaseClass](../../debugger/debug-interface-access/baseclass.md)|Symbol used for each base class of a user-defined type (UDT).|
|[Friend (Debug Interface Access SDK)](../../debugger/debug-interface-access/friend-debug-interface-access-sdk.md)|Symbol for friend classes and friend functions.|
|[FunctionType](../../debugger/debug-interface-access/functiontype.md)|Symbol for each unique function signature.|
|[FunctionArgType](../../debugger/debug-interface-access/functionargtype.md)|Symbol for each parameter to a function.|
|[VTableShape](../../debugger/debug-interface-access/vtableshape.md)|Symbol for the size of the virtual table.|
|[VTable](../../debugger/debug-interface-access/vtable.md)|Symbol for a virtual table.|
|[CustomType](../../debugger/debug-interface-access/customtype.md)|Symbol for vendor-defined type.|
|[ManagedType](../../debugger/debug-interface-access/managedtype.md)|Symbol for a type defined in metadata.|
|[Dimension](../../debugger/debug-interface-access/dimension.md)|Symbol for array dimensions.|

> [!NOTE]
> Each symbol can have properties that hold information about the symbol, as well as references to other symbols. These properties are listed in the individual symbol topics.

## See also

- [CV_access_e Enumeration](../../debugger/debug-interface-access/cv-access-e.md)
- [Lexical Hierarchy of Symbol Types](../../debugger/debug-interface-access/lexical-hierarchy-of-symbol-types.md)
- [Symbols and Symbol Tags](../../debugger/debug-interface-access/symbols-and-symbol-tags.md)
