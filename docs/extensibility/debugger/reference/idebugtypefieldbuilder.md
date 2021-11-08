---
description: "Represents the ability to create a field that represents a type."
title: IDebugTypeFieldBuilder | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugTypeFieldBuilder interface
ms.assetid: 2dfed0be-6972-4bec-baec-f0b78df9ef97
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
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
