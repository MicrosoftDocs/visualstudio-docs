---
description: "Represents the definition of a field for a managed code generic type."
title: IDebugGenericFieldDefinition
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugGenericFieldDefinition interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugGenericFieldDefinition

Represents the definition of a field for a managed code generic type.

## Syntax

```
IDebugGenericFieldDefinition : IUnknown
```

## Methods
 This interface implements the following methods:

|Method|Description|
|------------|-----------------|
|[ConstructInstantiation](../../../extensibility/debugger/reference/idebuggenericfielddefinition-constructinstantiation.md)|Constructs a field instance given an array of type arguments.|
|[GetFormalTypeParams](../../../extensibility/debugger/reference/idebuggenericfielddefinition-getformaltypeparams.md)|Retrieves the type parameters given the number of parameters.|
|[TypeParamCount](../../../extensibility/debugger/reference/idebuggenericfielddefinition-typeparamcount.md)|Retrieves the number of type parameters associated with the generic field.|

## Requirements
 Header: Sh.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll
