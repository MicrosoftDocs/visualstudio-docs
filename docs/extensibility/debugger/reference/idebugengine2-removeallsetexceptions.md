---
description: "Removes the list of exceptions the IDE has set for a particular run-time architecture or language."
title: IDebugEngine2::RemoveAllSetExceptions
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugEngine2::RemoveAllSetExceptions
helpviewer_keywords:
- IDebugEngine2::RemoveAllSetExceptions
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugEngine2::RemoveAllSetExceptions

Removes the list of exceptions the IDE has set for a particular run-time architecture or language.

## Syntax

### [C#](#tab/csharp)
```csharp
int RemoveAllSetExceptions( 
   ref Guid guidType
);
```
### [C++](#tab/cpp)
```cpp
HRESULT RemoveAllSetExceptions( 
   REFGUID guidType
);
```
---

## Parameters
`guidType`\
[in] Either the GUID for the language or the GUID for the debug engine that is specific to a run-time architecture.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The exceptions removed by this method were set by earlier calls to the [SetException](../../../extensibility/debugger/reference/idebugengine2-setexception.md) method.

 To remove a specific exception, call the [RemoveSetException](../../../extensibility/debugger/reference/idebugengine2-removesetexception.md) method.

## See also
- [IDebugEngine2](../../../extensibility/debugger/reference/idebugengine2.md)
- [IDebugEngine2](../../../extensibility/debugger/reference/idebugengine2.md)
- [RemoveSetException](../../../extensibility/debugger/reference/idebugengine2-removesetexception.md)
