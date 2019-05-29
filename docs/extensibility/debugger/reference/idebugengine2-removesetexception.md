---
title: "IDebugEngine2::RemoveSetException | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugEngine2::RemoveSetException"
helpviewer_keywords:
  - "IDebugEngine2::RemoveSetException"
ms.assetid: bdd25097-0e9d-4218-b417-0497ea48d2e8
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugEngine2::RemoveSetException
Removes the specified exception so it is no longer handled by the debug engine.

## Syntax

```cpp
HRESULT RemoveSetException( 
   EXCEPTION_INFO* pException
);
```

```csharp
int RemoveSetException( 
   EXCEPTION_INFO[] pException
);
```

## Parameters
`pException`\
[in] An [EXCEPTION_INFO](../../../extensibility/debugger/reference/exception-info.md) structure that describes the exception to be removed.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The exception being removed must have been previously set by an earlier call to the [SetException](../../../extensibility/debugger/reference/idebugengine2-setexception.md) method.

 To remove all set exceptions at once, call the [RemoveAllSetExceptions](../../../extensibility/debugger/reference/idebugengine2-removeallsetexceptions.md) method.

## See also
- [IDebugEngine2](../../../extensibility/debugger/reference/idebugengine2.md)
- [EXCEPTION_INFO](../../../extensibility/debugger/reference/exception-info.md)