---
description: "Gets a detailed description of the exception that fired this event."
title: IDebugExceptionEvent2::GetException
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugExceptionEvent2::GetException
helpviewer_keywords:
- IDebugExceptionEvent2::GetException
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugExceptionEvent2::GetException

Gets a detailed description of the exception that fired this event.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetException( 
   EXCEPTION_INFO[] pExceptionInfo
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetException( 
   EXCEPTION_INFO* pExceptionInfo
);
```
---

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
