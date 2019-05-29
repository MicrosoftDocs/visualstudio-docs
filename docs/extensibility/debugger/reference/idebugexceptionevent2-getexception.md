---
title: "IDebugExceptionEvent2::GetException | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugExceptionEvent2::GetException"
helpviewer_keywords:
  - "IDebugExceptionEvent2::GetException"
ms.assetid: 7c98f41d-322b-4e72-a514-cbd4823eb70d
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugExceptionEvent2::GetException
Gets a detailed description of the exception that fired this event.

## Syntax

```cpp
HRESULT GetException( 
   EXCEPTION_INFO* pExceptionInfo
);
```

```csharp
int GetException( 
   EXCEPTION_INFO[] pExceptionInfo
);
```

## Parameters
`pExceptionInfo`\
[in, out] An [EXCEPTION_INFO](../../../extensibility/debugger/reference/exception-info.md) structure that is filled in with the description of the exception.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks

 [C++ only] The caller is responsible for freeing any strings in the [EXCEPTION_INFO](../../../extensibility/debugger/reference/exception-info.md) structure as well as releasing the [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md) object in the structure.

## See also
- [IDebugExceptionEvent2](../../../extensibility/debugger/reference/idebugexceptionevent2.md)
- [EXCEPTION_INFO](../../../extensibility/debugger/reference/exception-info.md)
- [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md)
- [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)