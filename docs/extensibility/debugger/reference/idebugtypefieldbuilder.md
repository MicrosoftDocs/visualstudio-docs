---
description: "Represents the ability to create a field that represents a type."
title: IDebugTypeFieldBuilder
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugTypeFieldBuilder interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugTypeFieldBuilder

Represents the ability to create a field that represents a type.

## Syntax

```
IDebugTypeFieldBuilder : IUnknown
```

## Notes for Callers
 This interface is obtained from the symbol provider.

## Methods
 This interface implements the following methods:

|Method|Description|
|------------|-----------------|
|[CreatePrimitive](../../../extensibility/debugger/reference/idebugtypefieldbuilder-createprimitive.md)|Creates an object that represents a primitive type.|
|[CreatePointerToType](../../../extensibility/debugger/reference/idebugtypefieldbuilder-createpointertotype.md)|Creates a pointer to the specified type.|

## Requirements
 Header: Sh.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll
