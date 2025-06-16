---
description: "Extends the IDebugTypeFieldBuilder to be able to create array types."
title: IDebugTypeFieldBuilder2
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugTypeFieldBuilder2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugTypeFieldBuilder2

Extends the **IDebugTypeFieldBuilder** to be able to create array types.

## Syntax

```
IDebugTypeFieldBuilder2 : IDebugTypeFieldBuilder
```

## Notes for Callers
 This interface can be obtained from the symbol provider.

## Methods
 In addition to the methods on the [IDebugTypeFieldBuilder](../../../extensibility/debugger/reference/idebugtypefieldbuilder.md) interface, this interface implements the following method:

|Method|Description|
|------------|-----------------|
|[CreateArrayOfType](../../../extensibility/debugger/reference/idebugtypefieldbuilder2-createarrayoftype.md)|Creates an array of the specified type and size.|

## Requirements
 Header: Sh.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll
