---
title: "IDebugEngine2::RemoveAllSetExceptions | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugEngine2::RemoveAllSetExceptions"
helpviewer_keywords:
  - "IDebugEngine2::RemoveAllSetExceptions"
ms.assetid: 165fbe89-802d-4d99-85ca-c10fd6cccc09
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugEngine2::RemoveAllSetExceptions
Removes the list of exceptions the IDE has set for a particular run-time architecture or language.

## Syntax

```cpp
HRESULT RemoveAllSetExceptions( 
   REFGUID guidType
);
```

```csharp
int RemoveAllSetExceptions( 
   ref Guid guidType
);
```

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