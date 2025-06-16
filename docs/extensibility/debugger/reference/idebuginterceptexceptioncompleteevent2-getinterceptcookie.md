---
description: "Called when the processing of an intercepted exception has completed."
title: IDebugInterceptExceptionCompleteEvent2::GetInterceptCookie
titleSuffix: ""
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugInterceptExceptionCompleteEvent2::GetInterceptCookie
helpviewer_keywords:
- IDebugInterceptExceptionCompleteEvent2::GetInterceptCookie
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugInterceptExceptionCompleteEvent2::GetInterceptCookie

Called when the processing of an intercepted exception has completed.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetInterceptCookie(
   out ulong pqwCookie
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetInterceptCookie(
   UINT64* pqwCookie
);
```
---

## Parameters
`pqwCookie`\
[out] Unique value that is associated with the exception that was intercepted.

## Return Value
 If successful, returns `S_OK`; otherwise returns error code.

## Remarks
 After the [InterceptCurrentException](../../../extensibility/debugger/reference/idebugstackframe3-interceptcurrentexception.md) method has completed handling of an intercepted exception, it sends the [IDebugInterceptExceptionCompleteEvent2](../../../extensibility/debugger/reference/idebuginterceptexceptioncompleteevent2.md) event. The handler can use the `GetInterceptCookie` method to retrieve the unique value associated with the exception (the same value passed to the `InterceptCurrentException` method).

## See also
- [InterceptCurrentException](../../../extensibility/debugger/reference/idebugstackframe3-interceptcurrentexception.md)
- [IDebugInterceptExceptionCompleteEvent2](../../../extensibility/debugger/reference/idebuginterceptexceptioncompleteevent2.md)
