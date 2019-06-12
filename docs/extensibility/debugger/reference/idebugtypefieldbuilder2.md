---
title: "IDebugTypeFieldBuilder2 | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
helpviewer_keywords:
  - "IDebugTypeFieldBuilder2 interface"
ms.assetid: 23911c5b-2bbf-4734-9976-87a0bd6ea36c
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
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